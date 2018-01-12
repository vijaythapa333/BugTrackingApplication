using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Bug_Tracking_Application.Classes;

namespace Bug_Tracking_Application.DataAccessLayer
{
    public class BugDAL
    {
        //Database Connection Here
        static string myconnstr = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
        //Get Username from Login FOrm (Form1)
        static string Username = Form1.Username;
        //Get Bug Keywords o searcch for the bugs
        static string Bug_Keywords = BTA_BugReport.Bug_Keywords;

        //SELECT INSERT UPDATE DELETE
        public DataTable Select_Bug()
        {
            //STEP 1: Create SQL Connection
            SqlConnection conn = new SqlConnection(myconnstr);

            //Create a Datatable to hold the records from database
            DataTable dt = new DataTable();
            try
            {
                //Step 2: Writing T-SQL for Selecting Bug
                string sql = "SELECT * FROM tbl_Bug";

                //Step 3: Creating SQL Command using sql and conn
                SqlCommand cmd = new SqlCommand(sql,conn);

                //Step 4: Create SQL Data Adapter using cmd to get records 
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //Step 5:Open Connection
                conn.Open();

                //Step 6: Use Adapter to Fill dt
                adapter.Fill(dt);
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);

            }
            finally
            {
                //Step : Connection Close
                conn.Close();
            }

            return dt;
        }
        //SELECT TASKS
        public DataTable Select_Task()
        {
            //STEP 1: Create SQL Connection
            SqlConnection conn = new SqlConnection(myconnstr);

            //Create a Datatable to hold the records from database
            DataTable dt = new DataTable();
            try
            {
                
                //Step 2: Writing T-SQL for Selecting Bug
                string sql = "SELECT * FROM tbl_Bug WHERE AssignTo=(SELECT USERID FROM tbl_User WHERE Username='"+Username+"')";

                //Step 3: Creating SQL Command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Step 4: Create SQL Data Adapter using cmd to get records 
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //Step 5:Open Connection
                conn.Open();

                //Step 6: Use Adapter to Fill dt
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);

            }
            finally
            {
                //Step : Connection Close
                conn.Close();
            }

            return dt;
        }
        //SEarch Bugs
        public DataTable Search_Bug()
        {
            ////Step 1: Create SQL Connection
            SqlConnection conn = new SqlConnection(myconnstr);

            ////Create a Datatable to hold the records from database
            DataTable dt = new DataTable();

            try
            {
                
                //Step 2: Writing T-SQL for Selecting Bug
                string sql = "SELECT * FROM tbl_Bug WHERE BugTitle LIKE '%"+Bug_Keywords+"%' OR BugDescription LIKE '%"+Bug_Keywords+"%'";

                //Step 3: Creating SQL Command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Step 4: Create SQL Data Adapter using cmd to get records 
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //Step 5:Open Connection
                conn.Open();

                //Step 6: Use Adapter to Fill dt
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);

            }
            finally
            {
                //Step : Connection Close
                conn.Close();
            }
            return dt;
        }

        //Insert Function to Add Bug
        public bool Insert_Bug(Bugs b)
        {
            //create the return value and set it false by default
            bool isSuccess = false;

            //Step 1: Create Sql Connection
            SqlConnection conn = new SqlConnection(myconnstr);

            try
            {
                //Step 2: Writing T-SQL for Inserting Bug Data
                string sql = "INSERT INTO tbl_Bug (ProjectTitle, BugTitle, BugDescription, Severity, Status, ReportDate, SubmitCode, ImagePath) VALUES (@ProjectTitle, @BugTitle,@BugDescription, @Severity, @Status, @ReportDate, @SubmitCode, @ImagePath)";

                //Step 3: Create SQL Command using the sql and conn
                SqlCommand cmd = new SqlCommand(sql,conn);

                //Step 4: Pass Valueto parameters via cmd
                cmd.Parameters.AddWithValue("@ProjectTitle", b.ProjectTitle);
                cmd.Parameters.AddWithValue("@BugTitle", b.BugTitle);
                cmd.Parameters.AddWithValue("@BugDescription",b.BugDescription);
                cmd.Parameters.AddWithValue("@Severity",b.Severity);
                cmd.Parameters.AddWithValue("@Status", b.Status);
                cmd.Parameters.AddWithValue("@ReportDate",b.ReportDate);
                cmd.Parameters.AddWithValue("@SubmitCode", b.SubmitCode);
                cmd.Parameters.AddWithValue("@ImagePath", b.ImagePath);
                ////cmd.Parameters.AddWithValue("@BugImage", null);
                //cmd.Parameters.AddWithValue("@AssignTo", b.AssignTo);


                //Step 5: Open Connection
                conn.Open();

                //Step 6: Execute cmd
                int rows = cmd.ExecuteNonQuery();
                //if Inserted rows is greater is greater than 0
                //So save isSuccess to true
                //Else set isSuccess to false, Save Failed
                if(rows>0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);

            }
            finally
            {
                //Step :CLose Connection
                conn.Close();
            }

            return isSuccess;
        }

        //Function for Updating Bug Report
        public bool Update_Bug(Bugs b)
        {
            //Create return value and setvalue to false
            bool isSuccess = false;

            //Step 1: Create Sql Connection
            SqlConnection conn = new SqlConnection(myconnstr);

            try
            {
                //Step 2: Write T-SQL to Update Bug Details
                string sql = "UPDATE tbl_Bug SET ProjectTitle=@ProjectTitle, BugTitle=@BugTitle, BugDescription=@BugDescription, SubmitCode=@SubmitCode, Severity=@Severity, Status=@Status, ReportDate=@ReportDate, ImagePath=@ImagePath WHERE BugID=@BugID";

                //Step 3: Create SQL Command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Step 4: Pasing value to parameters using cmd
                cmd.Parameters.AddWithValue("@BugID", b.BugID);
                cmd.Parameters.AddWithValue("@ProjectTitle",b.ProjectTitle);
                cmd.Parameters.AddWithValue("@BugTitle", b.BugTitle);
                cmd.Parameters.AddWithValue("@BugDescription", b.BugDescription);
                cmd.Parameters.AddWithValue("@SubmitCode", b.SubmitCode);
                cmd.Parameters.AddWithValue("@Severity", b.Severity);
                cmd.Parameters.AddWithValue("@Status", b.Status);
                cmd.Parameters.AddWithValue("@ReportDate", b.ReportDate);
                cmd.Parameters.AddWithValue("@ImagePath", b.ImagePath);
                //cmd.Parameters.AddWithValue("@BugImage", b.BugImage);
                //
                //cmd.Parameters.AddWithValue("@AssignTo", b.AssignTo);

                //Step 5: Open Connection
                conn.Open();

                //Step 6: Execute cmd
                int rows = cmd.ExecuteNonQuery();

                //If Inserted the values of  rows is greater than 0
                //So set the value of isUsccess to true
                //Else set the value of isSuccess to false
                if(rows>0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);

            }
            finally
            {
                //Step 7: Close Connection
                conn.Close();
            }
            return isSuccess;
        }

        public bool Delete_Bug(Bugs b)
        {
            //create return value and set its default value to false
            bool isSuccess = false;
            //Step 1: Create Sql Connection
            SqlConnection conn = new SqlConnection(myconnstr);

            try
            {
                //STep 2: Write T-SQL to delete Bug
                string sql = "DELETE FROM tbl_Bug WHERE BugID=@BugID";

                //Step 3: Create Sql Command Using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Step 4: Passing value to paraeters via cmd
                cmd.Parameters.AddWithValue("@BugID", b.BugID);

                //Step 5: Open Connection
                conn.Open();

                //Step 6: Execute cmd
                int rows = cmd.ExecuteNonQuery();

                //if cmd is success rows value is greater than 0
                //set isSuccess value to true
                //Else set isSuccess value to false
                if(rows>0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);

            }
            finally
            {
                //Step 7: Close Connection
                conn.Close();
            }
            return isSuccess;
        }
        public bool Assign_Bug(Bugs b)
        {
            //create return value ans assign its default value to false
            bool isSuccess = false;

            //Step 1: Create SQL Connection
            SqlConnection conn = new SqlConnection(myconnstr);

            try
            {
                //Step 2: Write T-SQL to Update Bug Details
                string sql = "UPDATE tbl_Bug SET AssignTo=@AssignTo WHERE BugID=@BugID";

                //Step 3: Create SQL Command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Step 4: Pasing value to parameters using cmd
                cmd.Parameters.AddWithValue("@BugID", b.BugID);
                cmd.Parameters.AddWithValue("@AssignTo", b.AssignTo);

                //Step 5: Open Connection
                conn.Open();

                //Step 6: Execute cmd
                int rows = cmd.ExecuteNonQuery();

                //If Inserted the values of  rows is greater than 0
                //So set the value of isUsccess to true
                //Else set the value of isSuccess to false
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);

            }
            finally
            {
                //Step 7: Close Connection
                conn.Close();
            }
            return isSuccess;
        }
    }
}
