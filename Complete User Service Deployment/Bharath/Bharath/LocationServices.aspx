<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LocationServices.aspx.cs" Inherits="Bharath.LocationServices" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <div class ="jumbotron">
        <h1>Welcome to Location Services</h1>
        <p>This service has been implemented using GoogleMaps API services
            <asp:Image ID="locationimage" runat="server" ImageUrl="http://techiesprout.com/wp-content/uploads/2016/05/map-pin-location.jpg" Height ="50" width ="50 "/>
        </p>
        </div>
        <div class ="jumbotron">
            <p>Method Name : GetlocationdetailsAPI</p>
            <p>Parameter   : String Place</p>
            <p>Returns     : Joint string of Latitude,Longitude,Zipcode</p>
        </div>

        <h3> Enter a Place name: </h3>
        <asp:TextBox ID="locationtextbox" runat ="server" Width ="200px"></asp:TextBox>
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="locationbutton" runat="server" OnClick="Getlocationdetails" Text ="Get Details"  />
        &nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <p>
        Location Details are :
        </p>
        <br />
        <p>
            Latitude : 
            <asp:Label ID="latitudelabel" runat="server" Font-Bold ="true"></asp:Label>
        </p>
        <br />
        <p>
            Longitude : 
            <asp:Label ID="longitudelabel" runat="server" Font-Bold ="true"></asp:Label>
        </p>
        <br />
        <p>
            Zip Code : 
            <asp:Label ID="zipcodelabel" runat="server" Font-Bold ="true"></asp:Label>
        </p>
    </asp:Content>