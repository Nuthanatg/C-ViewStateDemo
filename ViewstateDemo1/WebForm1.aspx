﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ViewstateDemo1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:TextBox ID="TextBox1" runat="server" EnableViewState="true"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Button" />
        <div>
        </div>
    </form>
</body>
</html>
