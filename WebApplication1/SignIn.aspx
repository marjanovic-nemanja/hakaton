<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SignIn.aspx.cs" Inherits="WebApplication1.SignIn1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContentMaster" runat="server">
    <div class="split left">
  <div class="centered">
    <img src="Content/Images/guidemewhitepng.png" />
    <h3>Welcome back</h3>

      <asp:TextBox ID="tbEmail" runat="server" class="input-log" placeholder="Email"></asp:TextBox>
      <asp:TextBox ID="tbPassword" runat="server" class="input-log" placeholder="Password" TextMode="Password"></asp:TextBox>
      <a href="SignUp.aspx">Don't have an account?</a>
     <asp:Button ID="btn_signin" runat="server" Text="Sign In" CssClass="cta-btn cta-sign" OnClick="btn_signin_Click" />
  </div>
</div>

<div class="split right">
</div>
</asp:Content>
