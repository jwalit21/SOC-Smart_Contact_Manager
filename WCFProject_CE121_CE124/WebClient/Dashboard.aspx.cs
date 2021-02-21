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
    public partial class Dashboard : System.Web.UI.Page
    {
        ContactServiceClient contactProxy;
        GroupServiceClient groupProxy;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["UserID"] == null)
                {
                    this.Context.Items.Add("ErrorMessage", "Access Denied! Please Login");
                    Server.Transfer("~/Login.aspx");
                }
                var UserId = Int32.Parse(Session["UserId"].ToString());
                contactProxy = new ContactServiceClient();
                var contacts = ((IContactService)contactProxy).GetContacts(UserId);
                groupProxy = new GroupServiceClient();
                var groups = ((IGroupService)groupProxy).GetGroups(UserId);

                var totalContacts = contacts.Length;
                var minContactsLength = (totalContacts >= 3) ? 3 : totalContacts;
                var totalGroups = groups.Length;
                var minGroupsLength = (totalGroups >= 3) ? 3 : totalGroups;

                ContactLength.Text = totalContacts.ToString();
                GroupLength.Text = totalGroups.ToString();

                for (int i = 0; i < minContactsLength; i++)
                {
                    var contactUrl = "ViewContact.aspx?ContactId=" + contacts[i].ContactId;
                    TableCell seqNo = new TableCell();
                    TableCell contactName = new TableCell();
                    TableCell contactPhoneno = new TableCell();
                    TableCell viewContactButton = new TableCell();

                    seqNo.Text = "" + (i + 1);
                    contactName.Text = contacts[i].Name;
                    contactPhoneno.Text = contacts[i].PhoneNumber;
                    viewContactButton.Text = ("<a class='btn btn-primary' href=" + contactUrl + ">View</a>");
                    TableRow row = new TableRow();

                    row.Cells.Add(seqNo);
                    row.Cells.Add(contactName);
                    row.Cells.Add(contactPhoneno);
                    row.Cells.Add(viewContactButton);
                    ContactsList.Rows.Add(row);
                }

                for (int i = 0; i < minGroupsLength; i++)
                {
                    var groupUrl = "ViewGroup.aspx?GroupId=" + groups[i].GroupId;
                    TableCell seqNo = new TableCell();
                    TableCell groupName = new TableCell();
                    TableCell viewGroupButton = new TableCell();

                    seqNo.Text = "" + (i + 1);
                    groupName.Text = groups[i].Name;
                    viewGroupButton.Text = ("<a class='btn btn-primary' href=" + groupUrl + ">View</a>");

                    TableRow row = new TableRow();

                    row.Cells.Add(seqNo);
                    row.Cells.Add(groupName);
                    row.Cells.Add(viewGroupButton);
                    GroupList.Rows.Add(row);
                }
            }
            catch (System.ServiceModel.CommunicationException)
            {
                groupProxy = new GroupServiceClient();
                contactProxy = new ContactServiceClient();
                Server.Transfer("~/Dashboard.aspx");
            }
        }
    }
}