<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewContact.aspx.cs" Inherits="WebClient.ViewContact" MasterPageFile="~/Site.Master"%>

<asp:Content runat="server" ContentPlaceHolderID="MainContent">
    <br />
    <div class="card w-75 ml-auto mr-auto">
        <div class="card-header font-weight-bold">
            <asp:Label runat="server" ID="Name"></asp:Label>
        </div>
        <div class="card-body">
            <div class="row">
                <div class="col-sm-12">
                    Contact Number : 
                    <asp:Label runat="server" ID="PhoneNumber"></asp:Label>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-12">
                    Email : 
                    <asp:Label runat="server" ID="Email"></asp:Label>
                </div>
            </div>
            <div class="row">
                <div class="col-sm-12">
                    Description : 
                    <asp:Label runat="server" ID="Description"></asp:Label>
                </div>
            </div>
            <br />
        </div>
        <div class="card-footer">
            <div class="row">
                <div class="col-12 float-left">
                    <asp:HyperLink CssClass="btn btn-primary" ID="EditContactLink" runat="server">Edit</asp:HyperLink>

                    <asp:HyperLink CssClass="btn btn-danger" ID="DeleteContactLink" runat="server">Delete</asp:HyperLink>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
