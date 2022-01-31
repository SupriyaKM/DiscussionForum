<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication3.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <h1>Login</h1>
            <hr />
            <table>
                <tr>
                    <td>EmailId</td><td>
                        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Password</td><td>
                        <asp:TextBox ID="txtPasword" TextMode="Password" runat="server"></asp:TextBox></td>
                </tr>
                <tr><td></td><td>
                    <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click1" />
                    <asp:Button ID="btnReset" runat="server" Text="Reset" /></td></tr>
                 <tr><td colspan="2">
                     <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/UserRegistration.aspx">Register</asp:HyperLink>
                     </td></tr>
            </table>
            <hr />
            <div>
                <asp:Label Text="" ID="lblResult" runat="server" />
            </div>
        </div>
    </form>
</body>
</html>
        