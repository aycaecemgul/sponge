using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int countdown = 0;
        db_spongeMailEntities1 db = new db_spongeMailEntities1();

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        //USER LOGIN
        private void btnUserLogin_Click(object sender, EventArgs e)
        {
            List<Users> userList = db.Users.ToList();
            List<string> usernameList = (from u in userList select u.userName).ToList();
            
            
            string s = "WRONG USERNAME OR PASSWORD. YOU CAN TRY {0} MORE TIME";
            string tb_username = txtUserName.Text;
            string tb_password = tbPassword.Text;
            while (countdown < 10)
            {
                //(from p in userList where p.userName.Equals(tb_username) select p.pword).ToString())
                if (userList.Any(u => u.userName.Equals(tb_username) && u.pword.Equals(tb_password)))
                {
                    MessageBox.Show("WELCOME BACK!", "Online", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    break;
                }
                else
                {   
                    MessageBox.Show(string.Format(s,9-countdown),"Declined",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    countdown++;
                    break;
                }

            }
            if (countdown == 10)
            {
                MessageBox.Show("WASTED", "Wasted", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            Signup signUP = new Signup();
            signUP.Show();
            this.Hide();
        }

        private void adminbutton_Click(object sender, EventArgs e)
        {
            AdminLogin newAL = new AdminLogin();
            newAL.Show();
            this.Hide();
            
        }

        private void btn_mailUs_Click(object sender, EventArgs e)
        {
            sendMail newsendMail = new sendMail();
            newsendMail.Show();
            this.Hide();
        }
    }
}
