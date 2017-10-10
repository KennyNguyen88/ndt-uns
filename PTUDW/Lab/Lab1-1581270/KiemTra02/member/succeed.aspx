<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="succeed.aspx.cs" Inherits="KiemTra02.member.succeed" %>

<%@ Register Src="~/WUC/WUC_MemberSucceed.ascx" TagPrefix="uc1" TagName="WUC_MemberSucceed" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:WUC_MemberSucceed runat="server" id="WUC_MemberSucceed" />
</asp:Content>
