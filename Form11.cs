using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvidenceCollect
{
    public partial class Form11 : Form
    {
        string connectionString = @"Server=.; Database=Login; Integrated Security=True;";

        private int currentViewerId;

        public Form11(int viewerId)
        {
            InitializeComponent();
            currentViewerId = viewerId;
        }

        

        private void Form11_Load(object sender, EventArgs e)
        {
            LoadCases();
        }

        private void LoadCases()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = @"SELECT 
                               CaseID,
                               Title,
                               
                               CreatedDate
                               FROM Cases";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
                dataGridView1.Columns["CaseID"].Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Select a case first");
                return;
            }

            int caseId = Convert.ToInt32(
                dataGridView1.CurrentRow.Cells["CaseID"].Value);

            Reaction f = new Reaction(caseId, currentViewerId);
            f.Owner = this;
            f.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        
    }
}
