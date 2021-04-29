using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Stock_Management_System.dash
{
    public partial class profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            getProfile();
        }
        private void getProfile()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=mero_stock;Integrated Security=True"))
                {
                    con.Open();
                    string email = Session["user_email"].ToString();
                    string stquery = "SELECT * FROM user_details WHERE user_email = '" + email + "' ";
                    SqlCommand cmd = new SqlCommand(stquery, con);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        nameTxt.InnerText = reader.GetValue(1).ToString();
                        UsernameTxt.InnerText = reader.GetValue(1).ToString();
                        emailTxt.InnerText = reader.GetValue(2).ToString();
                        phoneTxt.InnerText = reader.GetValue(3).ToString();
                    }
                    con.Close();

                }

            }
            catch (Exception excep)
            {
                System.Diagnostics.Debug.WriteLine(excep);
                //alertbox.Visible = false;
            }
        }
    }
}