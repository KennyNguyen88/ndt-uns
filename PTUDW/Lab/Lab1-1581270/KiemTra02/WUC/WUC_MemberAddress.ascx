<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WUC_MemberAddress.ascx.cs" Inherits="KiemTra02.WUC.WUC_MemberAddress" %>
<asp:FormView ID="FormView1" runat="server" DataKeyNames="UserId" DataSourceID="SqlDataSourceUserAddress">
    <EditItemTemplate>        
        Fullname:
        <asp:TextBox ID="FullnameTextBox" runat="server" Text='<%# Bind("Fullname") %>' />
        <br />
        PhoneNumber:
        <asp:TextBox ID="PhoneNumberTextBox" runat="server" Text='<%# Bind("PhoneNumber") %>' />
        <br />
        ShippingAddress:
        <asp:TextBox ID="ShippingAddressTextBox" runat="server" Text='<%# Bind("ShippingAddress") %>' />
        <br />
        ShippingCity:
        <asp:TextBox ID="ShippingCityTextBox" runat="server" Text='<%# Bind("ShippingCity") %>' />
        <br />        
        <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Update" />
        &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
    </EditItemTemplate>    
    <ItemTemplate>        
        Fullname:
        <asp:Label ID="FullnameLabel" runat="server" Text='<%# Bind("Fullname") %>' />
        <br />
        PhoneNumber:
        <asp:Label ID="PhoneNumberLabel" runat="server" Text='<%# Bind("PhoneNumber") %>' />
        <br />
        ShippingAddress:
        <asp:Label ID="ShippingAddressLabel" runat="server" Text='<%# Bind("ShippingAddress") %>' />
        <br />
        ShippingCity:
        <asp:Label ID="ShippingCityLabel" runat="server" Text='<%# Bind("ShippingCity") %>' />
        <br />        
        <asp:LinkButton ID="EditButton" runat="server" CausesValidation="False" CommandName="Edit" Text="Edit" />        
    </ItemTemplate>
</asp:FormView>
<asp:SqlDataSource 
    ID="SqlDataSourceUserAddress" 
    runat="server" 
    ConflictDetection="CompareAllValues" 
    ConnectionString="<%$ ConnectionStrings:PTUDWConnectionString %>"     
    OldValuesParameterFormatString="original_{0}" 
    SelectCommand="SELECT * FROM [UserAddress] WHERE ([UserId] = @UserId)" 
    UpdateCommand="UPDATE [UserAddress] SET [Fullname] = @Fullname, [PhoneNumber] = @PhoneNumber, [ShippingAddress] = @ShippingAddress, [ShippingCity] = @ShippingCity, [ImagePath] = @ImagePath WHERE [UserId] = @original_UserId AND (([Fullname] = @original_Fullname) OR ([Fullname] IS NULL AND @original_Fullname IS NULL)) AND (([PhoneNumber] = @original_PhoneNumber) OR ([PhoneNumber] IS NULL AND @original_PhoneNumber IS NULL)) AND (([ShippingAddress] = @original_ShippingAddress) OR ([ShippingAddress] IS NULL AND @original_ShippingAddress IS NULL)) AND (([ShippingCity] = @original_ShippingCity) OR ([ShippingCity] IS NULL AND @original_ShippingCity IS NULL)) AND (([ImagePath] = @original_ImagePath) OR ([ImagePath] IS NULL AND @original_ImagePath IS NULL))">
    <SelectParameters>
        <asp:ControlParameter ControlID="HiddenFieldUserId" Name="UserId" PropertyName="Value" Type="String" />
    </SelectParameters>
    <UpdateParameters>
        <asp:Parameter Name="Fullname" Type="String" />
        <asp:Parameter Name="PhoneNumber" Type="String" />
        <asp:Parameter Name="ShippingAddress" Type="String" />
        <asp:Parameter Name="ShippingCity" Type="String" />
        <asp:Parameter Name="ImagePath" Type="String" />
        <asp:Parameter Name="original_UserId" Type="Object" />
        <asp:Parameter Name="original_Fullname" Type="String" />
        <asp:Parameter Name="original_PhoneNumber" Type="String" />
        <asp:Parameter Name="original_ShippingAddress" Type="String" />
        <asp:Parameter Name="original_ShippingCity" Type="String" />
        <asp:Parameter Name="original_ImagePath" Type="String" />
    </UpdateParameters>
</asp:SqlDataSource>
<asp:HiddenField ID="HiddenFieldUserId" runat="server" />

