<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomForm1.aspx.cs" Inherits="ValidationDemo.CustomForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
        function ValidateUsername(source, args) {
            var value = args.Value;
            if (value.length >= 6) {
                args.IsValid = true;
            } else {
                args.IsValid = false;
                alert("Username must be at least 6 characters");
            }
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Username : 
            <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
            <br />

            <asp:CustomValidator ID="CustomValidatorUsername" runat="server" ControlToValidate="txtUsername"
                ErrorMessage="Atleast 6 characters" ForeColor="Red" OnServerValidate="CustomValidatorUsername"></asp:CustomValidator>

            <br /> <br />

            <asp:Button ID="btnSave" runat="server" Text="Save" Onclick ="btnSaveClick" />
            <br /><br />

            <asp:Label ID="lblMsg" runat="server" Font-Bold="true"></asp:Label>
        </div>
    </form>
</body>
</html>
