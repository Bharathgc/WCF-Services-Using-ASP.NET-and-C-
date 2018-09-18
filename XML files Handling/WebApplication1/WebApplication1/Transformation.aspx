<%@ Page Language="C#"  MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Transformation.aspx.cs" Inherits="WebApplication1.Transformation" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Trasformation Service</h1>
        <p class="lead">This service takes url of the xsl file and the url of xml file as input and returns 2 things </p>
        <p>1. In the project folder @projectfolder\WcfService1\App_Data\Persons.html. THis html file contains the output of in html file format</p>
        <p>2. The table of containing the details mentioned in the xml file</p>
        <p> The url for the xml file :https://raw.githubusercontent.com/Bharathgc/xmlfiles/master/Persons.xml</p>
        <p> The url for the Xsl file : https://raw.githubusercontent.com/Bharathgc/xmlfiles/master/Persons.xsl</p>
        <p> feel free to use your own xsl and xml files.</p>
    </div>
    <h3> Enter URL for Xml file: </h3>
        <asp:TextBox ID="xmlfiletextbox" runat ="server" Width ="200px"></asp:TextBox>
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <h3> Enter URL for XsL file: </h3>
    <asp:TextBox ID="xslfiletextbox" runat ="server" Width ="200px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;   
    <asp:Button ID="Trasnformbutton" runat="server" OnClick="GetTransformation" Text ="Transform"  />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
     <br /><br /><br />
    <p>
        Result :
        <asp:Label ID="resultlabel" runat="server" Font-Bold="true"></asp:Label>
        </p>
    <br />    
</asp:Content>