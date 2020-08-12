<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="LinkLinkButton09.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Link<br />
            <asp:HyperLink ID="hlkUno" runat="server" NavigateUrl="https://www.google.com.br/">Ir a Google</asp:HyperLink>
            <br />
            <br />
            Link a un formulario de la misma aplicación <br />
            <asp:HyperLink ID="hbkDos" runat="server" NavigateUrl="~/WebForm2.aspx">Ir  al webForm2</asp:HyperLink>
            <br />
            <br />
            Abrir otra pestana <br />
            <asp:HyperLink ID="hbkTres" runat="server" NavigateUrl="~/WebForm2.aspx" Target="_blank">Ir a webForm2 en otra pestana</asp:HyperLink>
            <br />
            <br />
            Link con imágenes <br />
            <asp:HyperLink ID="hbkImagen" runat="server" ImageUrl="~/Imagenes/smiley_ok.jpg" NavigateUrl="~/WebForm2.aspx">Link con imagen</asp:HyperLink>  <br /> <br />
            <asp:HyperLink ID="hbrImagen2" runat="server" ImageUrl="~/Imagenesxxx/smile_2.png" NavigateUrl="~/WebForm2.aspx">Ir al webForm2</asp:HyperLink> <br /> <br />
            Link Button <br />
            <asp:LinkButton ID="lkbUno" runat="server" PostBackUrl="~/WebForm2.aspx">Ir  a webForm2</asp:LinkButton> <br /> <br />
            Link Button con evento del laadao del cliente <br />
            <asp:LinkButton ID="lkbScript" runat="server" PostBackUrl="~/WebForm2.aspx" OnClientClick="return Funcion();" >Tiene un script</asp:LinkButton>

            <script type="text/javascript">
                function Funcion() {
                    alert("Soy una funcion de JavaScript!!!");

                    return true;
                }
            </script>
        </div>

    </form>
</body>
</html>
