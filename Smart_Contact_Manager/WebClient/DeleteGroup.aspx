<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeleteGroup.aspx.cs" Inherits="WebClient.DeleteGroup" MasterPageFile="~/Site.Master" %>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <form style="margin-top: 5%" runat="server">
        <div class="row justify-content-center">
            <div class="jumbotron">
                <h4 class="text-danger">Are you Sure You want to delete this Group ?</h4>
                <asp:Label ID="GrpData" runat="server" Text=""></asp:Label>
                <br />
                <div class="float-right">
                    <asp:Button CssClass="btn  btn-danger" runat="server" ID="SubmitButton" Text="Delete" OnClick="SubmitButton_Click" />
                    <asp:Button CssClass="btn  btn-secondary" runat="server" ID="CancelButton" Text="Cancel" OnClick="CancelButton_Click" />
                </div>
            </div>
        </div>
    </form>
</asp:Content>
