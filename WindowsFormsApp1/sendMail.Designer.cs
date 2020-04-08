namespace WindowsFormsApp1
{
    partial class sendMail
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
            this.btn_sendMail = new System.Windows.Forms.Button();
            this.mailBox = new System.Windows.Forms.TextBox();
            this.context = new System.Windows.Forms.RichTextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.header = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_sendMail
            // 
            this.btn_sendMail.BackColor = System.Drawing.Color.Transparent;
            this.btn_sendMail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sendMail.FlatAppearance.BorderSize = 0;
            this.btn_sendMail.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_sendMail.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_sendMail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_sendMail.Font = new System.Drawing.Font("Cooper Black", 13F);
            this.btn_sendMail.ForeColor = System.Drawing.Color.Brown;
            this.btn_sendMail.Image = global::WindowsFormsApp1.Properties.Resources.simple_cartoon_wood_material_design_png_55318_crop;
            this.btn_sendMail.Location = new System.Drawing.Point(127, 526);
            this.btn_sendMail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_sendMail.Name = "btn_sendMail";
            this.btn_sendMail.Size = new System.Drawing.Size(290, 95);
            this.btn_sendMail.TabIndex = 9;
            this.btn_sendMail.Text = "Send Mail";
            this.btn_sendMail.UseVisualStyleBackColor = false;
            this.btn_sendMail.Click += new System.EventHandler(this.btn_sendMail_Click);
            // 
            // mailBox
            // 
            this.mailBox.Location = new System.Drawing.Point(127, 94);
            this.mailBox.Multiline = true;
            this.mailBox.Name = "mailBox";
            this.mailBox.Size = new System.Drawing.Size(603, 35);
            this.mailBox.TabIndex = 10;
            this.mailBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // context
            // 
            this.context.Location = new System.Drawing.Point(127, 156);
            this.context.Name = "context";
            this.context.Size = new System.Drawing.Size(603, 338);
            this.context.TabIndex = 11;
            this.context.Text = "";
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Transparent;
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cancel.Font = new System.Drawing.Font("Cooper Black", 13F);
            this.btn_cancel.ForeColor = System.Drawing.Color.Brown;
            this.btn_cancel.Image = global::WindowsFormsApp1.Properties.Resources.simple_cartoon_wood_material_design_png_55318_crop;
            this.btn_cancel.Location = new System.Drawing.Point(440, 526);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(290, 95);
            this.btn_cancel.TabIndex = 12;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.BackColor = System.Drawing.Color.Transparent;
            this.header.Font = new System.Drawing.Font("Cooper Black", 13F);
            this.header.ForeColor = System.Drawing.Color.Coral;
            this.header.Location = new System.Drawing.Point(34, 42);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(827, 25);
            this.header.TabIndex = 13;
            this.header.Text = "We appreciate the feedback! Mail us any questions/suggestions you have!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 13F);
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(34, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Mail:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 13F);
            this.label2.ForeColor = System.Drawing.Color.Coral;
            this.label2.Location = new System.Drawing.Point(31, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Your";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 13F);
            this.label3.ForeColor = System.Drawing.Color.Coral;
            this.label3.Location = new System.Drawing.Point(14, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Message:";
            // 
            // sendMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.wp2891267;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(882, 653);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.header);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.context);
            this.Controls.Add(this.mailBox);
            this.Controls.Add(this.btn_sendMail);
            this.Name = "sendMail";
            this.Text = "sendMail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_sendMail;
        private System.Windows.Forms.TextBox mailBox;
        private System.Windows.Forms.RichTextBox context;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}