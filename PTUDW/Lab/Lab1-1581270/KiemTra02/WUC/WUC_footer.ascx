<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WUC_footer.ascx.cs" Inherits="KiemTra02.WUC.WUC_footer" %>
<!-- //footer -->
<div class="footer">
		<div class="container">
			<div class="w3_footer_grids">
				<div class="col-md-3 w3_footer_grid">
					<h3>Contact</h3>
					
					<ul class="address">
						<li><i class="glyphicon glyphicon-map-marker" aria-hidden="true"></i>1234k Avenue, 4th block, <span>New York City.</span></li>
						<li><i class="glyphicon glyphicon-envelope" aria-hidden="true"></i><a href="mailto:info@example.com">info@example.com</a></li>
						<li><i class="glyphicon glyphicon-earphone" aria-hidden="true"></i>+1234 567 567</li>
					</ul>
				</div>
				<div class="col-md-3 w3_footer_grid">
					<h3>Information</h3>
					<ul class="info"> 
						<li><i class="fa fa-arrow-right" aria-hidden="true"></i>
                            <asp:HyperLink ID="HyperLink1" NavigateUrl="~/about.aspx" runat="server">About Us</asp:HyperLink></li>
						<li><i class="fa fa-arrow-right" aria-hidden="true"></i>
                            <asp:HyperLink ID="HyperLink2" NavigateUrl="~/contact.aspx" runat="server">Contact Us</asp:HyperLink></li>						
						<li><i class="fa fa-arrow-right" aria-hidden="true"></i>
                            <asp:HyperLink ID="HyperLink4" NavigateUrl="~/faq.aspx" runat="server">FAQ's</asp:HyperLink></li>
						<li><i class="fa fa-arrow-right" aria-hidden="true"></i>
                            <asp:HyperLink ID="HyperLink5" NavigateUrl="~/products.aspx" runat="server">Special Products</asp:HyperLink></li>
					</ul>
				</div>
				<div class="col-md-3 w3_footer_grid">
					<h3>Category</h3>
					<ul class="info"> 
						<li><i class="fa fa-arrow-right" aria-hidden="true"></i>
                            <asp:HyperLink ID="HyperLink6" NavigateUrl="~/groceries.aspx" runat="server">Groceries</asp:HyperLink></li>
						<li><i class="fa fa-arrow-right" aria-hidden="true"></i>
                            <asp:HyperLink ID="HyperLink7" NavigateUrl="~/household.aspx" runat="server">Household</asp:HyperLink></li>
						<li><i class="fa fa-arrow-right" aria-hidden="true"></i>
                            <asp:HyperLink ID="HyperLink8" NavigateUrl="~/personalcare.aspx" runat="server">Personal Care</asp:HyperLink></li>
						<li><i class="fa fa-arrow-right" aria-hidden="true"></i>
                            <asp:HyperLink ID="HyperLink9" NavigateUrl="~/packagedfoods.aspx" runat="server">Packaged Foods</asp:HyperLink></li>
						<li><i class="fa fa-arrow-right" aria-hidden="true"></i>
                            <asp:HyperLink ID="HyperLink10" NavigateUrl="~/beverages.aspx" runat="server">Beverages</asp:HyperLink></li>
					</ul>
				</div>
				<div class="col-md-3 w3_footer_grid">
					<h3>Profile</h3>
					<ul class="info"> 
						<li><i class="fa fa-arrow-right" aria-hidden="true"></i>
                            <asp:HyperLink ID="HyperLink11" NavigateUrl="~/products.aspx" runat="server">Store</asp:HyperLink></li>
						<li><i class="fa fa-arrow-right" aria-hidden="true"></i>
                            <asp:HyperLink ID="HyperLink12" NavigateUrl="~/checkout.aspx" runat="server">My Cart</asp:HyperLink></li>
						<li><i class="fa fa-arrow-right" aria-hidden="true"></i>
                            <asp:HyperLink ID="HyperLink13" NavigateUrl="~/login.aspx" runat="server">Login</asp:HyperLink></li>
						<li><i class="fa fa-arrow-right" aria-hidden="true"></i>
                            <asp:HyperLink ID="HyperLink14" NavigateUrl="~/registered.aspx" runat="server">Create Account</asp:HyperLink></li>
					</ul>
				</div>
				<div class="clearfix"> </div>
			</div>
		</div>
		
		<div class="footer-copy">
			
			<div class="container">
				<p>© 2017 Super Market. All rights reserved | Design by <a href="http://w3layouts.com/">W3layouts</a></p>
			</div>
		</div>
		
	</div>	
	<div class="footer-botm">
			<div class="container">
				<div class="w3layouts-foot">
					<ul>
						<li><a href="#" class="w3_agile_facebook"><i class="fa fa-facebook" aria-hidden="true"></i></a></li>
						<li><a href="#" class="agile_twitter"><i class="fa fa-twitter" aria-hidden="true"></i></a></li>
						<li><a href="#" class="w3_agile_dribble"><i class="fa fa-dribbble" aria-hidden="true"></i></a></li>
						<li><a href="#" class="w3_agile_vimeo"><i class="fa fa-vimeo" aria-hidden="true"></i></a></li>
					</ul>
				</div>
				<div class="payment-w3ls">	
					<img src="images/card.png" alt=" " class="img-responsive">
				</div>
				<div class="clearfix"> </div>
			</div>
		</div>
<!-- //footer -->