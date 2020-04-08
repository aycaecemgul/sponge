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
using System.Net.Mail;
using System.Net;


namespace WindowsFormsApp1
{
    public partial class Signup : Form
    {
        int adminPassword; 
        db_spongeMailEntities1 db = new db_spongeMailEntities1();

        public Signup()
        {
            InitializeComponent();



        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            //ENTITY LISTS
            List<Users> userList = db.Users.ToList();
            List<City> cityList = db.City.ToList();

            //ATTRIBUTE LISTS
            var mailList = (from m in userList select m.mail).ToList();
            var userNameList = (from n in userList select n.userName).ToList();
            var cityIDList = (from c in cityList select c.ID);

            //INPUT
            string signUp_mail = signUp_tb_mail.Text;
            string signUp_username = signUp_tb_uname.Text;
            string signUp_Pword = tbSignUpPword.Text;
            string signUp_PwordA = tbSignUpPwordA.Text;
            //DateTimePickerFormat signUp_Bday = dateTimePicker1;
            //string signUp_City = tbSignUpCity.Text;
            //int signUp_CityID = Convert.ToInt32(from i in cityList where i.cityName==signUp_City select i.ID);
            DateTime now = DateTime.Now;
            //DateTime bday = dateTimePicker1.Value.ToShortDateString();

            if (!mailList.Contains(signUp_mail) && !userNameList.Contains(signUp_username))
            {
                if (signUp_Pword == signUp_PwordA)
                {

                    Users newUser = new Users()
                    {
                        userName = signUp_username,
                        pword = signUp_Pword,
                        mail = signUp_mail,
                        cityID = 1,
                        accountCreationDate = now,
                        avatar = "jelly_fish.png"
                    };

                    try
                    {
                        db.Users.Add(newUser);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Oops!", "Sign up failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    try
                    {
                        var fromAddress = new MailAddress("aycaecemgul@gmail.com", "Admin");
                        var toAddress = new MailAddress(signUp_mail, "Receiver");
                        const string fromPassword = adminPassword;
                        SmtpClient sc = new SmtpClient {
                            Port = 587,
                            Host = "smtp.gmail.com",
                            EnableSsl = true,
                            DeliveryMethod = SmtpDeliveryMethod.Network,
                            UseDefaultCredentials = false,
                            Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                        };
                        

                        MailMessage mail = new MailMessage();

                        using (var message = new MailMessage(fromAddress, toAddress)
                        {
                            Subject = "Sponge",
                            Body = "Welcome to the world of Sponge "+ signUp_username+"!"
                        }
                        )
                        {
                            sc.Send(message);
                        }
                        MessageBox.Show("Sign up successful.Mail sent.", "Welcome!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    catch (Exception xx)
                    {
                        MessageBox.Show("Oops!", "MAIL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    this.Hide();
                    Profile newProfile = new Profile();
                    //newProfile.Show();
                    this.Close();
                    db.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Your passwords does not match,try again...", "Oops! ", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("There is already an account with that mail.", "And i ou-", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }

        }
    }
}