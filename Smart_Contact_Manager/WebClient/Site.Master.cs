using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebClient
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserID"] == null)
            {
                ViewState["isLoggedIn"] = false;
            }
            else
            {
                ViewState["isLoggedIn"] = true;
            }
        }

        protected void LogoutButton_Click(object sender, EventArgs e)
        {
            Session.Remove("UserID");
            //this.Context.Items.Add("SuccessMessage", "Logged out Successfully..!");
            Response.Redirect("~/Login.aspx");
        }
    }
}