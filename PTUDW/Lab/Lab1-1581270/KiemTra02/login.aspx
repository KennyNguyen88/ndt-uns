<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="KiemTra02.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- breadcrumbs -->
	<div class="breadcrumbs">
		<div class="container">
			<ol class="breadcrumb breadcrumb1 animated wow slideInLeft" data-wow-delay=".5s">
				<li><a href="index.html"><span class="glyphicon glyphicon-home" aria-hidden="true"></span>Home</a></li>
				<li class="active">Login Page</li>
			</ol>
		</div>
	</div>
<!-- //breadcrumbs -->
<!-- login -->
	<div class="login">
		<div class="container">
            <asp:LoginView ID="LoginView1" runat="server">
                <AnonymousTemplate>
                    <h2>Login Form</h2>
		
			<div class="login-form-grids animated wow slideInUp" data-wow-delay=".5s">

                    <asp:Login ID="Login1" runat="server">
                        <LayoutTemplate>                                                                                                                                          
                            <asp:TextBox ID="UserName" runat="server" TextMode="SingleLine" placeholder="Username" required=" "></asp:TextBox>
                            <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserName" ErrorMessage="User Name is required." ToolTip="User Name is required." ValidationGroup="Login1">*</asp:RequiredFieldValidator>                            
                            <asp:TextBox ID="Password" runat="server" TextMode="Password" placeholder="Password" required=" "></asp:TextBox>
                            <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="Password" ErrorMessage="Password is required." ToolTip="Password is required." ValidationGroup="Login1">*</asp:RequiredFieldValidator>
                            <asp:CheckBox ID="RememberMe" runat="server" Text="Remember me next time." />
                            <div class="forgot">
                                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/PasswordRecovery.aspx">Forgot Password?</asp:HyperLink>
					        </div>
                            <asp:Literal ID="FailureText" runat="server" EnableViewState="False"></asp:Literal>
                            <asp:Button ID="LoginButton" runat="server" CommandName="Login" Text="Log In" ValidationGroup="Login1" />
                        </LayoutTemplate>
                    </asp:Login>
					                    

			</div>
			<h4>For New People</h4>
			<p>
                <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/registered.aspx">Register Here</asp:HyperLink>
                 (Or) go back to <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/default.aspx">Home<span class="glyphicon glyphicon-menu-right" aria-hidden="true"></span></asp:HyperLink>

			</p>
                </AnonymousTemplate>
            </asp:LoginView>
			
		</div>
	</div>
<!-- //login -->
</asp:Content>
