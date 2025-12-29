<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminDashboard.aspx.cs" Inherits="Electrifiers.AdminDashboard" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admin Dashboard</title>
    <style>
        body {
            font-family: Arial;
            background-color: #f0f2f5;
            margin: 0; padding: 0;
        }
        .dashboard-container {
            width: 400px;
            margin: 100px auto;
            padding: 30px;
            background-color: #fff;
            display: flex;
            flex-direction: column;
            border-radius: 10px;
            text-align: center;
            box-shadow: 0 5px 15px rgba(0,0,0,0.3);
        }
        .dashboard-container h2 {
            margin-bottom: 20px;
        }
        .btnDashboard {
            width: 100%;
            padding: 10px;
            margin-bottom: 15px;
            font-weight: bold;
            border-radius: 5px;
            border: none;
            cursor: pointer;
            color: #fff;
            background-color: #28a745;
        }
        .btnDashboard:hover { background-color: #1e7e34; }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="dashboard-container">
            <h2>Admin Dashboard</h2>
            <asp:Button ID="btnAddBill" runat="server" Text="Add Bill" CssClass="btnDashboard" OnClick="btnAddBill_Click" />
            <asp:Button ID="btnViewBills" runat="server" Text="View Bills" CssClass="btnDashboard" OnClick="btnViewBills_Click" />
        </div>
    </form>
</body>
</html>
