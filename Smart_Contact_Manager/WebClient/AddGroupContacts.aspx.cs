using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebClient.ContactServiceReference;
using WebClient.GroupServiceReference;

namespace WebClient
{
    public partial class AddGroupContacts : System.Web.UI.Page
    {
        GroupServiceClient grpProxy;
        ContactServiceClient contactProxy;
        int GroupId;
        int UserId;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserID"] == null)
            {
                this.Context.Items.Add("ErrorMessage","Access Denied! Please Login");
                Server.Transfer("~/Login.aspx");
            }
            grpProxy = new GroupServiceClient();
            contactProxy = new ContactServiceClient();
            if (Request.QueryString["GroupId"] == null)
            {
                Response.Redirect("~/404.aspx");
            }
            GroupId = Int32.Parse(Request.QueryString["GroupId"]);
            UserId = Int32.Parse(Session["UserId"].ToString());
            var group = new Group1();
            group.UserId = UserId;
            group.GroupId = GroupId;
            var fetchedGroup = ((IGroupService)grpProxy).GetGroup(group);
            if (fetchedGroup.GroupId == 0)
            {
                Response.Redirect("~/404.aspx");
            }
            if (fetchedGroup.UserId != UserId)
            {
                Response.Redirect("~/AccessDenied.aspx");
            }
            GroupName.Text = fetchedGroup.Name;
            var allContacts = ((IContactService)contactProxy).GetContacts(UserId).ToList();
            var grpContacts = ((IGroupService)grpProxy).GetGroupContacts(GroupId).ToList();

            foreach (var contact in allContacts)
            {
                bool isInGroup = false;
                foreach (var grpContact in grpContacts)
                {
                    if (grpContact.ContactId == contact.ContactId)
                    {
                        isInGroup = true;
                        break;
                    }
                }
                if (!isInGroup)
                {
                    var contactToAdd = new ListItem();
                    contactToAdd.Value = contact.ContactId.ToString();
                    contactToAdd.Text = contact.Name;
                    GroupContacts.Items.Add(contactToAdd);
                }
            }
        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            foreach(ListItem grpContact in GroupContacts.Items)
            {
                if (grpContact.Selected)
                {
                    var grpContactToAdd = new GroupContact1();
                    grpContactToAdd.ContactId = Int32.Parse(grpContact.Value);
                    grpContactToAdd.GroupId = GroupId;
                    ((IGroupService)grpProxy).AddGroupContract(grpContactToAdd);
                }
            }
            Response.Redirect("~/ViewGroup.aspx?GroupId=" + GroupId);
        }
    }
}