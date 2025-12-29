<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="RegistrationForm.aspx.cs"
    Inherits="ValidationDemo.RegistrationForm" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration Form</title>

    <style type="text/css">
        .self_style {
            height: 400px;
            width: 100%;
            margin-left: 40px;
            background-color: #f0f0f0;
            border: 1px solid #ccc;
            padding: 20px;
        }
    </style>
</head>

<body>
    <form id="form1" runat="server">
        <div class="self_style">

            <h1 style="color:saddlebrown; font-size:20px; text-align:center">
                Registration Form
            </h1>

            <br /><br />

            <!-- Name -->
            Name:
            <asp:TextBox ID="txtname" runat="server" Width="200px" />
            <asp:RequiredFieldValidator 
                ID="RequiredFieldValidator1"
                runat="server"
                ControlToValidate="txtname"
                ErrorMessage="Name is required"
                ForeColor="Red" />
            <br /><br />

            <!-- Age -->
            Age:
            <asp:TextBox ID="txtage" runat="server" Width="200px" />
            <asp:RequiredFieldValidator
                ID="RequiredFieldValidator2"
                runat="server"
                ControlToValidate="txtage"
                ErrorMessage="Age is Required"
                Display="Dynamic"
                ForeColor="Red" />
            <asp:RangeValidator
                ID="RangeValidator1"
                runat="server"
                ControlToValidate="txtage"
                MinimumValue="21"
                MaximumValue="50"
                Type="Integer"
                ErrorMessage="Age must be between 21 and 50"
                Display="Dynamic"
                ForeColor="Red" />
            <br /><br />

            <!-- Email -->
            Email:
            <asp:TextBox ID="txtemail" runat="server" Width="200px" />
            <asp:RequiredFieldValidator
                ID="RequiredFieldValidator3"
                runat="server"
                ControlToValidate="txtemail"
                ErrorMessage="Email is Required"
                Display="Dynamic"
                ForeColor="Blue" />
            <asp:RegularExpressionValidator
                ID="RegularExpressionValidator1"
                runat="server"
                ControlToValidate="txtemail"
                ErrorMessage="Provide correct email format"
                Display="Dynamic"
                ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" />
            <br /><br />

            <!-- Password -->
            Password:
            <asp:TextBox ID="txtpassword" runat="server"
                Width="200px"
                PasswordMode="Password" />
            <asp:RequiredFieldValidator
                ID="RequiredFieldValidator4"
                runat="server"
                ControlToValidate="txtpassword"
                ErrorMessage="Password is required"
                ForeColor="Red" />
            <br /><br />

            <!-- Confirm Password -->
            Confirm Password:
            <asp:TextBox ID="txtcpass" runat="server"
                Width="200px"
                PasswordMode="Password" />
            <asp:RequiredFieldValidator
                ID="RequiredFieldValidator5"
                runat="server"
                ControlToValidate="txtcpass"
                ErrorMessage="Confirm the password"
                Display="Dynamic"
                ForeColor="Red" />
            <asp:CompareValidator
                ID="CompareValidator1"
                runat="server"
                ControlToValidate="txtcpass"
                ControlToCompare="txtpassword"
                ErrorMessage="Password is not matching"
                Display="Dynamic"
                ForeColor="Blue" />
            <br /><br />

            <!-- Button -->
            <asp:Button
                ID="BtnRegister"
                runat="server"
                Text="Register"
                OnClick="BtnRegister_Click" />

        </div>
    </form>
</body>
</html>
