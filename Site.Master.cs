using System;
using System.Collections.Generic;
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
            if (Session["user_email"]==null)
            {
                Response.Redirect("/Loginscreen");
            }
        }

        protected void Logoutbtn_Click(object sender, ImageClickEventArgs e)
        {
            Session.Abandon();
            Response.Redirect("/Loginscreen");
        }
    }
}