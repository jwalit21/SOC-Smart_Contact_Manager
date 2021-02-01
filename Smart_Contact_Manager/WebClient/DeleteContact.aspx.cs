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
    public partial class DeleteContact : System.Web.UI.Page
    {
        ContactServiceClient contactProxy;
        GroupServiceClient groupProxy;
        int UserId, ContactId;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserID"] == null)
            {
                this.Context.Items.Add("ErrorMessage", "Access Denied! Please Login");
                Server.Transfer("~/Login.aspx");
            }
            contactProxy = new ContactServiceClient();
            ContactId = Int32.Parse(Request.QueryString["ContactId"]);
            UserId = Int32.Parse(Session["UserId"].ToString());
            var contact = new Contact1();
            contact.UserId = UserId;
            contact.ContactId = ContactId;
            var fetchedContact = ((IContactService)contactProxy).GetContact(contact);
            if (fetchedContact.UserId != UserId)
            {
                Response.Redirect("~/AccessDenied.aspx");
            }
            ContactData.Text = "Name :- " + fetchedContact.Name +
                            "<br>Phone number :- " + fetchedContact.PhoneNumber +
                            "<br>Email :- " + fetchedContact.Email +
                            "<br>Description :- " + fetchedContact.Description;
        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            var contact = new Contact1();
            contact.ContactId = ContactId;
            ((IContactService)contactProxy).DeleteContact(contact);
            groupProxy = new GroupServiceClient();
            GroupContact1 groupContact = new GroupContact1();
            groupContact.ContactId = ContactId;
            ((IGroupService)groupProxy).DeleteGroupContactByContactId(groupContact);
            Response.Redirect("~/ContactList.aspx");
        }

        protected void CancelButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ViewContact.aspx?ContactId=" + ContactId);
        }
    }
}