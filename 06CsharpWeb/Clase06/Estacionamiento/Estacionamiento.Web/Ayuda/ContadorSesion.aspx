<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Principal.Master" AutoEventWireup="true" CodeBehind="ContadorSesion.aspx.cs" Inherits="Estacionamiento.Web.Ayuda.ContadorSesion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenidoPrincipal" runat="server">
    <h3>Contador por ViewState</h3>
    <asp:Label ID="lblContadorViewState" runat="server">0</asp:Label><br />
    <asp:Button ID="btnIncrementarViewState" CssClass="btn btn-primary" OnClick="btnIncrementarViewState_Click" runat="server" Text="Incrementar" />
    <hr />
    <h3>Contador por sesion</h3>
    <asp:Label ID="lblContador" runat="server">0</asp:Label><br />
    <asp:Button ID="btnIncrementar" CssClass="btn btn-primary" runat="server" OnClick="btnIncrementar_Click" Text="Incrementar" />
    <hr />
    <h3>Contador por aplicación</h3>
    <asp:Label ID="lblContadorAplicacion" runat="server">0</asp:Label>
    <asp:button ID="btnIncrementarAplicacion" runat="server" CssClass="btn btn-primary" OnClick="btnIncrementarAplicacion_Click" Text="Incrementar" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="contenidoFooter" runat="server">
</asp:Content>
