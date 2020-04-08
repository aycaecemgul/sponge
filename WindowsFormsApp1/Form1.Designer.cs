namespace WindowsFormsApp1
{
    partial class Form1
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
            this.lblUserName = new System.Windows.Forms.Label();
            this.btnUserLogin = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.adminbutton = new System.Windows.Forms.Button();
            this.btn_mailUs = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.ForeColor = System.Drawing.Color.Gold;
            this.lblUserName.Location = new System.Drawing.Point(105, 264);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(118, 23);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "Username:";
            // 
            // btnUserLogin
            // 
            this.btnUserLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnUserLogin.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.simple_cartoon_wood_material_design_png_55318_crop1;
            this.btnUserLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUserLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUserLogin.FlatAppearance.BorderSize = 0;
            this.btnUserLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnUserLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnUserLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserLogin.Font = new System.Drawing.Font("Cooper Black", 18F);
            this.btnUserLogin.ForeColor = System.Drawing.Color.Gold;
            this.btnUserLogin.Location = new System.Drawing.Point(314, 419);
            this.btnUserLogin.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnUserLogin.Name = "btnUserLogin";
            this.btnUserLogin.Size = new System.Drawing.Size(263, 127);
            this.btnUserLogin.TabIndex = 1;
            this.btnUserLogin.Text = "Sign IN";
            this.btnUserLogin.UseVisualStyleBackColor = false;
            this.btnUserLogin.Click += new System.EventHandler(this.btnUserLogin_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(258, 264);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtUserName.MaxLength = 10;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(434, 30);
            this.txtUserName.TabIndex = 2;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Password.ForeColor = System.Drawing.Color.Gold;
            this.lbl_Password.Location = new System.Drawing.Point(106, 353);
            this.lbl_Password.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(117, 23);
            this.lbl_Password.TabIndex = 3;
            this.lbl_Password.Text = "Password:";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(258, 346);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbPassword.MaxLength = 10;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(434, 30);
            this.tbPassword.TabIndex = 4;
            this.tbPassword.UseSystemPasswordChar = true;
            this.tbPassword.TextChanged += new System.EventHandler(this.tbPassword_TextChanged);
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.Transparent;
            this.btnSignUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignUp.FlatAppearance.BorderSize = 0;
            this.btnSignUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSignUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.ForeColor = System.Drawing.Color.Gold;
            this.btnSignUp.Image = global::WindowsFormsApp1.Properties.Resources.simple_cartoon_wood_material_design_png_55318_crop1;
            this.btnSignUp.Location = new System.Drawing.Point(314, 540);
            this.btnSignUp.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(261, 100);
            this.btnSignUp.TabIndex = 5;
            this.btnSignUp.Text = "Don\'t have an account..?";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources._3;
            this.pictureBox1.Location = new System.Drawing.Point(156, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(593, 166);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // adminbutton
            // 
            this.adminbutton.BackColor = System.Drawing.Color.Transparent;
            this.adminbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.adminbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.adminbutton.FlatAppearance.BorderSize = 0;
            this.adminbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.adminbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.adminbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminbutton.ForeColor = System.Drawing.Color.Navy;
            this.adminbutton.Image = global::WindowsFormsApp1.Properties.Resources.admin;
            this.adminbutton.Location = new System.Drawing.Point(755, 540);
            this.adminbutton.Name = "adminbutton";
            this.adminbutton.Size = new System.Drawing.Size(102, 91);
            this.adminbutton.TabIndex = 9;
            this.adminbutton.Text = "Admin";
            this.adminbutton.UseVisualStyleBackColor = false;
            this.adminbutton.Click += new System.EventHandler(this.adminbutton_Click);
            // 
            // btn_mailUs
            // 
            this.btn_mailUs.BackColor = System.Drawing.Color.Transparent;
            this.btn_mailUs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_mailUs.Cursor = System.Windows.Forms.Cursors.Help;
            this.btn_mailUs.FlatAppearance.BorderSize = 0;
            this.btn_mailUs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_mailUs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_mailUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mailUs.ForeColor = System.Drawing.Color.Navy;
            this.btn_mailUs.Image = global::WindowsFormsApp1.Properties.Resources.admin;
            this.btn_mailUs.Location = new System.Drawing.Point(30, 540);
            this.btn_mailUs.Name = "btn_mailUs";
            this.btn_mailUs.Size = new System.Drawing.Size(102, 91);
            this.btn_mailUs.TabIndex = 10;
            this.btn_mailUs.Text = "Mail us";
            this.btn_mailUs.UseVisualStyleBackColor = false;
            this.btn_mailUs.Click += new System.EventHandler(this.btn_mailUs_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.wp2891267;
            this.ClientSize = new System.Drawing.Size(882, 653);
            this.Controls.Add(this.btn_mailUs);
            this.Controls.Add(this.adminbutton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.btnUserLogin);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.btnSignUp);
            this.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign in";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button btnUserLogin;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button adminbutton;
        private System.Windows.Forms.Button btn_mailUs;
    }
}

