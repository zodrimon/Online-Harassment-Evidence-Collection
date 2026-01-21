using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvidenceCollect
{
    public partial class Reaction : Form
    {
        string connectionString = @"Server=.; Database=Login; Integrated Security=True;";


        int caseId;
        int viewerId; 
        public Reaction(int selectedcaseId, int viewerId)
        {
            InitializeComponent();
            caseId = selectedcaseId;
            this.viewerId = viewerId;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveReaction("Like");
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            LoadCaseDetails();
            LoadReactionCounts();
            LoadAutoReportStatus();
        }

        private void LoadCaseDetails()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = "SELECT Title, Description, CreatedDate FROM Cases WHERE CaseID=@cid";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@cid", caseId);

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    label1.Text = dr["Title"].ToString();
                    textBox1.Text = dr["Description"].ToString();
                    label2.Text = Convert.ToDateTime(dr["CreatedDate"]).ToString("dd MMM yyyy");
                }
            }
        }

        private void LoadReactionCounts()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = @"
                SELECT 
                    SUM(CASE WHEN ReactionType='Like' THEN 1 ELSE 0 END) AS Likes,
                    SUM(CASE WHEN ReactionType='Dislike' THEN 1 ELSE 0 END) AS Dislikes
                FROM PostReactions
                WHERE CaseID=@cid";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@cid", caseId);

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    label3.Text = "Likes: " + (dr["Likes"] == DBNull.Value ? "0" : dr["Likes"].ToString());
                    label4.Text = "Dislikes: " + (dr["Dislikes"] == DBNull.Value ? "0" : dr["Dislikes"].ToString());
                }
            }
        }
        private void LoadAutoReportStatus()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = @"SELECT TOP 1 
                    ar.ReportType,
                    ar.ForwardedTo,
                    ar.ReportDate,
                    rs.Status
                FROM AutoReports ar
                LEFT JOIN ReportStatus rs ON ar.ReportID = rs.ReportID
                WHERE ar.CaseID = @cid
                ORDER BY ar.ReportDate DESC";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@cid", caseId);

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    label7.Visible = true;

                    string status = dr["Status"]?.ToString() ?? "Pending";
                    string forwardedTo = dr["ForwardedTo"]?.ToString();
                    string reportType = dr["ReportType"]?.ToString();

                    label6.Text = $"Status: {status}";

                    if (status == "Action Taken" || status == "Under Review")
                    {
                        label7.Text = $"Forwarded To: {forwardedTo}";
                        label7.Visible = true;
                    }
                    else
                    {
                        label7.Visible = false;
                    }

                    // Color coding
                    switch (status)
                    {
                        case "Action Taken":
                            label6.ForeColor = Color.Green;
                            break;
                        case "Under Review":
                            label6.ForeColor = Color.Blue;
                            break;
                        case "Rejected":
                            label6.ForeColor = Color.Red;
                            break;
                        case "Pending":
                            label6.ForeColor = Color.Orange;
                            break;
                        default:
                            label6.ForeColor = Color.Black;
                            break;
                    }

                    // Show report type and date
                    label8.Text = $"Report Type: {reportType}";
                    label2.Text = $"Reported: {Convert.ToDateTime(dr["ReportDate"]).ToString("dd MMM yyyy HH:mm")}";
                }
                else
                {
                    // No report generated yet
                    label6.Visible = false;
                }
            }
        }

    private void button2_Click(object sender, EventArgs e)
        {
            SaveReaction("Dislike");
        }

        private void SaveReaction(string reactionType)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                // Check if already reacted
                string check = "SELECT COUNT(*) FROM PostReactions WHERE CaseID=@cid AND ViewerID=@vid";
                SqlCommand checkCmd = new SqlCommand(check, con);
                checkCmd.Parameters.AddWithValue("@cid", caseId);
                checkCmd.Parameters.AddWithValue("@vid", viewerId);

                int exists = Convert.ToInt32(checkCmd.ExecuteScalar());
                if (exists > 0)
                {
                    MessageBox.Show("You already reacted to this case");
                    return;
                }

                // Insert reaction
                string insert = @"INSERT INTO PostReactions 
                                (CaseID, ViewerID, ReactionType)
                                VALUES (@cid, @vid, @type)";

                SqlCommand cmd = new SqlCommand(insert, con);
                cmd.Parameters.AddWithValue("@cid", caseId);
                cmd.Parameters.AddWithValue("@vid", viewerId);
                cmd.Parameters.AddWithValue("@type", reactionType);

                cmd.ExecuteNonQuery();
                LoadReactionCounts();
                CheckAndAutoReport();
            }
        }

        private void CheckAndAutoReport()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string countQuery = @"
                SELECT
                    ISNULL(SUM(CASE WHEN ReactionType='Like' THEN 1 ELSE 0 END), 0) AS Likes,
                    ISNULL(SUM(CASE WHEN ReactionType='Dislike' THEN 1 ELSE 0 END), 0) AS Dislikes
                FROM PostReactions
                WHERE CaseID=@cid";

                SqlCommand cmd = new SqlCommand(countQuery, con);
                cmd.Parameters.AddWithValue("@cid", caseId);

                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();

                int likes = Convert.ToInt32(dr["Likes"]);
                int dislikes = Convert.ToInt32(dr["Dislikes"]);
                dr.Close();

                // Check thresholds
                if (dislikes >= 10 || likes >= 10)
                {
                    // Determine report type based on severity
                    string reportType = dislikes >= 10 ? "High Priority" : "Standard";
                    string forwardedTo = dislikes >= 10 ?
                        "Cyber Crime Investigation Division" :
                        "Digital Security Agency";
                    GenerateAutoReport(reportType, forwardedTo);
                }
            }
        }

        private void GenerateAutoReport(string reportType, string forwardedTo)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                // Check if report already exists for this threshold
                string checkQuery = @"
                SELECT COUNT(*) 
                FROM AutoReports 
                WHERE CaseID = @cid 
                AND ReportType = @type
                AND ForwardedTo = @to";

                SqlCommand checkCmd = new SqlCommand(checkQuery, con);
                checkCmd.Parameters.AddWithValue("@cid", caseId);
                checkCmd.Parameters.AddWithValue("@type", reportType);
                checkCmd.Parameters.AddWithValue("@to", forwardedTo);

                int exists = Convert.ToInt32(checkCmd.ExecuteScalar());
                if (exists > 0)
                {
                    LoadAutoReportStatus();
                    return;
                }

                string insertQuery = @"
                INSERT INTO AutoReports 
                (CaseID, ReportType, ForwardedTo, ReportDate)
                OUTPUT INSERTED.ReportID
                VALUES (@cid, @type, @to, GETDATE())";

                SqlCommand cmd = new SqlCommand(insertQuery, con);
                cmd.Parameters.AddWithValue("@cid", caseId);
                cmd.Parameters.AddWithValue("@type", reportType);
                cmd.Parameters.AddWithValue("@to", forwardedTo);

                int newReportId = (int)cmd.ExecuteScalar();

                InsertReportStatus(newReportId, "Pending", "Auto-generated based on reaction threshold");
                LoadAutoReportStatus();
                ShowReportNotification(reportType, forwardedTo);
            }
        }

        private void InsertReportStatus(int reportId, string status, string details)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                try
                {
                    string query = @"
                    INSERT INTO ReportStatus 
                    (ReportID, Status, StatusDetails, UpdatedDate)
                    VALUES (@rid, @status, @details, GETDATE())";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@rid", reportId);
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.Parameters.AddWithValue("@details", details);

                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {

                    CreateReportStatusTable();
                    InsertReportStatus(reportId, status, details);
                }
            }
        }

        private void CreateReportStatusTable()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string createTableQuery = @"
                IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='ReportStatus' AND xtype='U')
                BEGIN
                    CREATE TABLE [Login].[dbo].[ReportStatus] (
                        [StatusID] INT IDENTITY(1,1) PRIMARY KEY,
                        [ReportID] INT NOT NULL,
                        [Status] NVARCHAR(50) DEFAULT 'Pending' 
                            CHECK (Status IN ('Pending', 'Forwarded', 'Under Review', 'Action Taken', 'Closed', 'Rejected')),
                        [StatusDetails] NVARCHAR(500),
                        [UpdatedBy] INT NULL,
                        [UpdatedDate] DATETIME DEFAULT GETDATE()
                    )
                END";

                SqlCommand cmd = new SqlCommand(createTableQuery, con);
                cmd.ExecuteNonQuery();
            }
        }

        private void ShowReportNotification(string reportType, string forwardedTo)
        {
            MessageBox.Show(
                $"Auto-report generated!\n\n" +
                $"Type: {reportType}\n" +
                $"Forwarded To: {forwardedTo}\n" +
                $"Status: Pending\n\n" +
                $"The report will be reviewed by authorities.",
                "Report Generated",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }


        private void button3_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            // This would open a form to update report status
            // For now, just refresh
            LoadAutoReportStatus();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}