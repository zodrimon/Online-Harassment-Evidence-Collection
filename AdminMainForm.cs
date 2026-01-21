using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace C__project_AIUB
{
    public partial class AdminMainForm : Form
    {
        // Database connection
        SqlConnection connect = new SqlConnection(
            @"Server=localhost;Database=Login;Integrated Security=True;");

        public AdminMainForm()
        {
            InitializeComponent();
        }

        // Load users when form opens
        private void AdminMainForm_Load(object sender, EventArgs e)
        {
            // Ensure proper selection mode
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

            LoadUsers();
        }

        // Load all users into DataGridView
        private void LoadUsers()
        {
            try
            {
                if (connect.State == ConnectionState.Closed)
                    connect.Open();

                string query = "SELECT UserID, Name, Email, Password, Number FROM dbo.Users";
                SqlDataAdapter da = new SqlDataAdapter(query, connect);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // Set headers
                dataGridView1.Columns["UserID"].HeaderText = "ID";
                dataGridView1.Columns["UserID"].ReadOnly = true;
                dataGridView1.Columns["Name"].HeaderText = "Username";
                dataGridView1.Columns["Email"].HeaderText = "Email";
                dataGridView1.Columns["Password"].HeaderText = "Password";
                dataGridView1.Columns["Number"].HeaderText = "Phone";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading users: " + ex.Message);
            }
            finally
            {
                connect.Close();
            }
        }

        // Add new user
        private void dashboard_adduser_Click(object sender, EventArgs e)
        {
            string name = Prompt.ShowDialog("Enter username:", "Add User");
            string email = Prompt.ShowDialog("Enter email:", "Add User");
            string password = Prompt.ShowDialog("Enter password:", "Add User");
            string number = Prompt.ShowDialog("Enter phone number:", "Add User");

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(number))
            {
                MessageBox.Show("All fields are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (connect.State == ConnectionState.Closed)
                    connect.Open();

                // Generate new UserID manually
                int newId = 1;
                string maxIdQuery = "SELECT ISNULL(MAX(UserID), 0) FROM dbo.Users";
                using (SqlCommand cmd = new SqlCommand(maxIdQuery, connect))
                {
                    newId = Convert.ToInt32(cmd.ExecuteScalar()) + 1;
                }

                // Insert user with generated UserID
                string insertQuery = @"
                    INSERT INTO dbo.Users (UserID, Name, Email, Password, Number)
                    VALUES (@id, @name, @email, @password, @number)";

                using (SqlCommand cmd = new SqlCommand(insertQuery, connect))
                {
                    cmd.Parameters.AddWithValue("@id", newId);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@number", number);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show($"User added successfully!\nUserID: {newId}");
                LoadUsers(); // Refresh DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding user: " + ex.Message);
            }
            finally
            {
                connect.Close();
            }
        }

        // Remove selected user
        private void dashboard_removeuser_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user to remove.");
                return;
            }

            // Confirm deletion
            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to remove this user?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes)
                return;

            try
            {
                int userId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["UserID"].Value);

                if (connect.State == ConnectionState.Closed)
                    connect.Open();

                string deleteQuery = "DELETE FROM dbo.Users WHERE UserID=@id";
                using (SqlCommand cmd = new SqlCommand(deleteQuery, connect))
                {
                    cmd.Parameters.AddWithValue("@id", userId);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                        MessageBox.Show("User removed successfully!");
                    else
                        MessageBox.Show("User not found or could not be removed.");
                }

                LoadUsers(); // Refresh DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error removing user: " + ex.Message);
            }
            finally
            {
                connect.Close();
            }
        }

        // Placeholder for cases button
        private void dashboard_cases_Click(object sender, EventArgs e)
        {
            // Implement cases logic here

            AllCases caseForm = new AllCases();
            caseForm.Show();
            this.Hide();
        }

        // Placeholder for logout button
        private void dashboard_logout_Click(object sender, EventArgs e)
        {
            // Will implement later
        }

        // Placeholder for back button
        private void dashboard_backBtn_Click(object sender, EventArgs e)
        {
            // Will implement later
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Optional: can be used to select rows
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Any other button functionality
        }
    }

    // Custom Prompt class to replace VB InputBox
    public static class Prompt
    {
        public static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 350,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };

            Label textLabel = new Label() { Left = 20, Top = 20, Text = text, Width = 300 };
            TextBox inputBox = new TextBox() { Left = 20, Top = 50, Width = 300 };
            Button confirmation = new Button() { Text = "OK", Left = 240, Width = 80, Top = 80, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };

            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(inputBox);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? inputBox.Text : "";
        }
    }
}
