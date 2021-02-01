using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebClient
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SubmitButton_Click1(object sender, EventArgs e)
        {
            WebClient.AccountServiceReference.AccountServiceClient proxy = new AccountServiceReference.AccountServiceClient("BasicHttpBinding_IAccountService");
            AccountServiceReference.User user = new WebClient.AccountServiceReference.User();
            user.Email = Email.Text;
            user.Password = Password.Text;
            WebClient.AccountServiceReference.User fetchedUser = ((AccountServiceReference.IAccountService)proxy).Login(user);
            if (fetchedUser.UserId == 0)
            {
                ErrorMessage.Text = "Invalid Email or Password!!!";
                return;
            }
            Session["UserID"] = fetchedUser.UserId;
            ErrorMessage.Text = Session["UserID"].ToString();
        }
    }
}