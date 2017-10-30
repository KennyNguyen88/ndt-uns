<%@ Page Title="" Language="C#" MasterPageFile="~/GuestMaster.Master" AutoEventWireup="true" CodeBehind="blog.aspx.cs" Inherits="KiemTra01_1581270.blog" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">


        <!-- START of BREADCRUMBS -->
        <p id="breadcrumbs">
            <a href="#">Home</a>
            <em class="active">Blog</em>
        </p>
        <!-- END of BREADCRUMBS -->


        <!-- START of INNER-CONTAINER -->
        <div class="inner-container clearfix">

            <div id="blog">

                <h3 class="main-heading"><span>BLOG</span></h3>

                <div class="post">

                    <a href="#" class="post-feature-image">
                        <img src="images/blog/post-image-1.jpg" alt="Post Image 1" /></a>
                    <div class="header">
                        <a class="arrow">&nbsp;</a>
                        <div class="meta">
                            <div class="date">18</div>
                            <div class="month-year"><span>JAN</span><span>2012</span></div>
                        </div>
                        <div class="title">
                            <h2><a href="#">Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit</a></h2>
                            <p><span>Posted By <a href="#">Admin</a></span> / <span>Comments <a href="#">24</a></span></p>
                        </div>
                    </div>
                    <p class="post-detail">Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. sed quia consequuntur magni dolores eos qui</p>
                    <a href="#" class="read-more">Read More</a>

                </div>
                <!-- end of .post -->

                <div class="post">

                    <a href="#" class="post-feature-image">
                        <img src="images/blog/post-image-2.jpg" alt="Post Image 2" /></a>
                    <div class="header">
                        <a class="arrow">&nbsp;</a>
                        <div class="meta">
                            <div class="date">18</div>
                            <div class="month-year"><span>JAN</span><span>2012</span></div>
                        </div>
                        <div class="title">
                            <h2><a href="#">Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit</a></h2>
                            <p><span>Posted By <a href="#">Admin</a></span> / <span>Comments <a href="#">24</a></span></p>
                        </div>
                    </div>
                    <p class="post-detail">Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. sed quia consequuntur magni dolores eos qui</p>
                    <a href="#" class="read-more">Read More</a>

                </div>
                <!-- end of .post -->

                <div class="post last">

                    <a href="#" class="post-feature-image">
                        <img src="images/blog/post-image-3.jpg" alt="Post Image 3" /></a>
                    <div class="header">
                        <a class="arrow">&nbsp;</a>
                        <div class="meta">
                            <div class="date">18</div>
                            <div class="month-year"><span>JAN</span><span>2012</span></div>
                        </div>
                        <div class="title">
                            <h2><a href="#">Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit</a></h2>
                            <p><span>Posted By <a href="#">Admin</a></span> / <span>Comments <a href="#">24</a></span></p>
                        </div>
                    </div>
                    <p class="post-detail">Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. sed quia consequuntur magni dolores eos qui</p>
                    <a href="#" class="read-more">Read More</a>

                </div>
                <!-- end of .post -->

            </div>
            <!-- end of #contents -->

            <div id="sidebar">
                <div>
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
                <div>
                    <h3><span>ARCHIVES</span></h3>
                    <ul>
                        <li><a href="#">July 2011</a></li>
                        <li><a href="#">June 2011</a></li>
                        <li><a href="#">May 2011</a></li>
                        <li><a href="#">April 2011</a></li>
                        <li><a href="#">March 2011</a></li>
                        <li><a href="#">February 2011</a></li>
                        <li><a href="#">January 2011</a></li>
                    </ul>
                </div>
                <div>
                    <h3><span>LATEST TWEETS</span></h3>

                    <div id="twitter_update_list" class="twitter">
                        <li>No tweets loaded.</li>
                    </div>

                </div>
            </div>
            <!-- end of #sidebar -->

        </div>
        <!-- END of INNER-CONTAINER -->

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


    </div>
    <!-- end of .container -->
</asp:Content>
