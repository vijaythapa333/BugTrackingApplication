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

namespace Bug_Tracking_Application.UI
{
    public partial class BTA_Task : Form
    {
        //private readonly object dataGridView_Bugs;

        public BTA_Task()
        {
            InitializeComponent();
        }

        private void BTA_Task_Load(object sender, EventArgs e)
        {
            string Username = Form1.Username;
            //Loading Tasks into the data grid view
            BugDAL dal = new BugDAL();
            DataTable dt = dal.Select_Task();
            dataGridView_TaskBug.DataSource = dt;
        }

        private void dataGridView_TaskBug_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //STep 0: Find index of the row clickeds
            int index = e.RowIndex;

            //Step 1: Get Values from the Row Clicked
            string BugID = dataGridView_TaskBug.Rows[index].Cells[0].Value.ToString();
            string ProjectTitle = dataGridView_TaskBug.Rows[index].Cells[1].Value.ToString();
            string BugTitle = dataGridView_TaskBug.Rows[index].Cells[2].Value.ToString();
            string BugDescription = dataGridView_TaskBug.Rows[index].Cells[3].Value.ToString();
            string Severity = dataGridView_TaskBug.Rows[index].Cells[4].Value.ToString();
            string Status = dataGridView_TaskBug.Rows[index].Cells[5].Value.ToString();
            string ReportDate = dataGridView_TaskBug.Rows[index].Cells[6].Value.ToString();
            string BugImage = dataGridView_TaskBug.Rows[index].Cells[7].Value.ToString();
            string AssignTo = dataGridView_TaskBug.Rows[index].Cells[8].Value.ToString();
            string SubmitCode = dataGridView_TaskBug.Rows[index].Cells[9].Value.ToString();
            string ImagePath = dataGridView_TaskBug.Rows[index].Cells[10].Value.ToString();

            //Step 2: Writing these values to the Textbox
            textBox_BugID.Text = BugID;
            textBox_Project.Text = ProjectTitle;
            textBox_bugtitle.Text = BugTitle;
            textBox_bugdescription.Text = BugDescription;
            textBox_submitCode.Text = SubmitCode;
            comboBox_status.Text = Status;
            dateTimePicker_reportdate.Text = ReportDate;
            comboBox_severity.Text = Severity;
            if (ImagePath != "[Image Path]")
            {
                pictureBox_BugImage.Image = new Bitmap(ImagePath);
                //MessageBox.Show("Image Available"+ImagePath);
            }
            else
            {
                pictureBox_BugImage.Image = Resources.Np_Image;
            }
            label_ImagePath.Text = ImagePath;
            //pictureBox_view.Image = new Bitmap(imagename);
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
            BTA_HomePage home = new BTA_HomePage();
            home.Show();
            this.Close();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            //Get Values From UI
            int BugID = 0;
            if (textBox_BugID.Text.Trim() != "")
            {
                BugID = int.Parse(textBox_BugID.Text.Trim());
            }
            int ProjectTitle = int.Parse(textBox_Project.Text.Trim());
            string BugTitle = textBox_bugtitle.Text.Trim();
            string BugDescription = textBox_bugdescription.Text.Trim();
            string SubmitCode = textBox_submitCode.Text.Trim();
            //int AssignTo = int.Parse(comboBox_assignTo.SelectedValue.ToString());
            string Status = comboBox_status.Text.Trim();
            string ReportDate = dateTimePicker_reportdate.Text.Trim();
            string Severity = comboBox_severity.Text.Trim();
            //Waiting for Image
            string ImagePath = label_ImagePath.Text.Trim();
            //Declare and Assign/Initialize Object
            //Here Left Side Variable from User Class
            //And Right Side From Above Variables
            Bugs B = new Bugs();
            B.BugID = BugID;
            B.ProjectTitle = ProjectTitle;
            B.BugTitle = BugTitle;
            B.BugDescription = BugDescription;
            B.SubmitCode = SubmitCode;
            //B.AssignTo = AssignTo;
            B.Status = Status;
            B.ReportDate = ReportDate;
            B.Severity = Severity;
            B.ImagePath = ImagePath;

            //Create Object for Bug DAL
            BugDAL dal = new BugDAL();
            if(B.BugID>0)
            {
                //Udate the task
                //Case For Update
                bool success = dal.Update_Bug(B);
                if (success == true)
                {
                    //Update SUccess Message
                    MessageBox.Show("Task Successfully Updated. Thank You.");
                    //Updating Data Grid View After SUccess
                    DataTable dt = dal.Select_Task();
                    dataGridView_TaskBug.DataSource = dt;
                }
                else
                {
                    //Update Failed Message
                    MessageBox.Show("Failed to Update Bug Report. Please Try Again.");
                }
            }
            else
            {
                MessageBox.Show("Please Select Task to Update the Data. Thank You.");
            }
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BTA_Admin_Panel admin = new BTA_Admin_Panel();
            admin.Show();
            this.Hide();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BTA_BugReport bugs = new BTA_BugReport();
            bugs.Show();
            this.Hide();
        }

        private void projectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BTA_Task tasks = new BTA_Task();
            tasks.Show();
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
            BTA_HomePage admin = new BTA_HomePage();
            admin.Show();
            this.Hide();
        }
    }
}
