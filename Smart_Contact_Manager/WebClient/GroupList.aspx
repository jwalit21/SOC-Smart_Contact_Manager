<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GroupList.aspx.cs" Inherits="WebClient.GroupList" MasterPageFile="~/Site.Master" %>

<asp:Content ID="content" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <br />
    <div class="container">
        <div class="row mb-3">
            <div class="col-12 float-right" style="text-align:right">
                <asp:HyperLink CssClass="btn btn-primary" ID="CreateContactLink" runat="server" NavigateUrl="~/NewGroup.aspx">Create new Group</asp:HyperLink>
            </div>
        </div>

        <div class="card">
            <div class="card-header text-center text-light font-weight-bold mb-4 bg-dark">
                My Groups
            </div>
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

            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
    </div>
</asp:Content>
