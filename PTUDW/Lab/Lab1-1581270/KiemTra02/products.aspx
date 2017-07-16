<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="products.aspx.cs" Inherits="KiemTra02.products" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- breadcrumbs -->
	<div class="breadcrumbs">
		<div class="container">
			<ol class="breadcrumb breadcrumb1 animated wow slideInLeft" data-wow-delay=".5s">
				<li><a href="index.html"><span class="glyphicon glyphicon-home" aria-hidden="true"></span>Home</a></li>
				<li class="active">Products</li>
			</ol>
		</div>
	</div>
<!-- //breadcrumbs -->
<!--- products --->
	<div class="products">
		<div class="container">
			<div class="col-md-4 products-left">
				<div class="categories">
					<h2>Categories</h2>
                    <ul class="cate">
                    <asp:SqlDataSource 
                        ID="SqlDataSourceCategory" 
                        runat="server" 
                        ConnectionString="<%$ ConnectionStrings:PTUDWConnectionString %>" 
                        SelectCommand="SELECT [Id], [Name] FROM [Category] WHERE ([ParentId] IS NULL)">                        
                    </asp:SqlDataSource>
					<asp:Repeater runat="server" ID="RepeaterCategory" DataSourceID="SqlDataSourceCategory">                        
                        <ItemTemplate>
                            <asp:HiddenField runat="server" ID="HiddenFieldParentId" Value='<%# Eval("Id") %>'></asp:HiddenField>
                            <li>
                                <asp:HyperLink NavigateUrl='<%# "~/products.aspx?id=" + Eval("Id")%>' ID="HyperLink1" runat="server"><i class="fa fa-arrow-right" aria-hidden="true"></i><%# Eval("Name") %></asp:HyperLink>                                
                            </li>
                            <ul>
                                <asp:SqlDataSource 
                                    ID="SqlDataSourceSubCategory" 
                                    runat="server" 
                                    ConnectionString="<%$ ConnectionStrings:PTUDWConnectionString %>" 
                                    SelectCommand="SELECT [Id], [Name] FROM [Category] WHERE ([ParentId] = @ParentId)">
                                    <SelectParameters>
                                        <asp:ControlParameter Name="ParentId" ControlID="HiddenFieldParentId" PropertyName="Value" DbType="Int16" />
                                    </SelectParameters>
                                </asp:SqlDataSource>
                                <asp:Repeater ID="RepeaterSubCategory" runat="server" DataSourceID="SqlDataSourceSubCategory">
                                    <ItemTemplate>
                                        <li>
                                            <asp:HyperLink NavigateUrl='<%# "~/products.aspx?id=" + Eval("Id")%>'  ID="HyperLink2" runat="server"><i class="fa fa-arrow-right" aria-hidden="true"></i><%# Eval("Name") %></asp:HyperLink>                                            
                                        </li>
                                    </ItemTemplate>
                                </asp:Repeater>

								    								    
							</ul>
                        </ItemTemplate>
					</asp:Repeater>																			
					</ul>
				</div>																																												
			</div>
			<div class="col-md-8 products-right">
				<div class="products-right-grid">
					<div class="products-right-grids">
						<div class="sorting">
                            <asp:DropDownList ID="country" 
                                runat="server"
                                CssClass="frm-field required sect"
                                ClientIDMode="Static"
                                AutoPostBack="true"
                                OnSelectedIndexChanged="country_SelectedIndexChanged">
                                <asp:ListItem Value="Price" Text="Sort by Price"></asp:ListItem>
                                <asp:ListItem Value="AverageRating" Text="Sort by Rating"></asp:ListItem>
                            </asp:DropDownList>							
						</div>
						<div class="sorting-left">
							<asp:DropDownList ID="country1" 
                                runat="server"
                                CssClass="frm-field required sect"
                                ClientIDMode="Static"
                                AutoPostBack="true"
                                OnSelectedIndexChanged="country1_SelectedIndexChanged">
                                <asp:ListItem Value="9" Text="Item on Page 9"></asp:ListItem>
                                <asp:ListItem Value="18" Text="Item on Page 18"></asp:ListItem>
                            </asp:DropDownList>
						</div>
						<div class="clearfix"> </div>
					</div>
				</div>
                <asp:SqlDataSource 
                    ID="SqlDataSourceProducts" 
                    runat="server" 
                    ConnectionString="<%$ ConnectionStrings:PTUDWConnectionString %>" 
                    SelectCommand="
                    SELECT * 
                    FROM [Product] P, [Category] C 
                    WHERE (P.CategoryId = C.Id) 
                    AND (P.Name like '%' + @keyword + '%')
                    AND (((@CategoryId > 0) AND (P.CategoryId = @CategoryId) OR (C.ParentId = @CategoryId)) OR (@CategoryId = 0))">
                    <SelectParameters>
                        <asp:QueryStringParameter DefaultValue="0" Name="CategoryId" QueryStringField="id" Type="Int32" />
                        <asp:QueryStringParameter DefaultValue="%" Name="keyword" QueryStringField="keyword" Type="String" />
                    </SelectParameters>
                </asp:SqlDataSource>
                <asp:ListView 
                    ID="ListViewProducts" 
                    runat="server"
                    GroupPlaceholderID="groupPlaceHolder"
                    GroupItemCount="3"
                    ItemPlaceholderID="itemPlaceHolder"
                    DataSourceID="SqlDataSourceProducts">
                    <ItemTemplate>
                        <div class="col-md-4 top_brand_left">
						<div class="hover14 column">
							<div class="agile_top_brand_left_grid">
								<div class="agile_top_brand_left_grid_pos">
									<img src="images/offer.png" alt=" " class="img-responsive">
								</div>
								<div class="agile_top_brand_left_grid1">
									<figure>
										<div class="snipcart-item block">
											<div class="snipcart-thumb">
                                                <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl='<%# "~/single.aspx?id=" + Eval("Id") %>' ImageUrl='<%# "~/images/" + Eval("ImagePath") %>'></asp:HyperLink>												
												<p><%# Eval("Name") %></p>
												<h4>$<%# Eval("Price") %><span>$<%# Eval("OldPrice") %></span></h4>
											</div>
											<div class="snipcart-details top_brand_home_details">												
												<fieldset>
													<input type="hidden" name="cmd" value="_cart">
													<input type="hidden" name="add" value="1">
													<input type="hidden" name="business" value=" ">
													<input type="hidden" name="item_name" value="Fortune Sunflower Oil">
													<input type="hidden" name="amount" value="35.99">
													<input type="hidden" name="discount_amount" value="1.00">
													<input type="hidden" name="currency_code" value="USD">
													<input type="hidden" name="return" value=" ">
													<input type="hidden" name="cancel_return" value=" ">
													<input type="button" name="button" value="Add to cart" class="button">
												</fieldset>												
											</div>
										</div>
									</figure>
								</div>
							</div>
						</div>
					</div>
                    </ItemTemplate>
                    <GroupTemplate>
                        <div class="agile_top_brands_grids">
                            <asp:PlaceHolder runat="server" ID="itemPlaceHolder" />
                            <div class="clearfix"> </div>
                        </div>
                    </GroupTemplate>
                    <LayoutTemplate>
                        <asp:PlaceHolder runat="server" ID="groupPlaceHolder" />
                    </LayoutTemplate>
                    
                </asp:ListView>
				<nav class="numbering">
					<ul class="pagination paging">
                        <asp:DataPager 
                            ID="DataPagerProducts" 
                            runat="server"
                            PageSize="9"
                            PagedControlID="ListViewProducts"
                            ClientIDMode="Static">
                            <Fields>
                                <asp:NextPreviousPagerField 
                                    ButtonType="Link" 
                                    FirstPageText="&laquo;" 
                                    ShowFirstPageButton="true" 
                                    ShowPreviousPageButton="true"
                                    PreviousPageText="&laquo;"
                                    ShowLastPageButton="false"
                                    ShowNextPageButton="false" 
                                    RenderNonBreakingSpacesBetweenControls="false"/>
                                <asp:NumericPagerField 
                                    ButtonType="Link" 
                                    ButtonCount="5" 
                                    CurrentPageLabelCssClass="active" 
                                    RenderNonBreakingSpacesBetweenControls="false" />
                                <asp:NextPreviousPagerField 
                                    ButtonType="Link" 
                                    LastPageText="&raquo;"                                                                                                             
                                    ShowLastPageButton="true"
                                    ShowNextPageButton="true" 
                                    ShowPreviousPageButton="false"
                                    ShowFirstPageButton="false"
                                    NextPageText="&raquo;"
                                    RenderNonBreakingSpacesBetweenControls="false"/>
                                
                            </Fields>
                            
                        </asp:DataPager>
						
					</ul>
				</nav>
			</div>
			<div class="clearfix"> </div>
		</div>
	</div>
<!--- products --->
</asp:Content>
