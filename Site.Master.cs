using System;
using System.Collections.Generic;
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
                using (SqlConnection con = new SqlConnection(@"Data Source=BIBEKBIDARI-PC;Initial Catalog=mero_stock;Integrated Security=True"))
                {
                    con.Open();
                    string stquery = "SELECT item_name from inventory where status_delete = 0 and stock_quantity < 10";
                    SqlCommand cmd = new SqlCommand(stquery, con);
                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        
                    }
                    con.Close();

                }

            }
            catch (Exception excep)
            {
                System.Diagnostics.Debug.WriteLine(excep);
            }
        }

        protected void Logoutbtn_Click(object sender, ImageClickEventArgs e)
        {
            Session.Abandon();
            Response.Redirect("/Loginscreen");
        }
    }
}