<%@ Page Title="" Language="C#" MasterPageFile="~/GuestMaster.Master" AutoEventWireup="true" CodeBehind="checkout.aspx.cs" Inherits="KiemTra01_1581270.checkout" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
            
            
            <!-- START of BREADCRUMBS -->
            <p id="breadcrumbs">
            		<a href="#">Home</a>
                    <span class="active">CheckOut</span>
            </p>
            <!-- END of BREADCRUMBS -->
            
            
            <!-- START of INNER-CONTAINER -->
            <div class="inner-container clearfix">
            
            		<div id="checkout">
                    
                      		<h3><span>CHECKOUT</span></h3>
                    
                    		<h4>Step 1: Checkout Options <a href="#">Modify</a></h4>
                            <div class="pane">
                                    <p>Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Vestibulum tortor quam, feugiat vitae, ultricies eget, tempor sit amet, ante. Donec eu libero sit amet quam egestas semper. Aenean ultricies mi vitae est. Mauris placerat eleifend leo.</p>
                            </div>
                            
                            <h4>Step 2: Billing Details</h4>
                            <div class="pane current">
                                    <form method="post" action="#">
                                            <div class="top clearfix">
                                                <div class="left-side">
                                                        <fieldset>
                                                        	<legend>Your Personal Details</legend>
                                                        	<p>
                                                        	    <label for="f-name"><span>*</span>First Name:</label>
                                                        	    <input type="text" id="f-name" class="text" />
                                                        	</p>
                                                        	<p>
                                                        	    <label for="l-name"><span>*</span>Last Name:</label>
                                                        	    <input type="text" id="l-name" class="text" />
                                                        	</p>
                                                        	<p>
                                                        	    <label for="mail"><span>*</span>Email Address:</label>
                                                        	    <input type="text" id="mail" class="text" />
                                                        	</p>
                                                        	<p>
                                                        	    <label for="tel"><span>*</span>Telephone:</label>
                                                        	    <input type="text" id="tel" class="text" />
                                                        	</p>
                                                        	<p>
                                                        	    <label for="fax">Fax:</label>
                                                        	    <input type="text" id="fax" class="text" />
                                                        	</p>
                                                        </fieldset>
                                                </div>
                                                
                                                <div class="right-side">
                                                        <fieldset>
                                                        	<legend>Your Address</legend>
                                                        	<p>
                                                        	    <label for="comp">Company:</label>
                                                        	    <input type="text" id="comp" class="text" />
                                                        	</p>
                                                        	<p>
                                                        	    <label for="add1"><span>*</span>Address 1:</label>
                                                        	    <input type="text" id="add1" class="text" />
                                                        	</p>
                                                        	<p>
                                                        	    <label for="add2">Address 2:</label>
                                                        	    <input type="text" id="add2" class="text" />
                                                        	</p>
                                                        	<p>
                                                        	    <label for="city"><span>*</span>City:</label>
                                                        	    <input type="text" id="city" class="text" />
                                                        	</p>
                                                        	<p>
                                                        	    <label for="p-code"><span>*</span>Post Code:</label>
                                                        	    <input type="text" id="p-code" class="text" />
                                                        	</p>
                                                        	<p class="checkout-selectbox">
                                                        	    <label for="country"><span>*</span>Country:</label>
                                                        	    <select id="country">
                                                        	        <option value="uk" selected="selected">United Kingdom</option>
                                                        	        <option value="usa">United States America</option>
                                                        	        <option value="pk">Pakistan</option>
                                                        	        <option value="in">Indian</option>
                                                        	        <option value="sa">Saudi Arabia</option>
                                                        	        <option value="uae">United Arab Emirates</option>
                                                        	        <option value="my">Malaysia</option>
                                                        	        <option value="sg">Singapore</option>
                                                        	        <option value="fr">France</option>
                                                        	    </select>
                                                        	</p>
                                                        	<p class="checkout-selectbox">
                                                        	    <label for="state"><span>*</span>Region/State:</label>
                                                        	    <select id="state">
                                                        	        <option value="uk" selected="selected">----- Please Select -----</option>
                                                        	        <option value="usa">United States America</option>
                                                        	        <option value="pk">Pakistan</option>
                                                        	        <option value="in">Indian</option>
                                                        	        <option value="sa">Saudi Arabia</option>
                                                        	        <option value="uae">United Arab Emirates</option>
                                                        	        <option value="my">Malaysia</option>
                                                        	        <option value="sg">Singapore</option>
                                                        	        <option value="fr">France</option>
                                                        	    </select>
                                                        	</p>
                                                        </fieldset>
                                                </div>
                                            </div><!-- end of .data -->
                                            <div class="bottom clearfix">
                                                    <p>
                                                      <input type="checkbox" id="address-same" class="checkbox" />
                                                      <label for="address-same">My delivery and billing addresses are the same. </label>
                                                    </p>
                                                    
                                                    <input type="submit" id="submit" value="Continue" />
                                            </div><!-- end of .bottom -->
                                    </form>
                            </div>
                            
                            <h4>Step 3: Delivery Details</h4>
                            <div class="pane">
                                    <p>Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas.</p>
                            </div>
                            
                            <h4>Step 4: Delivery Method</h4>
                            <div class="pane">
                                    <p>Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Vestibulum tortor quam, feugiat vitae, ultricies eget, tempor sit amet, ante. Donec eu libero sit amet quam egestas semper. Aenean ultricies mi vitae est. Mauris placerat eleifend leo.</p>
                            </div>
                            
                            <h4>Step 5: Payment Method</h4>
                            <div class="pane">
                                    <p>Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Vestibulum tortor quam, feugiat vitae, ultricies eget, tempor sit amet, ante. Donec eu libero sit amet quam egestas semper. Aenean ultricies mi vitae est. Mauris placerat eleifend leo. Quisque sit amet est et sapien ullamcorper pharetra. Vestibulum erat wisi, condimentum sed, commodo vitae, ornare sit amet, wisi. Aenean fermentum, elit eget tincidunt condimentum, eros ipsum rutrum orci, sagittis tempus lacus enim ac dui. Donec non enim in turpis pulvinar facilisis. Ut felis. Praesent dapibus, neque id cursus faucibus, tortor neque egestas augue, eu vulputate magna eros eu erat. Aliquam erat volutpat. Nam dui mi, tincidunt quis, accumsan porttitor, facilisis luctus, metus</p>
                            </div>
                            
                            <h4>Step 6: Confirm Order</h4>
                            <div class="pane">
                                    <p>Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas.</p>
                            </div>
                    
                    </div><!-- end of #checkout -->	
            
            </div>
            <!-- END of INNER-CONTAINER -->
                		
    
    </div><!-- end of .container -->
</asp:Content>
