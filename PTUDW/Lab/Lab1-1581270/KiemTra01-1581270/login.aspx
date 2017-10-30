<%@ Page Title="" Language="C#" MasterPageFile="~/GuestMaster.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="KiemTra01_1581270.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container account-login">
            
            
            <!-- START of BREADCRUMBS -->
            <p id="breadcrumbs">
            		<a href="#">Home</a>
                    <a href="#">Account</a>
                    <span class="active">Login</span>
            </p>
            <!-- END of BREADCRUMBS -->
            
            
            <!-- START of LOGIN-FORM -->
            <div class="clearfix">
            	<div class="new-customer">
                		<h3><span>NEW CUSTOMER</span></h3>
                        <p><a href="#" class="reg">Register Account</a></p>
                        <p class="msg">By creating an account you will be able to shop faster, be up to date on an order's status, and keep track of<br />the orders you have previously made.</p>
                		<a class="cont">Continue</a>
                </div>
                <div class="login">
                	<h3><span>RETURNING CUSTOMER</span></h3>
                    <p>I am a returning customer</p>
                	<form class="login-form" method="post" action="#">
                			<fieldset>
                	        		<input type="text" id="email" value="Email Address" />
                	                <input type="password" id="pw" value="Password" />
                                    <p><a href="#">Forgotten Password</a></p>
                	                <input class="login-btn" type="submit" value="Login" />
                	        </fieldset>
                	</form>
                </div>
            </div>
            <!-- END of LOGIN-FORM -->
    		
    
    </div><!-- end of .container -->
</asp:Content>
