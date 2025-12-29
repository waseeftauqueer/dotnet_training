<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Electrifiers.Login" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admin Login</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f0f2f5;
            margin: 0;
            padding: 0;
        }

        .login-container {
            width: 350px;
            margin: 100px auto;
            padding: 30px;
            background-color: #fff;
            border-radius: 10px;
            text-align: center;
        }

        .login-container h2 {
            margin-bottom: 20px;
            color: #333;
        }

        .login-container label {
            display: block;
            text-align: left;
            margin-bottom: 5px;
            color: #555;
        }

        .txtInput {
            width: 100%;
            padding: 8px;
            margin-bottom: 15px;
            border: 1px solid #ccc;
            border-radius: 5px;
            box-sizing: border-box;
            font-size: 14px;
        }

        .btnSubmit {
            width: 100%;
            padding: 10px;
            background-color: #28a745;
            border: none;
            color: #fff;
            font-weight: bold;
            border-radius: 5px;
            cursor: pointer;
        }

        #lblMessage {
            margin-bottom: 15px;
            display: block;
            font-weight: bold;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="login-container">
            <h2>Admin Login</h2>
            <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
            
            <asp:Label ID="lblUsername" runat="server" Text="Username:"></asp:Label>
            <asp:TextBox ID="txtUsername" runat="server" CssClass="txtInput"></asp:TextBox>
            <asp:RequiredFieldValidator ID="VUsername" runat="server" ControlToValidate="txtUsername" ErrorMessage="username is required" ForeColor="Red" />
            <br /><br />
            <asp:Label ID="lblPassword" runat="server" Text="Password:"></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="txtInput"></asp:TextBox>
            
            <asp:RequiredFieldValidator ID="VPassword" runat="server" ControlToValidate="txtPassword" ErrorMessage="password is required" ForeColor="Red" />

            <asp:Button ID="btnLogin" runat="server" Text="Login" CssClass="btnSubmit" OnClick="btnLogin_Click" />
        </div>
    </form>
</body>
</html>
