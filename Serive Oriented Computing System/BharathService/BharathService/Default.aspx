<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BharathService._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>CSE 445 Distributed Software Development</h1>
        <h3>Submitted by : Gunari Bharath Chandrashekar</h3>
        <h3>ASU ID : 1213217679</h3>
        <p class="lead">Assignment 3. Please refer to the services below and click on the hyper links to use the service</p>
        <p>The 2 Required services implemented are WindIntensity Service and CrimeData Service </p>
        <p>Other Services are Location Details , Distance Services and Image Services</p>
    </div>
    <div class="jumbotron">
        <h2>Welcome to Trip Guide.</h2>
        <p>This Service Helps you plan your trip. Please make use of following services and plan you trip accordingly.</p>
        <p>Have SafeTrip!!!. </p>
    </div>

    <div class="jumbotron">
            <h2>Location Details Service</h2>
            <p>
                Want to know the details of the location you are heading.This location Service is implemented to take the name of a place as an input and return the latitude , longitude and zip code of the give place name.
                Please click below to get location services. Ex: Tempe
            </p>
            <p>
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="LocationServices.aspx">Get Location Details</asp:HyperLink>
            </p>
    </div>
    <div class="jumbotron">
            <h2>Distance Service</h2>
            <p>
                Want to know the travel distance between your place and the destination. This Distance Service is implemented to take the name of a 2 places as an input and return the Distance between those 2 places in kilometers.
                Please click below to get Distance services. Ex: place1 : Tempe place2: New York
            </p>
            <p>
                <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="DistanceServices.aspx">Get Location Details</asp:HyperLink>
            </p>
    </div>
    <div class="jumbotron">
            <h2>Image Service</h2>
            <p>
                Want to check out the place before you plan your trip. This Image Service is implemented to take the name of a place as an input and return the images of the place.
                Please click below to get Image. Ex: Chicago
            </p>
            <p>
                <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="Images.aspx">Get Images</asp:HyperLink>
            </p>
    </div>
    <div class="jumbotron">
            <h2>Wind Intensity Service.</h2>
            <p>
                Want to see the check Wind Speed before you start your journey. This WindIntensity Service is implemented to take the name of a place as an input and return the windspeed and it's direction and visibility for safe driving
                Please click below to get WindIntensity services. Ex: Tempe
            </p>
            <p>
                <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="WindIntensity.aspx">Get WindIntensity Details</asp:HyperLink>
            </p>
    </div>
    <div class="jumbotron">
            <h2>CrimeData Service</h2>
            <p>
                Planning a stay over and want to check the safety of the place.This location Service is implemented to take the name of a place as an input and return the crime statistics of the given place.
                Please click below to get CrimeData services. Ex: Tempe
            </p>
            <p>
                <asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl="CrimeData.aspx">Get CrimeData Statistics</asp:HyperLink>
            </p>
    </div>

</asp:Content>
