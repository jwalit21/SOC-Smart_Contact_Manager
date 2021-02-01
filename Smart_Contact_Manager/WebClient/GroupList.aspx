<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GroupList.aspx.cs" Inherits="WebClient.GroupList" MasterPageFile="~/Site.Master" %>

<asp:Content ID="content" ContentPlaceHolderID="MainContent" runat="server">
    <br /><br />
    <h3 class="text-center text-dark font-weight-bold mb-4">My Groups</h3>
    <div class="card">
        <div class="card-body">
            <div class="table mt-2 table-responsive" role="grid">
                <asp:Table runat="server" ID="GroupsList" CssClass="table my-0">
                    <asp:TableHeaderRow>
                        <asp:TableHeaderCell>#</asp:TableHeaderCell>
                        <asp:TableHeaderCell>Group Name</asp:TableHeaderCell>
                        <asp:TableHeaderCell>Group Description</asp:TableHeaderCell>
                        <asp:TableHeaderCell></asp:TableHeaderCell>
                        <asp:TableHeaderCell></asp:TableHeaderCell>
                    </asp:TableHeaderRow>
                    
                </asp:Table>
            </div>
        </div>
        
    <br /><br /><br /><br /><br />
    </div>
</asp:Content>
