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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server=.; Database=Login; Integrated Security=True;";


            string email = textBox1.Text.Trim();
            string username = textBox2.Text.Trim();  
            string password = textBox3.Text.Trim();  

            if (string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("All fields are required.");
                return;
            }

            string query = @"INSERT INTO Viewers (Username, Email, Password, CreatedDate)
                             VALUES (@Username, @Email, @Password, GETDATE())";

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", password);

                con.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Registration successful!");

                this.Hide();
                new Form13().Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form13().Show();
        }

        private void Form15_Load(object sender, EventArgs e)
        {

        }
    }
}