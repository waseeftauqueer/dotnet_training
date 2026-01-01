<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginForm.aspx.cs" Inherits="Security_Form_Prj.LoginForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        Username<asp:TextBox ID="txtLogin" runat="server" style="width: 128px; margin-left: 44px"></asp:TextBox>
        <br />
        <br />
        Password<asp:TextBox ID="txtPass" runat="server" style="margin-left: 47px"></asp:TextBox>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <div>

            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Login" Height="31px" />

        </div>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
