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
    public partial class BTA_BugAssign : Form
    {
        BugDAL bugDal = new BugDAL();
        ProjectDAL projectDal = new ProjectDAL();
        UserDAL userDal = new UserDAL();
        public BTA_BugAssign()
        {
            InitializeComponent();
        }

        private void BTA_BugAssign_Load(object sender, EventArgs e)
        {
            //Loading User Fullname Value from dataTable to User ComboBox
            DataTable dtUser = userDal.Select_User();
            comboBox_AssignTo.DataSource = dtUser;
            comboBox_AssignTo.DisplayMember = "FullName";
            comboBox_AssignTo.ValueMember = "UserID";

            //Loading Bug to the Combobox from dataTable in Bug ComboBox
            //DataTable dtBug = bugDal.Select_Bug();
            //comboBox_Bug.DataSource = dtBug;
            //comboBox_Bug.DisplayMember = "BugTitle";
            //comboBox_Bug.ValueMember = "BugID";

            //Loading Projecct to the ComboBox from dataTable in Project  ComboBox
            //DataTable dtProject = projectDal.Select_Project();
            //comboBox_Project.DataSource = dtProject;
            //comboBox_Project.DisplayMember = "ProjectTitle";
            //comboBox_Project.ValueMember = "ProjectID";

            //Loading User into Data Grid View
            BugDAL bugs = new BugDAL();
            DataTable dt = bugs.Select_Bug();
            dataGridView_Bugs.DataSource = dt;

        }
        

        private void button_Assign_Click(object sender, EventArgs e)
        {
            //Get Values from UI
            int BugID = 0;
            if(textBox_bugID.Text.Trim()!="")
            {
                BugID = int.Parse(textBox_bugID.Text.Trim());
            }
            int AssignTo = 0;
            if(comboBox_AssignTo.Text.Trim()!="")
            {
                AssignTo = int.Parse(comboBox_AssignTo.SelectedValue.ToString());
            }

            //Declare and Assign/Initialize Object
            //Here Left Side Variable from User Class
            //And Right Side From Above Variables
            Bugs bg = new Bugs();
            bg.BugID = BugID;
            bg.AssignTo = AssignTo;

            //Create Object for Bug DAL
            BugDAL dal = new BugDAL();

            bool success = dal.Assign_Bug(bg);
            if(success==true)
            {
                //Bug Assigned
                MessageBox.Show("Bug Successfully Assigned to the User. Thank You.");
                //CLose This Form
                //this.Close();
            }
            else
            {
                //FAiled to Assign Bug
                MessageBox.Show("Failed to Assign Bug. Please Try Again.");
            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            //CLose This Form
            this.Close();
        }

        private void dataGridView_Bugs_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Step 0: Find the index of the row clicked
            int index = e.RowIndex;

            //Step 1: Get Values from Row Clicked
            string BugID = dataGridView_Bugs.Rows[index].Cells[0].Value.ToString();
            string BugTitle = dataGridView_Bugs.Rows[index].Cells[2].Value.ToString();
            string ProjectTitle = dataGridView_Bugs.Rows[index].Cells[1].Value.ToString();

            //Step2: Write Values to the textbox to assign user
            textBox_bugID.Text = BugID;
            textBox_BugTitle.Text = BugTitle;
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
            this.Hide();
        }
    }
}
