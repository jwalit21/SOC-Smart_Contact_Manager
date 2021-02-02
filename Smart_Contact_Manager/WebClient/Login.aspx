<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" MasterPageFile="~/Site.Master" Inherits="WebClient.Login" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div style="margin-top: 5%">
        <div class="row">
            <div class="col-sm-3"></div>
            <div class="col-sm-6">
                <div class="card">
                    <div class="card-header bg-dark text-light text-center font-weight-bold">
                        Login
                    </div>
                    <div class="card-body">
                        <div class="auto-form-wrapper">
                            <form runat="server">

                                <div class="mb-3 row">
                                    <div class="text-success text-center font-weight-bold col-sm-12">
                                        <asp:Label ID="SuccessMessage" runat="server" Text=""></asp:Label>
                                    </div>

                                    <div class="text-danger text-center font-weight-bold col-sm-12">
                                        <asp:Label ID="ErrorMessage" runat="server" Text=""></asp:Label>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="label">Email</label>
                                    <div class="input-group">
                                        <asp:TextBox runat="server" TextMode="Email"
                                            placeholder="Enter Email" CssClass="form-control" ID="Email">
                                        </asp:TextBox>

                                    </div>
                                </div>
                                <div class="form-group">
                                    <label class="label">Password</label>
                                    <div class="input-group">
                                        <asp:TextBox runat="server" TextMode="Password"
                                            placeholder="Enter Password" CssClass="form-control" ID="Password">
                                        </asp:TextBox>

                                    </div>
                                </div>
                                <div class="form-group pt-3 text-center">
                                    <asp:Button CssClass="btn btn-dark submit-btn btn-group-sm pl-md-5 pr-md-5" ID="SubmitButton" Text="Login" runat="server" OnClick="SubmitButton_Click1"></asp:Button>
                                </div>
                                <!--
                                <div class="text-block text-center">
                                    <a href="#" class="text-small forgot-password text-black">Forgot Password</a>
                                </div>-->
                                <div class="text-block text-center mb-3">
                                    <span class="text-small font-weight-semibold">Not a member ?</span>
                                    <a href="/Register.aspx" class="text-black text-small">Create new account</a>
                                </div>
                            </form>
                        </div>

                    </div>
                </div>
            </div>
            <div class="col-sm-3"></div>
        </div>
    </div>
</asp:Content>
