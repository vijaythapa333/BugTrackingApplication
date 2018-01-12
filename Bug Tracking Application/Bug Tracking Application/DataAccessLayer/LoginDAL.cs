using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Bug_Tracking_Application.DataAccessLayer
{
    class LoginDAL
    {
        static string myconnstr = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
        public bool Login(string Username, string Password, string UserType)
        {
            //Step 1: Define boolean variable for login successfull and set initial value to false
            bool isLogin = false;

            //Step 2: Create Connection String
            String connectionstring = myconnstr;

            //Step 3: Create SQL Connection
            SqlConnection conn = new SqlConnection(connectionstring);

            try
            {
                //STep 4: Writing T-SQL for login
                String sql = "SELECT * FROM tbl_USER WHERE Username=@Username AND Password=@Password AND UserType=@UserType";

                //Step 5: Creating Sql Command using sql and command
                SqlCommand cmd = new SqlCommand(sql,conn);

                //Step 5.1 Add Values to Parameters
                cmd.Parameters.AddWithValue("@Username",Username);
                cmd.Parameters.AddWithValue("@Password", Password);
                cmd.Parameters.AddWithValue("@UserType", UserType);

                //Step 6: Create Sql Data Adapter using cmd to get records
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //Step 7: Create a datatable to hold the records from database
                DataTable dt = new DataTable();

                //Step 8: Open COnnection
                conn.Open();

                //Step 9: Use Adapter to fill dt
                adapter.Fill(dt);

                //..................................................................................
                //Step 10: use dt to find if log in is successful/failed
                if(dt.Rows.Count>0)
                {
                    //Login SUccessful
                    isLogin = true;
                }
                else
                {
                    //Login Failed
                    isLogin = false;
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                //Step 11: Close Connection
                conn.Close();
            }
            return isLogin;
        }
    }
}
