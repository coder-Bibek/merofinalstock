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
            if (Session["user_email"] == null)
            {
                Response.Redirect("/Loginscreen");
            }
            else {
                getProfile();
                alertbox.Visible = false;
            }
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

        protected void Changepwdbtn_Click(object sender, EventArgs e)
        {
            string oldpwd = crntPwd.Text.Trim();
            string newpwd = newPwd.Text.Trim();
            string confpwd = conPwd.Text.Trim();
            string gotPwd = "";
            if (newpwd != confpwd)
            {
                alertbox.Visible = true;
                alertbox.InnerText = "New password and Confirm password doesnt Match";
            }
            else
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=mero_stock;Integrated Security=True"))
                    {
                        con.Open();
                        string email = Session["user_email"].ToString();
                        string stquery = "SELECT user_password FROM user_details WHERE user_email = '" + email + "' ";
                        SqlCommand cmd = new SqlCommand(stquery, con);
                        gotPwd = cmd.ExecuteScalar().ToString();
                        if (oldpwd == "" || newpwd == "" || confpwd == "")
                        {
                            alertbox.Visible = true;
                            alertbox.InnerText = "Password cannot be empty";
                        }
                        else if (oldpwd == gotPwd)
                        {
                            try {
                                string updquery = "UPDATE user_details SET user_password = '"+newpwd+"'  WHERE user_email = '"+email+"' ";
                                SqlCommand updcmd = new SqlCommand(updquery, con);
                                updcmd.ExecuteNonQuery();
                                alertbox.Visible = true;
                                alertbox.Attributes.Add("style", "background-color:#d1e7dd;color:#842029");
                                alertbox.InnerText = "Password changed Succesfully";
                            }catch(Exception excp)
                            {
                                System.Diagnostics.Debug.WriteLine(excp);
                            }
                        }
                        else
                        {
                            alertbox.Visible = true;
                            alertbox.InnerText = "Old password doesnt match";
                        }
                        con.Close();

                    }

                }
                catch (Exception exp)
                {
                    System.Diagnostics.Debug.WriteLine(exp);
                }
            }
            
        }
    }
}