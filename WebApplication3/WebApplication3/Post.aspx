<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Post.aspx.cs" Inherits="WebApplication3.Post" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
        <div style="background-color: aqua;">
            <table>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Post Id"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtPost_Id" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Post Title"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtPost_Title" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="Post Subtitle"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtPost_Subtitle" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text="Post Content"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtPost_Content" runat="server"></asp:TextBox></td>
                    </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label5" runat="server" Text="Post Status"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtPost_status" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>&nbsp</td>
                    <td>
                        <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
                        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" />
                        <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
                        <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
                        <asp:Button ID="btnReset" runat="server" Text="Reset" OnClick="btnReset_Click" /></td>
                </tr>
            </table>
        
        <hr />
        <h2>Post Details</h2>

        <asp:GridView ID="gvPostDetails" runat="server"></asp:GridView>
    </div>
        </form>
</body>
</html>