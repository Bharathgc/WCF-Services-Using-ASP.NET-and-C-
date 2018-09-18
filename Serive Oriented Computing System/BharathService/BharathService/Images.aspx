<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Images.aspx.cs" Inherits="BharathService.Images" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <div class ="jumbotron">
        <h1>Welcome to Image Services</h1>
        <p>This service has been implemented using PIXABAY API services
            <asp:Image ID="locationimage" runat="server" ImageUrl="https://pixabay.com/static/img/public/medium_rectangle_a.png" alt="Pixabay" Height ="75" width ="75"/>
        </p>
        </div>
        <div class ="jumbotron">
            <p>Method Name : GetImages</p>
            <p>Parameter   : String Place</p>
            <p>Returns     : Images of the place returned by the API</p>
        </div>

        <h3> Enter Place: </h3>
        <asp:TextBox ID="placenametextbox" runat ="server" Width ="200px"></asp:TextBox>
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
       
        <asp:Button ID="distancebutton" runat="server" OnClick="GetImagesOfthePlace" Text ="Get Images"  />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br /><br /><br />
        
    <asp:Repeater ID="RepeaterImages" runat="server">
    <ItemTemplate>
        <asp:Image ID="Image" runat="server" ImageUrl='<%# Container.DataItem %>' height ="500" Width ="500"/>
    </ItemTemplate>
</asp:Repeater>
    </asp:Content>

 