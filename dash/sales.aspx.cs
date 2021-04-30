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
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["user_email"] == null)
            {
                Response.Redirect("/Loginscreen");
            }
            getUserid();
            if (!IsPostBack)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(@"Data Source=BIBEKBIDARI-PC;Initial Catalog=mero_stock;Integrated Security=True"))
                    {
                        con.Open();
                        string stquery = "SELECT * FROM category";
                        SqlCommand cmd = new SqlCommand(stquery, con);
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
            throw new NotImplementedException();
        }
    }
}