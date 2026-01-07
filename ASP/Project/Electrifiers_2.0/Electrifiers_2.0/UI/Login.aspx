<%@ Page Language="C#" AutoEventWireup="true" 
    MasterPageFile="~/UI/MasterPage.master" 
    CodeBehind="Login.aspx.cs" 
    Inherits="Electrifiers_2._0.UI.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="login-container">
        <h2>Admin Login</h2>
        <asp:Label ID="lblMsg" runat="server" ForeColor="Red"></asp:Label>

        <asp:Label ID="lblUser" runat="server" Text="Username:"></asp:Label>
        <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>

        <asp:Label ID="lblPass" runat="server" Text="Password:"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>

        <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
    </div>
</asp:Content>
