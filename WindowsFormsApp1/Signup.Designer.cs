namespace WindowsFormsApp1
{
    partial class Signup
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label lblSignUpBdate;
            this.lblSignUpMail = new System.Windows.Forms.Label();
            this.lblSignUpUname = new System.Windows.Forms.Label();
            this.lblSignUpPword = new System.Windows.Forms.Label();
            this.lblSignUpA = new System.Windows.Forms.Label();
            this.signUp_tb_mail = new System.Windows.Forms.TextBox();
            this.signUp_tb_uname = new System.Windows.Forms.TextBox();
            this.tbSignUpPword = new System.Windows.Forms.TextBox();
            this.tbSignUpPwordA = new System.Windows.Forms.TextBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.lblSignUpCity = new System.Windows.Forms.Label();
            this.tbSignUpCity = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            lblSignUpBdate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSignUpBdate
            // 
            lblSignUpBdate.AutoSize = true;
            lblSignUpBdate.BackColor = System.Drawing.Color.Transparent;
            lblSignUpBdate.Font = new System.Drawing.Font("Cooper Black", 12F);
            lblSignUpBdate.ForeColor = System.Drawing.Color.Tomato;
            lblSignUpBdate.Location = new System.Drawing.Point(168, 370);
            lblSignUpBdate.Name = "lblSignUpBdate";
            lblSignUpBdate.Size = new System.Drawing.Size(107, 23);
            lblSignUpBdate.TabIndex = 12;
            lblSignUpBdate.Text = "Birthday:";
            // 
            // lblSignUpMail
            // 
            this.lblSignUpMail.AutoSize = true;
            this.lblSignUpMail.BackColor = System.Drawing.Color.Transparent;
            this.lblSignUpMail.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.lblSignUpMail.ForeColor = System.Drawing.Color.Tomato;
            this.lblSignUpMail.Location = new System.Drawing.Point(201, 165);
            this.lblSignUpMail.Name = "lblSignUpMail";
            this.lblSignUpMail.Size = new System.Drawing.Size(59, 23);
            this.lblSignUpMail.TabIndex = 0;
            this.lblSignUpMail.Text = "Mail:";
            // 
            // lblSignUpUname
            // 
            this.lblSignUpUname.AutoSize = true;
            this.lblSignUpUname.BackColor = System.Drawing.Color.Transparent;
            this.lblSignUpUname.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.lblSignUpUname.ForeColor = System.Drawing.Color.Tomato;
            this.lblSignUpUname.Location = new System.Drawing.Point(171, 100);
            this.lblSignUpUname.Name = "lblSignUpUname";
            this.lblSignUpUname.Size = new System.Drawing.Size(118, 23);
            this.lblSignUpUname.TabIndex = 1;
            this.lblSignUpUname.Text = "Username:";
            // 
            // lblSignUpPword
            // 
            this.lblSignUpPword.AutoSize = true;
            this.lblSignUpPword.BackColor = System.Drawing.Color.Transparent;
            this.lblSignUpPword.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.lblSignUpPword.ForeColor = System.Drawing.Color.Tomato;
            this.lblSignUpPword.Location = new System.Drawing.Point(157, 228);
            this.lblSignUpPword.Name = "lblSignUpPword";
            this.lblSignUpPword.Size = new System.Drawing.Size(117, 23);
            this.lblSignUpPword.TabIndex = 2;
            this.lblSignUpPword.Text = "Password:";
            // 
            // lblSignUpA
            // 
            this.lblSignUpA.AutoSize = true;
            this.lblSignUpA.BackColor = System.Drawing.Color.Transparent;
            this.lblSignUpA.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.lblSignUpA.ForeColor = System.Drawing.Color.Tomato;
            this.lblSignUpA.Location = new System.Drawing.Point(116, 297);
            this.lblSignUpA.Name = "lblSignUpA";
            this.lblSignUpA.Size = new System.Drawing.Size(202, 23);
            this.lblSignUpA.TabIndex = 3;
            this.lblSignUpA.Text = "Password (Again):";
            // 
            // signUp_tb_mail
            // 
            this.signUp_tb_mail.Font = new System.Drawing.Font("Cooper Black", 10F);
            this.signUp_tb_mail.Location = new System.Drawing.Point(455, 160);
            this.signUp_tb_mail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.signUp_tb_mail.Name = "signUp_tb_mail";
            this.signUp_tb_mail.Size = new System.Drawing.Size(300, 27);
            this.signUp_tb_mail.TabIndex = 4;
            // 
            // signUp_tb_uname
            // 
            this.signUp_tb_uname.Font = new System.Drawing.Font("Cooper Black", 10F);
            this.signUp_tb_uname.Location = new System.Drawing.Point(455, 95);
            this.signUp_tb_uname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.signUp_tb_uname.Name = "signUp_tb_uname";
            this.signUp_tb_uname.Size = new System.Drawing.Size(300, 27);
            this.signUp_tb_uname.TabIndex = 5;
            // 
            // tbSignUpPword
            // 
            this.tbSignUpPword.Font = new System.Drawing.Font("Cooper Black", 10F);
            this.tbSignUpPword.Location = new System.Drawing.Point(455, 223);
            this.tbSignUpPword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSignUpPword.Name = "tbSignUpPword";
            this.tbSignUpPword.Size = new System.Drawing.Size(300, 27);
            this.tbSignUpPword.TabIndex = 6;
            // 
            // tbSignUpPwordA
            // 
            this.tbSignUpPwordA.BackColor = System.Drawing.SystemColors.Window;
            this.tbSignUpPwordA.Font = new System.Drawing.Font("Cooper Black", 10F);
            this.tbSignUpPwordA.Location = new System.Drawing.Point(455, 294);
            this.tbSignUpPwordA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSignUpPwordA.Name = "tbSignUpPwordA";
            this.tbSignUpPwordA.Size = new System.Drawing.Size(300, 27);
            this.tbSignUpPwordA.TabIndex = 7;
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.Transparent;
            this.btnSignUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSignUp.FlatAppearance.BorderSize = 0;
            this.btnSignUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSignUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSignUp.Font = new System.Drawing.Font("Cooper Black", 13F);
            this.btnSignUp.ForeColor = System.Drawing.Color.Brown;
            this.btnSignUp.Image = global::WindowsFormsApp1.Properties.Resources.simple_cartoon_wood_material_design_png_55318_crop;
            this.btnSignUp.Location = new System.Drawing.Point(414, 632);
            this.btnSignUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(367, 105);
            this.btnSignUp.TabIndex = 8;
            this.btnSignUp.Text = "Sign UP!";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.DarkOrange;
            this.checkBox1.Location = new System.Drawing.Point(455, 505);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(289, 24);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "I\'ve read terms and conditions";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.BackColor = System.Drawing.Color.Transparent;
            this.checkBox2.Font = new System.Drawing.Font("Cooper Black", 10.2F);
            this.checkBox2.ForeColor = System.Drawing.Color.DarkOrange;
            this.checkBox2.Location = new System.Drawing.Point(504, 554);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(152, 24);
            this.checkBox2.TabIndex = 10;
            this.checkBox2.Text = "Send me mails";
            this.checkBox2.UseVisualStyleBackColor = false;
            // 
            // lblSignUpCity
            // 
            this.lblSignUpCity.AutoSize = true;
            this.lblSignUpCity.BackColor = System.Drawing.Color.Transparent;
            this.lblSignUpCity.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.lblSignUpCity.ForeColor = System.Drawing.Color.Tomato;
            this.lblSignUpCity.Location = new System.Drawing.Point(188, 446);
            this.lblSignUpCity.Name = "lblSignUpCity";
            this.lblSignUpCity.Size = new System.Drawing.Size(58, 23);
            this.lblSignUpCity.TabIndex = 11;
            this.lblSignUpCity.Text = "City:";
            // 
            // tbSignUpCity
            // 
            this.tbSignUpCity.Font = new System.Drawing.Font("Cooper Black", 10F);
            this.tbSignUpCity.Location = new System.Drawing.Point(455, 441);
            this.tbSignUpCity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSignUpCity.Name = "tbSignUpCity";
            this.tbSignUpCity.Size = new System.Drawing.Size(300, 27);
            this.tbSignUpCity.TabIndex = 14;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.DarkOrange;
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.DarkOrange;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.DarkOrange;
            this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.Color.DarkOrange;
            this.dateTimePicker1.Font = new System.Drawing.Font("Cooper Black", 10.2F);
            this.dateTimePicker1.Location = new System.Drawing.Point(455, 366);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(300, 27);
            this.dateTimePicker1.TabIndex = 15;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 20F);
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(324, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(525, 39);
            this.label1.TabIndex = 23;
            this.label1.Text = "Let\'s Be Best Friends Forever!";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.wp2891267;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1179, 814);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSignUpPwordA);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.tbSignUpCity);
            this.Controls.Add(lblSignUpBdate);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.tbSignUpPword);
            this.Controls.Add(this.signUp_tb_uname);
            this.Controls.Add(this.signUp_tb_mail);
            this.Controls.Add(this.lblSignUpPword);
            this.Controls.Add(this.lblSignUpUname);
            this.Controls.Add(this.lblSignUpMail);
            this.Controls.Add(this.lblSignUpA);
            this.Controls.Add(this.lblSignUpCity);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Signup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign Up Now";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSignUpMail;
        private System.Windows.Forms.Label lblSignUpUname;
        private System.Windows.Forms.Label lblSignUpPword;
        private System.Windows.Forms.Label lblSignUpA;
        private System.Windows.Forms.TextBox signUp_tb_mail;
        private System.Windows.Forms.TextBox signUp_tb_uname;
        private System.Windows.Forms.TextBox tbSignUpPword;
        private System.Windows.Forms.TextBox tbSignUpPwordA;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label lblSignUpCity;
        private System.Windows.Forms.TextBox tbSignUpCity;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}