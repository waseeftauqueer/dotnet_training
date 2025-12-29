<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddBill.aspx.cs" Inherits="Electrifiers.AddBill" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add Electricity Bill</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f0f2f5;
        }

        .form-container {
            width: 400px;
            margin: 50px auto;
            padding: 30px;
            background-color: #fff;
            border-radius: 10px;
            text-align: center;
        }

        .txtInput {
            width: 100%;
            padding: 8px;
            margin-bottom: 5px;
            border-radius: 5px;
            border: 1px solid #ccc;
        }

        .btnSubmit {
            width: 100%;
            padding: 10px;
            background-color: #28a745;
            border: none;
            color: white;
            font-weight: bold;
            border-radius: 5px;
            margin-top: 10px;
        }

        .error {
            color: red;
            font-size: 12px;
            text-align: left;
        }
    </style>
</head>

<body>
<form id="form1" runat="server">
    <div class="form-container">
        <asp:Label ID="lblMessage" runat="server" ForeColor="Red" Visible="false"></asp:Label>

        <h2>Add Electricity Bill</h2>
        <asp:Label runat="server" Text="Consumer Number"></asp:Label>
        <asp:TextBox ID="txtConsumerNumber" runat="server" CssClass="txtInput"></asp:TextBox>
        <asp:RequiredFieldValidator ID="VConsumerNumber" runat="server" ControlToValidate="txtConsumerNumber" ErrorMessage="Consumer Number is required" ForeColor="Red" />
        <br />
        <asp:RegularExpressionValidator ID="revConsumerNumber" runat="server" ControlToValidate="txtConsumerNumber"
         ValidationExpression="^EB\d{5}$" ErrorMessage="Consumer Number must be in format EB12345" ForeColor="Red" />
        <br /><br />

        <asp:Label runat="server" Text="Consumer Name"></asp:Label>
        <asp:TextBox ID="txtConsumerName" runat="server" CssClass="txtInput"></asp:TextBox>
        <asp:RequiredFieldValidator ID="VConsumerName" runat="server" ControlToValidate="txtConsumerName" ErrorMessage="Consumer Name is required" ForeColor="Red" />
        <br />
        <asp:RegularExpressionValidator ID="revConsumerName" runat="server" ControlToValidate="txtConsumerName"
        ValidationExpression="^[A-Za-z ]{3,50}$" ErrorMessage="Name must contain only alphabets" CssClass="error" />
        <br /><br />

        <asp:Label runat="server" Text="Units Consumed"></asp:Label>
        <asp:TextBox ID="txtUnitsConsumed" runat="server" CssClass="txtInput"></asp:TextBox>
        <asp:RequiredFieldValidator ID="VUnits" runat="server" ControlToValidate="txtUnitsConsumed" ErrorMessage="Units Consumed is required" ForeColor="Red" />
        <br />
        <asp:RangeValidator ID="rvUnits" runat="server" ControlToValidate="txtUnitsConsumed"
         MinimumValue="0" MaximumValue="100000" Type="Integer" ErrorMessage="Units must be a positive number" ForeColor="Red" />
        <br /><br />

        <asp:Button ID="btnAddBill" runat="server" Text="Add Bill" CssClass="btnSubmit" OnClick="btnAddBill_Click" />
        <asp:Label ID="lblBillAmount" runat="server" ForeColor="Green"></asp:Label>

    </div>
</form>
</body>
</html>
