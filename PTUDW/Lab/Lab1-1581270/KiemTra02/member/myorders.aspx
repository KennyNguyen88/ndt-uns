<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="myorders.aspx.cs" Inherits="KiemTra02.member.myorders" %>

<%@ Register Src="~/WUC/WUC_MemberOrders.ascx" TagPrefix="uc1" TagName="WUC_MemberOrders" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:WUC_MemberOrders runat="server" id="WUC_MemberOrders" />
</asp:Content>
