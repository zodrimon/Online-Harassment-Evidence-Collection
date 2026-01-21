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

namespace harrassmenysystem
{
    public partial class GenerateReportForm : Form
    {
        string connectionString = @"Server=localhost;Database=Login;Integrated Security=True;";
        public GenerateReportForm()
        {
            InitializeComponent();
        }

        private void GenerateReportForm_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT CaseId, Title FROM Cases";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cmbCases.Items.Add(new { Text = reader["Title"].ToString(), Value = reader["CaseId"] });
                }

                con.Close();
            }

            cmbCases.DisplayMember = "Text";  // shows Title
            cmbCases.ValueMember = "Value";   // stores CaseId
            cmbCases.SelectedIndex = -1;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (cmbCases.SelectedIndex == -1)
            {
                MessageBox.Show("Select a case first");
                return;
            }

            int caseId = (int)((dynamic)cmbCases.SelectedItem).Value;

            // 1️⃣ Get case info
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                SqlCommand cmdInfo = new SqlCommand("SELECT Title, CreatedDate FROM Cases WHERE CaseId=@id", con);
                cmdInfo.Parameters.AddWithValue("@id", caseId);
                SqlDataReader reader = cmdInfo.ExecuteReader();
                if (reader.Read())
                {
                    lblCaseTitle.Text = "Title: " + reader["Title"].ToString();
                    lblCaseDate.Text = "Created: " + Convert.ToDateTime(reader["CreatedDate"]).ToString("g");
                }
                reader.Close();

                // 2️⃣ Get evidence for this case
                SqlDataAdapter da = new SqlDataAdapter("SELECT EvidenceType, FileName, UploadedDate FROM Evidence WHERE CaseId=@id", con);
                da.SelectCommand.Parameters.AddWithValue("@id", caseId);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvReport.DataSource = dt;

                // 3️⃣ Evidence count
                lblEvidenceCount.Text = "Total Evidence: " + dt.Rows.Count;

                con.Close();
            }
        }

        private void dgvReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grpCaseInfo_Enter(object sender, EventArgs e)
        {

        }
    }
}
