<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Register.ascx.cs" Inherits="Bharath.Register" %>
<%@ Register Assembly="BotDetect" Namespace="BotDetect.Web.UI" TagPrefix="BotDetect" %>
<div class="jumbotron">
	<h2>Register User</h2>
    <div class="panel-body">
        <div class="form-horizontal">
            <div class="form-group">
                <p>Username</p>
                <asp:TextBox ID="registerusernametextbox" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <p>Password</p>
                <asp:TextBox ID="registerpasswordtextbox" runat="server" TextMode="Password"></asp:TextBox>
            </div>
			<div class="form-group">
                <p>Retype Password</p>
                <asp:TextBox ID="registerretypepasswordtextbox" runat="server" TextMode="Password" ></asp:TextBox>
            </div>
			<div class="form-group">
                <p>First Name :</p>
                <asp:TextBox ID="registerfirstnametextbox" runat="server"></asp:TextBox>
            </div>
			<div class="form-group">
                <p>Last Name :</p>
                <asp:TextBox ID="registerlastnametextbox" runat="server"></asp:TextBox>
            </div>
			<div class="form-group">
                <p>Email ID :</p>
                <asp:TextBox ID="registeremailtextbox" runat="server"></asp:TextBox>
            </div>
			<div class="form-group">
				<p>Captcha</p>
                <BotDetect:WebFormsCaptcha ID="captcha_image" runat="server" UserInputControlID="captchatextbox"/><br/>
				<p> Enter Captcha</p>
				<asp:TextBox ID="captchatextbox" runat="server"></asp:TextBox>
			</div>
			<div class="form-group">
                <p>Register</p>
                <asp:Button ID="registerbutton" runat="server" Text="Register" CssClass="btn btn-primary" OnClick="RegisterUser" />
			</div>
                <asp:Label ID="registerstatus" runat="server" Text=""></asp:Label>
        </div>
    </div>
</div>