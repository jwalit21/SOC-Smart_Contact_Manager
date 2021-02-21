using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebClient.ContactServiceReference;

namespace WebClient
{
    public partial class EditContact : System.Web.UI.Page
    {
        ContactServiceClient contactProxy;
        int UserId, ContactId;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

                if (Session["UserID"] == null)
                {
                    this.Context.Items.Add("ErrorMessage", "Access Denied! Please Login");
                    Server.Transfer("~/Login.aspx");
                }
                contactProxy = new ContactServiceClient();
                if (Request.QueryString["ContactId"] == null)
                {
                    Response.Redirect("~/404.aspx");
                }
                ContactId = Int32.Parse(Request.QueryString["ContactId"]);
                UserId = Int32.Parse(Session["UserId"].ToString());
                var contact = new Contact1();
                contact.UserId = UserId;
                contact.ContactId = ContactId;
                var fetchedContact = ((IContactService)contactProxy).GetContact(contact);

                if (fetchedContact.ContactId == 0)
                {
                    Response.Redirect("~/404.aspx");
                }
                if (fetchedContact.UserId != UserId)
                {
                    Response.Redirect("~/AccessDenied.aspx");
                }
                ViewState["ContactId"] = ContactId.ToString();
                Name.Text = fetchedContact.Name;
                Description.Text = fetchedContact.Description;
                Email.Text = fetchedContact.Email;
                PhoneNumber.Text = fetchedContact.PhoneNumber;
            }
        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            contactProxy = new ContactServiceClient();
            Contact1 contact = new Contact1();
            contact.ContactId = Int32.Parse(ViewState["ContactId"].ToString());
            contact.Name = Name.Text;
            contact.Description = Description.Text;
            contact.UserId = Int32.Parse(Session["UserId"].ToString());
            contact.PhoneNumber = PhoneNumber.Text;
            contact.Email = Email.Text;
            contact.PhotoPath = "";
            var updatedContact = ((IContactService)contactProxy).UpdateContact(contact);
            if (updatedContact.ContactId == 0)
            {
                ErrorMessage.Text = "Contact is already added.";
                return;
            }
            Response.Redirect("~/ViewContact.aspx?ContactId=" + contact.ContactId);
        }
    }
}