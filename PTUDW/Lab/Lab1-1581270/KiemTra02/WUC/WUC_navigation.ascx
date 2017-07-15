<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WUC_navigation.ascx.cs" Inherits="KiemTra02.WUC.WUC_navigation" %>
<!-- navigation -->
	<div class="navigation-agileits">
		<div class="container">
			<nav class="navbar navbar-default">
							<!-- Brand and toggle get grouped for better mobile display -->
							<div class="navbar-header nav_2">
								<button type="button" class="navbar-toggle collapsed navbar-toggle1" data-toggle="collapse" data-target="#bs-megadropdown-tabs">
									<span class="sr-only">Toggle navigation</span>
									<span class="icon-bar"></span>
									<span class="icon-bar"></span>
									<span class="icon-bar"></span>
								</button>
							</div> 
							<div class="collapse navbar-collapse" id="bs-megadropdown-tabs">
								<ul class="nav navbar-nav">
									<li class="active">
                                        <asp:HyperLink ID="HyperLink1" NavigateUrl="~/default.aspx" runat="server">Home</asp:HyperLink></li>
                                    <asp:SqlDataSource 
                                        ID="SqlDataSourceMenuCategory" 
                                        runat="server" 
                                        ConnectionString="<%$ ConnectionStrings:PTUDWConnectionString %>" 
                                        SelectCommand="SELECT [Id], [Name], [ParentId] FROM [Category] WHERE ([ParentId] IS NULL)">
                                    </asp:SqlDataSource>
                                    <asp:Repeater 
                                        ID="RepeaterMenuCategory" 
                                        DataSourceID="SqlDataSourceMenuCategory"
                                        runat="server">                                        
                                        <ItemTemplate>
                                            <asp:HiddenField ID="HiddenFieldParentId" runat="server" Value='<%# Eval("Id") %>' />
                                            <asp:SqlDataSource 
                                                runat="server" 
                                                ID="SqlDataSourceSubMenuCategory" 
                                                ConnectionString="<%$ ConnectionStrings:PTUDWConnectionString %>" 
                                                SelectCommand="SELECT [Id], [Name], [ParentId], [Order] FROM [Category] WHERE ([ParentId] = @ParentId)">
                                            <SelectParameters>
                                                <asp:ControlParameter Name="ParentId" ControlID="HiddenFieldParentId" PropertyName="Value" DbType="Int16" />
                                            </SelectParameters>
                                            </asp:SqlDataSource>
                                            <li class="dropdown">
                                                <asp:LinkButton data-toggle="dropdown" CssClass="dropdown-toggle" ID="LinkButton1" runat="server"><%# Eval("Name") %><b class="caret"></b></asp:LinkButton>										        
										        <ul class="dropdown-menu multi-column columns-3">
											        <div class="row">
												        <div class="multi-gd-img">
													        <ul class="multi-column-dropdown">
														        <h6>
                                                                    <asp:HyperLink ID="HyperLink5" runat="server" NavigateUrl='<%# "~/products.aspx?id=" + Eval("Id")   %>'>All <%# Eval("Name") %></asp:HyperLink></h6>
                                                                <asp:Repeater 
                                                                    ID="RepeaterSubMenuCategory" 
                                                                    DataSourceID="SqlDataSourceSubMenuCategory"
                                                                    runat="server">
                                                                    <ItemTemplate>
                                                                        <li>
                                                                            <asp:HyperLink NavigateUrl='<%# "~/products.aspx?id=" + Eval("Id")   %>' runat="server"><%# Eval("Name") %></asp:HyperLink>
                                                                        </li>	
                                                                    </ItemTemplate>
                                                                    
                                                                </asp:Repeater>
														        							
													        </ul>
												        </div>	
												
											        </div>
										        </ul>
									        </li>
                                        </ItemTemplate>
                                    </asp:Repeater>									
									<li>
                                        <asp:HyperLink ID="HyperLink2" NavigateUrl="~/goumet.aspx" runat="server">Gourmet</asp:HyperLink></li>
									<li>
                                        <asp:HyperLink ID="HyperLink3" NavigateUrl="~/offers.aspx" runat="server">Offers</asp:HyperLink></li>
									<li>
                                        <asp:HyperLink ID="HyperLink4" NavigateUrl="~/contact.aspx" runat="server">Contact</asp:HyperLink></li>
								</ul>
							</div>
							</nav>
			</div>
		</div>
		
<!-- //navigation -->