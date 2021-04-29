using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Stock_Management_System.dash
{
    public partial class Salesview : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            getCustomer();
            getData();
        }

        private void getCustomer()
        {
            if (!IsPostBack)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(@"Data Source=BIBEKBIDARI-PC;Initial Catalog=mero_stock;Integrated Security=True"))
                    {
                        con.Open();
                        string stquery = "SELECT * from customer";
                        SqlCommand cmd = new SqlCommand(stquery, con);
                        customer.DataTextField = "customer_name";
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
        }

        private void getData()
        {
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection con = new SqlConnection(@"Data Source=BIBEKBIDARI-PC;Initial Catalog=mero_stock;Integrated Security=True"))
                {
                    con.Open();
                  
                    string stquery = "SELECT * from sales";
                    SqlCommand cmd = new SqlCommand(stquery, con);
                   using(SqlDataReader reader = cmd.ExecuteReader())
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
    }
}