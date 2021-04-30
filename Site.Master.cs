using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Stock_Management_System
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            getStockOutofDate();
            if (Session["user_email"]==null)
            {
                Response.Redirect("/Loginscreen");
            }
        }

        private void getStockOutofDate()
        {
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection con = new SqlConnection(@"Data Source=BIBEKBIDARI-PC;Initial Catalog=mero_stock;Integrated Security=True"))
                {
                    con.Open();
                    string stquery = "SELECT item_name 'Item less than 10' from inventory where status_delete = 0 and stock_quantity < 10";
                    SqlCommand cmd = new SqlCommand(stquery, con);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                    con.Close();
                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                }
            }
            catch (Exception excep)
            {
                System.Diagnostics.Debug.WriteLine(excep);
            }
        }

        protected void Logoutbtn_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("/Loginscreen");
        }
            protected void notificationButton_click(object sender, EventArgs e)
        {
            //notificationDot.Visible=false
            //notificationDot.Visible = false;
         
        }
    }
}