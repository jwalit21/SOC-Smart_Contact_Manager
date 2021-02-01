<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ContactList.aspx.cs" Inherits="WebClient.ContactList" MasterPageFile="~/Site.Master"%>

<asp:Content ID="content" ContentPlaceHolderID="MainContent" runat="server">
    <br /><br />

    <div class="row mb-3">
        <div class="col-12 float-right">
            <asp:HyperLink CssClass="btn btn-primary" ID="CreateContactLink" runat="server">Add new Contact</asp:HyperLink>
        </div>
    </div>

    <div class="card">
        <div class="card-header text-center text-light font-weight-bold mb-4 bg-dark">
             My Contacts
        </div>
        <div class="card-body">
            <div class="table mt-2 table-responsive" role="grid">
                <asp:Table runat="server" ID="ContactsList" CssClass="table my-0">
                    <asp:TableHeaderRow>
                        <asp:TableHeaderCell>#</asp:TableHeaderCell>
                        <asp:TableHeaderCell>Contact Name</asp:TableHeaderCell>
                        <asp:TableHeaderCell>Contact Number</asp:TableHeaderCell>
                        <asp:TableHeaderCell></asp:TableHeaderCell>
                        <asp:TableHeaderCell></asp:TableHeaderCell>
                    </asp:TableHeaderRow>
                </asp:Table>
            </div>
        </div>
        
    <br /><br /><br /><br /><br />
    </div>
</asp:Content>
