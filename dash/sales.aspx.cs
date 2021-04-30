using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Stock_Management_System.dash
{
    public partial class sales : System.Web.UI.Page
    {
        int user_id = 0;
        int quanity = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            salesbox.Visible = false;
            if (Session["user_email"] == null)
            {
                Response.Redirect("/Loginscreen");
            }
            getUserid();
            if (!IsPostBack)
            {
                getCustomer();
                getProducts();
            }
        }



        private void getProducts()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=BIBEKBIDARI-PC;Initial Catalog=mero_stock;Integrated Security=True"))
                {
                    con.Open();
                    string stquery = "SELECT * from inventory where status_delete = 0";
                    SqlCommand cmd = new SqlCommand(stquery, con);
                    product.DataTextField = "item_name";
                    product.DataValueField = "inventory_id";
                    product.DataSource = cmd.ExecuteReader();
                    product.DataBind();
                    con.Close();

                }

            }
            catch (Exception excep)
            {
                System.Diagnostics.Debug.WriteLine(excep);
            }
        }

        private void getCustomer()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=BIBEKBIDARI-PC;Initial Catalog=mero_stock;Integrated Security=True"))
                {
                    con.Open();
                    string stquery = "SELECT * from customer";
                    SqlCommand cmd = new SqlCommand(stquery, con);
                    customer.DataTextField = "cust_name";
                    customer.DataValueField = "member_number";
                    customer.DataSource = cmd.ExecuteReader();
                    customer.DataBind();
                    con.Close();

                }

            }
            catch (Exception excep)
            {
                System.Diagnostics.Debug.WriteLine(excep);
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
                    System.Diagnostics.Debug.WriteLine(user_id);
                    con.Close();
                }
            }
            catch (Exception excep)
            {
                System.Diagnostics.Debug.WriteLine(excep);
            }
        }

        protected void addSales_Click(object sender, EventArgs e)
        {
            string salesname = salesName.Text.Trim();
            int quantity_total = Convert.ToInt32(quantity.Text.Trim());
            DateTime time = DateTime.Today;
            int invent_id = Convert.ToInt32( product.SelectedValue.Trim());
            string invent_name = product.SelectedItem.ToString();
            string customer_name = customer.SelectedItem.ToString();
             System.Diagnostics.Debug.WriteLine(time.ToString("d"));

            try
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=BIBEKBIDARI-PC;Initial Catalog=mero_stock;Integrated Security=True"))
                {
                    con.Open();
                    string stquery = "SELECT stock_quantity FROM inventory WHERE item_name = '" + invent_name + "'";
                    SqlCommand cmd = new SqlCommand(stquery, con);
                    quanity = Convert.ToInt32(cmd.ExecuteScalar());
                    con.Close();
                }

            }
            catch (Exception excep)
            {
                System.Diagnostics.Debug.WriteLine(excep);
            }

            if (quantity_total > quanity || quantity_total <= 0)
            {
                salesbox.Visible = true;
                salesbox.InnerText = "Available Quantity is less than Required quantity";
            }
            else
            {
                try
                {

                    using (SqlConnection con = new SqlConnection(@"Data Source=BIBEKBIDARI-PC;Initial Catalog=mero_stock;Integrated Security=True"))
                    {
                        con.Open();
                        string stquery = " INSERT INTO[dbo].[sales]([sales_name],[sales_date],[inventory_id],[quantity],[user_id],[cust_name],[purchase_date]) VALUES('" + salesname + "','" + time.ToString("d") + "'," + invent_id + "," + quantity_total + "," + user_id + ",'" + customer_name + "','" + time.ToString("d") + "')";
                        SqlCommand cmd = new SqlCommand(stquery, con);
                        cmd.ExecuteNonQuery();
                        salesbox.Visible = true;
                        salesbox.InnerText = "Sales added successfully";
                        string upquery = "UPDATE inventory SET stock_quantity = stock_quantity - " + quantity_total + " WHERE item_name = '" + invent_name + "' ";
                        SqlCommand upcmd = new SqlCommand(upquery, con);
                        upcmd.ExecuteNonQuery();
                    }
                }
                catch (Exception excep)
                {
                    System.Diagnostics.Debug.WriteLine(excep);
                }
            }
           
        }
    }
}