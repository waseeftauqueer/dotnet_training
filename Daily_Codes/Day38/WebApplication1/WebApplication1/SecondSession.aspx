<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SecondSession.aspx.cs" Inherits="WebApplication1.SecondSession" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

<asp:Label ID="lblname" runat="server" Text=""></asp:Label>
<br />
<br />
 
        <asp:Label ID="lblregion" runat="server" Text=""></asp:Label>
<br />
<br />
 
        <asp:Button ID="BtnGetSession" runat="server" Text="Get Session Data" OnClick="BtnGetSession_Click" />
 
        &nbsp;&nbsp;&nbsp;&nbsp;
 
        <asp:Button ID="BtnThird" runat="server" Text="Redirect" OnClick="BtnThird_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;
</div>
    </form>
</body>
</html>
