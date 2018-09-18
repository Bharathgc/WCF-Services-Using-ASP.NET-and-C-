<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Manager.aspx.cs" Inherits="Bharath.Manager" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<asp:Button ID="logoutbutton" float="right" runat="server" Text="Logout" CssClass="btn btn-primary" OnClick="Logout"  />
    <div class="jumbotron">
        <h1>Welcome <asp:Label ID="username" runat="server"></asp:Label></h1>
        <h3>This is a Manager page where the manager can view all the  details of all <strong>Users and Staff</strong> including the password</h3>
    </div>
    <div ID="managerdiv"  runat="server">
        
    </div>
    <asp:Label ID="status" runat="server" Text="" Visible="false"></asp:Label>
</asp:Content>
