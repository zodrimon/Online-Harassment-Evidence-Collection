using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C__project_AIUB;
using EvidenceCollect;
using System.Windows.Forms;

namespace harrassmenysystem{
    public partial class Login : Form

    {
        string connectionString = @"Server=localhost;Database=Login;Integrated security=True;";
        public Login()
        {
            InitializeComponent();
        }
        private void MakeButtonRound(Button btn, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(btn.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(btn.Width - radius, btn.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, btn.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();

            btn.Region = new Region(path);
        }
        private void Login_Load(object sender, EventArgs e)
        {
            MakeButtonRound(btnLogin, 30);
            MakeButtonRound(btnRegister, 30);
        }

        


        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationForm regForm = new RegistrationForm();
            regForm.ShowDialog();
            this.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (email == "" || password == "")
            {
                MessageBox.Show("Please enter both email and password");
                return;
            }

            // Query to check if the user exists
            string query = "SELECT COUNT(*) FROM Users WHERE Email = @e AND [Password] = @p";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@e", email);
                        cmd.Parameters.AddWithValue("@p", password);

                        con.Open();
                        int result = (int)cmd.ExecuteScalar(); // Returns count

                        if (result > 0)
                        {
                            MessageBox.Show("Login Successful 😎");

                            // Open dashboard or main form
                            this.Hide();
                            MainForm mainForm = new MainForm(); // Replace with your dashboard form
                            mainForm.ShowDialog();
                            this.Show();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Email or Password ❌");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
             C__project_AIUB.Form1 adminForm = new C__project_AIUB.Form1();
            adminForm.Show();
            this.Hide();

        }

        private void btnvv_Click(object sender, EventArgs e)
        {
            EvidenceCollect.Form13 f13 = new EvidenceCollect.Form13();
            f13.Show();
        }
    }
}
