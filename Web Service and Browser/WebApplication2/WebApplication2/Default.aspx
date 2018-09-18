<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Temperature Converter</h1>
        <p class="lead">You can convert Celsius to Farenheit and Farenheit to Celsius</p>
        
    </div>
    <h2>ASP .NET Test Client</h2>
    <p> Please enter Celcius to Convert </p>
    <p>
        <asp:TextBox ID="c2f_textbox" runat ="server" Width ="200px"></asp:TextBox>
        &nbsp;
        <asp:Button ID="c2f_submit_button" runat="server" OnClick="c2f_button_Click" Text =" Convert"  />
    </p>
    <p>
        The converted temperature in Farenheit is: 
        <asp:Label ID="c2f_label" runat="server"></asp:Label>
    </p>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
     <p> Please enter Farenheit to Convert </p>
    <p>
    <asp:TextBox ID="f2c_textbox" runat ="server" Width ="200px"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         <asp:Button ID="f2c_submit_button" runat="server" OnClick="f2c_button_Click" Text ="Convert" />
    </p>
    <p>
        The converted temperature in Celsius is: 
        <asp:Label ID="f2c_label" runat="server"></asp:Label>
    </p>

    <p>Please click below to clear all the entries</p>
    <asp:Button ID="Clearallbutton" runat="server" OnClick="Clear_all_button" Text ="Clear all" />
</asp:Content>
