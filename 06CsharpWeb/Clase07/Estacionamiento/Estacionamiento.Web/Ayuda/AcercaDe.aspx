<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Principal.Master" AutoEventWireup="true" CodeBehind="AcercaDe.aspx.cs" Inherits="Estacionamiento.Web.Ayuda.AcercaDe" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenidoPrincipal" runat="server">
    <div class="row">
        <div class="col-md-6 offset-md-3">            
            <div class="card">
                <img src="../Imagenes/logo-educacionit.jpg" class="card-img-top" alt="...">
                <div class="card-body">
                    <h5 class="card-title">Acerca de Estaciona-IT</h5>
                    <p class="card-text">Este es un proyecto de desarrollo con fines didacticos para el programa Digit@lers</p>
                    <a href="../Default.aspx" class="btn btn-primary">Aceptar</a>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="contenidoFooter" runat="server">
</asp:Content>
