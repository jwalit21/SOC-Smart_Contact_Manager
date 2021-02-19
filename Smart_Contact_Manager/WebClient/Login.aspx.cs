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
        WebClient.AccountServiceReference.AccountServiceClient proxy;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                if (Session["UserID"] != null)
                {
                    this.Context.Items.Add("ErrorMessage", "Access Denied! Please Login");
                    Response.Redirect("~/Dashboard.aspx");
                }
                string Success_Message = (string)this.Context.Items["SuccessMessage"];
                string Error_Message = (string)this.Context.Items["ErrorMessage"];
                if (Success_Message != null)
                {
                    SuccessMessage.Visible = true;
                    SuccessMessage.Text = Success_Message;
                    this.Context.Items.Remove("SuccessMessage");
                    ErrorMessage.Visible = false;
                }
                if (Error_Message != null)
                {
                    ErrorMessage.Visible = true;
                    ErrorMessage.Text = Error_Message;
                    this.Context.Items.Remove("ErrorMessage");
                    SuccessMessage.Visible = false;
                }
            }
        }

        protected void SubmitButton_Click1(object sender, EventArgs e)
        {
            try
            {
                proxy = new AccountServiceReference.AccountServiceClient("BasicHttpBinding_IAccountService");
                AccountServiceReference.User user = new WebClient.AccountServiceReference.User();
                user.Email = Email.Text;
                user.Password = Password.Text;
                WebClient.AccountServiceReference.User fetchedUser = ((AccountServiceReference.IAccountService)proxy).Login(user);
                if (fetchedUser.UserId == 0)
                {
                    SuccessMessage.Visible = false;
                    ErrorMessage.Visible = true;
                    ErrorMessage.Text = "Invalid Email or Password!!!";
                    return;
                }
                Session["UserID"] = fetchedUser.UserId;
                Response.Redirect("~/Dashboard.aspx");
            }
            catch (System.ServiceModel.CommunicationException)
            {
                proxy = new AccountServiceReference.AccountServiceClient("BasicHttpBinding_IAccountService");
                Server.Transfer("~/Dashboard.aspx");
            }
        }
    }
}