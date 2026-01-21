using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace harrassmenysystem
{
    public partial class UploadEvidenceForm : Form
    {
        string connectionString = @"Server=localhost;Database=Login;Integrated Security=True;";
        private int SelectedCaseId;
        public UploadEvidenceForm()
        {
            InitializeComponent();
        }

        public UploadEvidenceForm(int caseId)
        {
            InitializeComponent();
            SelectedCaseId = caseId; // now this variable exists and has the right value
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UploadEvidenceForm_Load(object sender, EventArgs e)
        {
            cmbType.Items.Add("Image");
            cmbType.Items.Add("Audio");
            cmbType.Items.Add("Video");
            cmbType.Items.Add("Text");

            cmbType.SelectedIndex = -1;

            // Load Cases into cmbCases
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                // Show all cases (any victim can support any case)
                string query = "SELECT CaseId, Title FROM Cases";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cmbCases.Items.Add(new
                    {
                        Text = reader["Title"].ToString(),
                        Value = reader["CaseId"]
                    });
                }

                reader.Close();
                con.Close();
            }

            // Set DisplayMember and ValueMember
            cmbCases.DisplayMember = "Text";
            cmbCases.ValueMember = "Value";
            cmbCases.SelectedIndex = -1;
        }
        string selectedFilePath = "";
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                selectedFilePath = ofd.FileName;
                txtFilePath.Text = selectedFilePath;
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (cmbType.SelectedIndex == -1)
            {
                MessageBox.Show("Select evidence type");
                return;
            }

            if (string.IsNullOrEmpty(selectedFilePath))
            {
                MessageBox.Show("Select a file");
                return;
            }
            // New (correct)
            if (cmbCases.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a case");
                return;
            }

            int caseId = (int)((dynamic)cmbCases.SelectedItem).Value;
            string evidenceType = cmbType.SelectedItem.ToString();
            string fileName = Path.GetFileName(selectedFilePath);
            string filePath = selectedFilePath;
            DateTime uploadedDate = DateTime.Now;

            // 3️⃣ Insert into database
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO Evidence
        (CaseId, EvidenceType, FileName, FilePath, UploadedDate)
        VALUES (@CaseId, @EvidenceType, @FileName, @FilePath, @UploadedDate)";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@CaseId", caseId);
                cmd.Parameters.AddWithValue("@EvidenceType", evidenceType);
                cmd.Parameters.AddWithValue("@FileName", fileName);
                cmd.Parameters.AddWithValue("@FilePath", filePath);
                cmd.Parameters.AddWithValue("@UploadedDate", uploadedDate);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }

            MessageBox.Show("Evidence uploaded successfully");

            // 4️⃣ Clear
            cmbType.SelectedIndex = -1;
            txtFilePath.Clear();
            selectedFilePath = "";

            

            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
