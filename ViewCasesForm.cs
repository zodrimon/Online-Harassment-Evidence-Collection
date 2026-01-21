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
    public partial class ViewCasesForm : Form
    {
        string connectionString = @"Server=localhost;Database=Login;Integrated Security=True;";

        private void LoadCases()
        {
            string query = "SELECT CaseId, Title, Description, CreatedDate FROM Cases";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvCases.DataSource = dt;
                }
            }
        }
        public ViewCasesForm()
        {
            InitializeComponent();
        }

        private void ViewCasesForm_Load(object sender, EventArgs e)
        {
            LoadCases();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadCases();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUplodEvidence_Click(object sender, EventArgs e)
        {
            if (dgvCases.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a case first");
                return;
            }

            int caseId = Convert.ToInt32(dgvCases.SelectedRows[0].Cells["CaseId"].Value);

            UploadEvidenceForm uploadForm = new UploadEvidenceForm(caseId);
            uploadForm.ShowDialog();
        }

        private void dgvCases_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
