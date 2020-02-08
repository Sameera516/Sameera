<%@ Page Language="C#"MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebFormData.aspx.cs" Inherits="WebAppDataOperations.WebFormData" %>
<asp:Content ID="mycontent" ContentPlaceHolderID="MainContent" runat="server">
      <div class="jumbotran">
    <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged"></asp:GridView>

    </div>

</asp:Content>