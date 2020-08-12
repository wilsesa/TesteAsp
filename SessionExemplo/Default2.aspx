<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default2.aspx.cs" Inherits="SessionExemplo.Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnRecuperarDados" runat="server" Text="Recuperar dados da Session" OnClick="btnRecuperarDados_Click" />
            <asp:Label ID="lblNome" runat="server" Text="Nome"></asp:Label>
        </div>
    </form>
</body>
</html>
