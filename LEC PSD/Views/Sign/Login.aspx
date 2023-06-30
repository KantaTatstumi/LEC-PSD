<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="LEC_PSD.Views.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Log In</h1>
        </div>

        <br />

        <div>
            <p>Email    :<asp:TextBox ID="Email_Login" runat="server" style="margin-left: 41px"></asp:TextBox></p>
            <p>Password :<asp:TextBox ID="Password_Login" runat="server" style="margin-left: 19px"></asp:TextBox></p>
            <br />
            <asp:Button ID="Log_In" runat="server" Text="Sign In" OnClick="Log_In_Click"/>
            <br />
            <p><asp:CheckBox ID="RememberMe" runat="server" />Remember me</p>
            <br />
            <br />
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Views/Sign/SignUp.aspx">Don't have an account registered yet? Sign Up here!</asp:HyperLink>
        </div>
    </form>
</body>
</html>
