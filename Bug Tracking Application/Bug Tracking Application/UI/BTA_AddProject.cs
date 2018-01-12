using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
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
    public partial class BTA_AddProject : Form
    {
        public BTA_AddProject()
        {
            InitializeComponent();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            //Getting Values from Project UI
            int ProjectID = 0;
            if(textBox_ProjectID.Text.Trim()!="")
            {
                ProjectID = int.Parse(textBox_ProjectID.Text.Trim());
            }
            string ProjectTitle = textBox_projecttitle.Text.Trim();
            string ProjectDescription = textBox_projectdescription.Text.Trim();
            string ProjectUrl = textBox_projecturl.Text.Trim();
            string StartDate = dateTimePicker_startdate.Text.Trim();
            string EndDate = dateTimePicker_enddate.Text.Trim();

            //Declare and Assign/Initialize Object
            //Here Left Side Variable from User Class
            //And Right Side From Above Variables

            Project P = new Project();
            P.ProjectID = ProjectID;
            P.ProjectTitle = ProjectTitle;
            P.ProjectDescription = ProjectDescription;
            P.ProjectUrl = ProjectUrl;
            P.StartDate = StartDate;
            P.EndDate = EndDate;

            //Create dal for Project DAL
            ProjectDAL dal = new ProjectDAL();

            //Identify the Case for Insert or Update
            if(P.ProjectID==0)
            {
                //Case for Insert
                bool success = dal.Insert_Project(P);
                if(success==true)
                {
                    //Insert Successfull
                    MessageBox.Show("New Project Successfully Added. Thank You.");
                    //Refreshing the Data Grid View After Successfully inserting Project
                    DataTable dt = dal.Select_Project();
                    dataGridView_Projects.DataSource = dt;

                    //Clearing all the text box for new add
                    textBox_ProjectID.Clear();
                    textBox_projecttitle.Clear();
                    textBox_projectdescription.Clear();
                    textBox_projectdescription.Clear();
                    textBox_projecturl.Clear();
                    dateTimePicker_startdate.Text = "";
                    dateTimePicker_enddate.Text = "";
                }
                else
                {
                    //Insert Failed
                    MessageBox.Show("Failed to Add New Project. Please Try Again.");
                }
            }
            else
            {
                //Case for Update
                bool success = dal.Update_Project(P);
                if(success==true)
                {
                    //Success Message
                    MessageBox.Show("Project Successfully Updated. Thank You.");
                    //After Successfully updating, Refresh the data table
                    DataTable dt = dal.Select_Project();
                    dataGridView_Projects.DataSource = dt;
                }
                else
                {
                    //FAiled Message
                    MessageBox.Show("Failed to update Project. Try Again.");
                }
            }
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            textBox_ProjectID.Clear();
            textBox_projecttitle.Clear();
            textBox_projectdescription.Clear();
            textBox_projecturl.Clear();
            dateTimePicker_startdate.Text = "";
            dateTimePicker_enddate.Text = "";
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BTA_Admin_Panel admin = new BTA_Admin_Panel();
            admin.Show();
            this.Hide();
        }

        private void BTA_AddProject_Load(object sender, EventArgs e)
        {
            //Loading Projects into the DAta grid view
            ProjectDAL dal = new ProjectDAL();
            DataTable dt = dal.Select_Project();
            dataGridView_Projects.DataSource = dt;

        }

        private void dataGridView_Projects_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Step 0: Getting the row id of the clicked ros
            int index = e.RowIndex;

            //Step 1: Getting Values from Clicked rows
            string ProjectID = dataGridView_Projects.Rows[index].Cells[0].Value.ToString();
            string ProjectDescription = dataGridView_Projects.Rows[index].Cells[1].Value.ToString();
            string StartDate = dataGridView_Projects.Rows[index].Cells[2].Value.ToString();
            string EndDate = dataGridView_Projects.Rows[index].Cells[3].Value.ToString();
            string ProjectUrl = dataGridView_Projects.Rows[index].Cells[5].Value.ToString();
            string ProjectTitle = dataGridView_Projects.Rows[index].Cells[6].Value.ToString();

            //Step 2: Insert these values to textbox of the form
            textBox_ProjectID.Text = ProjectID;
            textBox_projecttitle.Text = ProjectTitle;
            textBox_projectdescription.Text = ProjectDescription;
            textBox_projecturl.Text = ProjectUrl;
            dateTimePicker_startdate.Text = StartDate;
            dateTimePicker_enddate.Text = EndDate;

        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            //Getting Values FROM UI
            int ProjectID = 0;

            if(textBox_ProjectID.Text.Trim()!="")
            {
                ProjectID = int.Parse(textBox_ProjectID.Text.Trim());
            }

            //Declare and initialize/Assign Object For Project Class
            Project P = new Project();
            P.ProjectID = ProjectID;

            //Create Object For Project DAL
            ProjectDAL dal = new ProjectDAL();
            bool success = dal.Delete_Project(P);
            if(success==true)
            {
                //Success Message
                MessageBox.Show("Project SUccessfully Deleted. Thank You.");
                //Refreshing Data Grid View After Successfully deleting Project
                DataTable dt = dal.Select_Project();
                dataGridView_Projects.DataSource = dt;

                //Now Clearing all the text fields
                textBox_ProjectID.Clear();
                textBox_projecttitle.Clear();
                textBox_projectdescription.Clear();
                dateTimePicker_startdate.Text = "";
                dateTimePicker_enddate.Text = "";
            }
            else
            {
                //FAiled Message
                MessageBox.Show("Failed to delte Project. Try Again.");
            }
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
            BTA_Help help = new BTA_Help();
            help.Show();
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
