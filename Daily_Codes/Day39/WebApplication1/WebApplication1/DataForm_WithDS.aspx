<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataForm_WithDS.aspx.cs" Inherits="WebApplication1.DataForm_WithDS" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="CourseId" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="CourseId" HeaderText="CourseId" InsertVisible="False" ReadOnly="True" SortExpression="CourseId" />
                <asp:BoundField DataField="CourseName" HeaderText="CourseName" SortExpression="CourseName" />
                <asp:BoundField DataField="Credits" HeaderText="Credits" SortExpression="Credits" />
                <asp:BoundField DataField="Semester" HeaderText="Semester" SortExpression="Semester" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:AdoDBConnectionString %>" ProviderName="<%$ ConnectionStrings:AdoDBConnectionString.ProviderName %>" SelectCommand="SELECT * FROM [Courses]"></asp:SqlDataSource>
        <asp:DetailsView ID="DetailsView1" runat="server" Height="50px" Width="125px">
        </asp:DetailsView>
    </form>
</body>
</html>
