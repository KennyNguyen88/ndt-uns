<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="MyCart.aspx.cs" Inherits="KiemTra02.MyCart" %>

<%@ Register Src="~/WUC/WUC_ShoppingCart.ascx" TagPrefix="uc1" TagName="WUC_ShoppingCart" %>

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
    <uc1:WUC_ShoppingCart runat="server" id="WUC_ShoppingCart" />

</asp:Content>
