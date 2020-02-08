<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="TraineeApp.WebForm1" %>


<asp:Content ID="traineeData" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jambotran">
    <asp:Label ID="label1" runat="server" Text="enter trainee id"></asp:Label>
    <br />
    <asp:TextBox ID="text1" runat="server" ></asp:TextBox>
    <br />
    <asp:Label ID="label2" runat="server" Text="enter name"></asp:Label>
    <br />
    <asp:TextBox ID="Text2" runat="server" ></asp:TextBox>
    <br />
    <asp:Label ID="label3" runat="server" Text="enter trainee location"></asp:Label>
    <br />
    <asp:TextBox ID="Text3" runat="server" ></asp:TextBox>
    <br />
    <asp:Label ID="label4" runat="server" Text="enter trainee techdomain"></asp:Label>
    <br />
    <asp:TextBox ID="Text4" runat="server" ></asp:TextBox>
    <br />
    <asp:Label ID="label5" runat="server" Text="enter trainee startdate"></asp:Label>
    <br />
    <asp:TextBox ID="text5" runat="server" ></asp:TextBox>
    <br />
    <asp:Button runat="server" OnClick="Butt_submit" Text="submit" />
</div>
    <div class="jumbotran">
    <asp:Label ID="displaylabel" runat="server"></asp:Label>
</div>
</asp:Content>
    
