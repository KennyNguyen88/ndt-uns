<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="registered.aspx.cs" Inherits="KiemTra02.registered" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- breadcrumbs -->
	<div class="breadcrumbs">
		<div class="container">
			<ol class="breadcrumb breadcrumb1 animated wow slideInLeft" data-wow-delay=".5s">
				<li><a href="index.html"><span class="glyphicon glyphicon-home" aria-hidden="true"></span>Home</a></li>
				<li class="active">Register Page</li>
			</ol>
		</div>
	</div>
<!-- //breadcrumbs -->
<!-- register -->
	<div class="register">
		<div class="container">
			<h2>Register Here</h2>
			<div class="login-form-grids">
                <asp:CreateUserWizard ID="CreateUserWizardRegister" runat="server" ActiveStepIndex="0" OnCreatedUser="CreateUserWizardRegister_CreatedUser">
                    <WizardSteps>
                        <asp:CreateUserWizardStep ID="CreateUserWizardStep1" runat="server">
                            <ContentTemplate>
                                <h5>profile information</h5>
                                <asp:TextBox ID="TextBoxFullName" runat="server" placeholder="Full Name..." required=" "></asp:TextBox>				
                                <asp:TextBox ID="Email" runat="server" TextMode="Email" placeholder="Email Address" required=" "></asp:TextBox>                                
				                <h6>Login information</h6>
                                <asp:TextBox ID="UserName" runat="server" TextMode="SingleLine" placeholder="Username" required=" "></asp:TextBox>                                                                
                                <asp:TextBox ID="Password" runat="server" TextMode="Password" placeholder="Password" required=" "></asp:TextBox>
                                <asp:TextBox ID="ConfirmPassword" runat="server" TextMode="Password" placeholder="Password Confirmation" required=" "></asp:TextBox>
					            <h6>Security information</h6>
                                <asp:DropDownList ID="Question" runat="server">
                                    <asp:ListItem>
                                        What is your favourite color ?
                                    </asp:ListItem>
                                    <asp:ListItem>
                                        What is your father's nickname?
                                    </asp:ListItem>
                                </asp:DropDownList>
                                <asp:TextBox ID="Answer" runat="server" placeholder="Security Answer"></asp:TextBox>
                                <div class="register-check-box">
						            <div class="check">
							            <label class="checkbox"><input type="checkbox" name="checkbox" required=""><i> </i>I accept the terms and conditions</label>
						            </div>
					            </div>
                                <asp:Button ID="StepNextButton" runat="server" Text="Register" CommandName="MoveNext" ValidationGroup="CreateUserWizard1" />					            
                                <asp:CompareValidator ID="CompareValidatorPassword" runat="server" ErrorMessage="The password and confirmed password must match !" ControlToValidate="ConfirmPassword" ControlToCompare="Password" Display="Dynamic" ValidationGroup="CreateUserWizard1"></asp:CompareValidator>
                                <asp:Literal ID="ErrorMessage" runat="server"></asp:Literal>
                            </ContentTemplate>                            
                            <CustomNavigationTemplate></CustomNavigationTemplate>
                        </asp:CreateUserWizardStep>
                        <asp:CompleteWizardStep ID="CompleteWizardStep1" runat="server">
                            <ContentTemplate>
                                Your account has been created !
                            </ContentTemplate>
                        </asp:CompleteWizardStep>
                    </WizardSteps>
                    
                </asp:CreateUserWizard>
				
                
                
				
			</div>
			<div class="register-home">
				<a href="index.html">Home</a>
			</div>
		</div>
	</div>
<!-- //register -->
</asp:Content>
