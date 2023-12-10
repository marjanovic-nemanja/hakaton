<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site-loggedin.Master" CodeBehind="Guides.aspx.cs" Inherits="WebApplication1.Profile.Guides" %>

<asp:Content ContentPlaceHolderID="MainContent" ID="MainContent" runat="server">
                   
    <section class="all-section">
        <asp:Button ID="Button1" runat="server" Text="Log Out" OnClick="Button1_Click" CssClass="filter-btn" />
        
    <button type="button" class="filter-btn" data-bs-toggle="modal" data-bs-target="#modalFilters"><img src="../Content/Images/filter.png" /> Filter</button>
    
        <!-- Modal -->
  <div class="modal fade" id="modalFilters" role="dialog">
    <div class="modal-dialog">
   
      <!-- Modal content-->
      <div class="modal-content">
        <div class="modal-header">
          <button type="button" class="close" data-dismiss="modal">&times;</button>
          <h4 class="modal-title">Filters</h4>
        </div>
        <div class="modal-body">
             <p>Country</p>
                <asp:DropDownList ID="ddlDrzava" class="btn btn-light btn-lg" runat="server">
   
</asp:DropDownList>
            <p>Interests</p>
            <asp:RadioButton ID="rbParty" runat="server" GroupName="radioButtoni" Text="Party"/>
            <asp:RadioButton ID="rbNature" runat="server" GroupName="radioButtoni" Text="Nature"/>
            <asp:RadioButton ID="rbScience" runat="server" GroupName="radioButtoni" Text="Science"/>
            <asp:RadioButton ID="rbHistory" runat="server" GroupName="radioButtoni" Text="History"/>
            <asp:RadioButton ID="rbSport" runat="server" GroupName="radioButtoni" Text="Sport"/>

        </div>
        <div class="modal-footer">
          <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
          <asp:Button ID="btnSearch" name="btnSearch" runat="server" class="btn" Text="Search" OnClick="btnSearch_Click" />
        </div>
      </div>
     
    </div>
  </div>
         
         <asp:Panel ID="guide" CssClass="guide-content" runat="server">
            </asp:Panel>
        
            
        


</section>

</asp:Content>

