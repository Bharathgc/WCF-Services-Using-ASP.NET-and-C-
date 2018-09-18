<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CrimeData.aspx.cs" Inherits="BharathService.CrimeData" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <div class ="jumbotron">
        <h1>Welcome to CrimeData Services</h1>
        <p>
           This service gives you crime statistics of the given place
        </p>
        </div>
        <div class ="jumbotron">
            <p>Method Name : GetCrimeData</p>
            <p>Parameter   : Double Latitude  Double Longitude</p>
            <p>Returns     : Crime statistics corresponding to those Geo Co-ordinates</p>
            <p>You don't have to worry about the co-ordinates. The method takes place name as input and passes the Geo-cordinates</p>
        </div>

        <h3> Enter Place: </h3>
        <asp:TextBox ID="placetextbox" runat ="server" Width ="200px"></asp:TextBox>
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="distancebutton" runat="server" OnClick="GetCrimedataOfthePlace" Text ="Get Data"  />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br /><br /><br />
        
        <p>
            Voilent Crimes Reported :
            <asp:Label ID="voilentcrimeslabel" runat="server" Font-Bold="true"></asp:Label>
        </p>
    <br />
        <p>
            Property Crimes Reported :
            <asp:Label ID="propertycrimeslabel" runat="server" Font-Bold="true"></asp:Label>
        </p>
        
   
    </asp:Content>