<%@ Page Title="" Language="C#" MasterPageFile="~/GuestMaster.Master" AutoEventWireup="true" CodeBehind="all-product.aspx.cs" Inherits="KiemTra01_1581270.all_product" %>

<%@ Register Src="~/WUC/WUC_Sidebar_Category.ascx" TagPrefix="uc1" TagName="WUC_Sidebar_Category" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
            
            
            <!-- START of BREADCRUMBS -->
            <p id="breadcrumbs">
            		<a href="#">Home</a>
                    <span class="active">All Products</span>
            </p>
            <!-- END of BREADCRUMBS -->
            
            
            <!-- START of INNER-CONTAINER -->
            <div class="inner-container clearfix">
            
            		<div id="all-product">
                            
							<h3>
								<span>All Products</span>
								<a class="list">List<span>&nbsp;</span></a>
								<a class="grid">Grid<span>&nbsp;</span></a>
							</h3>
																  
							<ul class="clearfix grid-view">
								<li class="product">
									<a href="#" class="thumb"><img src="images/products/product-2.jpg" alt="" /></a>
									  <div class="data">
										<a href="#" class="title">Lorem ipsum</a>
										<p>Aliquam dignissim porttitor tortor non fermentum. Curabitur in magna lectus. Duis sed eros diam. Lorem ipsum dolor sit amet, consectetur. Aliquam dignissim porttitor tortor non fermentum. Curabitur in magna lectus. Duis sed eros diam. Lorem ipsum dolor sit amet, consectetur. Curabitur in magna lectus. Duis sed eros diam. Lorem ipsum dolor sit amet, consectetur.</p>
										<div class="clearfix info">
											<a href="#" class="add-to-cart">ADD TO CART</a>
											<span class="price-text">$<span>70</span></span>
										</div>
									  </div>
								  </li>
								  <li class="product">
									<a href="#" class="thumb"><img src="images/products/product-3.jpg" alt="" /></a>
									  <div class="data">
										<a href="#" class="title">Lorem ipsum</a>
										<p>Aliquam dignissim porttitor tortor non fermentum. Curabitur in magna lectus. Duis sed eros diam. Lorem ipsum dolor sit amet, consectetur. Aliquam dignissim porttitor tortor non fermentum. Curabitur in magna lectus. Duis sed eros diam. Lorem ipsum dolor sit amet, consectetur. Curabitur in magna lectus. Duis sed eros diam. Lorem ipsum dolor sit amet, consectetur.</p>
										<div class="clearfix info">
											<a href="#" class="add-to-cart">ADD TO CART</a>
											<span class="price-text">$<span>70</span></span>
										</div>
									  </div>
								  </li>
								  <li class="product last">
									<a href="#" class="thumb"><img src="images/products/product-4.jpg" alt="" /></a>
									  <div class="data">
										<a href="#" class="title">Lorem ipsum</a>
										<p>Aliquam dignissim porttitor tortor non fermentum. Curabitur in magna lectus. Duis sed eros diam. Lorem ipsum dolor sit amet, consectetur. Aliquam dignissim porttitor tortor non fermentum. Curabitur in magna lectus. Duis sed eros diam. Lorem ipsum dolor sit amet, consectetur. Curabitur in magna lectus. Duis sed eros diam. Lorem ipsum dolor sit amet, consectetur.</p>
										<div class="clearfix info">
											<a href="#" class="add-to-cart">ADD TO CART</a>
											<span class="price-text">$<span>70</span></span>
										</div>
									  </div>
								  </li>
								  
								  <li class="product">
									<a href="#" class="thumb"><img src="images/products/product-5.jpg" alt="" /></a>
									  <div class="data">
										<a href="#" class="title">Lorem ipsum</a>
										<p>Aliquam dignissim porttitor tortor non fermentum. Curabitur in magna lectus. Duis sed eros diam. Lorem ipsum dolor sit amet, consectetur. Aliquam dignissim porttitor tortor non fermentum. Curabitur in magna lectus. Duis sed eros diam. Lorem ipsum dolor sit amet, consectetur. Curabitur in magna lectus. Duis sed eros diam. Lorem ipsum dolor sit amet, consectetur.</p>
										<div class="clearfix info">
											<a href="#" class="add-to-cart">ADD TO CART</a>
											<span class="price-text">$<span>70</span></span>
										</div>
									  </div>
								  </li>
								  <li class="product">
									<a href="#" class="thumb"><img src="images/products/product-6.jpg" alt="" /></a>
									  <div class="data">
										<a href="#" class="title">Lorem ipsum</a>
										<p>Aliquam dignissim porttitor tortor non fermentum. Curabitur in magna lectus. Duis sed eros diam. Lorem ipsum dolor sit amet, consectetur. Aliquam dignissim porttitor tortor non fermentum. Curabitur in magna lectus. Duis sed eros diam. Lorem ipsum dolor sit amet, consectetur. Curabitur in magna lectus. Duis sed eros diam. Lorem ipsum dolor sit amet, consectetur.</p>
										<div class="clearfix info">
											<a href="#" class="add-to-cart">ADD TO CART</a>
											<span class="price-text">$<span>70</span></span>
										</div>
									  </div>
								  </li>
								  <li class="product last">
									<a href="#" class="thumb"><img src="images/products/product-7.jpg" alt="" /></a>
									  <div class="data">
										<a href="#" class="title">Lorem ipsum</a>
										<p>Aliquam dignissim porttitor tortor non fermentum. Curabitur in magna lectus. Duis sed eros diam. Lorem ipsum dolor sit amet, consectetur. Aliquam dignissim porttitor tortor non fermentum. Curabitur in magna lectus. Duis sed eros diam. Lorem ipsum dolor sit amet, consectetur. Curabitur in magna lectus. Duis sed eros diam. Lorem ipsum dolor sit amet, consectetur.</p>
										<div class="clearfix info">
											<a href="#" class="add-to-cart">ADD TO CART</a>
											<span class="price-text">$<span>70</span></span>
										</div>
									  </div>
								  </li>
							</ul>
							                    
                    </div><!-- end of #product-list -->
                    
                    <div id="sidebar">
                    	<uc1:WUC_Sidebar_Category runat="server" ID="WUC_Sidebar_Category" />	
                    </div><!-- end of #sidebar -->
            
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
                		
    
    </div><!-- end of .container -->
</asp:Content>
