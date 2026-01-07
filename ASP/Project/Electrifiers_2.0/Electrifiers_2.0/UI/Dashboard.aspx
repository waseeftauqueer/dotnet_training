<%@ Page Language="C#" AutoEventWireup="true" 
    MasterPageFile="~/UI/MasterPage.master" 
    CodeBehind="Dashboard.aspx.cs" 
    Inherits="Electrifiers_2._0.UI.Dashboard" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="dashboard-container">
        <h2>Welcome to the Dashboard</h2>
        <p>Welcome to the Electricity Billing System. Choose from the options below to manage electricity bills.</p>

        <div class="dashboard-cards">
            <a class="dashboard-card" href="AddBill.aspx">Add New Bill</a>
            <a class="dashboard-card" href="ViewBills.aspx">View Bills</a>
            <a class="dashboard-card" href="Logout.aspx">Logout</a>
        </div>
    </div>
</asp:Content>
