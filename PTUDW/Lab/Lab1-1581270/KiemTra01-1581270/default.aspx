<%@ Page Title="" Language="C#" MasterPageFile="~/GuestMaster.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="KiemTra01_1581270._default" %>

<%@ Register Src="~/WUC/WUC_Slider.ascx" TagPrefix="uc1" TagName="WUC_Slider" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">    
        <!-- START of SLIDER -->
        <uc1:WUC_Slider runat="server" id="WUC_Slider" />
            <!-- END of SLIDER -->
            
            
            <!-- START of FEATURED PRODUCTS -->
            <div class="product-listing">
             		<h3><span>FEATURED</span></h3>
                    
                    <ul class="clearfix">
                    		<li class="product">
                            	<a href="product.html" class="thumb"><img src="images/products/product-6.jpg" alt="" /></a>
                                <a href="product.html" class="title">Lorem ipsum</a>
                                <div class="clearfix info">
                                	<a href="#" class="add-to-cart">ADD TO CART</a>
                                	<span class="price-text">$<span>118</span></span>
                                </div>
                            </li>
							
                            <li class="product">
                            	<a href="product.html" class="thumb"><img src="images/products/product-2.jpg" alt="" /></a>
                                <a href="product.html" class="title">Lorem ipsum</a>
                                <div class="clearfix info">
                                	<a href="#" class="add-to-cart">ADD TO CART</a>
                                	<span class="price-text">$<span>90</span></span>
                                </div>
                            </li>
                            
							<li class="product">
                            	<a href="product.html" class="thumb"><img src="images/products/product-3.jpg" alt="" /></a>
                                <a href="product.html" class="title">Lorem ipsum</a>
                                <div class="clearfix info">
                                	<a href="#" class="add-to-cart">ADD TO CART</a>
                                	<span class="price-text">$<span>120</span></span>
                                </div>
                            </li>
							
                            <li class="product last">
                            	<a href="product.html" class="thumb"><img src="images/products/product-7.jpg" alt="" /></a>
                                <a href="product.html" class="title">Lorem ipsum ipsum ipsum</a>
                                <div class="clearfix info">
                                	<a href="#" class="add-to-cart">ADD TO CART</a>
                                	<span class="price-text">$<span>70</span></span>
                                </div>
                            </li>
                    </ul>
            </div>
            <!-- END of FEATURED PRODUCTS -->
            
            
            <!-- START of LATEST PRODUCTS -->
            <div class="product-listing">
            		<h3><span>LATEST</span></h3>
                    
                    <ul class="clearfix">
					
                    		<li class="product">
                            	<a href="product.html" class="thumb"><img src="images/products/product-5.jpg" alt="" /></a>
                                <a href="product.html" class="title">Lorem ipsum</a>
                                <div class="clearfix info">
                                	<a href="#" class="add-to-cart">ADD TO CART</a>
                                	<span class="price-text">$<span>70</span></span>
                                </div>
                            </li>
							
                            <li class="product">
                            	<a href="product.html" class="thumb"><img src="images/products/product-1.jpg" alt="" /></a>
                                <a href="product.html" class="title">Lorem ipsum</a>
                                <div class="clearfix info">
                                	<a href="#" class="add-to-cart">ADD TO CART</a>
                                	<span class="price-text">$<span>70</span></span>
                                </div>
                            </li>
							
                            <li class="product">
                            	<a href="product.html" class="thumb"><img src="images/products/product-4.jpg" alt="" /></a>
                                <a href="product.html" class="title">Lorem ipsum</a>
                                <div class="clearfix info">
                                	<a href="#" class="add-to-cart">ADD TO CART</a>
                                	<span class="price-text">$<span>70</span></span>
                                </div>
                            </li>
							
                            <li class="product last">
                            	<a href="product.html" class="thumb"><img src="images/products/product-8.jpg" alt="" /></a>
                                <a href="product.html" class="title">Lorem ipsum</a>
                                <div class="clearfix info">
                                	<a href="#" class="add-to-cart">ADD TO CART</a>
                                	<span class="price-text">$<span>70</span></span>
                                </div>
                            </li>
                    </ul>
            </div>
            <!-- END of LATEST PRODUCTS -->
    
    
    		<!-- START of PAGINATION -->
    		<p class="pagination">
    				<a href="#">&lt;</a>
                    <a href="#" class="active">1</a>
                    <a href="#">2</a>
                    <a href="#">3</a>
                    <a href="#">4</a>
                    <a href="#">5</a>
                    <a href="#">6</a>
                    <a href="#">7</a>
                    <a href="#">&gt;</a>        		
            </p>
    		<!-- END of PAGINATION -->
    		
    
    </div><!-- end of .container -->
</asp:Content>



