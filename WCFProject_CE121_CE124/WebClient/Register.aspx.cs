using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebClient
{
    public partial class Register : System.Web.UI.Page
    {
        AccountServiceReference.AccountServiceClient proxy;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            try
            {
                proxy = new AccountServiceReference.AccountServiceClient("BasicHttpBinding_IAccountService");
                AccountServiceReference.User user = new WebClient.AccountServiceReference.User();
                user.Email = Email.Text;
                user.Password = Password.Text;
                user.PhoneNumber = PhoneNumber.Text;
                user.Name = Name.Text;
                WebClient.AccountServiceReference.User fetchedUser = ((AccountServiceReference.IAccountService)proxy).Register(user);
                if (fetchedUser.Email == null)
                {
                    ErrorMessage.Text = "Error occured while Registration. (Username is might be taken)";
                    return;
                }
                this.Context.Items.Add("SuccessMessage", "Registered Successfully..! Please Login");
                Server.Transfer("/Login.aspx", true);
            }
            catch (System.ServiceModel.CommunicationException)
            {
                proxy = new AccountServiceReference.AccountServiceClient("BasicHttpBinding_IAccountService");
                Server.Transfer("~/Dashboard.aspx");
            }
        }
    }
}