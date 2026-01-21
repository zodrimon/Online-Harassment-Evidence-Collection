using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace harrassmenysystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateCase_Click(object sender, EventArgs e)
        {
            CreateCaseForm createCaseForm = new CreateCaseForm();
            createCaseForm.ShowDialog();
        }

        private void btnViewCases_Click(object sender, EventArgs e)
        {
            ViewCasesForm viewCasesForm = new ViewCasesForm();
            viewCasesForm.ShowDialog();
        }

        private void btnUploadEvidence_Click(object sender, EventArgs e)
        {
            UploadEvidenceForm uploadEvidenceForm = new UploadEvidenceForm();
            uploadEvidenceForm.ShowDialog();
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            GenerateReportForm reportForm = new GenerateReportForm();
            reportForm.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close(); 
            Login loginForm = new Login();
            loginForm.Show();
        }
    }
}
