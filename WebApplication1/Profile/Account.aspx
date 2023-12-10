<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site-loggedin.Master" AutoEventWireup="true" CodeBehind="Account.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        .isLogged {
            background: transparent !important;
        }
        nav ul li a {
            padding: 12px 30px 10px 30px !important;
            height: 100% !important;
        }

    </style>

    <section class="all-sections profile">
        <div class="left-account">
            <img src="../Content/Images/user.png" />
        </div>
        <div class="right-account">
            <input type="text" id="nameAcc" placeholder="First Name" class="input-log" runat="server"/>
            <input type="email" id="emailAcc" placeholder="Email" class="input-log" runat="server"/>
            <input type="text" id="drzavaAcc" placeholder="Country" class="input-log" runat="server"/>
            <input type="password" id="passAcc" placeholder="Password" class="input-log" runat="server"/>
            <asp:Button ID="btnSave" runat="server" Text="Save" CssClass="cta-btn cta-sign" OnClick="" />
        </div>
    </section>
</asp:Content>
