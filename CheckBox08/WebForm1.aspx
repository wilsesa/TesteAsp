<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CheckBox08.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
Cantidad a pagar:<asp:TextBox ID="txtPago" runat="server">0</asp:TextBox>
            <br />
            <asp:CheckBox ID="chkQueso" runat="server" AutoPostBack="True" OnCheckedChanged="chkQueso_CheckedChanged" Text="Extra queso" />
            <br />
            <asp:CheckBox ID="chkPapas" runat="server" Checked="True" Text="Papas" />
            <br />
            <asp:CheckBox ID="chkBebida" runat="server" Text="Bebida" />
            <br />
            Total: <asp:Label ID="lblTotal" runat="server" Text="Label" ToolTip="$0"></asp:Label>
            <br />
            <asp:Button ID="btnCalcular" runat="server" OnClick="btnCalcular_Click" Text="Calcular" />
        </div>
    </form>
</body>
</html>
