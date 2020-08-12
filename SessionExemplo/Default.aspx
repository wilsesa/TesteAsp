<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SessionExemplo._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <br />
    <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
    <asp:Label ID="lblNome" runat="server" Text="Nome"></asp:Label>
    <asp:Button ID="btnGravar" runat="server" Text="Salvar" OnClick="btnGravar_Click"  />

</asp:Content>
