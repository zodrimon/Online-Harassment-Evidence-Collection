namespace harrassmenysystem
{
    partial class MainForm
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
            this.btnCreateCase = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnViewCases = new System.Windows.Forms.Button();
            this.btnUploadEvidence = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateCase
            // 
            this.btnCreateCase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnCreateCase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateCase.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCreateCase.Location = new System.Drawing.Point(165, 115);
            this.btnCreateCase.Name = "btnCreateCase";
            this.btnCreateCase.Size = new System.Drawing.Size(435, 47);
            this.btnCreateCase.TabIndex = 2;
            this.btnCreateCase.Text = "CREATE NEW CASE";
            this.btnCreateCase.UseVisualStyleBackColor = false;
            this.btnCreateCase.Click += new System.EventHandler(this.btnCreateCase_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.lblWelcome.Location = new System.Drawing.Point(38, 55);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(477, 45);
            this.lblWelcome.TabIndex = 3;
            this.lblWelcome.Text = "Dont worry, you are not alone.";
            this.lblWelcome.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnViewCases
            // 
            this.btnViewCases.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnViewCases.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewCases.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewCases.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnViewCases.Location = new System.Drawing.Point(165, 168);
            this.btnViewCases.Name = "btnViewCases";
            this.btnViewCases.Size = new System.Drawing.Size(435, 47);
            this.btnViewCases.TabIndex = 4;
            this.btnViewCases.Text = "VIEW CASES";
            this.btnViewCases.UseVisualStyleBackColor = false;
            this.btnViewCases.Click += new System.EventHandler(this.btnViewCases_Click);
            // 
            // btnUploadEvidence
            // 
            this.btnUploadEvidence.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnUploadEvidence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUploadEvidence.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadEvidence.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUploadEvidence.Location = new System.Drawing.Point(165, 221);
            this.btnUploadEvidence.Name = "btnUploadEvidence";
            this.btnUploadEvidence.Size = new System.Drawing.Size(435, 47);
            this.btnUploadEvidence.TabIndex = 5;
            this.btnUploadEvidence.Text = "UPLOAD EVIDENCE";
            this.btnUploadEvidence.UseVisualStyleBackColor = false;
            this.btnUploadEvidence.Click += new System.EventHandler(this.btnUploadEvidence_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogout.Location = new System.Drawing.Point(165, 366);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(229, 47);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "log out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnGenerateReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateReport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGenerateReport.Location = new System.Drawing.Point(165, 274);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(435, 47);
            this.btnGenerateReport.TabIndex = 7;
            this.btnGenerateReport.Text = "GENERATE CASE REPORTS";
            this.btnGenerateReport.UseVisualStyleBackColor = false;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::harrassmenysystem.Properties.Resources.download__5_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnUploadEvidence);
            this.Controls.Add(this.btnViewCases);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnCreateCase);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mainform";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCreateCase;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnViewCases;
        private System.Windows.Forms.Button btnUploadEvidence;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnGenerateReport;
    }
}