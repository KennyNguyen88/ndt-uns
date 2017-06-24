﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="KiemTra01_1581270._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
	
	<!-- Always force latest IE rendering engine (even in intranet) & Chrome Frame. Remove this if you use the .htaccess -->
    <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1" />
  
	<title>Bonfire : HTML Template for Shoping Website</title>
	<!-- A Sunil Joshi design (http://themeforest.net/user/suniljoshi/portfolio) - Proudly developed by 960development (http://960development.com) -->
    
	<link rel="stylesheet" type="text/css" media="all" href="style.css" />
    <link rel="stylesheet" type="text/css" media="all" href="jquery.selectBox.css" />
	
	<!-- Generate Favicon Using 1.http://tools.dynamicdrive.com/favicon/ OR 2.http://www.favicon.cc/ -->
	<link rel="shortcut icon" href="favicon.html" />
</head>
<body>
    <form id="form1" runat="server">
        <!-- START of HEADER WRAPPER -->
	<div class="header-wrapper">
    		
            <div id="header" class="clearfix">
                    
                    <!-- LOGO -->
                    <a href="index-2.html" class="logo"><img src="images/logo.png" alt="BonFire Logo" /></a>
                    
                    <!-- SLOGAN LINE -->
                    <strong class="slogan">SO TURN THE LIGHTS OUT</strong>
                    
                    <!-- TOP NAV -->
                    <ul class="top-nav">
                    		<li><a href="#">WISH LIST (0)</a></li>
                            <li><a href="login.html">MY ACCOUNT</a></li>
                            <li><a href="shopping-cart.html">SHOPPING CART</a></li>
                            <li><a href="checkout.html">CHECK OUT</a></li>
                            <li><a href="#" class="cart">&nbsp;</a><span class="cart-bubble">0</span></li>
                    </ul><!-- end of .top-nav -->
                    
            </div><!-- end of #header -->
            
    </div>
	<!-- END OF HEADER WRAPPER -->
    
    
    <!-- START of NAVIGATION WRAPPER -->
    <div class="navigation-wrapper">
            
            <!-- MAIN NAVIGATION -->
		    <ul id="navigation" class="clearfix">
            		<li><a href="index-2.html"><img src="images/home.png" alt="" />Home</a></li>
            		<li><a href="all-product.html">Products</a></li> 
                    <li><a href="product.html">Product Details</a></li>           		
            		<li><a href="blog.html">Blog</a></li> 
                    <li><a href="blog-single.html">Blog Post</a></li>           		
            		<li><a href="full-width.html">Fullwidth</a></li>            		            	
            		<li><a href="contact.html">Contact</a></li>
                    <li><a href="#">Sample Menu</a>
                        <ul>
                            <li><a href="#">Sub Menu 1</a></li>
                            <li><a href="#">Sub Menu 2</a></li>
                            <li><a href="#">Sub Menu 3</a></li>
                            <li><a href="#">Sub Menu 4</a></li>
                            <li><a href="#">Sub Menu 5</a></li>
                            <li><a href="#">Sub Menu 6</a></li>
                        </ul>
                    </li>
		    </ul><!-- end of #navigation -->
            
  	</div>
    <!-- END of NAVIGATION WRAPPER -->
    
    
    <!-- START of BOTTOM -->
    <div class="bottom-wrapper">
    
		    <div id="bottom" class="clearfix">
            
            		<strong class="welcome-message">Welcome visitor you can <a href="login.html">login</a> or <a href="login.html">create an account</a>.</strong>
                    
                    <div class="right">
                    
                    	<ul class="social-nav clearfix">
                    			<li><a href="#" class="rss">&nbsp;</a></li>
                    			<li><a href="#" class="fb">&nbsp;</a></li>
                    			<li><a href="#" class="tw">&nbsp;</a></li>
                    			<li><a href="#" class="skype">&nbsp;</a></li>
                    	</ul><!-- end of .social-nav -->
                    	
                        <form class="choose-currancy" method="get" action="#">
                    			<fieldset>
                    	        		<select id="header-select">
                    	                		<option value="dollar">Dollar</option>
                    	                        <option value="euro" selected="selected">Euro</option>
                    	                        <option value="pound">Pound</option>
                    	                        <option value="dirham">Dirham</option>
                    	                        <option value="riyal">Riyal</option>
                    	                        <option value="euro">Euro</option>
                    	                        <option value="pound">Pound</option>
                    	                </select>
                    	        </fieldset>
                    	</form><!-- end of .choose-currany -->
                        
                        <form class="search" method="get" action="#">
                    			<fieldset>
                    	        		<input type="text" id="s" name="s" value="Search" />
                    	                <input class="submit" type="submit" value="Submit" />
                    	        </fieldset>
                    	</form><!-- end of .search -->
                    	
                    </div>
            
		    </div><!-- end of #bottom -->
            
    </div>
    <!-- END of BOTTOM -->
    
    <div class="container">
    
    		<!-- START of SLIDER -->
            <div id="slider">
            		<div class="slides" id="slides">
					
                    		<div class="slide">
                            		<a href="product.html"><img src="images/slider/slide1.jpg" alt="diamonds on the soles of her shoes" /></a>                                    
                                    <div class="caption">
                                    		<a href="product.html" class="purchase-btn">&nbsp;</a>
                                    		<p>Shoes with Diamonds - Now Available for just <span class="price">$89.99</span></p>                                            
                                    </div><!-- end of .caption -->
                            </div><!-- end of .slide -->
                            
                            <div class="slide">
                            		<a href="product.html"><img src="images/slider/slide2.jpg" alt="suit for the soles of his body" /></a>                                    
                                    <div class="caption">
                                    		<a href="product.html" class="purchase-btn">&nbsp;</a>
                                    		<p>Lorem Suit - Now Available for just <span class="price">$99.99</span></p>                                            
                                    </div><!-- end of .caption -->
                            </div><!-- end of .slide -->
                            
                            <div class="slide">
                            		<a href="product.html"><img src="images/slider/slide3.jpg" alt="cool camera" /></a>                                    
                                    <div class="caption">
                                    		<a href="product.html" class="purchase-btn">&nbsp;</a>
                                    		<p>Top Selling Camera - Now Available for just <span class="price">$80.50</span></p>                                            
                                    </div><!-- end of .caption -->
                            </div><!-- end of .slide -->
							
							<div class="slide">
                            		<a href="product.html"><img src="images/slider/slide4.jpg" alt="comfortable sofa" /></a>                                    
                                    <div class="caption">
                                    		<a href="product.html" class="purchase-btn">&nbsp;</a>
                                    		<p>White Sofa - Now Available for just <span class="price">$120</span></p>                                            
                                    </div><!-- end of .caption -->
                            </div><!-- end of .slide -->
							
                    </div><!-- end of .slides -->
                    
                    <div id="slider-pager"></div>                    
            </div>
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
    
    
	<!-- START of PAGE-BOTTOM -->
    <div class="page-bottom-wrapper">
    		
            <div id="page-bottom" class="clearfix">
            		
                    <div class="box">
                            <div class="icon">
                            	<img src="images/icon-1.png" alt="" />
                            </div>                                   
							<div class="data">
								 <h3>Lorem ipsum dolor</h3>
								 <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque pretium nisi id sapien cursus eu lobortis libero imperdiet. Aliquam erat volutpat.</p>
							</div>
                            
                    </div><!-- end of .box -->
                    
                    <div class="box">
							<div class="icon">
                            	<img src="images/icon-2.png" alt="" />
                            </div>                                    
							<div class="data">
								 <h3>Lorem ipsum dolor</h3>
								 <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque pretium nisi id sapien cursus eu lobortis libero imperdiet. Aliquam erat volutpat.</p>
							</div>							
                    </div><!-- end of .box -->
                    
                    <div class="box last">
							<div class="icon">
                            	<img src="images/icon-3.png" alt="" />
                            </div>                                    
							<div class="data">
								 <h3>Lorem ipsum dolor</h3>
								 <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque pretium nisi id sapien cursus eu lobortis libero imperdiet. Aliquam erat volutpat.</p>
							</div>                    		
                    </div><!-- end of .box -->
                    
            </div><!-- end of #page-bottom -->
            
    </div>
    <!-- END of PAGE-BOTTOM -->
    
    
    <!-- START of FOOTER -->
    <div class="footer-wrapper">
    		
            <div id="footer" class="clearfix">
            
            		<div class="column double">
                    		<a href="index-2.html"><img src="images/footer-logo.png" alt="Bonfire" /></a>
                            <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque pretium nisi id sapien cursus eu lobortis libero imperdiet. Aliquam erat volutpat. Pellentesque lacus urna, pellentesque non vehicula ac, adipiscing scelerisque eros. Mauris id tortor vitae velit auctor convallis nec non metus. Praesent eget dictum mauris. Sed vitae lorem et magna lacinia ultricies et non purus. </p>
                    </div>
                    
                    <div class="column">
                    		<h3>Links</h3>
                            <ul>
                            		<li><a href="#">About Us</a></li>
                                    <li><a href="#">Delivery Information</a></li>
                                    <li><a href="#">Privacy Policy</a></li>
                                    <li><a href="#">Terms &amp; Conditions</a></li>
									<li><a href="#">Site Map</a></li>
									<li><a href="#">Contact Us</a></li>
                            </ul>
                    </div>
                    
                    <div class="column">
                    		<h3>MY ACCOUNT</h3>
                            <ul>
                            		<li><a href="#">My Account</a></li>
                                    <li><a href="#">Order History</a></li>
                                    <li><a href="#">Wish List</a></li>
                                    <li><a href="#">Newsletter</a></li>
									<li><a href="#">Returns</a></li>									
							</ul>
                    </div>
                    
                    <div class="column last">
                    		<h3>EXTRAS</h3>
                            <ul>
                            		<li><a href="#">Brands</a></li>
                                    <li><a href="#">Gift Vouchers</a></li>
                                    <li><a href="#">Affiliates</a></li>
                                    <li><a href="#">Specials</a></li>
                            </ul>
                    </div>
            
            </div><!-- end of #footer -->
            
    </div>
    <!-- END of FOOTER -->
    
    
    <!-- START of COPYRIGHTS-WRAPPER -->
    <div class="copyright-wrapper">
    
    		<div id="copyrights" class="clearfix">
            		<p class="left">copyright of <a href="#">bonfire</a> <span>2012</span> All Rights Reserved</p>
                    <p class="right">Designed by <a href="http://themedesigner.in/">Sunil Joshi</a> and Developed by <a href="http://960development.com/">960Development</a></p>
            </div><!-- end of #copyrights -->
    
    </div>
    <!-- END of COPYRIGHTS-WRAPPER -->
    
	<!-- jQuery -->
	<script type="text/javascript" src="js/jquery-1.6.2.min.js"></script>
    
    <!-- jQuery Easing -->
	<script type="text/javascript" src="js/jquery.easing.1.3.js"></script>
	
    <!-- jQuery Selectbox Script to custom style form select boxes -->
    <script type="text/javascript" src="js/jquery.selectBox.js"></script>
    
    <!-- jQuery Cycle Plugin for home page slider-->
    <script type="text/javascript" src="js/jquery.cycle.all.js"></script>
    
    <!-- jQuery Tabs and Accordion Script -->
    <script type="text/javascript" src="js/tabs-accordian.js"></script>
    
    <!-- jQuery Coud Zoom Plugin for Product Page Image Zoom Effect-->
    <script type="text/JavaScript" src="js/cloud-zoom.1.0.2.js"></script>
    
    <!-- jQuery Animate Color Plugin for Hover Color Animation for Links-->
    <script type="text/javascript" src="js/jquery.animate-colors-min.js"></script>           
    
    <!-- jQuery Form and Validation Plugin for Contact form validation and ajax submition -->
    <script type="text/javascript" src="js/jquery.form.js"></script>
    <script type="text/javascript" src="js/jquery.validate.js"></script>    	
	
    <!-- script file to add your own JavaScript -->
	<script type="text/javascript" src="js/script.js"></script>
    </form>
</body>
</html>
