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

        protected void addProduct_Click(object sender, EventArgs e)
        {
            string item_name = itemName.Text.Trim();
            int item_price = Convert.ToInt32(price.Text.Trim());
            string item_description = description.Text.Trim().ToString();
        }
    }
}