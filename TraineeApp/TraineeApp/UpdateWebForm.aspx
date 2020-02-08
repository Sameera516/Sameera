<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UpdateWebForm.aspx.cs" Inherits="TraineeApp.UpdateWebForm" %>
<asp:Content ID="Updatedata" ContentPlaceHolderID="MainContent" runat="server">
    <
    <asp:Label ID="label1" Text="enter ID" runat="server"></asp:Label>
    <br />
    <asp:TextBox ID="text1" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="label2" Text="enter domain" runat="server"></asp:Label>
    <br />
    <asp:TextBox ID="Domain" runat="server" ></asp:TextBox>
    <br />
    <asp:Button ID="Button1" runat="server" Text="Update" OnClick="UPdate_ButtonSubmit" />
   
</asp:Content>