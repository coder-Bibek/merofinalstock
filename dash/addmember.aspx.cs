using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Stock_Management_System.dash
{
    public partial class addMember : System.Web.UI.Page
    {
        int user_id = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user_email"] == null)
            {
                Response.Redirect("/Loginscreen");
            }
            getUserid();
            mainalertbox.Visible = false;
            string[] memType = { "With Card", "Without Card" };
            for (int i = 0; i < memType.Length; i++)
            {
                memberType.Items.Add(new ListItem(memType[i], memType[i].ToUpper()));

            }
        }

        private void getUserid()
        {
            try
            {
                string email = Session["user_email"].ToString();
                using (SqlConnection con = new SqlConnection(@"Data Source=BIBEKBIDARI-PC;Initial Catalog=mero_stock;Integrated Security=True"))
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


        protected void addMember_button_Click(object sender, EventArgs e)
        {
            string cust_Name = customerName.Text.Trim();
            string cust_address = address.Text.Trim();
            string cust_email = Email.Text.Trim();
            string cust_phone = contactNumber.Text.Trim();
            string member_type = memberType.SelectedItem.ToString();
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=BIBEKBIDARI-PC;Initial Catalog=mero_stock;Integrated Security=True"))
                {
                    con.Open();
                    string stquery = "INSERT INTO [dbo].[customer] ([cust_name],[cust_address],[cust_contactno],[cust_email],[member_type],[user_id])VALUES('"+cust_Name+"','"+cust_address+ "','" + cust_phone + "','" + cust_email+"','"+member_type+"',"+user_id+")";
                    SqlCommand cmd = new SqlCommand(stquery, con);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    customerName.Text = "";
                    address.Text = "";
                    Email.Text = "";
                    contactNumber.Text = "";

                    mainalertbox.Visible = true;
                    mainalertbox.Attributes.Add("style", "background-color:#d1e7dd;color:#842029");
                    mainalertbox.InnerText = "Member Added Succesfully";
                }
            }
            catch (Exception exp)
            {
                mainalertbox.Visible = true;
                mainalertbox.InnerText = exp.Message;
            }
        }
    }
    }
