﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm02.aspx.cs" Inherits="StateLess001.WebForm02" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtConteo" runat="server"></asp:TextBox>
            <asp:Button ID="btnIncrementa" runat="server" OnClick="btnIncrementa_Click" Text="Incrementa" />
            <br />
            ViewState webforms2 
            <br />
            Comparar com webforms4 en leccion de variables de sesion
        </div>
    </form>
</body>
</html>
