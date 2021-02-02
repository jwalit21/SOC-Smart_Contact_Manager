using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebClient.ContactServiceReference;

namespace WebClient
{
    public partial class NewContact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserID"] == null)
            {
                this.Context.Items.Add("ErrorMessage", "Access Denied! Please Login");
                Server.Transfer("~/Login.aspx");
            }
        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            ContactServiceReference.ContactServiceClient proxy = new ContactServiceReference.ContactServiceClient();
            Contact1 contact = new Contact1();
            contact.Email = Email.Text;
            contact.Name = Name.Text;
            contact.PhoneNumber = PhoneNumber.Text;
            contact.Description = Description.Text;
            contact.PhotoPath = "";
            contact.UserId = Int32.Parse(Session["UserId"].ToString());
            var fetchedContact = ((IContactService)proxy).AddContact(contact);
            if (fetchedContact.UserId == 0)
            {
                ErrorMessage.Text = "Contact number is already added";
                return;
            }
            Response.Redirect("ContactList.aspx");
        }
    }
}