namespace C__project_AIUB
{
    partial class AllCases
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cases_verifyBtn = new System.Windows.Forms.Button();
            this.cases_backBtn = new System.Windows.Forms.Label();
            this.cases_addCase = new System.Windows.Forms.Button();
            this.cases_removeCase = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 149);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(1254, 517);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cases_verifyBtn
            // 
            this.cases_verifyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.cases_verifyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cases_verifyBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cases_verifyBtn.Location = new System.Drawing.Point(988, 692);
            this.cases_verifyBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cases_verifyBtn.Name = "cases_verifyBtn";
            this.cases_verifyBtn.Size = new System.Drawing.Size(182, 58);
            this.cases_verifyBtn.TabIndex = 6;
            this.cases_verifyBtn.Text = "VERIFY";
            this.cases_verifyBtn.UseVisualStyleBackColor = false;
            this.cases_verifyBtn.Click += new System.EventHandler(this.cases_verifyBtn_Click);
            // 
            // cases_backBtn
            // 
            this.cases_backBtn.AutoSize = true;
            this.cases_backBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cases_backBtn.Location = new System.Drawing.Point(1214, 34);
            this.cases_backBtn.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.cases_backBtn.Name = "cases_backBtn";
            this.cases_backBtn.Size = new System.Drawing.Size(29, 29);
            this.cases_backBtn.TabIndex = 7;
            this.cases_backBtn.Text = "X";
            this.cases_backBtn.Click += new System.EventHandler(this.cases_backBtn_Click);
            // 
            // cases_addCase
            // 
            this.cases_addCase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.cases_addCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cases_addCase.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cases_addCase.Location = new System.Drawing.Point(94, 692);
            this.cases_addCase.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cases_addCase.Name = "cases_addCase";
            this.cases_addCase.Size = new System.Drawing.Size(294, 58);
            this.cases_addCase.TabIndex = 15;
            this.cases_addCase.Text = "Add Case";
            this.cases_addCase.UseVisualStyleBackColor = false;
            this.cases_addCase.Click += new System.EventHandler(this.cases_addCase_Click);
            // 
            // cases_removeCase
            // 
            this.cases_removeCase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.cases_removeCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cases_removeCase.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cases_removeCase.Location = new System.Drawing.Point(436, 692);
            this.cases_removeCase.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cases_removeCase.Name = "cases_removeCase";
            this.cases_removeCase.Size = new System.Drawing.Size(268, 58);
            this.cases_removeCase.TabIndex = 16;
            this.cases_removeCase.Text = "Remove Case";
            this.cases_removeCase.UseVisualStyleBackColor = false;
            this.cases_removeCase.Click += new System.EventHandler(this.cases_removeCase_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(20, 62);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(672, 38);
            this.label6.TabIndex = 17;
            this.label6.Text = "HARASSMENT EVIDENCE COLLECTION";
            // 
            // AllCases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.ClientSize = new System.Drawing.Size(1290, 771);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cases_removeCase);
            this.Controls.Add(this.cases_addCase);
            this.Controls.Add(this.cases_backBtn);
            this.Controls.Add(this.cases_verifyBtn);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AllCases";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AllCases";
            this.Load += new System.EventHandler(this.AllCases_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button cases_verifyBtn;
        private System.Windows.Forms.Label cases_backBtn;
        private System.Windows.Forms.Button cases_addCase;
        private System.Windows.Forms.Button cases_removeCase;
        private System.Windows.Forms.Label label6;
    }
}