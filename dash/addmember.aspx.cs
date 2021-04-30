using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Stock_Management_System.dash
{
    public partial class addcustomer : System.Web.UI.Page
    {
        int user_id = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user_email"] == null)
            {
                Response.Redirect("/Loginscreen");
            }
            getUserid();
            
        }

        private void getUserid()
        {
            try
            {
                string email = Session["user_email"].ToString();
                using (SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=mero_stock;Integrated Security=True"))
                {
                    con.Open();
                    string stquery = "SELECT user_id FROM user_details where user_email = '" + email + "'";
                    SqlCommand cmd = new SqlCommand(stquery, con);
                    user_id = Convert.ToInt32(cmd.ExecuteScalar());
                    con.Close();
                }
            }
            catch (Exception excep)
            {
                System.Diagnostics.Debug.WriteLine(excep);
            }
        }
        }
}