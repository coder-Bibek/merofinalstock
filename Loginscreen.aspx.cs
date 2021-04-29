using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Stock_Management_System.Screens
{
    public partial class Loginscreen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user_email"] != null )
            {
                Response.Redirect("/");
            }
            alertbox.Visible = false;
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            try {
                using (SqlConnection con = new SqlConnection(@"Data Source=BIBEKBIDARI-PC;Initial Catalog=merostock;Integrated Security=True"))
                {
                    con.Open();
                    string useremail = txtEmail.Text.Trim();
                    string userpassword = txtPassword.Text.Trim();
                    System.Diagnostics.Debug.WriteLine(useremail);
                    System.Diagnostics.Debug.WriteLine(userpassword);
                    string stquery = "SELECT COUNT(1) FROM user_details WHERE user_email = '" + useremail + "' and user_password = '" + userpassword + "'";
                    SqlCommand cmd = new SqlCommand(stquery, con);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
               
                    if (count == 1)
                    {
                        Session["user_email"] = useremail;
                        Response.Redirect("/");
                    }
                    else
                    {
                        alertbox.Visible = true;
                    }
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