<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChangePasswordPage.aspx.cs" Inherits="LabDay1EFR.ChangePasswordPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">Old Password</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txt_oldpass" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Label ID="Label1" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">New Password</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txt_newpass" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="btn_save" runat="server" OnClick="btn_save_Click" Text="Save" Width="101px" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
