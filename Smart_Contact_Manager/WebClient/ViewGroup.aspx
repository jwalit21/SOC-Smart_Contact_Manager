<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewGroup.aspx.cs" Inherits="WebClient.ViewGroup" MasterPageFile="~/Site.Master" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent">
    <br /><br />
    <div class="container">
        <div class="row">
            <div class="col-12 float-right" style="text-align:right">
                <asp:HyperLink CssClass="btn btn-primary" ID="AddContactLink" runat="server">Add New Contacts</asp:HyperLink>

                <asp:HyperLink CssClass="btn btn-danger" ID="DeleteGroupLink" runat="server">Delete This Group</asp:HyperLink>
            </div>
        </div>
        <br />
        <div class="card">
            <div class="card-header">
                <h3 class="text-center">
                    <asp:Label runat="server" Text="" CssClass="text-dark font-weight-bold" ID="GroupName"></asp:Label></h3>
                <br />
                <h5 class="text-center">
                    <asp:Label Text="" runat="server" CssClass="text-dark text-muted" ID="GrpDesc"></asp:Label>
                </h5>
            </div>
            <br />
            <div class="card-body">
                <div class="row">
                    <div class="table mt-2 table-responsive" role="grid">
                        <asp:Table runat="server" ID="GroupContacList" CssClass="table my-0">
                            <asp:TableHeaderRow>
                                <asp:TableHeaderCell>#</asp:TableHeaderCell>
                                <asp:TableHeaderCell>Name</asp:TableHeaderCell>
                                <asp:TableHeaderCell>Contact Number</asp:TableHeaderCell>
                                <asp:TableHeaderCell></asp:TableHeaderCell>
                                <asp:TableHeaderCell></asp:TableHeaderCell>
                            </asp:TableHeaderRow>
                        </asp:Table>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
