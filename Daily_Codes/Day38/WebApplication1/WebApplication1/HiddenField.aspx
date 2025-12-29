<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HiddenField.aspx.cs" Inherits="WebApplication1.HiddenField" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>HiddenField Example</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <!-- Username -->
            <asp:Label ID="lblusername" runat="server" Text="User Name:"></asp:Label>
            &nbsp;&nbsp;
            <asp:TextBox ID="txtusername" runat="server" Width="200px"></asp:TextBox>
            <asp:HiddenField ID="HiddenField1" runat="server" />

            <br /><br />

            <!-- Password -->
            <asp:Label ID="lblpassword" runat="server" Text="Password:"></asp:Label>
            &nbsp;&nbsp;
            <asp:TextBox ID="txtpass" runat="server" TextMode="Password"></asp:TextBox>
            <asp:HiddenField ID="HiddenField2" runat="server" />

            <br /><br />

            <!-- Buttons -->
            <asp:Button ID="BtnStore" runat="server" Text="Store Data" OnClick="BtnStore_Click" />
            &nbsp;&nbsp;
            <asp:Button ID="BtnLoad" runat="server" Text="Load Data" OnClick="BtnLoad_Click" />

            <br /><br />

            <!-- Message Label -->
            <asp:Label ID="lblmessage" runat="server" Text="" ForeColor="Blue"></asp:Label>
        </div>
    </form>
</body>
</html>
