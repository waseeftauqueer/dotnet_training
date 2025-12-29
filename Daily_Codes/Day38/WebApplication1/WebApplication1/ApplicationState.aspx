<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ApplicationState.aspx.cs" Inherits="WebApplication1.ApplicationState" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
<asp:Button ID="btnApp" runat="server" text="Get App Count" OnClick="btnApp_Click" />
<br /><br />
<asp:Label ID="lblcount" runat="server" Text=""></asp:Label>
</div>
    </form>
</body>
</html>
