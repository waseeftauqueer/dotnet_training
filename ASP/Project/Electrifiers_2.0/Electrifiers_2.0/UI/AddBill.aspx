<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/UI/MasterPage.master" CodeBehind="AddBill.aspx.cs" Inherits="Electrifiers_2._0.UI.AddBill" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="server">
    <head>
        <title>Add Electricity Bill</title>
    </head>
    <h2>Add Electricity Bill</h2>
    <asp:Label ID="lblMsg" runat="server" ForeColor="Red"></asp:Label><br /><br />

    <table>
        <tr>
            <td>Consumer Number:</td>
            <td><asp:TextBox ID="txtConsumerNumber" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Consumer Name:</td>
            <td><asp:TextBox ID="txtConsumerName" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Units Consumed:</td>
            <td><asp:TextBox ID="txtUnits" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Month:</td>
            <td>
                <asp:DropDownList ID="ddlMonth" runat="server">
                    <asp:ListItem Text="January" Value="1" />
                    <asp:ListItem Text="February" Value="2" />
                    <asp:ListItem Text="March" Value="3" />
                    <asp:ListItem Text="April" Value="4" />
                    <asp:ListItem Text="May" Value="5" />
                    <asp:ListItem Text="June" Value="6" />
                    <asp:ListItem Text="July" Value="7" />
                    <asp:ListItem Text="August" Value="8" />
                    <asp:ListItem Text="September" Value="9" />
                    <asp:ListItem Text="October" Value="10" />
                    <asp:ListItem Text="November" Value="11" />
                    <asp:ListItem Text="December" Value="12" />
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>Year:</td>
            <td><asp:TextBox ID="txtYear" runat="server" Text='<%# DateTime.Now.Year %>'></asp:TextBox></td>
        </tr>
    </table>
    <br />
    <asp:Button ID="btnAddBill" runat="server" Text="Add Bill" OnClick="btnAddBill_Click" />

</asp:Content>
