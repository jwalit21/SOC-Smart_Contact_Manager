<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" MasterPageFile="~/Site.Master" Inherits="WebClient.Login" %>
  
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

<div style="margin-top:10%">
    <div class="row">
        <div class="col-sm-3"></div>
        <div class="col-sm-6">
            <div class="card">
                <div class="card-header text-center">
                    <h2 class="text-dark">Login</h2>
                </div>
                <div class="card-body">
                    <form runat="server">
                        <div class="mb-3 row">
                            <div class="text-danger col-sm-12">
                                
                                <asp:Label ID="ErrorMessage" runat="server" Text=""></asp:Label>
                                
                            </div>
                        </div>
                        <div class="mb-3 row">
                            <label for="Email" class="col-sm-3 col-form-label">Email</label>
                            <div class="col-sm-9">
                              <asp:TextBox runat="server" TextMode="Email" 
                                  placeholder="Enter Email" CssClass="form-control" ID="Email" >
                              </asp:TextBox>
                            </div>
                          </div>
                          <div class="mb-3 row">
                            <label for="Password" class="col-sm-3 col-form-label">Password</label>
                            <div class="col-sm-9">
                              <asp:TextBox runat="server" TextMode="Password" 
                                  placeholder="Enter Password" CssClass="form-control" ID="Password" >
                              </asp:TextBox>
                            </div>
                          </div>
                          <br />
                          <div class="mb-3 row">
                            <label class="col-sm-3 col-form-label"></label>
                            <div class="col-sm-9">
                              <asp:Button ID="SubmitButton" CssClass="btn btn-primary btn-lg" runat="server" Text="Login" OnClick="SubmitButton_Click1"></asp:Button>
                            </div>
                          </div>
                    </form>
                </div>
            </div>
        </div>
        <div class="col-sm-3"></div>
    </div>
</div>
</asp:Content>