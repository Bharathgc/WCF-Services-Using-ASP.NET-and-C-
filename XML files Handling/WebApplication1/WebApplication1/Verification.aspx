<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Verification.aspx.cs" Inherits="WebApplication1.Verification" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Verification Services</h1>
        <p class="lead">This service takes url of the xml file and the url of schema file as input and gives verification result of the cml file against schema</p>
        <p>The XML files are stored in my github repository and also are submitted along this project. You can also use your own xml and schema files</p>
        <p>URL for Schema File      : https://raw.githubusercontent.com/Bharathgc/xmlfiles/master/Persons.xsd</p>
        <p>URL for XML file         : https://raw.githubusercontent.com/Bharathgc/xmlfiles/master/Persons.xml</p>
        <p>URL for error XML file   : https://raw.githubusercontent.com/Bharathgc/xmlfiles/master/Persons_error.xml</p>
    </div>
    <h3> Enter URL for Schema file: </h3>
        <asp:TextBox ID="schmeafiletextbox" runat ="server" Width ="200px"></asp:TextBox>
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <h3> Enter URL for XML file: </h3>
    <asp:TextBox ID="xmlfiletextbox" runat ="server" Width ="200px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;   
    <asp:Button ID="verifybutton" runat="server" OnClick="GetVerification" Text ="Verify"  />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
     <br /><br /><br />
    <p>
        Result :
        <asp:Label ID="resultlabel" runat="server" Font-Bold="true"></asp:Label>
        </p>
    <br />    
</asp:Content>