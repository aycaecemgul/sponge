using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AdminLogin : Form
    {
        db_spongeMailEntities1 db = new db_spongeMailEntities1();

        public AdminLogin()
        {
            InitializeComponent();
        }

        private void btAdminLogin_Click(object sender, EventArgs e)
        {
            List<Administrator> ad = db.Administrator.ToList();
            string adminName = (from n in ad select n.adminName).ToString();
            string adminPword = (from z in ad select z.pword).ToString();
            string loginName = loginAdminName.Text;
            string loginPword = loginAdminPword.Text;
            if (loginName.Equals("ayca") && loginPword.Equals("0000"))
            {
                MessageBox.Show("WELCOME BACK MASTER!", "Online", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            else
            {
                MessageBox.Show("YOU SHOULDN'T HAVE COME HERE.","Staff Only!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Hide();
                Form1 newform1 = new Form1();
                newform1.Show();
            }
        }
    }
}
