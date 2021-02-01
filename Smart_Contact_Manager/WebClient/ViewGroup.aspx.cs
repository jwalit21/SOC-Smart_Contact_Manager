using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebClient.GroupServiceReference;
using WebClient.ContactServiceReference;

namespace WebClient
{
    public partial class ViewGroup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserID"] == null)
            {
                Response.Redirect("~/Login.aspx");
            }
            int GroupId = Int32.Parse(Request.QueryString["GroupId"]);
            var UserId = Int32.Parse(Session["UserId"].ToString());
            var proxy = new GroupServiceClient();
            var group = new Group1();
            group.UserId = UserId;
            group.GroupId = GroupId;
            var fetchedGroup = ((IGroupService)proxy).GetGroup(group);
            GroupName.Text = fetchedGroup.Name;
            GrpDesc.Text = fetchedGroup.Description;
            var groupContacts = ((IGroupService)proxy).GetGroupContacts(GroupId);

            var contactProxy = new ContactServiceClient();
            var contact = new Contact1();
            for(int i = 0; i < groupContacts.Length; i++)
            {
                TableCell seqNo = new TableCell();
                TableCell ContactId = new TableCell();
                TableCell PhoneNumber = new TableCell();
                TableCell button = new TableCell();
                seqNo.Text = "" + (i + 1);
                contact.ContactId = groupContacts[i].ContactId;
                var fetchedContact = ((IContactService)contactProxy).GetContact(contact);
                ContactId.Text = fetchedContact.Name;
                PhoneNumber.Text = fetchedContact.PhoneNumber;
                button.Text = ("<a class='btn btn-primary' href=''>View Contact</a>");
                TableRow row = new TableRow();
                row.Cells.Add(seqNo);
                row.Cells.Add(ContactId);
                row.Cells.Add(PhoneNumber);
                row.Cells.Add(button);
                GroupContacList.Rows.Add(row);
            }
        }
    }
}