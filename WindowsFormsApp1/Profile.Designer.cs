namespace WindowsFormsApp1
{
    partial class Profile
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
            this.avatarPicture = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.profileEditButton = new System.Windows.Forms.Button();
            this.profileLogOut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.profileCity = new System.Windows.Forms.Label();
            this.profileBday = new System.Windows.Forms.Label();
            this.profileLikes = new System.Windows.Forms.Button();
            this.profileDislikes = new System.Windows.Forms.Button();
            this.profileHobbies = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bt_search = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // avatarPicture
            // 
            this.avatarPicture.Location = new System.Drawing.Point(50, 149);
            this.avatarPicture.Name = "avatarPicture";
            this.avatarPicture.Size = new System.Drawing.Size(170, 185);
            this.avatarPicture.TabIndex = 0;
            this.avatarPicture.TabStop = false;
            // 
            // profileEditButton
            // 
            this.profileEditButton.ForeColor = System.Drawing.Color.Aqua;
            this.profileEditButton.Location = new System.Drawing.Point(752, 12);
            this.profileEditButton.Name = "profileEditButton";
            this.profileEditButton.Size = new System.Drawing.Size(118, 36);
            this.profileEditButton.TabIndex = 1;
            this.profileEditButton.Text = "Edit Profile";
            this.profileEditButton.UseVisualStyleBackColor = true;
            // 
            // profileLogOut
            // 
            this.profileLogOut.ForeColor = System.Drawing.Color.Aqua;
            this.profileLogOut.Location = new System.Drawing.Point(752, 63);
            this.profileLogOut.Name = "profileLogOut";
            this.profileLogOut.Size = new System.Drawing.Size(118, 34);
            this.profileLogOut.TabIndex = 2;
            this.profileLogOut.Text = "Log out";
            this.profileLogOut.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 30F);
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(407, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 57);
            this.label1.TabIndex = 3;
            this.label1.Text = "nickname";
            // 
            // profileCity
            // 
            this.profileCity.AutoSize = true;
            this.profileCity.BackColor = System.Drawing.Color.Transparent;
            this.profileCity.Font = new System.Drawing.Font("Cooper Black", 15F);
            this.profileCity.ForeColor = System.Drawing.Color.Gold;
            this.profileCity.Location = new System.Drawing.Point(45, 466);
            this.profileCity.Name = "profileCity";
            this.profileCity.Size = new System.Drawing.Size(62, 29);
            this.profileCity.TabIndex = 7;
            this.profileCity.Text = "city";
            // 
            // profileBday
            // 
            this.profileBday.AutoSize = true;
            this.profileBday.BackColor = System.Drawing.Color.Transparent;
            this.profileBday.Font = new System.Drawing.Font("Cooper Black", 15F);
            this.profileBday.ForeColor = System.Drawing.Color.Gold;
            this.profileBday.Location = new System.Drawing.Point(45, 408);
            this.profileBday.Name = "profileBday";
            this.profileBday.Size = new System.Drawing.Size(125, 29);
            this.profileBday.TabIndex = 8;
            this.profileBday.Text = "birthday";
            // 
            // profileLikes
            // 
            this.profileLikes.Location = new System.Drawing.Point(294, 196);
            this.profileLikes.Name = "profileLikes";
            this.profileLikes.Size = new System.Drawing.Size(540, 107);
            this.profileLikes.TabIndex = 9;
            this.profileLikes.Text = "likes";
            this.profileLikes.UseVisualStyleBackColor = true;
            // 
            // profileDislikes
            // 
            this.profileDislikes.Location = new System.Drawing.Point(294, 336);
            this.profileDislikes.Name = "profileDislikes";
            this.profileDislikes.Size = new System.Drawing.Size(540, 101);
            this.profileDislikes.TabIndex = 10;
            this.profileDislikes.Text = "dislikes";
            this.profileDislikes.UseVisualStyleBackColor = true;
            // 
            // profileHobbies
            // 
            this.profileHobbies.Location = new System.Drawing.Point(294, 482);
            this.profileHobbies.Name = "profileHobbies";
            this.profileHobbies.Size = new System.Drawing.Size(540, 101);
            this.profileHobbies.TabIndex = 11;
            this.profileHobbies.Text = "hobbies";
            this.profileHobbies.UseVisualStyleBackColor = true;
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.BackColor = System.Drawing.Color.Transparent;
            this.username.Font = new System.Drawing.Font("Cooper Black", 15F);
            this.username.ForeColor = System.Drawing.Color.Gold;
            this.username.Location = new System.Drawing.Point(45, 353);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(142, 29);
            this.username.TabIndex = 12;
            this.username.Text = "user name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(354, 44);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(185, 28);
            this.textBox1.TabIndex = 13;
            // 
            // bt_search
            // 
            this.bt_search.Location = new System.Drawing.Point(571, 49);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(75, 23);
            this.bt_search.TabIndex = 14;
            this.bt_search.Text = "Search";
            this.bt_search.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources._3;
            this.pictureBox1.Location = new System.Drawing.Point(35, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 147);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.wp2891267;
            this.ClientSize = new System.Drawing.Size(882, 653);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bt_search);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.username);
            this.Controls.Add(this.profileHobbies);
            this.Controls.Add(this.profileDislikes);
            this.Controls.Add(this.profileLikes);
            this.Controls.Add(this.profileBday);
            this.Controls.Add(this.profileCity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.profileLogOut);
            this.Controls.Add(this.profileEditButton);
            this.Controls.Add(this.avatarPicture);
            this.Name = "Profile";
            this.Text = "Profile";
            ((System.ComponentModel.ISupportInitialize)(this.avatarPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox avatarPicture;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button profileEditButton;
        private System.Windows.Forms.Button profileLogOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label profileCity;
        private System.Windows.Forms.Label profileBday;
        private System.Windows.Forms.Button profileLikes;
        private System.Windows.Forms.Button profileDislikes;
        private System.Windows.Forms.Button profileHobbies;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bt_search;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}