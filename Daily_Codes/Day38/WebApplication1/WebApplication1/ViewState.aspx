<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewState.aspx.cs" Inherits="WebApplication1.ViewState" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ViewState Example</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblusername" runat="server" Text="User Name:"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtusername" runat="server" Width="200px"></asp:TextBox>
            <br /><br />

            <asp:Label ID="lblpassword" runat="server" Text="Password:"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtpass" runat="server" TextMode="Password"></asp:TextBox>
            <br /><br />

            <asp:Button ID="BtnStore" runat="server" Text="Store Data" OnClick="BtnStore_Click" />
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="BtnLoad" runat="server" Text="Load Data" OnClick="BtnLoad_Click" />
            <br /><br />

            <asp:Label ID="lblmessage" runat="server" Text="" ForeColor="Blue"></asp:Label>
        </div>
    </form>
</body>
</html>
