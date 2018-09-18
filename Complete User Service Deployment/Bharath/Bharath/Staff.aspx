<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Staff.aspx.cs" Inherits="Bharath.Staff" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<asp:Button ID="logoutbutton" float="right" runat="server" Text="Logout" CssClass="btn btn-primary" OnClick="Logout"  />
    <div class="jumbotron">
        <h1>Welcome <asp:Label ID="username" runat="server"></asp:Label></h1>
        <h3>This is a staff page where the staff can view all the <strong>Users</strong> only</h3>
    </div>
    <div ID="userdiv"  runat="server">
        
    </div>
    <asp:Label ID="status" runat="server" Text="" Visible="false"></asp:Label>
</asp:Content>