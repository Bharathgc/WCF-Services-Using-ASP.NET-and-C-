<%@ Page Language="C#" MasterPageFile="~/Site.Master"  AutoEventWireup="true" CodeBehind="WindIntensity.aspx.cs" Inherits="Bharath.WindIntensity" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <div class ="jumbotron">
        <h1>Welcome to Wind Intensity Services</h1>
        <p>
            This service is used to check the Wind Intensity in the given location
        </p>
        </div>
        <div class ="jumbotron">
            <p>Method Name : GetWindIntensity</p>
            <p>Parameter   : String Place1</p>
            <p>Returns     : Distance between place1 and place2 in kilometers</p>
        </div>

        <h3> Enter Place name: </h3>
        <asp:TextBox ID="placetextbox" runat ="server" Width ="200px"></asp:TextBox>
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        
        <asp:Button ID="distancebutton" runat="server" OnClick="GetWindIntensityDetails" Text ="Get WindIntensity"  />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br /><br /><br />
    <p>
        Visibility:
        <asp:Label ID="visibilitylabel" runat="server" Font-Bold="true"></asp:Label>
        </p>
    <br />
      <p>
        The Wind Intensity is :
        <asp:Label ID="windspeedlabel" runat="server" Font-Bold="true"></asp:Label> 
          mps 
        </p>
    <br />  
    <p>
        Direction: 
        <asp:Label ID="directionlabel" runat="server" Font-Bold="true"></asp:Label>
        </p>
    <br />
        
   
    </asp:Content>
