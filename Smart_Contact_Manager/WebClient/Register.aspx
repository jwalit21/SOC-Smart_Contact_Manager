<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" MasterPageFile="~/Site.Master" Inherits="WebClient.Register" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div style="margin-top: 5%">
        <div class="row">
            <div class="col-sm-3"></div>
            <div class="col-sm-6">
                <div class="card">
                    <div class="card-header bg-dark text-light text-center font-weight-bold">
                        Register
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
                                            placeholder="Enter Name" CssClass="form-control" ID="Name">
                                        </asp:TextBox>
                                    </div>
                                </div>

                                <div class="form-group row">
                                    <div class="col-md-6">
                                        <label class="label">Email (Username)</label>
                                        <div class="input-group">
                                            <asp:TextBox runat="server" TextMode="Email"
                                                placeholder="Enter Email" CssClass="form-control" ID="Email">
                                            </asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="col-md-6">
                                        <label class="label">Contact Number</label>
                                        <div class="input-group">
                                            <asp:TextBox runat="server" TextMode="Phone"
                                                placeholder="Enter contact Number" CssClass="form-control" ID="PhoneNumber">
                                            </asp:TextBox>
                                        </div>
                                    </div>
                                </div>

                                <div class="form-group row">
                                    <div class="col-md-6">
                                        <label class="label">Password</label>
                                        <div class="input-group">
                                            <asp:TextBox runat="server" TextMode="Password"
                                                placeholder="Enter Password" CssClass="form-control" ID="Password">
                                            </asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="col-md-6">
                                        <label class="label">Confirm Password</label>
                                        <div class="input-group">
                                            <asp:TextBox runat="server" TextMode="Password"
                                                placeholder="Enter Password again" CssClass="form-control" ID="ConfirmPassword">
                                            </asp:TextBox>
                                        </div>
                                    </div>
                                </div>

                                <div class="form-group pt-3 text-center">
                                    <asp:Button CssClass="btn btn-dark submit-btn btn-group-sm pl-md-5 pr-md-5" ID="SubmitButton" Text="Register" runat="server" OnClick="SubmitButton_Click"></asp:Button>
                                </div>

                                <div class="text-block text-center my-3">
                                    <span class="text-small font-weight-semibold">Already a member ?</span>
                                    <a href="Login.aspx" class="text-black text-small">Login</a>
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
