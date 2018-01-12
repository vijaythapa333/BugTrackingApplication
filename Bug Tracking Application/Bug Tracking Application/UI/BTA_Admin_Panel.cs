using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bug_Tracking_Application;
using Bug_Tracking_Application.Properties;
using Bug_Tracking_Application.UI;

namespace Bug_Tracking_Application
{
    public partial class BTA_Admin_Panel : Form
    {
        public object References { get; private set; }

        public BTA_Admin_Panel()
        {
            InitializeComponent();
        }

        private void BTA_Admin_Panel_Load(object sender, EventArgs e)
        {
            label_user.Text = "Welcome "+Form1.Username;
        }

        private void button_usermanager_Click(object sender, EventArgs e)
        {
            
        }

        private void button_projectmanager_Click(object sender, EventArgs e)
        {
            
        }

        private void button_bugsmanager_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button_logout_Click(object sender, EventArgs e)
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

        private void pictureBox_userManager_MouseHover(object sender, EventArgs e)
        {
            pictureBox_userManager.Image = Resources.Blue2;
        }

        private void pictureBox_userManager_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_userManager.Image = Resources.Blue1;
        }

        private void pictureBox_userManager_Click(object sender, EventArgs e)
        {
            BTA_AddUser users = new BTA_AddUser();
            users.Show();
            this.Close();
        }

        private void pictureBox_ProjectManager_MouseHover(object sender, EventArgs e)
        {
            pictureBox_ProjectManager.Image = Resources.Projects2;
        }

        private void pictureBox_ProjectManager_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_ProjectManager.Image = Resources.Projects;
        }

        private void pictureBox_ProjectManager_Click(object sender, EventArgs e)
        {
            BTA_AddProject projects = new BTA_AddProject();
            projects.Show();
            this.Hide();
        }

        private void pictureBox_bugAssign_MouseHover(object sender, EventArgs e)
        {
            pictureBox_bugAssign.Image = Resources.assign2;
        }

        private void pictureBox_bugAssign_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_bugAssign.Image = Resources.assign1;
        }

        private void pictureBox_bugAssign_Click(object sender, EventArgs e)
        {
            BTA_BugAssign assign = new BTA_BugAssign();
            assign.Show();
        }

        private void pictureBox_Logout_MouseHover(object sender, EventArgs e)
        {
            pictureBox_Logout.Image = Resources.logout2;
        }

        private void pictureBox_Logout_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_Logout.Image = Resources.logout1;
        }

        private void pictureBox_Logout_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Close();
        }

        private void pictureBox_bugManager_MouseHover(object sender, EventArgs e)
        {
            pictureBox_bugManager.Image = Resources.Bugs2;
        }

        private void pictureBox_bugManager_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_bugManager.Image = Resources.Bugs;
        }

        private void pictureBox_bugManager_Click(object sender, EventArgs e)
        {
            BTA_BugReport bugs = new BTA_BugReport();
            bugs.Show();
        }

        private void pictureBox_Help_MouseHover(object sender, EventArgs e)
        {
            pictureBox_Help.Image = Resources.Help2;
        }

        private void pictureBox_Help_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_Help.Image = Resources.Help;
        }

        private void pictureBox_Help_Click(object sender, EventArgs e)
        {
            BTA_Help help = new BTA_Help();
            help.Show();
            this.Hide();
            
        }
    }
}
