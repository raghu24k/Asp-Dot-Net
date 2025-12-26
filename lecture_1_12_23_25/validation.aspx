<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="validation.aspx.cs" Inherits="lecture_1_12_23_25.validation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Required field validator:<br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
        &nbsp;&nbsp;&nbsp; <asp:TextBox ID="textbox1" runat="server" ></asp:TextBox>
        &nbsp;&nbsp;
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" BackColor="Red" BorderColor="White" ControlToValidate="textbox1" ErrorMessage="Name is Required"></asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        </div>
    </form>
</body>
</html>
