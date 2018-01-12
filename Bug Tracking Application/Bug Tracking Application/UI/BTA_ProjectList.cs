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
    public partial class BTA_ProjectList : Form
    {
        public BTA_ProjectList()
        {
            InitializeComponent();
        }

        private void button_addproject_Click(object sender, EventArgs e)
        {
            //Opening Add Project Form
            BTA_AddProject addproject = new BTA_AddProject();
            addproject.Show();
            this.Hide();
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

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Opening Add User Form
            BTA_AddUser adduser = new BTA_AddUser();
            adduser.Show();
            this.Hide();
        }

        private void listProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Listing Projects from Project List Form
            BTA_ProjectList projects = new BTA_ProjectList();
            projects.Show();
            this.Hide();
        }

        private void addProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Opening Add Project Form
            BTA_AddProject addproject = new BTA_AddProject();
            addproject.Show();
            this.Hide();
        }
    }
}
