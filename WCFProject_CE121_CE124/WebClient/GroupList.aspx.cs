using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebClient.GroupServiceReference;

namespace WebClient
{
    public partial class GroupList : System.Web.UI.Page
    {
        GroupServiceClient proxy;
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
                proxy = new GroupServiceClient();
                var groups = ((IGroupService)proxy).GetGroups(UserId);
                for (int i = 0; i < groups.Length; i++)
                {
                    var grpUrl = "ViewGroup.aspx?GroupId=" + groups[i].GroupId;
                    var editUrl = "EditGroup.aspx?GroupId=" + groups[i].GroupId;
                    TableCell seqNo = new TableCell();
                    TableCell grpName = new TableCell();
                    TableCell grpDesc = new TableCell();
                    TableCell button = new TableCell();
                    TableCell editButton = new TableCell();
                    seqNo.Text = "" + (i + 1);
                    grpName.Text = groups[i].Name;
                    grpDesc.Text = groups[i].Description;
                    button.Text = ("<a class='btn btn-primary' href=" + grpUrl + ">View</a>");
                    editButton.Text = ("<a class='btn btn-secondary' href=" + editUrl + ">Edit</a>");
                    TableRow row = new TableRow();
                    row.Cells.Add(seqNo);
                    row.Cells.Add(grpName);
                    row.Cells.Add(grpDesc);
                    row.Cells.Add(button);
                    row.Cells.Add(editButton);
                    GroupsList.Rows.Add(row);
                }
            }
            catch (System.ServiceModel.CommunicationException)
            {
                proxy = new GroupServiceClient();
                Server.Transfer("~/Dashboard.aspx");
            }
        }
    }
}