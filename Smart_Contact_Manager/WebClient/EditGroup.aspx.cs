using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebClient.GroupServiceReference;

namespace WebClient
{
    public partial class EditGroup : System.Web.UI.Page
    {
        GroupServiceClient grpProxy;
        int UserId, GroupId;

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            { 
                if (Session["UserID"] == null)
                {
                    this.Context.Items.Add("ErrorMessage", "Access Denied! Please Login");
                    Server.Transfer("~/Login.aspx");
                }
                grpProxy = new GroupServiceClient();
                GroupId = Int32.Parse(Request.QueryString["GroupId"]);
                UserId = Int32.Parse(Session["UserId"].ToString());
                ViewState["GroupId"] = GroupId.ToString();
                var group = new Group1();
                group.UserId = UserId;
                group.GroupId = GroupId;
                var fetchedGroup = ((IGroupService)grpProxy).GetGroup(group);
                if (fetchedGroup.UserId != UserId)
                {
                    Response.Redirect("~/AccessDenied.aspx");
                }
                Name.Text = fetchedGroup.Name;
                Description.Text = fetchedGroup.Description;
            }
        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            grpProxy = new GroupServiceClient();
            Group1 grp = new Group1();
            grp.GroupId = Int32.Parse(ViewState["GroupId"].ToString());
            grp.Name = Name.Text;
            grp.Description = Description.Text;
            grp.UserId = Int32.Parse(Session["UserId"].ToString());
            var updatedGrp = ((IGroupService)grpProxy).UpdateGroup(grp);
            if(updatedGrp.GroupId==0)
            {
                ErrorMessage.Text = "Group Name is already Used.";
                return;
            }
            Response.Redirect("~/ViewGroup.aspx?GroupId=" + grp.GroupId);
        }
    }
}