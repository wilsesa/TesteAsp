<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Boton06.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            SingleLine<br />
&nbsp;<asp:TextBox ID="txtSingleLine" runat="server" ToolTip="TextBox de una linea"></asp:TextBox>
            <asp:Label ID="lblSingleLine" runat="server" Text="Label"></asp:Label>
            <br />
            ReadOnly<br />
&nbsp;<asp:TextBox ID="txtReadOnly" runat="server" ReadOnly="True"></asp:TextBox>
            <br />
            MaxLeagth 5<br />
&nbsp;<asp:TextBox ID="txtMaxLength" runat="server" MaxLength="5"></asp:TextBox>
            <br />
            Columns 5<br />
&nbsp;<asp:TextBox ID="txtColumnas" runat="server" Columns="5"></asp:TextBox>
            <br />            
            MultiLine rows 5 <br />
            <asp:TextBox ID="txtMultiLine" runat="server" Columns="45" Rows="15" TextMode="MultiLine"></asp:TextBox>
            <br />
            Password<br />
&nbsp;<asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnEnviar" runat="server" Text="Enviar" OnClick="btnEnviar_Click"  />
        </div>
    </form>
</body>
</html>
