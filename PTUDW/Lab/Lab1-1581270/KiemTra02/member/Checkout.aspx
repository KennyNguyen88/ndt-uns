<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="Checkout.aspx.cs" Inherits="KiemTra02.member.Checkout" %>

<%@ Register Src="~/WUC/WUC_MemberCheckout.ascx" TagPrefix="uc1" TagName="WUC_MemberCheckout" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:WUC_MemberCheckout runat="server" id="WUC_MemberCheckout" />
</asp:Content>
