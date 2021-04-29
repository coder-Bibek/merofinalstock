using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Stock_Management_System.Screens
{
    public partial class Registerscreen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            alertbox.Visible = false;
        }

        protected void Btnregister_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=mero_stock;Integrated Security=True"))
                {
                    con.Open();
                    string username = txtName.Text.Trim();
                    string useremail = txtEmail.Text.Trim();
                    string usernumber = txtNumber.Text.Trim();
                    string userpassword = txtPassword.Text.Trim();
                    //System.Diagnostics.Debug.WriteLine(useremail);
                    //System.Diagnostics.Debug.WriteLine(userpassword);
                    string stquery = "SELECT COUNT(1) FROM user_details WHERE user_email = '" + useremail + "'";
                    SqlCommand cmd = new SqlCommand(stquery, con);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    if (count == 1)
                    {
                        alertbox.Visible = true;
                        alertbox.InnerText = "User Already Exists";
                    }
                    else
                    {
                        try
                        {
                            string insertquery = "INSERT INTO [dbo].[user_details] ([full_name],[user_email],[user_phnumber],[user_password],[user_role])VALUES('" + username + "','" + useremail + "','" + usernumber + "','" + userpassword + "','regular' )";
                            SqlCommand instcmd = new SqlCommand(insertquery, con);
                            instcmd.ExecuteNonQuery();
                            Session["user_email"] = useremail;
                            Response.Redirect("/");
                            Response.End();
                        }
                        catch (Exception excep)
                        {
                            System.Diagnostics.Debug.WriteLine(excep);
                        }
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