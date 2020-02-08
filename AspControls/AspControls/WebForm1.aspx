<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="AspControls.WebForm1" %>

<asp:Content ID="id122" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">

        <asp:Label ID="Label1" runat="server" Text="Enter name"></asp:Label>
        <br />
        <asp:TextBox ID="TxtName" runat="server" ></asp:TextBox>
        <br />
        <asp:Label ID="LAbel2" runat="server" Text="Enter DOB"></asp:Label>
        <br />
        <asp:Calendar ID="Calender1" runat="server"></asp:Calendar>
        <br />
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" Width="146px">
            <asp:ListItem>Female</asp:ListItem>
            <asp:ListItem>Male</asp:ListItem>
           
        </asp:RadioButtonList>
        <br />
        <asp:Label ID="label4" runat="server" Text="Tick mark Hobbies:"></asp:Label>
        <br />
        <asp:CheckBoxList ID="CheckBocList1" runat="server" >
            <asp:ListItem>Badminton</asp:ListItem>
            <asp:ListItem>singing</asp:ListItem>
            <asp:ListItem>travelling</asp:ListItem>
            <asp:ListItem>reading</asp:ListItem>
        </asp:CheckBoxList>
        <br />
        <asp:Label ID="Label5" runat="server" Text="Education:"></asp:Label>
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server" Width="134px">
            <asp:ListItem>HighSchool</asp:ListItem>
            <asp:ListItem>Secondary</asp:ListItem>
            <asp:ListItem>UG</asp:ListItem>
            <asp:ListItem>PG</asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Button ID="Button1" runat="server" Text="submit" OnClick="Button_OnClick" Width="143px" />
    </div>
    <div class="jumbotron">
        
        <asp:Label ID="lblDisplay" runat="server" Text="output to be displayed"></asp:Label>

    </div>
</asp:Content>
