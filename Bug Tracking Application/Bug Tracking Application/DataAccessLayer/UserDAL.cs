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
    class UserDAL
    {
        //Database Connection Here
        static string myconnstr = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
        //select inert update delete
        public DataTable Select_User()
        {
            //Step 1: Create SQL Connection
            SqlConnection conn = new SqlConnection(myconnstr);

            //Create a Datatable to hold the records from database
            DataTable dt = new DataTable();
            try
            {
                //Step 2: Writing T-SQL Here
                String sql = "SELECT * FROM tbl_User";

                //Step 3: Creating SQL Command Using the SQL and CONN
                SqlCommand cmd = new SqlCommand(sql, conn);

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
                //Step 8: Close Connection
                conn.Close();
            }
            return dt;
        }

        public bool Insert_User(User u)
        {
            //define the return value & set it false by default
            bool isSuccess = false;

            //Step 1: create sql connection
            SqlConnection conn = new SqlConnection(myconnstr);
            
            try
            {
                //Step 2: Writing T-SQL
                String sql = "INSERT INTO tbl_User (FullName, Email, Username, Password, Gender, Contact, Address, UserType) VALUES (@FullName, @Email, @Username, @Password, @Gender, @Contact, @Address, @UserType)";
                
                //Step 3: Create Spl Command Using the sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //STEP 4: Pass Value tp Parameters via cmd
                cmd.Parameters.AddWithValue("@FullName", u.FullName);
                cmd.Parameters.AddWithValue("@Email", u.Email);
                cmd.Parameters.AddWithValue("@Username", u.Username);
                cmd.Parameters.AddWithValue("@Password", u.Password);
                cmd.Parameters.AddWithValue("@Gender", u.Gender);
                cmd.Parameters.AddWithValue("@Contact", u.Contact);
                cmd.Parameters.AddWithValue("@Address", u.Address);
                cmd.Parameters.AddWithValue("@UserType", u.UserType);

                //STEP 5: Open Connection
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
        
        public bool Update_User(User u)
        {
            //define the return value & set it false by default
            bool isSuccess = false;

            //Step 1: create sql connection
            SqlConnection conn = new SqlConnection(myconnstr);

            try
            {
                //STEP 2: Write Your T-SQL
                String sql = "UPDATE tbl_User SET FullName=@FullName, Email=@Email, Username=@Username, Password=@Password, Gender=@Gender, Contact=@Contact, Address=@Address, UserType=@UserType WHERE UserId=@UserID";
                
                //Step 3: Create Spl Command Using the sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //STEP 4: Pass Value to Parameters via cmd
                cmd.Parameters.AddWithValue("@FullName", u.FullName);
                cmd.Parameters.AddWithValue("@Email", u.Email);
                cmd.Parameters.AddWithValue("@Username", u.Username);
                cmd.Parameters.AddWithValue("@Password", u.Password);
                cmd.Parameters.AddWithValue("@Gender", u.Gender);
                cmd.Parameters.AddWithValue("@Contact", u.Contact);
                cmd.Parameters.AddWithValue("@Address", u.Address);
                cmd.Parameters.AddWithValue("@UserType", u.UserType);
                cmd.Parameters.AddWithValue("@UserID", u.UserID);

                //STEP 5: Open Connection
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
        public bool Delete_User(User u)
        {
            //Define the return vaue and set its default vlaue to false
            bool isSuccess = false;

            //STEP 1: Create sql Connection
            SqlConnection conn = new SqlConnection(myconnstr);

            try
            {
                //STEP 2: Write Your T-SQL
                String sql = "DELETE FROM tbl_User WHERE UserID=@UserID";

                //STEP 3: Create sql Command using the sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //STEP 4: Pass Value to Parameters via cmd
                cmd.Parameters.AddWithValue("@UserID", u.UserID);

                //STEP 5: Open Connection
                conn.Open();

                //STEP 6: execute cmd
                int rows = cmd.ExecuteNonQuery();

                //if DELETED rows is greater than zero,
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
    }
}
