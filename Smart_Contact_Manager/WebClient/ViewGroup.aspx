<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewGroup.aspx.cs" Inherits="WebClient.ViewGroup" MasterPageFile="~/Site.Master" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent">
    <br />
    <h3 class="text-center">
        <asp:Label runat="server" Text="" CssClass="text-dark font-weight-bold" ID="GroupName"></asp:Label></h3>
    <br />
    <h4 class="text-center">
        <asp:Label Text="" runat="server" CssClass="text-dark" ID="GrpDesc"></asp:Label>
    </h4>
    <br />
    <div class="row">
                <div class="col-sm-4">
                    <a href="#" class="btn btn-primary">Add New Contacts</a>
                </div>
                <div class="col-sm-4"></div>
                <div class="col-sm-4">
                    <a href="#" class="btn btn-danger">Delete This Group</a>
                </div>
            </div>  
    <br />
    <div class="card">
        <div class="card-body">
            
            <br />
            <div class="row">
                <div class="table mt-2 table-responsive" role="grid">
                    <asp:Table runat="server" ID="GroupContacList" CssClass="table my-0">
                        <asp:TableHeaderRow>
                            <asp:TableHeaderCell>#</asp:TableHeaderCell>
                            <asp:TableHeaderCell>Name</asp:TableHeaderCell>
                            <asp:TableHeaderCell>Contact Number</asp:TableHeaderCell>
                            <asp:TableHeaderCell></asp:TableHeaderCell>
                        </asp:TableHeaderRow>
                    </asp:Table>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
