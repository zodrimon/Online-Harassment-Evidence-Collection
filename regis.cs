using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace harrassmenysystem
{
    public partial class RegistrationForm : Form
    {
        string connectionString = @"Server=.; Database=Login; Integrated Security=True;";
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login logForm = new Login();
            logForm.ShowDialog();
            this.Show();

        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistor_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            string number = txtNumber.Text;

            if (name == "" || email == "" || password == "" || number == "")
            {
                MessageBox.Show("Please fill all fields");
                return;
            }

            string query =
                "INSERT INTO Users (Name, Email, Password, Number) " +
                "VALUES (@n, @e, @p, @num)";

            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@n", name);
            cmd.Parameters.AddWithValue("@e", email);
            cmd.Parameters.AddWithValue("@p", password);
            cmd.Parameters.AddWithValue("@num", number);

             con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Registration successful 😋");
            this.Close();
        }

        
    }
}
