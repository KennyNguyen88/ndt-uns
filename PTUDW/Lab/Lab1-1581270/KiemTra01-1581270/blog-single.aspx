<%@ Page Title="" Language="C#" MasterPageFile="~/GuestMaster.Master" AutoEventWireup="true" CodeBehind="blog-single.aspx.cs" Inherits="KiemTra01_1581270.blog_single" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
            
            
            <!-- START of BREADCRUMBS -->
            <p id="breadcrumbs">
            		<a href="#">Home</a>
                    <span class="active">Blog</span>
            </p>
            <!-- END of BREADCRUMBS -->
            
            
            <!-- START of INNER-CONTAINER -->
            <div class="inner-container clearfix">
            
            		<div id="blog">
                    
                    		<h3 class="main-heading"><span>BLOG</span></h3>
                            
                            <div class="post">
                            
                            		<a href="#" class="post-feature-image"><img src="images/blog/post-image-1.jpg" alt="Post Image 1" /></a>
                                    <div class="header">
                                    		<a class="arrow">&nbsp;</a>
                                    		<div class="meta">
                                            		<div class="date">18</div>
                                                    <div class="month-year"><span>JAN</span><span>2012</span></div>
                                            </div>
                                            <div class="title">
                                            		<h2>Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit</h2>
                                                    <p><span>Posted By <a href="#">Admin</a></span> / <span>Comments <a href="#">24</a></span></p>
                                            </div>
                                    </div>
									
                                    <p class="post-detail">Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Netmo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. sed quia consequuntur magni dolores eos qui "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.</p>
                            
                            </div><!-- end of .post -->
                            
                            
                            <div class="author clearfix">
                            
                              		<a href="#" class="author-avatar"><img src="images/author.jpg" alt="Joh Doe The Author" /></a>
                                    
                                    <div class="author-detail">
                                    
                                    		<h4><span>Article by</span> <a href="#">Johndoe</a></h4>
                                    		<p class="meta"><span>Member since</span>  <a>11/10/2011</a>  <span>Posted</span>  <a href="#">24 Articles</a></p>
                                            <p class="paragraph">Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Netmo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt.</p>
                                    
                                    </div><!-- end of .author detail -->
                            
                            </div><!-- end of .author -->
                            
                            
                            <div class="comments">
                            
                            		<h4 class="heading">50 Comments</h4>
                                    
                                    <ul class="comment-list">
                                    		<li class="clearfix">
                                            		<a href="#" class="comment-avatar"><img src="images/author.jpg" alt="Joh Doe The Author" /></a>
                                    
				                                    <div class="comment-detail">
				                                    		<h4><a href="#">Johndoe</a> / <span>Dec 01/20011</span></h4>
                                                            <p>Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Netmo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione </p>
				                                    		<a href="#" class="reply">Reply</a>
                                                    </div><!-- end of .author detail -->
                                            </li>
                                            <li class="clearfix">
                                            		<a href="#" class="comment-avatar"><img src="images/author.jpg" alt="Joh Doe The Author" /></a>
                                    
				                                    <div class="comment-detail">
				                                    		<h4><a href="#">Johndoe</a> / <span>Dec 01/20011</span></h4>
                                                            <p>Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Netmo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione </p>
				                                    		<a href="#" class="reply">Reply</a>
                                                    </div><!-- end of .author detail -->
                                            </li>
                                            <li class="clearfix">
                                            		<a href="#" class="comment-avatar"><img src="images/author.jpg" alt="Joh Doe The Author" /></a>
                                    
				                                    <div class="comment-detail">				                                    
				                                    		<h4><a href="#">Johndoe</a> / <span>Dec 01/20011</span></h4>
                                                            <p>Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Netmo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione </p>
				                                    		<a href="#" class="reply">Reply</a>
                                                    </div><!-- end of .author detail -->
                                            </li>
                                    </ul><!-- end of .comment-list -->
                                    
                                    <form class="comment-form" method="post" action="#">
                                    
                                    		<h3>Leave a Comment</h3>
                                            
                                            <div>
                                            	<fieldset class="clearfix">
                                            			<label for="name">Name:</label>
                                            	        <input id="name" type="text" />
                                            	</fieldset>
                                            	<fieldset class="clearfix">
                                            			<label for="email">Email:</label>
                                            	        <input id="email" type="text" />
                                            	</fieldset>
                                            	<fieldset class="clearfix">
                                            			<label for="url">Website:</label>
                                            	        <input id="url" type="text" />
                                            	</fieldset>
                                            	<fieldset class="clearfix">
                                            			<label for="message">Comment:</label>
                                            	        <textarea id="message" cols="5" rows="5"></textarea>
                                            	</fieldset>
                                                <fieldset class="submit-button clearfix">
                                                		<input type="submit" class="submit" value="Submit" />
                                                </fieldset>
                                            </div>
                                    
                                    </form><!-- end of .comment-form -->
                            
                            </div><!-- end of .comments -->
                            
                    
                    </div><!-- end of #contents -->
                    
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
                                    <li>Test Tweet</li>
                                </div>

                    		</div>
                    </div><!-- end of #sidebar -->
            
            </div>
            <!-- END of INNER-CONTAINER -->
    		
    
    </div><!-- end of .container -->
</asp:Content>
