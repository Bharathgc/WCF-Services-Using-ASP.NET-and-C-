<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="Bharath.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
    <h1>Trip guide's Applicatipon Description Page</h1>
       <h2>Welcome.</h2>
        <h3>This page provides a brief description of the services that my web page has to offer. Those are inidvidually listed below</h3>
    <p>1. <strong>Location Service:</strong> Use get the details of a location like Zipcode and Co-ordinates of a plave just by entering thename of the place</p>
    <p>2. <strong>Wind Intensity Service:</strong> You can get the wind intensity of a particular place just by entering the name of the place</p>
    <p>3. <strong>Crime data Service : </strong>This service will give insights of a crimes statistics of a place. It give you voilent and property crimes statistics of given place</p>
    <p>4. <strong>Image Service :</strong> This service will let you look up the images of a particular place</p>
    <p>5. <strong>Distanc Service :</strong> This service will help yo determine the distance between the 2 places. You can just enter the names of 2 places and get to know the distance between them interms of kilometers and miles.</p>
    <p>If you want to try these services please click below</p>
    <a href="Default.aspx">Try IT Page</a>
    </div>
</asp:Content>
