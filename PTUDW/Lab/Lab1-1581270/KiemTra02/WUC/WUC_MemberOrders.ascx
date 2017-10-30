<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WUC_MemberOrders.ascx.cs" Inherits="KiemTra02.WUC.WUC_MemberOrders" %>
<div class="panel-group" id="accordion" role="tablist" aria-multiselectable="true">
    
    <asp:Repeater ID="RepeaterOrder" runat="server">
        <ItemTemplate>
            <div class="panel panel-default">
                <div class="panel-heading" role="tab" id="headingOne">
                    <h4 class="panel-title">
                        <a role="button" data-toggle="collapse" data-parent="#accordion" href="<%# Container.ItemIndex %>" aria-expanded="true" aria-controls="<%# Container.ItemIndex %>">
                            <%# Container.ItemIndex + 1 %> Order No. <%# Eval("Id") %> <%#Eval("OrderDatetime")  %> - <%# Eval("OrderStatu.Name") %>
                        </a>
                    </h4>
                </div>
                <asp:HiddenField ID="HiddenFieldOrderId" Value='<%# Eval("Id") %>' runat="server" />
                <div id="<%# Container.ItemIndex %>" class="panel-collapse collapse in" role="tabpanel" aria-labelledby="headingOne">
                    <div class="panel-body">
                        <asp:SqlDataSource ID="SqlDataSourceDetail" runat="server" ConnectionString="<%$ ConnectionStrings:PTUDWConnectionString %>" SelectCommand="SELECT p.[Name] as [Name], o.[Quantity] as [Quantity], o.[TotalPrice] as [TotalPrice], o.[UnitPrice] as [UnitPrice]  FROM [OrderDetail] o, [Product] p where o.[ProductId] = p.[Id] and o.[OrderId]=@OrderId">
                            <SelectParameters>
                                <asp:ControlParameter Name="OrderId" ControlID="HiddenFieldOrderId" PropertyName="Value" DbType="Int16" />
                            </SelectParameters>
                        </asp:SqlDataSource>                    
                        <div class="items">
                            <div class="col-md-9">
                                <table class="table table-striped">
                                    <tr>
                                        <th>Product</th>
                                        <th>Unit Price</th>
                                        <th>Quantity</th>
                                        <th>Price</th>
                                    </tr>
                                    <asp:Repeater ID="RepeaterDetail" runat="server" DataSourceID="SqlDataSourceDetail">
                                        <ItemTemplate>
                                            <tr>
                                                <td>
                                                    <ul>
                                                        <li><%#Eval("Name") %></li>
                                                    </ul>
                                                </td>
                                                <td>
                                                    <b><%#toCurrency(Eval("UnitPrice").ToString()) %></b>
                                                </td>
                                                <td>
                                                    <b><%#Eval("Quantity") %></b>
                                                </td>
                                                <td>
                                                    <b><%#toCurrency(Eval("TotalPrice").ToString()) %></b>
                                                </td>
                                            </tr>
                                        </ItemTemplate>
                                    </asp:Repeater>
                                </table>
                            </div>
                            <div class="col-md-3">
                                <div style="text-align: center;">
                                    <h3>Order Total</h3>
                                    <h3><span style="color: green;">
                                       <%#toCurrency(Eval("OrderTotal").ToString()) %>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </ItemTemplate>
    </asp:Repeater>
</div>

