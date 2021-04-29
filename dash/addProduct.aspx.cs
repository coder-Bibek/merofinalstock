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
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                alertbox.Visible = false;
                try
                {
                    using (SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=mero_stock;Integrated Security=True"))
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

        protected void addProduct_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;

            string item_name = itemName.Text.Trim();
            int item_price = Convert.ToInt32(price.Text.Trim());
            string item_description = description.Text.Trim().ToString();
            string item_purchaseDate = today.ToString("dd/MM/yyyy");
            string item_categories = category.Text.Trim().ToString();
            string  item_ManuDate= manufactureDate.Text.Trim().ToString();
            string  item_ExpDate= expiryDate.Text.Trim().ToString();

            string email = Session["user_email"].ToString();

            try { 
            using (SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=mero_stock;Integrated Security=True"))
            {
                con.Open();
                string stquery = $"INSERT INTO inventory (item_name,item_desc,item_price,category_name,manufacture_date,expiry_date,user_id,avialable_status) values('{item_name}','{item_description}','{item_price}','{item_categories}','{item_ManuDate}','{item_ExpDate}','{email}','y')";
                SqlCommand cmd = new SqlCommand(stquery, con);
                category.DataSource = cmd.ExecuteNonQuery();
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
    }
}