﻿<%@ Page Title="" Language="C#" MasterPageFile="~/GuestMaster.Master" AutoEventWireup="true" CodeBehind="product.aspx.cs" Inherits="KiemTra01_1581270.product" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">


        <!-- START of BREADCRUMBS -->
        <p id="breadcrumbs">
            <a href="#">Home</a>
            <a href="#">Products</a>
            <span class="active">Sample Product</span>
        </p>
        <!-- END of BREADCRUMBS -->


        <!-- START of INNER-CONTAINER -->
        <div class="inner-container clearfix">

            <div id="product" class="clearfix">
                <div class="product-gallery">
                    <div class="large-image">
                        <a class="cloud-zoom" id='zoom1' href="images/product-gallery/very-large-image.jpg" rel="adjustX: 10, adjustY:-4, softFocus:true">
                            <img src="images/product-gallery/large-image.jpg" alt="" />
                        </a>
                    </div>
                    <ul class="clearfix">
                        <li><a class="thumbnail cloud-zoom-gallery" href='images/product-gallery/very-large-image.jpg' title='Thumbnail 1' rel="useZoom: 'zoom1', smallImage: 'images/product-gallery/large-image.jpg' ">
                            <img src="images/product-gallery/thumb_1.jpg" alt="" />
                        </a>
                        </li>
                        <li><a class="thumbnail cloud-zoom-gallery" href="images/product-gallery/very-large-image2.jpg" title='Thumbnail 2' rel="useZoom: 'zoom1', smallImage: 'images/product-gallery/large-image2.jpg' ">
                            <img src="images/product-gallery/thumb_2.jpg" alt="" />
                        </a>
                        </li>
                        <li><a class="thumbnail cloud-zoom-gallery" href="images/product-gallery/very-large-image3.jpg" title='Thumbnail 3' rel="useZoom: 'zoom1', smallImage: 'images/product-gallery/large-image3.jpg' ">
                            <img src="images/product-gallery/thumb_3.jpg" alt="" />
                        </a>
                        </li>
                        <li><a class="thumbnail last cloud-zoom-gallery" href="images/product-gallery/very-large-image4.jpg" title='Thumbnail 4' rel="useZoom: 'zoom1', smallImage: 'images/product-gallery/large-image4.jpg' ">
                            <img src="images/product-gallery/thumb_4.jpg" alt="" />
                        </a>
                        </li>
                    </ul>
                </div>
                <!-- end of .product-gallery -->

                <div class="product-detail">
                    <h2><a href="#">Sample Product</a></h2>
                    <cite>BY Lorem Ipsum</cite>
                    <p>Product Code: 123456</p>
                    <p>Reward Points: 9</p>
                    <p>Availability:<span>In Stock</span></p>
                    <p class="price">Price: $40.50</p>
                    <p class="tax">TAX: $5.99</p>
                    <form class="options-form" method="get" action="#">
                        <fieldset>
                            <div class="available-options">
                                <label for="options">Size:</label>
                                <select id="options">
                                    <option value="32">38</option>
                                    <option value="40">40</option>
                                    <option value="42">42</option>
                                    <option value="44">44</option>
                                </select>
                            </div>
                            <p class="qty">
                                <label>Quantity:</label>
                                <input type="text" value="1" />
                            </p>
                            <input type="submit" class="submit-btn" value="ADD TO CART" />
                        </fieldset>
                    </form>
                    <!-- end of .available-options -->
                    <p class="add-links">
                        <a href="#">+Add to Wish List</a>
                        <a href="#">+ Add to Compare</a>
                    </p>
                    <div class="clearfix rat-rev">
                        <div class="rating">
                            <a href="#" class="yellow">&nbsp;</a>
                            <a href="#" class="yellow">&nbsp;</a>
                            <a href="#" class="yellow">&nbsp;</a>
                            <a href="#" class="gray">&nbsp;</a>
                            <a href="#" class="gray">&nbsp;</a>
                        </div>
                        <p class="review">
                            <a href="#" class="review-count">1 Review</a>
                            <a href="#">Write a Review</a>
                        </p>
                    </div>
                    <ul class="icons">
                        <li><a class="tw" href="#">&nbsp;</a></li>
                        <li><a class="fb" href="#">&nbsp;</a></li>
                        <li><a class="print" href="#">&nbsp;</a></li>
                        <li><a class="email" href="#">&nbsp;</a></li>
                        <li><a class="share" href="#">&nbsp;</a></li>
                    </ul>
                </div>
                <!-- end of .product-detail -->
            </div>
            <!-- end of #contents -->

            <div id="sidebar">
                <h3><span>CATEGORIES</span></h3>
                <ul>
                    <li><a href="#">Bags</a></li>
                    <li><a href="#">Shoes</a></li>
                    <li><a href="#">Lorems</a></li>
                    <li><a href="#">Ipsums</a></li>
                    <li><a href="#">Dresses</a></li>
                    <li><a href="#">Jewellery</a></li>
                    <li><a href="#">Furniture</a></li>
                </ul>
            </div>
            <!-- end of #sidebar -->

        </div>
        <!-- END of INNER-CONTAINER -->


        <!-- START TABS EXAMPLE -->
        <div class="product-tabs">
            <ul class="tabs">
                <li><a>DESCRIPTION</a></li>
                <li><a>REVIEW (1)</a></li>
            </ul>
            <div class="panes">
                <div class="tab-pane">
                    <p>Duis blandit, ante quis elementum lobortis, metus sapien dapibus quam Non pulvinar sapien massa vel ipsum. Fusce non risus urna. Nulla ultricies purus eget augue vulputate in accumsan turpis accumsan. Sed vel faucibus sem. Quisque diam massa, consectetur eu suscipit et, ullamcorper vitae eros. Vestibulum bibendum, lacus vel mattis interdum, mauris libero mollis velit, sit amet semper ligula enim eu neque. Morbi ac mauris nec velit ullamcorper eleifend. Quisque tempor lorem non enim dictum ac commodo risus rutrum.</p>
                </div>
                <div class="tab-pane">
                    <p>Duis blandit, ante quis elementum lobortis, metus sapien dapibus quam Non pulvinar sapien massa vel ipsum. Fusce non risus urna. Nulla ultricies purus eget augue vulputate in accumsan turpis accumsan. Sed vel faucibus sem. Quisque diam massa, consectetur eu suscipit et, ullamcorper vitae eros. Vestibulum bibendum, lacus vel mattis interdum, mauris libero mollis velit, sit amet semper ligula enim eu neque. Morbi ac mauris nec velit ullamcorper eleifend. Quisque tempor lorem non enim dictum ac commodo risus rutrum.</p>
                    <p>Duis blandit, ante quis elementum lobortis, metus sapien dapibus quam Non pulvinar sapien massa vel ipsum. Fusce non risus urna. Nulla ultricies purus eget augue vulputate in accumsan turpis accumsan. Sed vel faucibus sem. Quisque diam massa, consectetur eu suscipit et, ullamcorper vitae eros. Vestibulum bibendum, lacus vel mattis interdum, mauris libero mollis velit, sit amet semper ligula enim eu neque. Morbi ac mauris nec velit ullamcorper eleifend. Quisque tempor lorem non enim dictum ac commodo risus rutrum.</p>
                </div>
            </div>
        </div>
        <!-- END TABS EXAMPLE -->


        <!-- START of RELATED PRODUCTS -->
        <div class="product-listing">
            <h3><span>RELATED</span></h3>

            <ul class="clearfix">

                <li class="product">
                    <a href="#" class="thumb">
                        <img src="images/products/product-2.jpg" alt="" /></a>
                    <a href="#" class="title">Lorem ipsum</a>
                    <div class="clearfix info">
                        <a href="#" class="add-to-cart">ADD TO CART</a>
                        <span class="price-text">$<span>70</span></span>
                    </div>
                </li>

                <li class="product">
                    <a href="#" class="thumb">
                        <img src="images/products/product-6.jpg" alt="" /></a>
                    <a href="#" class="title">Lorem ipsum</a>
                    <div class="clearfix info">
                        <a href="#" class="add-to-cart">ADD TO CART</a>
                        <span class="price-text">$<span>70</span></span>
                    </div>
                </li>

                <li class="product">
                    <a href="#" class="thumb">
                        <img src="images/products/product-4.jpg" alt="" /></a>
                    <a href="#" class="title">Lorem ipsum</a>
                    <div class="clearfix info">
                        <a href="#" class="add-to-cart">ADD TO CART</a>
                        <span class="price-text">$<span>70</span></span>
                    </div>
                </li>

                <li class="product last">
                    <a href="#" class="thumb">
                        <img src="images/products/product-8.jpg" alt="" /></a>
                    <a href="#" class="title">Lorem ipsum</a>
                    <div class="clearfix info">
                        <a href="#" class="add-to-cart">ADD TO CART</a>
                        <span class="price-text">$<span>70</span></span>
                    </div>
                </li>
            </ul>
        </div>
        <!-- END of LATEST PRODUCTS -->


    </div>
    <!-- end of .container -->
</asp:Content>
