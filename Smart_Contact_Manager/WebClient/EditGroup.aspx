<%--  --%>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditGroup.aspx.cs" Inherits="WebClient.EditGroup" MasterPageFile="~/Site.Master" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div style="margin-top: 5%">
        <div class="row">
            <div class="col-sm-3"></div>
            <div class="col-sm-6">
                <div class="card">
                    <div class="card-header text-center text-light font-weight-bold mb-4 bg-dark">
                        Edit Group
                    </div>
                    <div class="card-body">
                        <div class="auto-form-wrapper">
                            <form runat="server">
                                <div class="mb-3 row">
                                    <div class="text-danger text-center font-weight-bold col-sm-12">

                                        <asp:Label ID="ErrorMessage" runat="server" Text=""></asp:Label>

                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="label">Name</label>
                                    <div class="input-group">
                                        <asp:TextBox runat="server"
                                            placeholder="Enter Group Name" CssClass="form-control" ID="Name">
                                        </asp:TextBox>

                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="label">Description</label>
                                    <div class="input-group">
                                        <asp:TextBox runat="server" TextMode="MultiLine"
                                            placeholder="Enter Description" Rows="3" CssClass="form-control" ID="Description">
                                        </asp:TextBox>

                                    </div>
                                </div>
                                <div class="form-group">
                                    <asp:Button ID="SubmitButton" CssClass="btn btn-dark submit-btn btn-block" Text="Update" runat="server" OnClick="SubmitButton_Click"></asp:Button>
                                </div>
                            </form>
                        </div>

                    </div>
                </div>
            </div>
            <div class="col-sm-3"></div>
        </div>
    </div>
    <br />
    <br />
</asp:Content>
