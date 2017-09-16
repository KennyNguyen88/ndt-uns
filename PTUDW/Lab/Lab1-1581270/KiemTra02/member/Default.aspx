<%@ Page Title="" Language="C#" MasterPageFile="~/member/Member.master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="KiemTra02.member.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="memberContent" runat="server">
    <asp:ChangePassword ID="ChangePassword1" runat="server">
        <ChangePasswordTemplate>
            <!-- Password input-->
            <div class="form-group">
                <label class="col-md-6 control-label" for="currentPassword">Current Password</label>
                <div class="col-md-6">
                    <asp:TextBox ID="CurrentPassword" runat="server" TextMode="Password" placeholder="" class="form-control input-md" required=""></asp:TextBox>                    
                </div>
            </div>

            <!-- Password input-->
            <div class="form-group">
                <label class="col-md-6 control-label" for="newPassword">New Password</label>
                <div class="col-md-6">
                    <asp:TextBox ID="NewPassword" runat="server" TextMode="Password" placeholder="" class="form-control input-md" required=""></asp:TextBox>                    
                </div>
            </div>

            <!-- Password input-->
            <div class="form-group">
                <label class="col-md-6 control-label" for="confirmPassword">Confirm Password</label>
                <div class="col-md-6">
                    <asp:TextBox ID="ConfirmPassword" runat="server" TextMode="Password" placeholder="" class="form-control input-md" required=""></asp:TextBox>                                        
                </div>
            </div>
            <asp:CompareValidator ID="NewPasswordCompare" ControlToCompare="NewPassword" ControlToValidate="ConfirmPassword" runat="server" ErrorMessage="CompareValidator"></asp:CompareValidator>
            <!-- Button -->
            <div class="form-group">
                <label class="col-md-6 control-label" for="btnChange"></label>
                <div class="col-md-4">
                    <asp:Button ID="ChangePassword" runat="server" CommandName="ChangePassword" Text="Change Password" class="btn btn-primary" ValidationGroup="ChangePassword1" />                    
                </div>
            </div>
            
        </ChangePasswordTemplate>
        <SuccessTemplate>
            <table cellpadding="1" cellspacing="0" style="border-collapse: collapse;">
                <tr>
                    <td>
                        <table cellpadding="0">
                            <tr>
                                <td align="center" colspan="2">Change Password Complete</td>
                            </tr>
                            <tr>
                                <td>Your password has been changed!</td>
                            </tr>
                            <tr>
                                <td align="right" colspan="2">
                                    <asp:Button ID="ContinuePushButton" runat="server" CausesValidation="False" CommandName="Continue" Text="Continue" />
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
        </SuccessTemplate>
    </asp:ChangePassword>
</asp:Content>
