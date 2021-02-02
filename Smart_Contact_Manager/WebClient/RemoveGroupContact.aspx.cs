using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebClient.GroupServiceReference;

namespace WebClient
{
    public partial class RemoveGroupContact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserID"] == null)
            {
                this.Context.Items.Add("ErrorMessage", "Access Denied! Please Login");
                Server.Transfer("~/Login.aspx");
            }
            if (Request.QueryString["Id"] == null || Request.QueryString["GroupId"] == null)
            {
                Response.Redirect("~/404.aspx");
            }
            int Id = Int32.Parse(Request.QueryString["Id"]);
            int GroupId = Int32.Parse(Request.QueryString["GroupId"]);
            var proxy = new GroupServiceClient();
            var grpContact = new GroupContact1();
            grpContact.Id = Id;
            ((IGroupService)proxy).DeleteGroupContact(grpContact);
            Response.Redirect("~/ViewGroup.aspx?GroupId=" + GroupId);
        }
    }
}