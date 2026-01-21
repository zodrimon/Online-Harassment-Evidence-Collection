using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace C__project_AIUB
{
    public partial class EvidenceForm : Form
    {
        private int caseID;

        SqlConnection connect = new SqlConnection(
            @"Server=localhost;Database=Login;Integrated Security=True;");

        // ---------- Receive CaseID from AllCases ----------
        public EvidenceForm(int id)
        {
            InitializeComponent();
            caseID = id;
        }

        private void EvidenceForm_Load(object sender, EventArgs e)
        {
            LoadEvidence();
        }

        // ---------------- LOAD EVIDENCE ----------------
        private void LoadEvidence()
        {
            try
            {
                if (connect.State == ConnectionState.Closed)
                    connect.Open();

                string query = @"SELECT EvidenceType, FileName, FilePath, UploadedDate 
                                 FROM Evidence 
                                 WHERE CaseID = @id";

                SqlCommand cmd = new SqlCommand(query, connect);
                cmd.Parameters.AddWithValue("@id", caseID);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading evidence: " + ex.Message);
            }
            finally
            {
                connect.Close();
            }
        }

        // ---------------- ON ROW CLICK SHOW PREVIEW ----------------
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string type = dataGridView1.Rows[e.RowIndex].Cells["EvidenceType"].Value.ToString();
            string path = dataGridView1.Rows[e.RowIndex].Cells["FilePath"].Value.ToString();

            ShowPreview(type, path);
        }

        // ---------------- PREVIEW LOGIC ----------------
        private void ShowPreview(string type, string path)
        {
            // Hide all
            pictureBox1.Visible = false;
            richTextBox1.Visible = false;

            if (!File.Exists(path))
            {
                MessageBox.Show("File not found: " + path);
                return;
            }

            if (type == "image")
            {
                pictureBox1.Visible = true;
                pictureBox1.Image = Image.FromFile(path);
            }
            else if (type == "text")
            {
                richTextBox1.Visible = true;
                richTextBox1.Text = File.ReadAllText(path);
            }
            else
            {
                // Not previewable → user must open file manually
                MessageBox.Show("This file cannot be previewed here. Click 'Open File'.");
            }
        }

        // ---------------- OPEN FILE USING DEFAULT APP ----------------
        private void evidence_openfileBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select an evidence item first!");
                return;
            }

            string path = dataGridView1.SelectedRows[0].Cells["FilePath"].Value.ToString();

            if (!File.Exists(path))
            {
                MessageBox.Show("Error: File not found!");
                return;
            }

            try
            {
                Process.Start(path); // Opens with VLC, Movies, PDF reader etc.
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open file: " + ex.Message);
            }
        }

        private void evidence_backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e) { }

        private void pictureBox1_Click(object sender, EventArgs e) { }

        private void label6_Click(object sender, EventArgs e) { }
    }
}
