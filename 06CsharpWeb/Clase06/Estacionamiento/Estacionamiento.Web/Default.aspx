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
            <hr />
            Valor máximo de Int32: <asp:Label runat="server" ID="lblIntMaximo"></asp:Label><br />
            Valor mínimo de Int32: <asp:Label runat="server" ID="lblIntMinimo"></asp:Label>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="contenidoFooter" runat="server">
    Esto es el pie de pagina
</asp:Content>
