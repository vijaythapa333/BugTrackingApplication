using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Bug_Tracking_Application.Classes;
using System.IO;


namespace Bug_Tracking_Application.DataAccessLayer
{
    class ProjectDAL
    {
        //Database Connection Here
        static string myconnstr = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;

        //SELECT, INSERT, UPDATE and DELETE
        public DataTable Select_Project()
        {
            //Step 1: Create SQl Connection Here
            SqlConnection conn = new SqlConnection(myconnstr);

            //Create a DataTable to hold the records from Database
            DataTable dt = new DataTable();

            try
            {
                //STEP 2: Writing T-SQL Here
                String sql = "SELECT * FROM tbl_Project";

                //STEP 3: Creating SQL Command using the sql and conn
                SqlCommand cmd = new SqlCommand(sql,conn);

                //STEP 4: Create SQL DATA Adapter using cmd to get records
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //STEP 5: Open Connection
                conn.Open();

                //STEP 6: Use Adapter to fill dt
                adapter.Fill(dt);
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);

            }
            finally
            {
                //Step 8: Close Connecction
                conn.Close();
            }
            return dt;
        }

        public bool Insert_Project(Project p)
        {
            //define the return value and set its default value false
            bool isSuccess = false;

            //Step 1: Create SQL Connection
            SqlConnection conn = new SqlConnection(myconnstr);

            try
            {
                //STEP 2: Writing T-SQL to insert data
                String sql = "INSERT INTO tbl_Project (ProjectTitle, ProjectDescription, ProjectUrl, StartDate, EndDate) VALUES (@ProjectTitle, @ProjectDescription, @ProjectUrl, @StartDate, @EndDate) ";

                //STEP 3: Create Sql Command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //STEP 4: Pass Value to  Parameters via cmd
                //cmd.Parameters.AddWithValue("@ProjectID",p.ProjectID);
                cmd.Parameters.AddWithValue("@ProjectTitle", p.ProjectTitle);
                cmd.Parameters.AddWithValue("@ProjectDescription", p.ProjectDescription);
                cmd.Parameters.AddWithValue("@ProjectUrl", p.ProjectUrl);
                cmd.Parameters.AddWithValue("@StartDate", p.StartDate);
                cmd.Parameters.AddWithValue("@EndDate", p.EndDate);

                //STEP 5: OPEN Connection
                conn.Open();

                //STEP 6: Execute cmd
                int rows = cmd.ExecuteNonQuery();
                //if inserted rows is greater than zero,
                //in this case, set success to true
                //otherwise, set success to false
                if (rows > 0)
                    isSuccess = true;
                else
                    isSuccess = false;

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);

            }
            finally
            {
                //STEP 7: Close Connection
                conn.Close();
            }
            return isSuccess;
        }

        public bool Update_Project(Project p)
        {
            //Define the return value and set its default value false
            bool isSuccess = false;

            //Step 1: Creating Sql Connection
            SqlConnection conn = new SqlConnection(myconnstr);
            try
            {
                //STEP 2: Writing T-SQL Here
                String sql = "UPDATE tbl_Project SET ProjectTitle=@ProjectTitle,ProjectDescription=@ProjectDescription,StartDate=@StartDate, EndDate=@EndDate,ProjectUrl=@ProjectUrl WHERE ProjectId=@ProjectID";

                //STEP 3: Create Sql Command Using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //STEP 4: Pass value to Parameters via cmd
                cmd.Parameters.AddWithValue("@ProjectID", p.ProjectID);
                cmd.Parameters.AddWithValue("@ProjectTitle", p.ProjectTitle);
                cmd.Parameters.AddWithValue("@ProjectDescription", p.ProjectDescription);
                cmd.Parameters.AddWithValue("@ProjectUrl", p.ProjectUrl);
                cmd.Parameters.AddWithValue("@StartDate", p.StartDate);
                cmd.Parameters.AddWithValue("@EndDate", p.EndDate);

                //STEP 5: Open Connection
                conn.Open();

                //STEP 6: Execute cmd
                int rows = cmd.ExecuteNonQuery();
                //if updated rows is greater than 1
                //in this case set isSuccess is equal to true
                //Else set isSuccess is equal to false
                if (rows > 0)
                    isSuccess = true;
                else
                    isSuccess = false;
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);

            }
            finally
            {
                //STEp 7: Close Connection
                conn.Close();
            }
            return isSuccess;
        }

        public bool Delete_Project(Project p)
        {
            //Define return value and set its default value to false
            bool isSuccess = false;
            //STEP 1: Create Sql Connection
            SqlConnection conn = new SqlConnection(myconnstr);

            try
            {
                //STEP 2: Writing T-SQl for deleting Project
                String sql = "DELETE FROM tbl_Project WHERE ProjectID=@ProjectID";

                //STEP 3: CREATE Sql Command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //STEP 4: Pass value to Parameters via cmd
                cmd.Parameters.AddWithValue("@ProjectID", p.ProjectID);

                //STEP 4: Open Connection
                conn.Open();

                //STEP 5: Execute cmd
                int rows = cmd.ExecuteNonQuery();
                //if Deleted rows is greater than 0
                // in this case, set isSuccess is equal to true
                //else set isSuccess is equal to false
                if (rows > 0)
                    isSuccess = true;
                else
                    isSuccess = false;

            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);

            }
            finally
            {
                //STEP 7: Close Connection
                conn.Close();
            }
            return isSuccess;
        }
    }
}
