<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm01.aspx.cs" Inherits="ControlesEventos05.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            .....................................
            <br />
            <br />
            Evento PostBack
            <br />
            <asp:Button ID="btnPostBack" runat="server" Text="PostBack" OnClick="btnPostBack_Click" />
            <asp:Label ID="lblMensajePB" runat="server" Text="Antes del PostBack"></asp:Label>
            <br />
            <br />
            Evento Cached
            <br />
            <asp:TextBox ID="txtChanged" runat="server" OnTextChanged="txtChanged_TextChanged"></asp:TextBox>
            <asp:Label ID="lblMensajeCached" runat="server" Text="No ha sucedido el evento cached"></asp:Label>
            <br />
            <br />
            Evento Validacion
            <br />
            <asp:TextBox ID="txtValidacion" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RFVtxtValidacion" runat="server" ErrorMessage="Mi mensaje de Error" ControlToValidate="txtValidacion" Enabled="False"></asp:RequiredFieldValidator>
            <%--<asp:Label ID="RFVtxtValidacion" runat="server" Text="Mi mensaje de error"></asp:Label>--%>
        </div>
    </form>
</body>
</html>
