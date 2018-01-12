using Bug_Tracking_Application.DataAccessLayer;
using Bug_Tracking_Application.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bug_Tracking_Application.Classes;

namespace Bug_Tracking_Application
{
    public partial class Form1 : Form
    {
        //Making Static Class to Send Value from this form to another form
        public static string Username;
        public static string UserType;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Login Button Clicked");
            //First Checking the Login Authentication and Open the respective Section
            //i.e. Admin Panel or User (Tester/Debugger) Panel
            //Getting Login Credentials of the User
            string username = textBox_username.Text.Trim();
            string password = textBox_password.Text.Trim();
            //Decrypt Password Here
            password = EncryptDecrypt.Encrypt(password);
            string usertype = comboBox_usertype.Text.Trim();
            
            switch(usertype)
            {
                case "Admin":
                    {
                        //Check user credentials For Admin Login
                        LoginDAL l = new LoginDAL();
                        l.Login(username, password, usertype);
                        bool isLogin = l.Login(username,password,usertype);
                        if(isLogin==true)
                        {
                            //Login Successfull
                            MessageBox.Show("Login Successfull. Welcome " + username + " to the admin panel.");
                            //Open Admin Panel
                            //SEnding username and usertype to another form
                            Username = username;
                            UserType = usertype;
                            BTA_Admin_Panel admin = new BTA_Admin_Panel();
                            admin.Show();
                            this.Hide();

                        }
                        else
                        {
                            //Login Failed
                            MessageBox.Show("Invalid login credentials. Try Again.");
                        }

                        
                    }
                    break;
                case "Tester":
                    {
                        //Check user credentials For Admin Login
                        LoginDAL l = new LoginDAL();
                        l.Login(username, password, usertype);
                        bool isLogin = l.Login(username, password, usertype);
                        if (isLogin == true)
                        {
                            //Login Successfull
                            MessageBox.Show("Login Successfull. Welcome " + username + " to the admin panel.");
                            //Open tester Admin Panel
                            //SEnding username and usertype to another form
                            Username = username;
                            UserType = usertype;
                            BTA_HomePage testerHome = new BTA_HomePage();
                            testerHome.Show();
                            this.Hide();

                        }
                        else
                        {
                            //Login Failed
                            MessageBox.Show("Invalid login credentials. Try Again.");
                        }
                    }
                    break;
                case "Debugger":
                    {
                        //Check user credentials For Admin Login
                        LoginDAL l = new LoginDAL();
                        l.Login(username, password, usertype);
                        bool isLogin = l.Login(username, password, usertype);
                        if (isLogin == true)
                        {
                            //Login Successfull
                            MessageBox.Show("Login Successfull. Welcome " + username + " to the admin panel.");
                            //SEnding username and usertype to another form
                            Username = username;
                            UserType = usertype;
                            //Open tester Admin Panel
                            BTA_HomePage testerHome = new BTA_HomePage();
                            testerHome.Show();
                            this.Hide();

                        }
                        else
                        {
                            //Login Failed
                            MessageBox.Show("Invalid login credentials. Try Again.");
                        }
                    }
                    break;
                default:
                    {
                        MessageBox.Show("Invalid Login Credentials.");
                    }
                    break;
            }

            
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            //Clear all the Input fields for new login credentials
            textBox_username.Clear();
            textBox_password.Clear();
            comboBox_usertype.Text = "User Type";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox_Close_MouseHover(object sender, EventArgs e)
        {
            pictureBox_Close.Image = Resources.close;
        }

        private void pictureBox_Close_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_Close.Image = Resources.Closeb;
        }

        private void textBox_username_Click(object sender, EventArgs e)
        {
            textBox_username.Text = "";
        }

        private void textBox_username_Leave(object sender, EventArgs e)
        {
            if(textBox_username.Text.Trim()=="")
            {
                textBox_username.Text = "USERNAME";
            }
        }

        private void textBox_password_Click(object sender, EventArgs e)
        {
            textBox_password.Text = "";
        }

        private void textBox_password_Leave(object sender, EventArgs e)
        {
            if(textBox_password.Text.Trim()=="")
            {
                textBox_password.Text = "Password";
            }
        }
    }
}
