using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebClient.ContactServiceReference;

namespace WebClient
{
    public partial class ContactList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserID"] == null)
            {
                this.Context.Items.Add("ErrorMessage", "Access Denied! Please Login");
                Server.Transfer("~/Login.aspx");
            }
            var UserId = Int32.Parse(Session["UserId"].ToString());
            var proxy = new ContactServiceClient();
            var contacts = ((IContactService)proxy).GetContacts(UserId);
            CreateContactLink.NavigateUrl = "NewContact.aspx";
            for (int i = 0; i < contacts.Length; i++)
            {
                var contactUrl = "ViewContact.aspx?ContactId=" + contacts[i].ContactId;
                var editUrl = "EditContact.aspx?ContactId=" + contacts[i].ContactId;
                TableCell seqNo = new TableCell();
                TableCell contactName = new TableCell();
                TableCell contactPhoneno = new TableCell();
                TableCell viewButton = new TableCell();
                TableCell editButton = new TableCell();
                seqNo.Text = "" + (i + 1);
                contactName.Text = contacts[i].Name;
                contactPhoneno.Text = contacts[i].PhoneNumber;
                viewButton.Text = ("<a class='btn btn-primary' href=" + contactUrl + ">View</a>");
                editButton.Text = ("<a class='btn btn-secondary' href=" + editUrl + ">Edit</a>");
                TableRow row = new TableRow();
                row.Cells.Add(seqNo);
                row.Cells.Add(contactName);
                row.Cells.Add(contactPhoneno);
                row.Cells.Add(viewButton);
                row.Cells.Add(editButton);
                ContactsList.Rows.Add(row);
            }
        }
    }
}