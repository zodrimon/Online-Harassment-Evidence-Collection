namespace C__project_AIUB
{
    partial class AdminMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dashboard_backBtn = new System.Windows.Forms.Button();
            this.dashboard_logout = new System.Windows.Forms.Button();
            this.dashboard_cases = new System.Windows.Forms.Button();
            this.dashboard_removeuser = new System.Windows.Forms.Button();
            this.dashboard_adduser = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1102, 165);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(939, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hello, Admin!";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.dashboard_backBtn);
            this.panel2.Controls.Add(this.dashboard_logout);
            this.panel2.Controls.Add(this.dashboard_cases);
            this.panel2.Controls.Add(this.dashboard_removeuser);
            this.panel2.Controls.Add(this.dashboard_adduser);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 165);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(363, 784);
            this.panel2.TabIndex = 1;
            // 
            // dashboard_backBtn
            // 
            this.dashboard_backBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.dashboard_backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.dashboard_backBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dashboard_backBtn.Location = new System.Drawing.Point(36, 702);
            this.dashboard_backBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dashboard_backBtn.Name = "dashboard_backBtn";
            this.dashboard_backBtn.Size = new System.Drawing.Size(288, 65);
            this.dashboard_backBtn.TabIndex = 6;
            this.dashboard_backBtn.Text = "BACK";
            this.dashboard_backBtn.UseVisualStyleBackColor = false;
            this.dashboard_backBtn.Click += new System.EventHandler(this.dashboard_backBtn_Click);
            // 
            // dashboard_logout
            // 
            this.dashboard_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.dashboard_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.dashboard_logout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dashboard_logout.Location = new System.Drawing.Point(36, 449);
            this.dashboard_logout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dashboard_logout.Name = "dashboard_logout";
            this.dashboard_logout.Size = new System.Drawing.Size(288, 65);
            this.dashboard_logout.TabIndex = 5;
            this.dashboard_logout.Text = "LOGOUT";
            this.dashboard_logout.UseVisualStyleBackColor = false;
            this.dashboard_logout.Click += new System.EventHandler(this.dashboard_logout_Click);
            // 
            // dashboard_cases
            // 
            this.dashboard_cases.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.dashboard_cases.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.dashboard_cases.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dashboard_cases.Location = new System.Drawing.Point(36, 335);
            this.dashboard_cases.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dashboard_cases.Name = "dashboard_cases";
            this.dashboard_cases.Size = new System.Drawing.Size(288, 65);
            this.dashboard_cases.TabIndex = 4;
            this.dashboard_cases.Text = "CASES";
            this.dashboard_cases.UseVisualStyleBackColor = false;
            this.dashboard_cases.Click += new System.EventHandler(this.dashboard_cases_Click);
            // 
            // dashboard_removeuser
            // 
            this.dashboard_removeuser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.dashboard_removeuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.dashboard_removeuser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dashboard_removeuser.Location = new System.Drawing.Point(36, 226);
            this.dashboard_removeuser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dashboard_removeuser.Name = "dashboard_removeuser";
            this.dashboard_removeuser.Size = new System.Drawing.Size(288, 65);
            this.dashboard_removeuser.TabIndex = 1;
            this.dashboard_removeuser.Text = "REMOVE USER";
            this.dashboard_removeuser.UseVisualStyleBackColor = false;
            this.dashboard_removeuser.Click += new System.EventHandler(this.dashboard_removeuser_Click);
            // 
            // dashboard_adduser
            // 
            this.dashboard_adduser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.dashboard_adduser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.dashboard_adduser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dashboard_adduser.Location = new System.Drawing.Point(36, 108);
            this.dashboard_adduser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dashboard_adduser.Name = "dashboard_adduser";
            this.dashboard_adduser.Size = new System.Drawing.Size(288, 71);
            this.dashboard_adduser.TabIndex = 0;
            this.dashboard_adduser.Text = "ADD USER";
            this.dashboard_adduser.UseVisualStyleBackColor = false;
            this.dashboard_adduser.Click += new System.EventHandler(this.dashboard_adduser_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(351, 165);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(752, 785);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(31, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(460, 26);
            this.label1.TabIndex = 15;
            this.label1.Text = "HARASSMENT EVIDENCE COLLECTION";
            // 
            // AdminMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 949);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AdminMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminMainForm";
            this.Load += new System.EventHandler(this.AdminMainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button dashboard_removeuser;
        private System.Windows.Forms.Button dashboard_adduser;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button dashboard_backBtn;
        private System.Windows.Forms.Button dashboard_logout;
        private System.Windows.Forms.Button dashboard_cases;
        private System.Windows.Forms.Label label1;
    }
}