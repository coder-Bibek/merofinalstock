using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Stock_Management_System
{
    public class GetUserId
    {
        public static int GetUserid(string session_id)
        {
                using (SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=mero_stock;Integrated Security=True"))
                {
                    con.Open();
                    string stquery = "SELECT user_id FROM user_details where user_email = '" + session_id + "'";
                    SqlCommand cmd = new SqlCommand(stquery, con);
                    int user_id = Convert.ToInt32(cmd.ExecuteScalar());
                    System.Diagnostics.Debug.WriteLine(user_id);
                    con.Close();
                    return user_id;
                }
        }
    }
}