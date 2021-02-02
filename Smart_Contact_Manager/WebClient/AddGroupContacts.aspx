<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddGroupContacts.aspx.cs" Inherits="WebClient.AddGroupContacts" MasterPageFile="~/Site.Master" %>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <form runat="server">
        <br />
        <h2 class="text-center font-weight-bold text-dark">
            <asp:Label ID="GroupName" Text="" runat="server"></asp:Label>
        </h2>
        <br />
        <div class="row">
            <div class="col-sm-3"></div>

            <div class="col-sm-6">
                <div class="card">
                    <div class="card-header text-center">
                        <h4 class="text-primary">Add Contacts</h4>
                    </div>
                    <div class="card-body">
                        <asp:ListBox ID="GroupContacts" runat="server" CssClass="form-group"
                            Width="100%" Rows="10" SelectionMode="Multiple"></asp:ListBox>
                        <div class="form-group">
                            <asp:Button runat="server" ID="SubmitButton" Text="Add" CssClass="btn btn-primary btn-block" OnClick="SubmitButton_Click" />
                        </div>
                    </div>
                </div>
            </div>

            <div class="col-sm-3"></div>
        </div>
    </form>
    <br /><br />
</asp:Content>
