<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WUC_Header.ascx.cs" Inherits="KiemTra01_1581270.WUC.WUC_Header" %>
<!-- START of HEADER WRAPPER -->
<div class="header-wrapper">

    <div id="header" class="clearfix">

        <!-- LOGO -->
        <a href="default.aspx" class="logo">
            <img src="images/logo.png" alt="BonFire Logo" /></a>

        <!-- SLOGAN LINE -->
        <strong class="slogan">SO TURN THE LIGHTS OUT</strong>

        <!-- TOP NAV -->
        <ul class="top-nav">
            <li><a href="#">WISH LIST (0)</a></li>
            <li><a href="login.aspx">MY ACCOUNT</a></li>
            <li><a href="shopping-cart.aspx">SHOPPING CART</a></li>
            <li><a href="checkout.aspx">CHECK OUT</a></li>
            <li><a href="#" class="cart">&nbsp;</a><span class="cart-bubble">0</span></li>
        </ul>
        <!-- end of .top-nav -->

    </div>
    <!-- end of #header -->

</div>
<!-- END OF HEADER WRAPPER -->


<!-- START of NAVIGATION WRAPPER -->
<div class="navigation-wrapper">

    <!-- MAIN NAVIGATION -->
    <ul id="navigation" class="clearfix">
        <li><a href="default.aspx">
            <img src="images/home.png" alt="" />Home</a></li>
        <li><a href="all-product.aspx">Products</a></li>
        <li><a href="product.aspx">Product Details</a></li>
        <li><a href="blog.aspx">Blog</a></li>
        <li><a href="blog-single.aspx">Blog Post</a></li>        
        <li><a href="contact.aspx">Contact</a></li>
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
    </ul>
    <!-- end of #navigation -->

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
            </ul>
            <!-- end of .social-nav -->

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
            </form>
            <!-- end of .choose-currany -->

            <form class="search" method="get" action="#">
                <fieldset>
                    <input type="text" id="s" name="s" value="Search" />
                    <input class="submit" type="submit" value="Submit" />
                </fieldset>
            </form>
            <!-- end of .search -->

        </div>

    </div>
    <!-- end of #bottom -->

</div>
<!-- END of BOTTOM -->
