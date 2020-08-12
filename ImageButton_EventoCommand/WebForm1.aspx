<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ImageButton_EventoCommand.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="lblResultado">
            ImagenButton<br />  <br />           
            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Imagenes/smile_2.png" OnClick="ImageButton1_Click" /> <br /> <br /> <br />
            a:

            <asp:TextBox ID="txtA" runat="server">0</asp:TextBox>
            <br />
            b:<asp:TextBox ID="txtB" runat="server">0</asp:TextBox>
            <br />
            Label<br />
            <asp:Label ID="lblResultado" runat="server"></asp:Label>
            <br />
            <asp:Button ID="btnSuma" runat="server" CommandName="Suma" OnCommand="operaciones" Text="Suma" />
            <br />
            <br />
            <asp:Button ID="btnResta" runat="server" CommandName="Resta" OnCommand="operaciones" Text="Resta" />
            <br />
            <br />
            <asp:Button ID="btnMulti" runat="server" CommandName="Multi" OnCommand="operaciones" Text="Multi" />
            <br />
            <br />
            <asp:Button ID="btnDiv" runat="server" CommandName="Div" OnCommand="operaciones" Text="Div" />
            <br />
            <br />
            Ahora el miso handler com parametros<br />
            <br />
            <asp:Button ID="btnSaludo" runat="server" CommandArgument="Hola" CommandName="esp" OnCommand="mensaje" Text="Saludo" />
            <asp:Button ID="btnDespedida" runat="server" CommandArgument="Adios" CommandName="esp" OnCommand="mensaje" Text="Despedida" />
            <br />
            <br />
            <asp:Button ID="btnGreetings" runat="server" CommandArgument="Hello" CommandName="ing" OnCommand="mensaje" Text="Greetings" />
            <asp:Button ID="btnFareWell" runat="server" CommandArgument="GoodBye" CommandName="ing" OnCommand="mensaje" Text="FareWell" />

        </div>
    </form>
</body>
</html>
