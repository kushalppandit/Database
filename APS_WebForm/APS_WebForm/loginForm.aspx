<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="loginForm.aspx.cs" Inherits="APS_WebForm.loginForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        User Id<asp:TextBox ID="uid" runat="server"></asp:TextBox>
        Password<asp:TextBox ID="pwd" runat="server"></asp:TextBox><asp:Button ID="sbmt" runat="server" OnClick="sbmt_Click" Text="Submit" />
    </form>
</body>
</html>
