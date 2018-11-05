<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="loginpage.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <table>
            <tr><td>Username :</td><td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td></tr>
             <tr><td>Password :</td><td><asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox> </td></tr>
             <tr><td></td><td><asp:Button runat="server" Text="Login" id="btnLogin" OnClick="btnLogin_Click"/></td></tr>
            <tr><td></td><td><asp:Label runat="server" ID="lblMsg"></asp:Label></td></tr>
        </table>
    </form>
</body>
</html>
