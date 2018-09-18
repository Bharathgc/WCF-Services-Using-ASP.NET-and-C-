<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Login.ascx.cs" Inherits="Bharath.Login" %>
<div class="jumbotron">
    <h2>User LogIn</h2>
    <div class="panel-body">
        <div class="form-horizontal">
            <div class="form-group">
                <p>Username</p>
                <asp:TextBox ID="loginusernametextbox" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <p>Password</p>
                <asp:TextBox ID="loginpasswordtextbox" runat="server" TextMode="Password" ></asp:TextBox>
            </div>
			<div class="form-group">
                <asp:Button ID="loginbutton" runat="server" Text="Login" CssClass="btn btn-success" OnClick="Loginuser" />
			</div>
            <asp:Label ID="loginstatus" runat="server"></asp:Label>
        </div>
    </div>
</div>