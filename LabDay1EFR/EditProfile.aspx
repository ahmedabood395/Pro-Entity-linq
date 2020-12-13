<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditProfile.aspx.cs" Inherits="LabDay1EFR.EditProfile" %>

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
                    <td class="auto-style2">Select ID</td>
                    <td>
                        <asp:DropDownList ID="drp_select" runat="server">
                        </asp:DropDownList>
                        &nbsp;&nbsp; </td>
                </tr>
                <tr>
                    <td class="auto-style2">Name</td>
                    <td>
                        <asp:TextBox ID="txt_name" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Email</td>
                    <td>
                        <asp:TextBox ID="txt_Email" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">CV</td>
                    <td>
                        <asp:FileUpload ID="flup_cv" runat="server" style="height: 22px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Photo</td>
                    <td>
                        <asp:FileUpload ID="flup_img" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Age</td>
                    <td>
                        <asp:TextBox ID="txt_age" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Dept_Name</td>
                    <td>
                        <asp:DropDownList ID="drp_dept" runat="server">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
                        <asp:Button ID="Btn_edit" runat="server" OnClick="Btn_edit_Click" Text="Edit" />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btn_update" runat="server" OnClick="btn_update_Click" Text="Update" />
                        &nbsp;&nbsp;&nbsp;<asp:Button ID="Btn_pass" runat="server" OnClick="Btn_pass_Click" Text="ChangePassword" />
                        &nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
