<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Addition.aspx.cs" Inherits="Addition" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p id="No1">
            No 1:&nbsp;&nbsp;
            <asp:TextBox ID="txtbox1" runat="server"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p id="No2">
            No 1:&nbsp;&nbsp;
            <asp:TextBox ID="txtbox2" runat="server"></asp:TextBox>
        </p>
        <p id="lblresult">
            <asp:Label ID="lblresult" runat="server" Text="Result"></asp:Label>
        </p>
        <p>
&nbsp;<asp:Button ID="btnadd" runat="server" OnClick="btnadd_Click" Text="Add" />
&nbsp;&nbsp;
            <asp:Button ID="btnsub" runat="server" OnClick="btnsub_Click" Text="Subtract" />
&nbsp;
            <asp:Button ID="btnmulti" runat="server" OnClick="btnmulti_Click" Text="Multiplication" />
&nbsp;
            <asp:Button ID="btndiv" runat="server" OnClick="btndiv_Click" Text="Divison" />
&nbsp;
            <asp:Button ID="btnreset" runat="server" OnClick="btnreset_Click" Text="Reset" />
        </p>
    </form>
</body>
</html>
