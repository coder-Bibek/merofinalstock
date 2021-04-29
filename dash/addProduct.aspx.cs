using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Stock_Management_System.dash
{
    public partial class addProduct : System.Web.UI.Page
    {
        int user_id = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            categoryalert.Visible = false;
            if (Session["user_email"] == null)
            {
                Response.Redirect("/Loginscreen");
            }
            getUserid();
            if (!IsPostBack)
            {
                alertbox.Visible = false;
                try
                {
                    using (SqlConnection con = new SqlConnection(@"Data Source=BIBEKBIDARI-PC;Initial Catalog=mero_stock;Integrated Security=True"))
                    {
                        con.Open();
                        string stquery = "SELECT * FROM category";
                        SqlCommand cmd = new SqlCommand(stquery, con);
                        category.DataTextField = "category_name";
                        category.DataValueField = "category_id";
                        category.DataSource = cmd.ExecuteReader();
                        category.DataBind();
                        con.Close();
                    }
                }
                catch (Exception excep)
                {
                    System.Diagnostics.Debug.WriteLine(excep);
                }
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
                    string stquery = "SELECT user_id FROM user_details where user_email = '"+email+"'";
                    SqlCommand cmd = new SqlCommand(stquery, con);
                    user_id = Convert.ToInt32(cmd.ExecuteScalar());
                    System.Diagnostics.Debug.WriteLine(user_id);
                    con.Close();
                }
            }
            catch (Exception excep)
            {
                System.Diagnostics.Debug.WriteLine(excep);
            }
        }

        protected void addProduct_Click(object sender, EventArgs e)
        {

            string item_name = itemName.Text.Trim();
            int item_price = Convert.ToInt32(price.Text.Trim());
            string item_description = description.Text.Trim().ToString();
            int item_quantity =Convert.ToInt32( stockquantity.Text.Trim());
            string item_categories = category.SelectedItem.ToString();
            string  item_ManuDate= manufactureDate.Text.Trim().ToString();
            string  item_ExpDate= expiryDate.Text.Trim().ToString();

          

            try { 
            using (SqlConnection con = new SqlConnection(@"Data Source=BIBEKBIDARI-PC;Initial Catalog=mero_stock;Integrated Security=True"))
            {
                con.Open();
                    string stquery = "INSERT INTO [dbo].[inventory]([item_name],[item_desc],[item_price],[category_name],[manufacture_date],[expiry_date],[user_id],[available_status],[stock_quantity])VALUES('"+item_name+ "','" + item_description + "',"+ item_price+",'"+item_categories+"','"+item_ManuDate+"','"+item_ExpDate+"',"+user_id+",'y',"+item_quantity+")";
                SqlCommand cmd = new SqlCommand(stquery, con);
                    cmd.ExecuteNonQuery();
                con.Close();

                alertbox.Visible = true;
                alertbox.Attributes.Add("style", "background-color:#d1e7dd;color:#842029");
                alertbox.InnerText = "Product Added Succesfully";
            }
            }catch(Exception exp)
            {
                alertbox.Visible = true;
                alertbox.InnerText = exp.Message;
            }
        }

        protected void addCaterogyButton_Click(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string category_name = categoryName.Text.Trim();
                using (SqlConnection con = new SqlConnection(@"Data Source=BIBEKBIDARI-PC;Initial Catalog=mero_stock;Integrated Security=True"))
                {
                    con.Open();
                    string stquery = "INSERT INTO [dbo].[category]([category_name],[user_id])VALUES('" + category_name + "'," + user_id + ")";
                    SqlCommand cmd = new SqlCommand(stquery, con);
                    cmd.ExecuteNonQuery();
                    categoryalert.Visible = true;
                    categoryName.Text = "";
                    categoryalert.InnerText = "Category added successfully";
                    con.Close();

                }
            }
        }
    }
}