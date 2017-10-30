<%@ Page Title="" Language="C#" MasterPageFile="~/GuestMaster.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="KiemTra01_1581270.Contact" %>

<%@ Register Src="~/WUC/WUC_Sidebar_Category.ascx" TagPrefix="uc1" TagName="WUC_Sidebar_Category" %>
<%@ Register Src="~/WUC/WUC_Sidebar_Archive.ascx" TagPrefix="uc1" TagName="WUC_Sidebar_Archive" %>
<%@ Register Src="~/WUC/WUC_Sidebar_LatestTweet.ascx" TagPrefix="uc1" TagName="WUC_Sidebar_LatestTweet" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
            
            
            <!-- START of BREADCRUMBS -->
            <p id="breadcrumbs">
            		<a href="#">Home</a>
                    <span class="active">Contact</span>
            </p>
            <!-- END of BREADCRUMBS -->
            
            
            <!-- START of INNER-CONTAINER -->
            <div class="inner-container clearfix">
            
            		<div id="contact">
                    
                    		<h3 class="main-heading"><span>Contact</span></h3>
                            
                            <h4 class="sub-heading">Address</h4>
                            
                            <div class="address">                            
                            		<em>John Doe</em>
                                    <p>Loreum ipsum, Layout 1, Some street 123-4, Melbourne VIC 3000, Australia</p>
                                    <em>Telephone:</em>
                                    <p>+61 (0) 3 9023 0074</p>
                                    <em>Fax:</em>
                                    <p>+61 (0) 3 9023 0074</p>                                    
                                    
                                    <div id="map_canvas"></div>  
                                    
                                    <!-- Google Map API call for contact page map -->                                        
                                    <script type="text/javascript" src="http://maps.googleapis.com/maps/api/js?key=&amp;sensor=false"></script>
                                    
                                    <script type="text/javascript">
                                       // Google Map
                                     function initialize() {
                                        var myOptions = {
                                          center: new google.maps.LatLng(48.87366, 2.29507),
                                          zoom: 14,
                                          mapTypeId: google.maps.MapTypeId.ROADMAP
                                        };
                                        var map = new google.maps.Map(document.getElementById("map_canvas"),
                                            myOptions);
                                      }
                                      
                                      initialize();
          
                                    </script>                         
                            </div><!-- end of .address -->
                            
                            <!-- START OF CONTACT FORM SECTIOIN -->
                            <div class="comments">
                            
                              	<form id="contact-form" class="comment-form" method="post" action="http://inspirythemes.com/templates/bonfire-html/mail.php">
                                    
                                      <h3>Leave US a Message</h3>
                                      
                                      <div>
											<fieldset class="clearfix">
												<label for="name">Name:</label>
												<input name="name" id="name" type="text" class="required" />
											</fieldset>
											<fieldset class="clearfix">
												<label for="email">Email:</label>
												<input name="email" id="email" type="text" class="required email" />
											</fieldset>
											<fieldset class="clearfix">
												<label for="message">Message:</label>
												<textarea id="message" name="message" cols="5" rows="5" class="required"></textarea>
											</fieldset>
												<fieldset class="submit-button clearfix">
												<input name="submit" type="submit" class="submit" value="Submit" />
											</fieldset>
																					  
											<img id="loader" src="images/loader.gif" />
											<p id="result"></p>
                                      </div>
                                      
                                     
                              
                              </form><!-- end of #contact-form -->
                            
                            </div>                         
                            <!-- END OF CONTACT FORM SECTIOIN-->
                            
                    </div><!-- end of #contact -->
                    
                    <div id="sidebar">
                        <uc1:WUC_Sidebar_Archive runat="server" id="WUC_Sidebar_Archive" />
                    	<uc1:WUC_Sidebar_Category runat="server" id="WUC_Sidebar_Category" />
                        <uc1:WUC_Sidebar_LatestTweet runat="server" id="WUC_Sidebar_LatestTweet" />	
                    </div><!-- end of #sidebar -->
            
            </div>
            <!-- END of INNER-CONTAINER -->
    		
    
    </div><!-- end of .container -->
</asp:Content>
