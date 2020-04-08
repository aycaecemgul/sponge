namespace WindowsFormsApp1
{
    partial class AdminLogin
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
            this.btAdminLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginAdminName = new System.Windows.Forms.TextBox();
            this.loginAdminPword = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btAdminLogin
            // 
            this.btAdminLogin.BackColor = System.Drawing.Color.Transparent;
            this.btAdminLogin.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.simple_cartoon_wood_material_design_png_55318_crop;
            this.btAdminLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btAdminLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAdminLogin.FlatAppearance.BorderSize = 0;
            this.btAdminLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btAdminLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btAdminLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdminLogin.Font = new System.Drawing.Font("Cooper Black", 18F);
            this.btAdminLogin.ForeColor = System.Drawing.Color.Gold;
            this.btAdminLogin.Location = new System.Drawing.Point(279, 496);
            this.btAdminLogin.Name = "btAdminLogin";
            this.btAdminLogin.Size = new System.Drawing.Size(320, 100);
            this.btAdminLogin.TabIndex = 0;
            this.btAdminLogin.Text = "Login";
            this.btAdminLogin.UseVisualStyleBackColor = false;
            this.btAdminLogin.Click += new System.EventHandler(this.btAdminLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 25F);
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(190, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(501, 49);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome Back,Master.";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.BackColor = System.Drawing.Color.Transparent;
            this.lbl.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.lbl.ForeColor = System.Drawing.Color.Gold;
            this.lbl.Location = new System.Drawing.Point(144, 306);
            this.lbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(118, 23);
            this.lbl.TabIndex = 2;
            this.lbl.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(145, 393);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            // 
            // loginAdminName
            // 
            this.loginAdminName.Location = new System.Drawing.Point(301, 307);
            this.loginAdminName.Name = "loginAdminName";
            this.loginAdminName.Size = new System.Drawing.Size(267, 22);
            this.loginAdminName.TabIndex = 4;
            // 
            // loginAdminPword
            // 
            this.loginAdminPword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginAdminPword.Location = new System.Drawing.Point(301, 393);
            this.loginAdminPword.Name = "loginAdminPword";
            this.loginAdminPword.Size = new System.Drawing.Size(267, 22);
            this.loginAdminPword.TabIndex = 5;
            this.loginAdminPword.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.admin1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(364, 117);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 139);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.wp2891267;
            this.ClientSize = new System.Drawing.Size(882, 653);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.loginAdminPword);
            this.Controls.Add(this.loginAdminName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btAdminLogin);
            this.Name = "AdminLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAdminLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox loginAdminName;
        private System.Windows.Forms.TextBox loginAdminPword;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}