<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewBills.aspx.cs" Inherits="Electrifiers.ViewBills" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>View Last N Bills</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f0f2f5;
            margin: 0; 
            padding: 0;
        }

        .form-container {
            width: 500px;
            margin: 50px auto;
            padding: 30px;
            background-color: #fff;
            border-radius: 10px;
            text-align: center;
        }

        .form-container h2 {
            margin-bottom: 20px;
            color: #333;
        }

        .form-container label {
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
            margin-bottom: 20px;
        }

        #GridView1 {
            width: 100%;
            border-collapse: collapse;
        }

        #GridView1 th, #GridView1 td {
            border: 1px solid #ccc;
            padding: 8px;
            text-align: left;
        }

        #GridView1 th {
            background-color: #28a745;
            color: #fff;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="form-container">
            <h2>View Last N Bills</h2>
            <asp:Label ID="lblN" runat="server" Text="Enter number of bills:" CssClass="lbl"></asp:Label>
            <asp:TextBox ID="txtN" runat="server" CssClass="txtInput"></asp:TextBox>
            <asp:RequiredFieldValidator ID="VInput" runat="server" ControlToValidate="txtN" ErrorMessage="number is required" ForeColor="Red" />
            <br />
            <br />

            <asp:Button ID="btnFetch" runat="server" Text="Fetch Bills" CssClass="btnSubmit" OnClick="btnFetch_Click" />

            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" CssClass="grid">
                <Columns>
                    <asp:BoundField DataField="ConsumerNumber" HeaderText="Consumer Number" />
                    <asp:BoundField DataField="ConsumerName" HeaderText="Consumer Name" />
                    <asp:BoundField DataField="UnitsConsumed" HeaderText="Units Consumed" />
                    <asp:BoundField DataField="BillAmount" HeaderText="Bill Amount" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
