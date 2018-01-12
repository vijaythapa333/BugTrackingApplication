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
using Bug_Tracking_Application.UI;
using Bug_Tracking_Application.Properties;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.Configuration;

namespace Bug_Tracking_Application
{
    public partial class BTA_BugReport : Form
    {
        static string myconnstr = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
        BugDAL bugDal = new BugDAL();
        ProjectDAL projectDal = new ProjectDAL();
        UserDAL userDal = new UserDAL();
        public static string Bug_Keywords;

        public BTA_BugReport()
        {
            InitializeComponent();
        }

        private void BTA_BugReport_Load(object sender, EventArgs e)
        {
            //For Changing Header of the form
            string type = Form1.UserType;
            if(type=="Admin")
            {
                label_ManageBugs.Text = "Manage Bugs";
            }
            else
            {
                label_ManageBugs.Text = "Report Bug";
            }
            //Loading Bugs into the data grid view
            BugDAL dal = new BugDAL();
            DataTable dt = dal.Select_Bug();
            dataGridView_Bugs.DataSource = dt;
            
            //Loading ProjectTitle Value from dataTable to Project ComboBox
            DataTable dtProject = projectDal.Select_Project();
            comboBoxProject.DataSource = dtProject;
            comboBoxProject.DisplayMember = "ProjectTitle";
            comboBoxProject.ValueMember = "ProjectID";

            //Loading User Fullname Value from dataTable to User ComboBox
            //DataTable dtUser = userDal.Select_User();
            //comboBox_assignTo.DataSource = dtUser;
            //comboBox_assignTo.DisplayMember = "FullName";
            //comboBox_assignTo.ValueMember = "UserID";
        }

        private void button_addbug_Click(object sender, EventArgs e)
        {
            //Get Values From UI
            int BugID = 0;
            if(textBox_BugID.Text.Trim()!="")
            {
                BugID = int.Parse(textBox_BugID.Text.Trim());
            }
            int ProjectTitle = int.Parse(comboBoxProject.SelectedValue.ToString());
            string BugTitle = textBox_bugtitle.Text.Trim();
            string BugDescription = textBox_bugdescription.Text.Trim();
            string SubmitCode = richTextBox_submitCode.Text.Trim();
            //int AssignTo = int.Parse(comboBox_assignTo.SelectedValue.ToString());
            string Status = comboBox_status.Text.Trim();
            string ReportDate = dateTimePicker_reportdate.Text.Trim();
            string Severity = comboBox_severity.Text.Trim();
            //Waiting for Image
            string ImagePath = label_path.Text.Trim();
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

            //Now Identifiying the case for Insert or Update
            if(B.BugID==0)
            {
                //CAse for Insert
                bool success = dal.Insert_Bug(B);
                if(success==true)
                {
                    //Insert SUccessfull Message
                    MessageBox.Show("Bug Successfully Reported. Thank You.");
                    //Refresh Data Grid View
                    DataTable dt = dal.Select_Bug();
                    dataGridView_Bugs.DataSource = dt;

                    //Clear all the Input fields
                    textBox_BugID.Clear();
                    comboBoxProject.Text = "";
                    textBox_bugtitle.Clear();
                    textBox_bugdescription.Clear();
                    richTextBox_submitCode.Clear();
                    //comboBox_assignTo.Text = "";
                    comboBox_status.Text = "";
                    dateTimePicker_reportdate.Text = "";
                    comboBox_severity.Text = "";
                    label_path.Text = "[Image Path]";
                }
                else
                {
                    //Insert FAiled Message
                    MessageBox.Show("Failed to report bug. Please Try Again.");
                }
            }
            else
            {
                //Check if the user if admin or tester or debugger
                string type = Form1.UserType;
                if(type=="Admin")
                {
                    //Case For Update
                    bool success = dal.Update_Bug(B);
                    if (success == true)
                    {
                        //Update SUccess Message
                        MessageBox.Show("Bug Report Successfully Updated. Thank You.");
                        //Updating Data Grid View After SUccess
                        DataTable dt = dal.Select_Bug();
                        dataGridView_Bugs.DataSource = dt;
                    }
                    else
                    {
                        //Update Failed Message
                        MessageBox.Show("Failed to Update Bug Report. Please Try Again.");
                    }
                }
                else
                {
                    MessageBox.Show("Sorry! You are not authorized to modify the data.");
                }
                
            }
        }

        private void dataGridView_Bugs_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //STep 0: Find index of the row clickeds
            int index = e.RowIndex;

            //Step 1: Get Values from the Row Clicked
            string BugID = dataGridView_Bugs.Rows[index].Cells[0].Value.ToString();
            string ProjectTitle = dataGridView_Bugs.Rows[index].Cells[1].Value.ToString();
            string BugTitle = dataGridView_Bugs.Rows[index].Cells[2].Value.ToString();
            string BugDescription = dataGridView_Bugs.Rows[index].Cells[3].Value.ToString();
            string Severity = dataGridView_Bugs.Rows[index].Cells[4].Value.ToString();
            string Status = dataGridView_Bugs.Rows[index].Cells[5].Value.ToString();
            string ReportDate = dataGridView_Bugs.Rows[index].Cells[6].Value.ToString();
            string BugImage = dataGridView_Bugs.Rows[index].Cells[7].Value.ToString();
            string AssignTo = dataGridView_Bugs.Rows[index].Cells[8].Value.ToString();
            string SubmitCode = dataGridView_Bugs.Rows[index].Cells[9].Value.ToString();
            string ImagePath = dataGridView_Bugs.Rows[index].Cells[10].Value.ToString();

            //Step 2: Writing these values to the Textbox
            textBox_BugID.Text = BugID;
            comboBoxProject.Text = ProjectTitle;
            textBox_bugtitle.Text = BugTitle;
            textBox_bugdescription.Text = BugDescription;
            richTextBox_submitCode.Text = SubmitCode;
            comboBox_status.Text = Status;
            dateTimePicker_reportdate.Text = ReportDate;
            comboBox_severity.Text = Severity;
            if(ImagePath!="[Image Path]")
            {
                pictureBox_BugImage.Image = new Bitmap(ImagePath);
                //MessageBox.Show("Image Available"+ImagePath);
            }
            else
            {
                pictureBox_BugImage.Image = Resources.Np_Image;
            }
            label_path.Text = ImagePath;
            //pictureBox_view.Image = new Bitmap(imagename);
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            //Clear all the text fields for new bug report
            textBox_BugID.Clear();
            comboBoxProject.Text = "";
            textBox_bugtitle.Clear();
            textBox_bugdescription.Clear();
            richTextBox_submitCode.Clear();
            comboBox_status.Text = "";
            dateTimePicker_reportdate.Text = "";
            comboBox_severity.Text = "";
            label_path.Text = "[Image Path]";
            pictureBox_BugImage.Image = Resources.Np_Image;
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            //Checking if the user is admin or tester or debugger
            string type = Form1.UserType;
            if(type=="Admin")
            {
                //Getting Values from UI
                int BugId = 0;
                if (textBox_BugID.Text.Trim() != "")
                {
                    BugId = int.Parse(textBox_BugID.Text.Trim());
                }
                //For Checking the value
                //MessageBox.Show("Selected User is "+BugId);
                //Declare and Initialize/Assign Object for BUgs CLass
                Bugs B = new Bugs();
                B.BugID = BugId;

                //Create Object for Bug Dal
                BugDAL dal = new BugDAL();
                bool success = dal.Delete_Bug(B);
                if (success == true)
                {
                    //Delete Success Message
                    MessageBox.Show("Bug Deleted Successfully. Thank You.");
                    //Refresh Data Grid View
                    DataTable dt = dal.Select_Bug();
                    dataGridView_Bugs.DataSource = dt;
                }
                else
                {
                    //Delete Failed Message
                    MessageBox.Show("Failed to deelte bug. Please Try Again.");
                }
            }
            else
            {
                MessageBox.Show("Sorry! You are not allowed to remove any data.");
            }
            
        }

        private void textBox_Search_Click(object sender, EventArgs e)
        {
            textBox_Search.Text = "";
        }

        private void textBox_Search_Leave(object sender, EventArgs e)
        {
            if(textBox_Search.Text.Trim()=="")
            {
                textBox_Search.Text = "SEARCH";
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
            
            this.Close();
        }

        
        private void button_Search_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Clicked"+textBox_Search.Text.Trim());
            if(textBox_Search.Text.Trim()!="")
            {
                //B//MessageBox.Show(textBox_Search.Text.Trim());
                string BugKey = textBox_Search.Text.Trim();
                SqlConnection conn = new SqlConnection(myconnstr);
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tbl_Bug WHERE BugTitle LIKE '%" + BugKey + "%' OR BugDescription LIKE '%" + BugKey + "%'", conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView_Bugs.DataSource = dt;
            }
        }

        private void button_browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog browse = new OpenFileDialog();
            browse.Filter = "Images|*.png;*.jpg;*.jpeg;*.gif";
            if (browse.ShowDialog() == DialogResult.OK)
            {
                label_path.Text = browse.FileName;
                pictureBox_BugImage.Image = new Bitmap(browse.FileName);
            }
        }

        //Syntax to highlight
        public Regex keyWords = new Regex("abstract|as|base|bool|break|byte|case|catch|char|checked|class|const|continue|decimal|default|delegate|do|double|else|enum|event|explicit|extern|false|finally|fixed|float|for|" +
        "foreach|goto|if|implicit|in|int|interface|internal|is|lock|long|namespace|new|null|object|operator|out|override|params|private|protected|public|readonly|ref|return|sbyte|sealed|short|sizeof|stackalloc|static|" + 
            "string|struct|switch|this|throw|true|try|typeof|uint|ulong|unchecked|unsafe|ushort|using|virtual|volatile|void|while|");
        //For Syntax Color Changing
        [DllImport("user32.dll")] // import lockwindow to remove flashing
        public static extern bool LockWindowUpdate(IntPtr hWndLock);

        private void richTextBox_submitCode_TextChanged(object sender, EventArgs e)
        {
            try
            {
                LockWindowUpdate(richTextBox_submitCode.Handle);
                        //Highlight every found word from keyWords.
                        //Get the last cursor position in the richTextBox1.
                        int selPos = richTextBox_submitCode.SelectionStart;
                //For each match from the regex, highlight the word.
                foreach (Match keyWordMatch in keyWords.Matches(richTextBox_submitCode.Text))
                {
                    richTextBox_submitCode.Select(keyWordMatch.Index, keyWordMatch.Length);
                    richTextBox_submitCode.SelectionColor = Color.Blue;
                    richTextBox_submitCode.SelectionStart = selPos;
                    richTextBox_submitCode.SelectionColor = Color.Black;
                }
            }
            catch(Exception ex)
            {

            }
            finally { LockWindowUpdate(IntPtr.Zero); }

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string type = Form1.UserType;
            if (type == "Admin")
            {
                BTA_Admin_Panel admin = new BTA_Admin_Panel();
                admin.Show();
                this.Hide();
            }
            else
            {
                BTA_HomePage home = new BTA_HomePage();
                home.Show();
                this.Hide();
            }
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
            this.Hide();
        }

        private void textBox_Search_TextChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(textBox_Search.Text.Trim());
            string BugKey = textBox_Search.Text.Trim();
            SqlConnection conn = new SqlConnection(myconnstr);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tbl_Bug WHERE BugTitle LIKE '%"+BugKey+"%' OR BugDescription LIKE '%"+BugKey+"%'",conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView_Bugs.DataSource = dt;
        }

        private void button_push_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://vijaythapa333@bitbucket.org/vijaythapa333/bug-tracking-application.git");
        }

        //private void button_bugAssign_Click(object sender, EventArgs e)
        //{
        //    ////Load Bug Assign Form
        //    //BTA_BugAssign assign = new BTA_BugAssign();
        //    //assign.Show();
        //}
    }
}
