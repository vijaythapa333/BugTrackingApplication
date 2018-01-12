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
using Bug_Tracking_Application.DataAccessLayer;
using Bug_Tracking_Application.Properties;
using Bug_Tracking_Application.UI;

namespace Bug_Tracking_Application
{
    public partial class BTA_AddUser : Form
    {
        public BTA_AddUser()
        {
            InitializeComponent();
        }

        private void BTA_AddUser_Load(object sender, EventArgs e)
        {
            //Loading Users into the Data Grid View
            UserDAL dal = new UserDAL();
            DataTable dt = dal.Select_User();
            dataGridView_userlist.DataSource = dt;
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Opening Admin Panel
            BTA_Admin_Panel admin = new BTA_Admin_Panel();
            admin.Show();
            this.Hide();
        }

        private void listUserToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Opening List Project Form
            BTA_ProjectList projects = new BTA_ProjectList();
            projects.Show();
            this.Hide();
        }

        private void addProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Opening ADD project Form
            BTA_AddProject addproject = new BTA_AddProject();
            addproject.Show();
            this.Hide();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            //Getting Values from UI
            int UserID = 0;
            //Get UserID from textbox if the row is selected
            if(textBox_UserID.Text.Trim()!="")
            {
                UserID = int.Parse(textBox_UserID.Text.Trim());
            }
            string FullName = textBox_fullname.Text.Trim();
            string Email = textBox_email.Text.Trim();
            string Username = textBox_username.Text.Trim();
            string Password = textBox_password.Text.Trim();
            //Encrypt Password
            Password = EncryptDecrypt.Encrypt(Password);
            string Contact = textBox_contact.Text.Trim();
            string Address = textBox_address.Text.Trim();
            string UserType = comboBox_usertype.Text.Trim();
            string Gender = comboBox_Gender.Text.Trim();
            

            //Declare and Assign/Initialize Object
            //Here Left Side Variable from User Class
            //And Right Side From Above Variables
            User U = new User();
            U.UserID = UserID;
            U.FullName = FullName;
            U.Email = Email;
            U.Username = Username;
            U.Password = Password;
            U.Contact = Contact;
            U.Address = Address;
            U.UserType = UserType;
            U.Gender = Gender;
            //how to add radio gender

            //create Object for UserDAL
            UserDAL dal = new UserDAL();

            //Identify the Case for Insert or Update
            if(U.UserID==0)
            {
                //Case For Insert
                bool success = dal.Insert_User(U);
                if(success==true)
                {
                    MessageBox.Show("New User Successfully Added. Thank You.");
                    //AfterSaving Successfully, redirecting form to User List
                }
                else
                {
                    MessageBox.Show("Failed to Insert User. Try Again");
                }
            }
            else
            {
                //Case For Update
                bool success = dal.Update_User(U);
                if(success==true)
                {
                    //Show Messsage to display success message
                    MessageBox.Show("User Successfully updated. Thank You.");
                    //After Successfully Updating User, Refreshing the Datagrid view
                    DataTable dt = dal.Select_User();
                    dataGridView_userlist.DataSource = dt;
                }
                else
                {
                    //Show Error Message
                    MessageBox.Show("Failed tp Update User. Try Again.");
                }
            }
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            //Clear all the input field
            textBox_fullname.Text = "";
            textBox_email.Text = "";
            textBox_username.Text = "";
            textBox_password.Text = "";
            textBox_contact.Text = "";
            textBox_address.Text = "";
            comboBox_usertype.Text = "";
            comboBox_Gender.Text = "";

        }

        private void dataGridView_userlist_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Step 0: Find index of Row Clicked
            int index = e.RowIndex; //index = no. of rows starting from 0

            //Step 1: Get Values from Row Clicked
            string UserID = dataGridView_userlist.Rows[index].Cells[0].Value.ToString();
            string FullName = dataGridView_userlist.Rows[index].Cells[1].Value.ToString();
            string Email = dataGridView_userlist.Rows[index].Cells[2].Value.ToString();
            string Username = dataGridView_userlist.Rows[index].Cells[3].Value.ToString();
            string Password = dataGridView_userlist.Rows[index].Cells[4].Value.ToString();
            string Gender = dataGridView_userlist.Rows[index].Cells[5].Value.ToString();
            string Contact = dataGridView_userlist.Rows[index].Cells[6].Value.ToString();
            string Address = dataGridView_userlist.Rows[index].Cells[7].Value.ToString();
            string UserType = dataGridView_userlist.Rows[index].Cells[8].Value.ToString();

            //Write these Values to TextBox to Update
            textBox_UserID.Text = UserID;
            textBox_fullname.Text = FullName;
            textBox_username.Text = Username;
            textBox_email.Text = Email;
            textBox_password.Text = Password;
            comboBox_Gender.Text = Gender;
            textBox_contact.Text = Contact;
            textBox_address.Text = Address;
            comboBox_usertype.Text = UserType;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            //
            //MessageBox.Show("Delete Button CLicked");
            //Get Values FROm UI
            int UserID = 0;
            if(textBox_UserID.Text.Trim()!="")
            {
                UserID = int.Parse(textBox_UserID.Text.Trim());
            }
            //Declare and initialiaze/Assign Object for User Class
            User U = new User();
            U.UserID = UserID;

            //Create Object For UserDAL
            UserDAL dal = new UserDAL();
            bool success = dal.Delete_User(U);
            if(success==true)
            {
                //Display Success Message
                MessageBox.Show("User Successfully Deleted. Thank You.");
                //After Successfully Deleting User, Refreshing the Data Grid View
                DataTable dt = dal.Select_User();
                dataGridView_userlist.DataSource = dt;
                //Refreshing Form too.
                textBox_UserID.Clear();
                textBox_fullname.Clear();
                textBox_email.Clear();
                textBox_username.Clear();
                textBox_password.Clear();
                comboBox_Gender.Text = "";
                textBox_contact.Clear();
                textBox_address.Clear();
                comboBox_usertype.Text = "User Type";
            }
            else
            {
                //Display Error Message
                MessageBox.Show("Failed to Delete User. Try Again.");
            }
        }

        private void pictureBox_CLose_MouseHover(object sender, EventArgs e)
        {
            pictureBox_CLose.Image = Resources.close;
        }

        private void pictureBox_CLose_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_CLose.Image = Resources.Closeb;
        }

        private void pictureBox_CLose_Click(object sender, EventArgs e)
        {
            BTA_Admin_Panel admin = new BTA_Admin_Panel();
            admin.Show();
            this.Close();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BTA_AddUser users = new BTA_AddUser();
            users.Show();
            this.Hide();
        }

        private void projectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BTA_AddProject projects = new BTA_AddProject();
            projects.Show();
            this.Hide();
        }

        private void bugsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BTA_BugReport bugs = new BTA_BugReport();
            bugs.Show();
            this.Hide();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BTA_Help helpform = new BTA_Help();
            helpform.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BTA_Admin_Panel admin = new BTA_Admin_Panel();
            admin.Show();
            this.Hide();
        }
    }
}
