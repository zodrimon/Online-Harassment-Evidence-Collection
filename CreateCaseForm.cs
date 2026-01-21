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
    public partial class CreateCaseForm : Form
    {
        string connectionString = @"Server=localhost;Database=Login;Integrated Security=True;";
        public CreateCaseForm()
        {
            InitializeComponent();
        }

        private void CreateCaseForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text.Trim();
            string description = txtDescription.Text.Trim();

            if (title == "" || description == "")
            {
                MessageBox.Show("Please enter both Title and Description", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DateTime createdDate = DateTime.Now;

            string query = "INSERT INTO Cases (Title, Description, CreatedDate) VALUES (@t, @d, @cd)";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@t", title);
                        cmd.Parameters.AddWithValue("@d", description);
                        cmd.Parameters.AddWithValue("@cd", createdDate);

                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Case created successfully! 😎", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Close form after saving
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
