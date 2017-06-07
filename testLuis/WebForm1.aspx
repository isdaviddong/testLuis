<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="testLuis.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <br />
        App ID:
        <asp:TextBox ID="textBoxAppID" runat="server" Width="366px"></asp:TextBox>
        <br />
        App Key:
        <asp:TextBox ID="textBoxKey" runat="server" Width="355px"></asp:TextBox>
        <br />
        <br />
        語句: <asp:TextBox ID="textBoxQuery" runat="server" Width="592px"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Label ID="textBoxResult" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="判斷" OnClick="Button1_Click" />
    </div>
    </form>
</body>
</html>
