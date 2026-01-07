<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Logout.aspx.cs" Inherits="Electrifiers_2._0.UI.Logout" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Logout</title>
    <meta http-equiv="refresh" content="2;url=Login.aspx" /> <!-- Redirect to login after 2 seconds -->
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align:center; margin-top:50px;">
            <h3>You have been logged out successfully!</h3>
            <p>Redirecting to Login page...</p>
        </div>
    </form>
</body>
</html>
