<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WUC_header.ascx.cs" Inherits="KiemTra02.WUC.WUC_header" %>
<!-- header -->
	<div class="agileits_header">
		<div class="container">
			<div class="w3l_offers">
				<p>SALE UP TO 70% OFF. USE CODE "SALE70%" . <asp:HyperLink NavigateUrl="~/products.aspx" ID="HyperLink1" runat="server">SHOP NOW</asp:HyperLink></p>
			</div>
			<div class="agile-login">
				<ul>
					<li>
                        <asp:HyperLink NavigateUrl="~/registered.aspx" ID="HyperLink2" runat="server">Create Account</asp:HyperLink></li>
					<li>
                        <asp:HyperLink NavigateUrl="~/login.aspx" ID="HyperLink3" runat="server">Login</asp:HyperLink></li>
					<li>
                        <asp:HyperLink NavigateUrl="~/contact.aspx" ID="HyperLink4" runat="server">Help</asp:HyperLink></li>					
				</ul>
			</div>
			<div class="product_list_header">  					
				<input type="hidden" name="cmd" value="_cart">
				<input type="hidden" name="display" value="1">
				<%--<button class="w3view-cart" type="submit" name="submit" value=""><i class="fa fa-cart-arrow-down" aria-hidden="true"></i></button>--%>					
			</div>
			<div class="clearfix"> </div>
		</div>
	</div>

	<div class="logo_products">
		<div class="container">
		<div class="w3ls_logo_products_left1">
				<ul class="phone_email">
					<li><i class="fa fa-phone" aria-hidden="true"></i>Order online or call us : (+0123) 234 567</li>
					
				</ul>
			</div>
			<div class="w3ls_logo_products_left">
				<h1>
                    <asp:HyperLink NavigateUrl="~/default.aspx" ID="HyperLink5" runat="server">super Market</asp:HyperLink></h1>
			</div>
		<div class="w3l_search">
            <asp:TextBox 
                ID="TextBoxKeyword" 
                runat="server"
                TextMode="Search"
                placeholder="Search for a Product..." 
                required=""
                ValidationGroup="Search"
                ClientIDMode="Static"
                OnTextChanged="TextBoxKeyword_TextChanged"
                AutoPostBack="true">
            </asp:TextBox>
            <asp:LinkButton 
                ID="LinkButtonSearch" 
                runat="server"
                ValidationGroup="Search"
                CssClass="btn btn-default search"
                aria-label="Left Align"
                OnClick="LinkButtonSearch_Click"
                AutoPostBack="true">
                <i class="fa fa-search" aria-hidden="true"> </i>
            </asp:LinkButton>			
			<div class="clearfix"></div>			
		</div>
			
			<div class="clearfix"> </div>
		</div>
	</div>
<!-- //header -->