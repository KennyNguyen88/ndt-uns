<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="contact.aspx.cs" Inherits="KiemTra02.contact" %>
<%@ Register Assembly="BotDetect" Namespace="BotDetect.Web.UI"
    TagPrefix="BotDetect" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- breadcrumbs -->
	<div class="breadcrumbs">
		<div class="container">
			<ol class="breadcrumb breadcrumb1 animated wow slideInLeft" data-wow-delay=".5s">
				<li><a href="index.html"><span class="glyphicon glyphicon-home" aria-hidden="true"></span>Home</a></li>
				<li class="active">Contact</li>
			</ol>
		</div>
	</div>
<!-- //breadcrumbs -->
<!-- contact -->
	<div class="about">
		<div class="w3_agileits_contact_grids">
			<div class="col-md-6 w3_agileits_contact_grid_left">
				<div class="agile_map">
					<iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3919.6359969467953!2d106.6801572652817!3d10.762511292331!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x31752f1bf8da4697%3A0x5c1e00e1d6a2b7a6!2zSSwgMjI3IE5ndXnhu4VuIFbEg24gQ-G7qywgcGjGsOG7nW5nIDQsIFF14bqtbiA1LCBI4buTIENow60gTWluaCwgVmlldG5hbQ!5e0!3m2!1sen!2s!4v1501082283626" width="600" height="450" frameborder="0" style="border:0" allowfullscreen></iframe>
				</div>
				<div class="agileits_w3layouts_map_pos">
					<div class="agileits_w3layouts_map_pos1">
						<h3>Contact Info</h3>
						<p>1234k Avenue, 4th block, New York City.</p>
						<ul class="wthree_contact_info_address">
							<li><i class="fa fa-envelope" aria-hidden="true"></i><a href="mailto:info@example.com">info@example.com</a></li>
							<li><i class="fa fa-phone" aria-hidden="true"></i>+(0123) 232 232</li>
						</ul>
						<div class="w3_agile_social_icons w3_agile_social_icons_contact">
							<ul>
								<li><a href="#" class="icon icon-cube agile_facebook"></a></li>
								<li><a href="#" class="icon icon-cube agile_rss"></a></li>
								<li><a href="#" class="icon icon-cube agile_t"></a></li>
							</ul>
						</div>
					</div>
				</div>
			</div>
			<div class="col-md-6 w3_agileits_contact_grid_right">
				<h2 class="w3_agile_header">Leave a<span> Message</span></h2>				
					<span class="input input--ichiro">
                        <asp:TextBox 
                            ID="TextBoxName" 
                            runat="server"
                            ClientIDMode="Static"
                            TextMode="SingleLine" 
                            name="Name" 
                            placeholder=" " 
                            required=""
                            ValidationGroup="contact"
                            CssClass="input__field input__field--ichiro"
                            ></asp:TextBox>						
						<label class="input__label input__label--ichiro" for="TextBoxName">
							<span class="input__label-content input__label-content--ichiro">Your Name</span>
						</label>
					</span>
					<span class="input input--ichiro">
                        <asp:TextBox 
                            ID="TextBoxEmail" 
                            runat="server"
                            ClientIDMode="Static"
                            TextMode="Email" 
                            name="Email" 
                            placeholder=" " 
                            required=""
                            ValidationGroup="contact"
                            CssClass="input__field input__field--ichiro"
                            ></asp:TextBox>							
						<label class="input__label input__label--ichiro" for="TextBoxEmail">
							<span class="input__label-content input__label-content--ichiro">Your Email</span>
						</label>
					</span>
                    <span class="input input--ichiro">
                    <asp:TextBox
                        ID="TextBoxMessage"
                        runat="server"                        
                        TextMode="MultiLine" 
                        name="Message" 
                        placeholder="Your message here..." 
                        required=""
                        ValidationGroup="contact"
                        ></asp:TextBox>
                    <asp:Label ID="CaptchaLabel" runat="server" AssociatedControlID="CaptchaCode">
                        Retype the characters from the picture:
                    </asp:Label>
                    <BotDetect:WebFormsCaptcha ID="ExampleCaptcha" runat="server" />
                    <asp:TextBox ID="CaptchaCode" runat="server" />
                    <asp:Label ID="CaptchaErrorLabel" runat="server"/>
                    <asp:Button runat="server" Text="Submit" ID="ButtonSubmit" OnClick="ButtonSubmit_Click" />					
				    <div>
                        <asp:Label ID="LabelThongBao" runat="server" Text=""></asp:Label>
                    </div>
			</div>
			<div class="clearfix"> </div>
		</div>
	</div>
<!-- contact -->
</asp:Content>
