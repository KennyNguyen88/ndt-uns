<%@ Page Title="" Language="C#" MasterPageFile="~/member/Member.master" AutoEventWireup="true" CodeBehind="MyAddress.aspx.cs" Inherits="KiemTra02.member.MyAddress" %>

<%@ Register Src="~/WUC/WUC_MemberAddress.ascx" TagPrefix="uc1" TagName="WUC_MemberAddress" %>

<asp:Content ID="Content1" ContentPlaceHolderID="memberContent" runat="server">
    <uc1:WUC_MemberAddress runat="server" id="WUC_MemberAddress" />
</asp:Content>
