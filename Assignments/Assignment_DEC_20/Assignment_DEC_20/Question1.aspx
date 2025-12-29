<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="Question1.aspx.cs" 
    Inherits="Assignment_DEC_20.Question1" 
    UnobtrusiveValidationMode="None" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Validation Form</title>
</head>
<body>
    <form id="f" runat="server">
        <div>
            <h3>insert your details:</h3>

            <asp:Label ID="lblN" runat="server" Text="name:"></asp:Label>
            <asp:TextBox ID="txtN" runat="server" Width="200px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvN" runat="server" ControlToValidate="txtN" ErrorMessage="* required" ForeColor="red" />
            <br /><br />

            <asp:Label ID="lblF" runat="server" Text="family name:"></asp:Label>
            <asp:TextBox ID="txtF" runat="server" Width="200px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvF" runat="server" ControlToValidate="txtF" ErrorMessage="* required" ForeColor="red" />
            <asp:CustomValidator ID="cvName" runat="server" ControlToValidate="txtF" OnServerValidate="chkName" ErrorMessage="must differ from name" ForeColor="red" />
            <br /><br />

            <asp:Label ID="lblAdd" runat="server" Text="address:"></asp:Label>
            <asp:TextBox ID="txtAdd" runat="server" Width="200px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvAdd" runat="server" ControlToValidate="txtAdd" ErrorMessage="* required" ForeColor="red" />
            <asp:CustomValidator ID="cvAdd" runat="server" ControlToValidate="txtAdd" OnServerValidate="chkAdd" ErrorMessage="at least 2 chars plz" ForeColor="red" />
            <br /><br />

            <asp:Label ID="lblCity" runat="server" Text="city:"></asp:Label>
            <asp:TextBox ID="txtCity" runat="server" Width="200px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvCity" runat="server" ControlToValidate="txtCity" ErrorMessage="* required" ForeColor="red" />
            <asp:CustomValidator ID="cvCity" runat="server" ControlToValidate="txtCity" OnServerValidate="chkCity" ErrorMessage="at least 2 chars plz" ForeColor="red" />
            <br /><br />

            <asp:Label ID="lblZip" runat="server" Text="zip code:"></asp:Label>
            <asp:TextBox ID="txtZip" runat="server" Width="200px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvZip" runat="server" ControlToValidate="txtZip" ErrorMessage="* required" ForeColor="red" />
            <asp:RegularExpressionValidator ID="revZip" runat="server" ControlToValidate="txtZip" ValidationExpression="^\d{5}$" ErrorMessage="zip must b 5 digits" ForeColor="red" />
            <br /><br />

            <asp:Label ID="lblPh" runat="server" Text="phone:"></asp:Label>
            <asp:TextBox ID="txtPh" runat="server" Width="200px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvPh" runat="server" ControlToValidate="txtPh" ErrorMessage="* required" ForeColor="red" />
            <asp:RegularExpressionValidator ID="revPh" runat="server" ControlToValidate="txtPh" ValidationExpression="^\d{2,3}-\d{7}$" ErrorMessage="format: XX-XXXXXXX or XXX-XXXXXXX" ForeColor="red" />
            <br /><br />

            <asp:Label ID="lblEm" runat="server" Text="e-mail:"></asp:Label>
            <asp:TextBox ID="txtEm" runat="server" Width="200px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvEm" runat="server" ControlToValidate="txtEm" ErrorMessage="* required" ForeColor="red" />
            <asp:RegularExpressionValidator ID="revEm" runat="server" ControlToValidate="txtEm"
            ValidationExpression="^[^\s@]+@[^\s@]+\.[^\s@]+$" ErrorMessage="invalid email, pls check" ForeColor="red" />
            <br /><br />

            <asp:Button ID="btnChk" runat="server" Text="check" OnClick="btnChk_Click" />
            <br /><br />

            <asp:ValidationSummary ID="valSum" runat="server" ForeColor="red" />
            <asp:Label ID="lblMsg" runat="server" ForeColor="green"></asp:Label>

        </div>
    </form>
</body>
</html>
