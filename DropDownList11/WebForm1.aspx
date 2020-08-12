<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="DropDownList11.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Frutas:<br />
        </div>
        <asp:DropDownList ID="ddlFrutas" runat="server">
            <asp:ListItem Value="1">Manzana</asp:ListItem>
            <asp:ListItem Value="2">Pera</asp:ListItem>
            <asp:ListItem Value="3">Durazno</asp:ListItem>
            <asp:ListItem Value="4">Papaya</asp:ListItem>
            <asp:ListItem Value="5">Guayaba</asp:ListItem>
        </asp:DropDownList>
        <asp:Button ID="btnPrueba" runat="server" OnClick="btnPrueba_Click" Text="Prueba" />
&nbsp;&nbsp;
        <asp:Label ID="lblSelecionado" runat="server" Text="Selecionado"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblIndice" runat="server" Text="Indice"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblValor" runat="server" Text="Valor"></asp:Label>
    </form>
</body>
</html>
