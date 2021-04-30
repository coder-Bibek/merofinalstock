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
        protected void Page_Load(object sender, EventArgs e)
        {
            alertbox.Visible = false;
            string [] memType = {"With Card","Without Card"};
            for(int i=0;i<memType.Length; i++)
            {
                memberType.Items.Add(new ListItem(memType[i], memType[i].ToUpper()));
            }
        }
        protected void addMember_click(object sender, EventArgs e)
        {
            string cust_Name = customerName.Text.Trim();
            string cust_address = address.Text.Trim();
            string cust_email = Email.Text.Trim();
            string cust_phone = contactNumber.Text.Trim();
            string member_type = memberType.SelectedItem.ToString();
            string email = Session["user_email"].ToString();
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=mero_stock;Integrated Security=True"))
                {
                    con.Open();
                    int user_id = GetUserId.GetUserid(email);
                    string stquery = "INSERT INTO [dbo].[customer] ([cust_name],[cust_address],[cust_contactno],[cust_email],[member_type],[user_id])VALUES"+
           $"('{cust_Name}','{cust_address}','{cust_phone}','{cust_email}','{member_type}','{user_id}')";
                    SqlCommand cmd = new SqlCommand(stquery, con);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    customerName.Text="";
                    address.Text="";
                    Email.Text="";
                    contactNumber.Text="";

                    alertbox.Visible = true;
                    alertbox.Attributes.Add("style", "background-color:#d1e7dd;color:#842029");
                    alertbox.InnerText = "Member Added Succesfully";
                }
            }
            catch (Exception exp)
            {
                alertbox.Visible = true;
                alertbox.InnerText = exp.Message;
            }
        }
    }
}