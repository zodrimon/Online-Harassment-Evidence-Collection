namespace harrassmenysystem
{
    partial class GenerateReportForm
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
            this.btnGenerate = new System.Windows.Forms.Button();
            this.cmbCases = new System.Windows.Forms.ComboBox();
            this.lblSelectCase = new System.Windows.Forms.Label();
            this.grpCaseInfo = new System.Windows.Forms.GroupBox();
            this.lblCaseDate = new System.Windows.Forms.Label();
            this.lblEvidenceCount = new System.Windows.Forms.Label();
            this.lblCaseTitle = new System.Windows.Forms.Label();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.grpCaseInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.panel1.Controls.Add(this.btnGenerate);
            this.panel1.Controls.Add(this.cmbCases);
            this.panel1.Controls.Add(this.lblSelectCase);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 60);
            this.panel1.TabIndex = 0;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(613, 20);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(155, 37);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "Generate Report";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // cmbCases
            // 
            this.cmbCases.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCases.FormattingEnabled = true;
            this.cmbCases.Location = new System.Drawing.Point(163, 25);
            this.cmbCases.Name = "cmbCases";
            this.cmbCases.Size = new System.Drawing.Size(320, 28);
            this.cmbCases.TabIndex = 1;
            // 
            // lblSelectCase
            // 
            this.lblSelectCase.AutoSize = true;
            this.lblSelectCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectCase.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSelectCase.Location = new System.Drawing.Point(21, 25);
            this.lblSelectCase.Name = "lblSelectCase";
            this.lblSelectCase.Size = new System.Drawing.Size(130, 25);
            this.lblSelectCase.TabIndex = 0;
            this.lblSelectCase.Text = "Select Case";
            // 
            // grpCaseInfo
            // 
            this.grpCaseInfo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpCaseInfo.BackgroundImage = global::harrassmenysystem.Properties.Resources.Hình_nền_máy_tính_stitch;
            this.grpCaseInfo.Controls.Add(this.lblCaseDate);
            this.grpCaseInfo.Controls.Add(this.lblEvidenceCount);
            this.grpCaseInfo.Controls.Add(this.lblCaseTitle);
            this.grpCaseInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpCaseInfo.Location = new System.Drawing.Point(0, 60);
            this.grpCaseInfo.Name = "grpCaseInfo";
            this.grpCaseInfo.Size = new System.Drawing.Size(800, 120);
            this.grpCaseInfo.TabIndex = 1;
            this.grpCaseInfo.TabStop = false;
            this.grpCaseInfo.Text = "Case Information";
            this.grpCaseInfo.Enter += new System.EventHandler(this.grpCaseInfo_Enter);
            // 
            // lblCaseDate
            // 
            this.lblCaseDate.AutoSize = true;
            this.lblCaseDate.Location = new System.Drawing.Point(159, 52);
            this.lblCaseDate.Name = "lblCaseDate";
            this.lblCaseDate.Size = new System.Drawing.Size(70, 20);
            this.lblCaseDate.TabIndex = 2;
            this.lblCaseDate.Text = "Created:";
            // 
            // lblEvidenceCount
            // 
            this.lblEvidenceCount.AutoSize = true;
            this.lblEvidenceCount.Location = new System.Drawing.Point(159, 85);
            this.lblEvidenceCount.Name = "lblEvidenceCount";
            this.lblEvidenceCount.Size = new System.Drawing.Size(117, 20);
            this.lblEvidenceCount.TabIndex = 2;
            this.lblEvidenceCount.Text = "Total Evidence:";
            // 
            // lblCaseTitle
            // 
            this.lblCaseTitle.AutoSize = true;
            this.lblCaseTitle.Location = new System.Drawing.Point(159, 22);
            this.lblCaseTitle.Name = "lblCaseTitle";
            this.lblCaseTitle.Size = new System.Drawing.Size(42, 20);
            this.lblCaseTitle.TabIndex = 1;
            this.lblCaseTitle.Text = "Title:";
            // 
            // dgvReport
            // 
            this.dgvReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReport.Location = new System.Drawing.Point(0, 180);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.ReadOnly = true;
            this.dgvReport.RowHeadersWidth = 62;
            this.dgvReport.RowTemplate.Height = 28;
            this.dgvReport.Size = new System.Drawing.Size(800, 270);
            this.dgvReport.TabIndex = 2;
            this.dgvReport.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReport_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.btnBack);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 400);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 50);
            this.panel2.TabIndex = 3;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(323, 7);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(155, 37);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // GenerateReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvReport);
            this.Controls.Add(this.grpCaseInfo);
            this.Controls.Add(this.panel1);
            this.Name = "GenerateReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GenerateReportForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GenerateReportForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpCaseInfo.ResumeLayout(false);
            this.grpCaseInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.ComboBox cmbCases;
        private System.Windows.Forms.Label lblSelectCase;
        private System.Windows.Forms.GroupBox grpCaseInfo;
        private System.Windows.Forms.Label lblCaseDate;
        private System.Windows.Forms.Label lblEvidenceCount;
        private System.Windows.Forms.Label lblCaseTitle;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBack;
    }
}