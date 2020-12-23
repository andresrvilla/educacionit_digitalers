<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Principal.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Estacionamiento.Web.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenidoPrincipal" runat="server">
    <div class="row">
        <div class="col-lg-8">
            Hola Mundo
        </div>
        <div class="col-lg-4">
            <a href="Botonera.aspx">Ir a la botonera</a>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="contenidoFooter" runat="server">
    Esto es el pie de pagina
</asp:Content>
