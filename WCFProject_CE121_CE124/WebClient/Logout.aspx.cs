using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebClient
{
    public partial class Logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Clear();
            this.Context.Items.Add("SuccessMessage", "Logout Successfully!!!");
            Server.Transfer("/Login.aspx", true);
        }
    }
}