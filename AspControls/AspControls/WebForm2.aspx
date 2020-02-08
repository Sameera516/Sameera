<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="AspControls.WebForm2" %>

<asp:Content ID="id111" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotran">
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" Text="enter name" runat="server" ValidationGroup="vg" ForeColor="#FF3300" ControlToValidate="TextBox1"></asp:RequiredFieldValidator>

        <br />
        <asp:TextBox ID="TextBox1" runat="server" ></asp:TextBox>
        <br />
        <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="range must be filled" MaximumValue="18" MinimumValue="100" ForeColor="#FF3300" ControlToValidate="TextBox2">enter age</asp:RangeValidator>
        <br />
        <asp:TextBox ID="TextBox2" runat="server" ValidationGroup="vg"></asp:TextBox>
        <br />
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox3" ErrorMessage="email must be in correct format" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="vg" ForeColor="#FF3300"
>enter emailid</asp:RegularExpressionValidator>
        <br />
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <asp:RequiredFieldValidator ID="RequriedFieldValidator1" runat="server" ControlToValidate="TextBox4" ErrorMessage="must enter password" ValidationGroup="vg" ForeColor="#FF3300">enter password</asp:RequiredFieldValidator>
        <br />
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />
        <asp:CompareValidator ID="CompareVAlidator1" runat="server" ErrorMessage="password must match" ForeColor="#FF3300" ValidationGroup="vg" ControlToCompare="TextBox4" ControlToValidate="TextBox5">confirm password</asp:CompareValidator>
        <br />
        <asp:TextBox ID="TextBox5" runat="server" ValidationGroup="vg"></asp:TextBox>
        <br />
        <asp:ValidationSummary ID="validationsummary1" runat="server" ValidationGroup="vg" />
        <br />
        <asp:Button ID="button1" Text="submit" runat="server" OnClick="Button_onClick" />

        <br />


    </div>
    <div class="jambotran">
        <asp:Label ID="label1" runat="server"></asp:Label>
    </div>

</asp:Content>