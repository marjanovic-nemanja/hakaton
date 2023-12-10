<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="WebApplication1.SignUp1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContentMaster" runat="server">
        <div class="split left">
  <div class="centered">
    <img src="Content/Images/guidemewhitepng.png" />
    <h3>Welcome</h3>
       <asp:TextBox ID="tbIme" runat="server" class="input-log" placeholder="First Name"></asp:TextBox>
       <asp:TextBox ID="tbPrezime" runat="server" class="input-log" placeholder="Last Name"></asp:TextBox>
       <asp:TextBox ID="tbEmail" runat="server" class="input-log" placeholder="Email"></asp:TextBox>
       <asp:TextBox ID="tbSifra" runat="server" class="input-log" placeholder="Password" TextMode="Password"></asp:TextBox>
    <a href="SignIn.aspx">Already registered?</a>
    <asp:Button ID="btn_signup" runat="server" Text="Sign Up" CssClass="cta-btn cta-sign" OnClick="btn_signup_Click" />
  </div>
</div>

<div class="split right">
</div>
</asp:Content>
