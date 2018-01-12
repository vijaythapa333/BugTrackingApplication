using Bug_Tracking_Application.Properties;
using Bug_Tracking_Application.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bug_Tracking_Application
{
    public partial class BTA_HomePage : Form
    {
        public BTA_HomePage()
        {
            InitializeComponent();
        }

        private void button_reportBug_Click(object sender, EventArgs e)
        {
            //BTA_BugReport reportbug = new BTA_BugReport();
            //reportbug.Show();
            //this.Hide();
        }

        private void button_resolveBug_Click(object sender, EventArgs e)
        {

        }

        private void button_profileSetting_Click(object sender, EventArgs e)
        {

        }

        private void button_Help_Click(object sender, EventArgs e)
        {

        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            
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
            this.Close();
        }

        private void pictureBox_BugReport_MouseHover(object sender, EventArgs e)
        {
            pictureBox_BugReport.Image = Resources.bugreport2;
        }

        private void pictureBox_BugReport_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_BugReport.Image = Resources.bugreport;
        }

        private void pictureBox_BugReport_Click(object sender, EventArgs e)
        {
            BTA_BugReport bugreport = new BTA_BugReport();
            bugreport.Show();
        }

        private void pictureBox_Tasks_MouseHover(object sender, EventArgs e)
        {
            pictureBox_Tasks.Image = Resources.tasks2;
        }

        private void pictureBox_Tasks_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_Tasks.Image = Resources.tasks;
        }

        private void pictureBox_Tasks_Click(object sender, EventArgs e)
        {
            BTA_Task taskform = new BTA_Task();
            taskform.Show();
            this.Hide();
        }

        private void pictureBox_Close_MouseHover(object sender, EventArgs e)
        {
            pictureBox_Close.Image = Resources.close;
        }

        private void pictureBox_Close_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_Close.Image = Resources.Closeb;
        }

        private void pictureBox_Close_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Close();
        }

        private void BTA_HomePage_Load(object sender, EventArgs e)
        {
            label_WElcome.Text = "Welcome "+Form1.Username;
        }
    }
}
