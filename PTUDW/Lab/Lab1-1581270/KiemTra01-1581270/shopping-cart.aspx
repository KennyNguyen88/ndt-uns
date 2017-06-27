<%@ Page Title="" Language="C#" MasterPageFile="~/GuestMaster.Master" AutoEventWireup="true" CodeBehind="shopping-cart.aspx.cs" Inherits="KiemTra01_1581270.shopping_cart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
            
            
            <!-- START of BREADCRUMBS -->
            <p id="breadcrumbs">
            		<a href="#">Home</a>
                    <span class="active">Shopping Cart</span>
            </p>
            <!-- END of BREADCRUMBS -->
            
            
            <!-- START of INNER-CONTAINER -->
            <div class="inner-container">
            
            		<div class="cart">
                            
				              		<h3>
                                    	<span>SHOPPING CART</span>
                                    </h3>
                                    
                                    <table>
                                    		<tr>
                                            		<th>Remove</th>
                                                    <th>Image</th>
                                                    <th class="name-header">Name</th>
                                                    <th>Model</th>
                                                    <th>Item No.</th>
                                                    <th>Quantity</th>
                                                    <th>Unit Price</th>
                                                    <th>Total</th>
                                            </tr>
                                            <tr>
                                            		<td><input type="checkbox" /></td>
                                                    <td class="thumb"><img src="images/thumb.png" alt="" /></td>
                                                    <td class="name">Onesie</td>
                                                    <td><a href="#">0ABFG</a></td>
                                                    <td><a href="#">1536</a></td>
                                                    <td class="qty"><input type="text" value="1" /></td>
                                                    <td>$45.00</td>
                                                    <td class="red">$45.00</td>
                                            </tr>
                                            <tr>
                                            		<td><input type="checkbox" /></td>
                                                    <td class="thumb"><img src="images/thumb.png" alt="" /></td>
                                                    <td class="name">Onesie</td>
                                                    <td><a href="#">0ABFG</a></td>
                                                    <td><a href="#">1536</a></td>
                                                    <td class="qty"><input type="text" value="1" /></td>
                                                    <td>$45.00</td>
                                                    <td class="red">$45.00</td>
                                            </tr>
                                            <tr>
                                            		<td><input type="checkbox" /></td>
                                                    <td class="thumb"><img src="images/thumb.png" alt="" /></td>
                                                    <td class="name">Onesie</td>
                                                    <td><a href="#">0ABFG</a></td>
                                                    <td><a href="#">1536</a></td>
                                                    <td class="qty"><input type="text" value="1" /></td>
                                                    <td>$45.00</td>
                                                    <td class="red">$45.00</td>
                                            </tr>
                                            <tr>
                                            		<td><input type="checkbox" /></td>
                                                    <td class="thumb"><img src="images/thumb.png" alt="" /></td>
                                                    <td class="name">Onesie</td>
                                                    <td><a href="#">0ABFG</a></td>
                                                    <td><a href="#">1536</a></td>
                                                    <td class="qty"><input type="text" value="1" /></td>
                                                    <td>$45.00</td>
                                                    <td class="red">$45.00</td>
                                            </tr>
                                    </table>
                                    
                                    <div class="clearfix">
                                    	<div class="left-column">
                                        		<input type="text" id="coupon-code" value="Coupon Code:" />
                                                <a class="apply">Apply</a>
                                    	</div>
                                    	
                                    	<div class="right-column">
                                        		<p>Sub Total: $0.00</p>
                                                <p>Vat 17%: $0.00</p>
                                                <p class="total">Total: $0.00</p>
                                                <p>
                                                	<a class="checkout">Checkout</a>
                                                	<a class="update">Update</a>
                                                </p>
                                                <p><a href="#">Continue Shopping &rarr;</a></p>
                                    	</div>
                                    </div>
                    
                    </div><!-- end of #product-list -->
            
            </div>
            <!-- END of INNER-CONTAINER -->
                		
    
    </div><!-- end of .container -->
</asp:Content>
