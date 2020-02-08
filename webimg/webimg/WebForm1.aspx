﻿<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="webimg.WebForm1" %>

<asp:Content ID="id123" ContentPlaceHolderID="MainContent" runat="server">
  <div class="jumbotron">
      <asp:FileUpload ID="FileUpload1" runat="server" />
      <br/>
      <br />
      <asp:Button ID="Button1" runat="server" Text="Upload" OnClick="Button1_" />
      <br />
      <br />
      <asp:DataList ID="DataList1" runat="server" RepeatColumns="2">
          <ItemTemplate>
              <asp:Image ID="Image1"
                  ImageUrl='<%# Eval("Name","~/Resources/{0}" )%>'
                  width="350px" Height="350px" runat="server" />
              <br />
              <%# Eval("Name") %>
          </ItemTemplate>
      </asp:DataList>
  </div>


</asp:Content>