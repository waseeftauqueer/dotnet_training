<%@ Page Language="C#" AutoEventWireup="true" 
    MasterPageFile="~/UI/MasterPage.master" 
    CodeBehind="ViewBills.aspx.cs" 
    Inherits="Electrifiers_2._0.UI.ViewBills" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="server">
    <h2>View Electricity Bills</h2>

    <asp:Label ID="lblMsg" runat="server" ForeColor="Red"></asp:Label>
    <br />

    <table>
        <tr>
            <td>Consumer Number:</td>
            <td><asp:TextBox ID="txtConsumerNumber" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Month:</td>
            <td>
                <asp:DropDownList ID="ddlMonth" runat="server">
                    <asp:ListItem Text="--Any--" Value="" />
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
        <tr>
            <td>Bill Amount From:</td>
            <td><asp:TextBox ID="txtMinAmount" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Bill Amount To:</td>
            <td><asp:TextBox ID="txtMaxAmount" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Date From:</td>
            <td><asp:TextBox ID="txtStartDate" runat="server" placeholder="yyyy-mm-dd"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Date To:</td>
            <td><asp:TextBox ID="txtEndDate" runat="server" placeholder="yyyy-mm-dd"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Last N Bills:</td>
            <td><asp:TextBox ID="txtLastN" runat="server"></asp:TextBox></td>
        </tr>
    </table>
    <br />
    <asp:Button ID="btnFilter" runat="server" Text="Filter Bills" OnClick="btnFilter_Click" />
    <br /><br />

    <asp:GridView ID="gvBills" runat="server" AutoGenerateColumns="False" GridLines="Both">
        <Columns>
            <asp:BoundField DataField="ConsumerNumber" HeaderText="Consumer Number" />
            <asp:BoundField DataField="ConsumerName" HeaderText="Consumer Name" />
            <asp:BoundField DataField="UnitsConsumed" HeaderText="Units Consumed" />
            <asp:BoundField DataField="BillAmount" HeaderText="Bill Amount" DataFormatString="{0:C}" />
            <asp:BoundField DataField="BillMonth" HeaderText="Month" />
            <asp:BoundField DataField="BillYear" HeaderText="Year" />
            <asp:BoundField DataField="CreatedDate" HeaderText="Created Date" DataFormatString="{0:yyyy-MM-dd HH:mm}" />
        </Columns>
    </asp:GridView>
</asp:Content>
