<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Assignment 4 CSE 445</h1>
        <h2> Submitted by: Bharath Gunari</h2>
        <h2> ASU id      : 1213217679</h2>
        <p class="lead">This is a try it page for the the 2 services which are mentioned below. Please refer the links to use the service</p>
    </div>
    <div class="jumbotron">
        <h3>Verfication Service</h3>
        <p class="lead">Please use the link given below to verify the xml file against the schema.</p>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="Verification.aspx">Verification</asp:HyperLink>
    </div>
    <div class="jumbotron">
        <h3>Transformation Serivce</h3>
        <p class="lead">Please use the link given below to obtain the html output from xml and xsl file.</p>
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="Transformation.aspx">Transformation</asp:HyperLink>
    </div>
</asp:Content>
