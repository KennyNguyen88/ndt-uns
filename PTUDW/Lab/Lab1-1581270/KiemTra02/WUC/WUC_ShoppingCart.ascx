<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WUC_ShoppingCart.ascx.cs" Inherits="KiemTra02.WUC.WUC_ShoppingCart" %>
<table id="cart" class="table table-hover table-condensed">
    <thead>
		<tr>
			<th style="width:50%">Product</th>
			<th style="width:10%">Price</th>
			<th style="width:8%">Quantity</th>
			<th style="width:22%" class="text-center">Subtotal</th>
			<th style="width:10%"></th>
		</tr>
	</thead>
	<tbody>
        <asp:Repeater ID="RepeaterShoppingCart" runat="server" OnItemCommand="RepeaterShoppingCart_ItemCommand">
            <ItemTemplate>
                <tr>
			        <td data-th="Product">
				        <div class="row">
					        <div class="col-sm-2 hidden-xs">
                                <asp:Image ID="Image1" runat="server" CssClass="img-responsive" ImageUrl='<%# "~/images/" + Eval("ImagePath") %>'/>                                
					        </div>
					        <div class="col-sm-10">
						        <h4 class="nomargin"><%# Eval("Name") %></h4>
						        <p><%# Eval("Summary") %></p>
					        </div>
				        </div>
			        </td>
			        <td data-th="Price"><%# Eval("UnitPrice") %></td>
			        <td data-th="Quantity">
                        <asp:TextBox runat="server" ID="TextBoxQuantity" CssClass="form-control text-center" Text='<%# Eval("Quantity") %>' TextMode="Number" />
				        
			        </td>
			        <td data-th="Subtotal" class="text-center"><%# Eval("TotalPrice") %></td>
			        <td class="actions" data-th="">
                        <asp:LinkButton 
                            ID="LinkButtonUpdate" 
                            runat="server" 
                            CssClass="btn btn-info btn-sm"
                            CommandName="UpdateItem"
                            CommandArgument='<%# Eval("ProductId") %>'><i class="fa fa-refresh"></i></asp:LinkButton>
                        <asp:LinkButton 
                            ID="LinkButtonDelete" 
                            runat="server" 
                            CssClass="btn btn-danger btn-sm"
                            CommandName="RemoveItem"
                            CommandArgument='<%# Eval("ProductId") %>'
                            OnClientClick="return confirm('Do you want to remove this item');"
                            ><i class="fa fa-trash-o"></i></asp:LinkButton>				        							
			        </td>
		        </tr>
            </ItemTemplate>
        </asp:Repeater>


		
	</tbody>
	<tfoot>
		<tr class="visible-xs">
			<td class="text-center"><strong>Total <asp:Label ID="LabelTotalCost" runat="server" Text="Label"></asp:Label></strong></td>
		</tr>
		<tr>
			<td><a href="#" class="btn btn-warning"><i class="fa fa-angle-left"></i> Continue Shopping</a></td>
			<td colspan="2" class="hidden-xs"></td>
			<td class="hidden-xs text-center"><strong>Total <asp:Label ID="LabelTotalCostHidden" runat="server" Text="Label"></asp:Label></strong></td>
			<td><a href="../member/Checkout.aspx" class="btn btn-success btn-block">Checkout <i class="fa fa-angle-right"></i></a></td>
		</tr>
	</tfoot>
</table>