<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ListBox14.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lbFrutas" runat="server" SelectionMode="Multiple">
            <asp:ListItem Text="Banana" Value="1" />
            <asp:ListItem Text="Cereza" Value="2" />
            <asp:ListItem Text="Kiwi" Value="3" />
            <%--<asp:ListItem Text="Manzana" Value="4" />
            <asp:ListItem Text="Platano" Value="5" />--%>
        </asp:ListBox>
        <asp:Button ID="btnSeleccionar" runat="server" Text="Seleccionar" OnClick="btnSeleccionar_Click" />
    </form>
</body>
</html>
