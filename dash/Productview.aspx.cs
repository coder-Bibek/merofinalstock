using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Stock_Management_System.dash
{
    public partial class Productview : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            getData();
            getItem();
        }
        private void getItem()
        {
            if (!IsPostBack)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(@"Data Source=BIBEKBIDARI-PC;Initial Catalog=mero_stock;Integrated Security=True"))
                    {
                        con.Open();
                        string stquery = "SELECT * from inventory";
                        SqlCommand cmd = new SqlCommand(stquery, con);
                        item.DataTextField = "item_name";
                        item.DataValueField = "inventory_id";
                        item.DataSource = cmd.ExecuteReader();
                        item.DataBind();
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

                    string stquery = "SELECT * from inventory";
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

        protected void Searchbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string itemname = item.SelectedItem.ToString();
                System.Diagnostics.Debug.WriteLine(itemname);
                DataTable dt = new DataTable();
                using (SqlConnection con = new SqlConnection(@"Data Source=BIBEKBIDARI-PC;Initial Catalog=mero_stock;Integrated Security=True"))
                {
                    con.Open();

                    string stquery = "SELECT * from sales WHERE item_name = '" + itemname + "' AND available_status = 'y' ";
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
    }
}