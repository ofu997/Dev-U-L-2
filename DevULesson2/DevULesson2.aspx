<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DevULesson2.aspx.cs" Inherits="DevULesson2.DevULesson2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Simple Calculator<br />
            <br />
            1st number:
            <asp:TextBox ID="firstTextBox" runat="server" OnTextChanged="firstTextBox_TextChanged"></asp:TextBox>
            <br />
            <br />
            2nd number:&nbsp;
            <asp:TextBox ID="secondTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="addButton" runat="server" OnClick="addButton_Click" Text="+" />
&nbsp;<asp:Button ID="subtractButton" runat="server" OnClick="subtractButton_Click" Text="-" />
&nbsp;<asp:Button ID="multiply" runat="server" OnClick="multiply_Click" Text="x" />
&nbsp;<asp:Button ID="divideButton" runat="server" OnClick="divideButton_Click" Text="/" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server" BackColor="#EEFFFF" BorderColor="White" style="font-weight: 700; color: #006A00"></asp:Label>
        </div>
    </form>
</body>
</html>
