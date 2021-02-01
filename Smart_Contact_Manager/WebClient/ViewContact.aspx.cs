using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebClient.ContactServiceReference;

namespace WebClient
{
    public partial class ViewContact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserID"] == null)
            {
                this.Context.Items.Add("ErrorMessage", "Access Denied! Please Login");
                Server.Transfer("~/Login.aspx");
            }
            int ContactId = Int32.Parse(Request.QueryString["ContactId"]);
            var UserId = Int32.Parse(Session["UserId"].ToString());
            var proxy = new ContactServiceClient();
            var contact = new Contact1();
            contact.UserId = UserId;
            contact.ContactId = ContactId;

            var fetchedContact = ((IContactService)proxy).GetContact(contact);
            if (fetchedContact.UserId != UserId)
            {
                Response.Redirect("~/AccessDenied.aspx");
            }
            if(fetchedContact.ContactId == 0)
            {
                Response.Redirect("~/404.aspx");
            }
            Name.Text = fetchedContact.Name;
            PhoneNumber.Text = fetchedContact.PhoneNumber;
            Description.Text = fetchedContact.Description;
            Email.Text = fetchedContact.Email;
            EditContactLink.NavigateUrl = "EditContact.aspx?ContactId=" + ContactId;
            DeleteContactLink.NavigateUrl = "DeleteContact.aspx?ContactId=" + ContactId;
        }
    }
}