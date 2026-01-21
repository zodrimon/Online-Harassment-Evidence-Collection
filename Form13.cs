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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server=.; Database=Login; Integrated Security=True;";


            string name = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Enter Viewer Name and Password.");
                return;
            }

            string query =
            "SELECT ViewerId FROM Viewers WHERE  Username=@Username AND Password=@Password";

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@Username", name);
                cmd.Parameters.AddWithValue("@Password", password);

                con.Open();
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    int viewerId = Convert.ToInt32(result);
                    MessageBox.Show("Viewer Login Successful!");
                    this.Hide();
                    new Form10(viewerId).Show();
                }
                else
                {
                    MessageBox.Show("Invalid Viewer Credentials.");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form15().Show();
        }

        private void Form13_Load(object sender, EventArgs e)
        {

        }
    }
}
