using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace WindowsFormsApp1
{
    
    public partial class sendMail : Form
    {
        int adminPassword;
        public sendMail()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Form1 newMainPage = new Form1();
            newMainPage.Show();
            this.Hide();
        }

        private void btn_sendMail_Click(object sender, EventArgs e)
        {
            string feedback = context.Text;
            string mail = mailBox.Text;
            string adminMail = "aycaecemgul@gmail.com";

            var client = new SmtpClient("smtp.gmail.com", 587);
            client.UseDefaultCredentials = false;
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential(adminMail, adminPassword);

            MailMessage newMail = new MailMessage();
            newMail.From = new MailAddress("aycaecemgul@gmail.com", "New feedback.");
            newMail.To.Add(adminMail);
            newMail.Subject = mail + " sent you a feedback!";
            newMail.Body = feedback; 

            client.Send(newMail);

            MessageBox.Show("Sign up successful.Mail sent.", "Welcome!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Profile newProfile = new Profile();
            this.Close();

        }
    }
}
