<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Principal.Master" AutoEventWireup="true" CodeBehind="Calculadora.aspx.cs" Inherits="Estacionamiento.Web.Ayuda.Calculadora" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenidoPrincipal" runat="server">
    Resultado: <br />
    <asp:Label runat="server" ID="lblResultado">0</asp:Label><br />
    <asp:TextBox runat="server" ID="txtIngresoNumero"></asp:TextBox><br />
    <asp:Button runat="server" Id="btnSumar" OnClick="btnSumar_Click" Text="Sumar" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="contenidoFooter" runat="server">
</asp:Content>
