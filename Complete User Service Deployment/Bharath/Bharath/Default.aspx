<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Bharath._Default" %>

<%@ Register TagPrefix="LoginControl" TagName="Login" Src="~/Login.ascx" %>
<%@ Register  TagPrefix="RegisterControl" TagName="Register" Src="~/Register.ascx" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Welcome to the Trip guide application</h1>
        <h3>Plesae Login/Signup to start using our services </h3>
    </div>
    <div class="row">
        <div class="col-md-6">
            <LoginControl:Login ID="Login" runat="server" />
        </div>
        <div class="col-md-6">
            <RegisterControl:Register ID="Register" runat="server" />
        </div>
    </div>
</asp:Content>
