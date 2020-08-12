<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="RadioButtonList.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:RadioButtonList ID="rblFrutas" runat="server">
            <asp:ListItem Text="Manzana" Value="1" />
            <asp:ListItem Text="Pera" Value="2" />
            <asp:ListItem Text="Durazno" Value="3" />
            <asp:ListItem Text="Platano" Value="4" />
            <asp:ListItem Text="Ananas" Value="5" />
            <asp:ListItem Text="Mango" Value="6" />
        </asp:RadioButtonList>
        <asp:Button ID="btnSeleccionar" runat="server" Text="Seleccionar" OnClick="btnSeleccionar_Click" />
        <br />
        <br />
        <p>--------------</p>
        <asp:RadioButtonList ID="rblColores" runat="server">
            <asp:ListItem Text="Rojo" Value="1" />
            <asp:ListItem Text="Naranja" Value="2" />
            <asp:ListItem Text="Amarillo" Value="3" />
            <asp:ListItem Text="Verede" Value="4" />
            <asp:ListItem Text="Azul" Value="5" />
            <asp:ListItem Text="Violeta" Value="6" />
        </asp:RadioButtonList>
        <asp:Button ID="btnSeleccionarLimpiar" runat="server" Text="Seleccionar y Limpiar" />
        <br />
    </form>
</body>
</html>
