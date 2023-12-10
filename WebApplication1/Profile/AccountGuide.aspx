<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site-loggedin.Master" AutoEventWireup="true" CodeBehind="AccountGuide.aspx.cs" Inherits="WebApplication1._Default" %>

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
            <input type="text" id="nameAcg" placeholder="First Name" class="input-log" runat="server"/>
            <input type="email" id="emailAcg" placeholder="Email" class="input-log" runat="server"/>
            <input type="text" id="drzavaAcg" placeholder="Country" class="input-log" runat="server"/>
            <input type="password" id="passAcg" placeholder="Password" class="input-log" runat="server"/>
            <input type="text" id="interestAcg" placeholder="Interest" class="input-log" runat="server"/>
            <input type="number" id="priceAcg" class="input-log" runat="server" />
            <asp:Button ID="btnSaveAcg" runat="server" Text="Save" CssClass="cta-btn cta-sign" />
        </div>
    </section>
</asp:Content>
