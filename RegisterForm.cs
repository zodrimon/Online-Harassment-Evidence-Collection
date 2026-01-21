using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__project_AIUB
{
    public partial class RegisterForm : Form
    {
        SqlConnection connect = new SqlConnection(
            @"Server=localhost;Database=Login;Integrated Security=True;");

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void reigster_singinBtn_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            register_pass.PasswordChar = register_showpassword.Checked ? '\0' : '•';
            register_cpass.PasswordChar = register_showpassword.Checked ? '\0' : '•';
        }

        public bool emptyfield()
        {
            if (string.IsNullOrWhiteSpace(register_adminId.Text) ||
                string.IsNullOrWhiteSpace(register_username.Text) ||
                string.IsNullOrWhiteSpace(register_email.Text) ||
                string.IsNullOrWhiteSpace(register_pass.Text) ||
                string.IsNullOrWhiteSpace(register_cpass.Text))
            {
                return true;
            }
            return false;
        }

        private void register_signupBtn_Click(object sender, EventArgs e)
        {
            if (emptyfield())
            {
                DialogResult result = MessageBox.Show(
                    "Please fill all fields.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                if (result == DialogResult.OK)
                {
                    Form1 f1 = new Form1();
                    f1.Show();
                    this.Hide(); // optional
                    return;

                }

            }

            // Validate AdminId is an INTEGER
            if (!int.TryParse(register_adminId.Text.Trim(), out int adminIdValue))
            {
                MessageBox.Show("Admin ID must be a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();

                    // Check AdminId unique
                    string checkIdQuery = "SELECT * FROM dbo.Admin WHERE AdminId = @AdminId";
                    using (SqlCommand cmd = new SqlCommand(checkIdQuery, connect))
                    {
                        cmd.Parameters.Add("@AdminId", SqlDbType.Int).Value = adminIdValue;

                        SqlDataAdapter ad = new SqlDataAdapter(cmd);
                        DataTable tbl = new DataTable();
                        ad.Fill(tbl);

                        if (tbl.Rows.Count > 0)
                        {
                            MessageBox.Show("Admin ID already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Check Name unique
                    string checkNameQuery = "SELECT * FROM dbo.Admin WHERE Name = @Name";
                    using (SqlCommand cmd = new SqlCommand(checkNameQuery, connect))
                    {
                        cmd.Parameters.AddWithValue("@Name", register_username.Text.Trim());

                        SqlDataAdapter ad = new SqlDataAdapter(cmd);
                        DataTable tbl = new DataTable();
                        ad.Fill(tbl);

                        if (tbl.Rows.Count > 0)
                        {
                            MessageBox.Show("Username already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Check Email unique
                    string checkEmailQuery = "SELECT * FROM dbo.Admin WHERE Email = @Email";
                    using (SqlCommand cmd = new SqlCommand(checkEmailQuery, connect))
                    {
                        cmd.Parameters.AddWithValue("@Email", register_email.Text.Trim());

                        SqlDataAdapter ad = new SqlDataAdapter(cmd);
                        DataTable tbl = new DataTable();
                        ad.Fill(tbl);

                        if (tbl.Rows.Count > 0)
                        {
                            MessageBox.Show("Email already registered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Password checks
                    if (register_pass.Text != register_cpass.Text)
                    {
                        MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (register_pass.Text.Length < 8)
                    {
                        MessageBox.Show("Password must be at least 8 characters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Insert into Admin table
                    string insertQuery = @"INSERT INTO dbo.Admin (AdminId, Name, Email, Password)
                                           VALUES (@AdminId, @Name, @Email, @Password)";

                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, connect))
                    {
                        insertCmd.Parameters.Add("@AdminId", SqlDbType.Int).Value = adminIdValue;
                        insertCmd.Parameters.AddWithValue("@Name", register_username.Text.Trim());
                        insertCmd.Parameters.AddWithValue("@Email", register_email.Text.Trim());
                        insertCmd.Parameters.AddWithValue("@Password", register_pass.Text.Trim());

                        int result = insertCmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Registration Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                          Form1 loginForm = new Form1();
                            loginForm.Show();
                            this.Hide();
                          
                        }
                        else
                        {
                            MessageBox.Show("Registration failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void register_cpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void register_pass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
