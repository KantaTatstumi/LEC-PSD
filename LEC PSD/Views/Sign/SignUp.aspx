<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="LEC_PSD.Views.SignUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Sign Up</h1>
        </div>

        <br />

        <div>
            <p>Username<asp:TextBox ID="Username_Register" runat="server"></asp:TextBox></p>
            <p>Age<asp:TextBox ID="Age_Register" runat="server"></asp:TextBox></p>
            <p>Email<asp:TextBox ID="Email_Register" runat="server"></asp:TextBox></p>
            <p>Password<asp:TextBox ID="Password_Register" runat="server"></asp:TextBox></p>
            <p>Grade<asp:DropDownList ID="Grade_List" runat="server"></asp:DropDownList></p>
            <p>Major<asp:DropDownList ID="Major_List" runat="server"></asp:DropDownList></p>
            <br />
            <asp:Button ID="Sign_Up" runat="server" Text="Sign Up" OnClick="Sign_Up_Click"/>
        </div>
    </form>
</body>
</html>
