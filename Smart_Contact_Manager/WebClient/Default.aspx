<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" MasterPageFile="~/Site.Master" Inherits="WebClient.Default" %>
  
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

<div style="margin-top:10%">
    <div class="row">
        <div class="col-sm-3"></div>
        <div class="col-sm-6">
            <div class="card">
                <div class="card-body">
                    <form runat="server">
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
                          <div class="col-12 justify-content-center">
                            <button class="btn btn-primary" type="submit">Submit form</button>
                          </div>
                    </form>
                </div>
            </div>
        </div>
        <div class="col-sm-3"></div>
    </div>
</div>
</asp:Content>