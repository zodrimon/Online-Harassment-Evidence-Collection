using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace C__project_AIUB
{
    public partial class AllCases : Form
    {
        SqlConnection connect = new SqlConnection(
            @"Server=localhost;Database=Login;Integrated Security=True;");

        public AllCases()
        {
            InitializeComponent();
            LoadCases();
        }

        // ---------------------- LOAD CASES ----------------------
        private void LoadCases()
        {
            try
            {
                if (connect.State == ConnectionState.Closed)
                    connect.Open();

                string query = "SELECT CaseID, Title, Description, CreatedDate FROM dbo.Cases";
                SqlDataAdapter da = new SqlDataAdapter(query, connect);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.MultiSelect = false;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading cases: " + ex.Message);
            }
            finally
            {
                connect.Close();
            }
        }

        // ---------------------- ADD CASE ----------------------
        private void cases_addCase_Click(object sender, EventArgs e)
        {
            string title = Prompt.ShowDialog("Enter case title:", "Add Case");
            string description = Prompt.ShowDialog("Enter case description:", "Add Case");

            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(description))
            {
                MessageBox.Show("Both fields are required!");
                return;
            }

            try
            {
                if (connect.State == ConnectionState.Closed)
                    connect.Open();

                string query = "INSERT INTO dbo.Cases (Title, Description) VALUES (@title, @desc)";
                SqlCommand cmd = new SqlCommand(query, connect);
                cmd.Parameters.AddWithValue("@title", title);
                cmd.Parameters.AddWithValue("@desc", description);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Case added successfully!");
                LoadCases();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding case: " + ex.Message);
            }
            finally
            {
                connect.Close();
            }
        }

        // ---------------------- REMOVE CASE ----------------------
        private void cases_removeCase_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a case to remove.");
                return;
            }

            int caseID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["CaseID"].Value);

            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to delete this case?",
                "Confirm Delete",
                MessageBoxButtons.YesNo);

            if (confirm != DialogResult.Yes)
                return;

            try
            {
                if (connect.State == ConnectionState.Closed)
                    connect.Open();

                string query = "DELETE FROM dbo.Cases WHERE CaseID = @id";
                SqlCommand cmd = new SqlCommand(query, connect);
                cmd.Parameters.AddWithValue("@id", caseID);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Case removed successfully!");
                LoadCases();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error removing case: " + ex.Message);
            }
            finally
            {
                connect.Close();
            }
        }

        private void cases_verifyBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a case first!");
                return;
            }

            int caseID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["CaseID"].Value);

            // Open EvidenceForm
            EvidenceForm evForm = new EvidenceForm(caseID);
            evForm.Show(); // or ShowDialog() if you want it modal
        }


        private void cases_backBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Optional: handle row click if needed
        }

        private void AllCases_Load(object sender, EventArgs e)
        {

        }
    }
}
