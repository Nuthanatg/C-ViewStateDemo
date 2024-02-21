<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="ViewstateDemo1.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #Text1 {
            margin-top: 9px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            ASP.NET Server Control:
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            HTML Control:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <!--<input id="Text1" type="text" /></div> // html control won't retain its state we can change this to server control-->
            <input id="Text1" type="text" runat="server" /></div>
        <p>
            &nbsp;</p>
        <asp:Button ID="Button1" runat="server" Text="Button" />
    </form>
</body>
</html>
