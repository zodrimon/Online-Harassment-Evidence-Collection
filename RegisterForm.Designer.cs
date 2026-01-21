namespace C__project_AIUB
{
    partial class RegisterForm
    {
        private System.ComponentModel.IContainer components = null;

        // Controls
        private System.Windows.Forms.TextBox register_adminId;
        private System.Windows.Forms.TextBox register_username;
        private System.Windows.Forms.TextBox register_email;
        private System.Windows.Forms.TextBox register_pass;
        private System.Windows.Forms.TextBox register_cpass;
        private System.Windows.Forms.CheckBox register_showpassword;
        private System.Windows.Forms.Button register_signupBtn;
        private System.Windows.Forms.Button reigster_singinBtn;
        private System.Windows.Forms.Label label1;

        /// <summary>
        /// Clean up resources.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Initialize UI components.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.register_adminId = new System.Windows.Forms.TextBox();
            this.register_username = new System.Windows.Forms.TextBox();
            this.register_email = new System.Windows.Forms.TextBox();
            this.register_pass = new System.Windows.Forms.TextBox();
            this.register_cpass = new System.Windows.Forms.TextBox();
            this.register_showpassword = new System.Windows.Forms.CheckBox();
            this.register_signupBtn = new System.Windows.Forms.Button();
            this.reigster_singinBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // register_adminId
            // 
            resources.ApplyResources(this.register_adminId, "register_adminId");
            this.register_adminId.Name = "register_adminId";
            // 
            // register_username
            // 
            resources.ApplyResources(this.register_username, "register_username");
            this.register_username.Name = "register_username";
            // 
            // register_email
            // 
            resources.ApplyResources(this.register_email, "register_email");
            this.register_email.Name = "register_email";
            // 
            // register_pass
            // 
            resources.ApplyResources(this.register_pass, "register_pass");
            this.register_pass.Name = "register_pass";
            this.register_pass.TextChanged += new System.EventHandler(this.register_pass_TextChanged);
            // 
            // register_cpass
            // 
            resources.ApplyResources(this.register_cpass, "register_cpass");
            this.register_cpass.Name = "register_cpass";
            this.register_cpass.TextChanged += new System.EventHandler(this.register_cpass_TextChanged);
            // 
            // register_showpassword
            // 
            resources.ApplyResources(this.register_showpassword, "register_showpassword");
            this.register_showpassword.Name = "register_showpassword";
            this.register_showpassword.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // register_signupBtn
            // 
            resources.ApplyResources(this.register_signupBtn, "register_signupBtn");
            this.register_signupBtn.Name = "register_signupBtn";
            this.register_signupBtn.Click += new System.EventHandler(this.register_signupBtn_Click);
            // 
            // reigster_singinBtn
            // 
            resources.ApplyResources(this.reigster_singinBtn, "reigster_singinBtn");
            this.reigster_singinBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.reigster_singinBtn.Name = "reigster_singinBtn";
            this.reigster_singinBtn.Click += new System.EventHandler(this.reigster_singinBtn_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.reigster_singinBtn);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Name = "label8";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Name = "label10";
            // 
            // RegisterForm
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.register_adminId);
            this.Controls.Add(this.register_username);
            this.Controls.Add(this.register_email);
            this.Controls.Add(this.register_pass);
            this.Controls.Add(this.register_cpass);
            this.Controls.Add(this.register_showpassword);
            this.Controls.Add(this.register_signupBtn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
    }
}
