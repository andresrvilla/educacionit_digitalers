<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Principal.Master" AutoEventWireup="true" CodeBehind="Cocheras.aspx.cs" Inherits="Estacionamiento.Web.Administracion.Cocheras" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenidoPrincipal" runat="server">
    <div class="row">
        <div class="col-md-8 offset-md-2">
            <asp:ListView runat="server" ID="lstCocheras">
                <LayoutTemplate>
                    <div class="row row-cols-1 row-cols-md-2">                      
                          <asp:PlaceHolder runat="server" id="itemPlaceHolder"></asp:PlaceHolder>                      
                    </div>
                </LayoutTemplate>
                <ItemTemplate>
                    <div class="col mb-4">
                        <div class="card">
                          <div class="card-body">
                            <h5 class="card-title">Nro Cochera: <%#Eval("NumeroCochera") %></h5>
                              <% If ((Estacionamiento.ClasesDeNegocio.Cochera)Container.DataItem).EstaVacia then %>
                              <%--<a href="<%=Page.ResolveUrl("~/Administracion/Cocheras.aspx?Id="+Eval("Nombre")) %>" class="btn btn-primary">
                              <a href="<%#Eval("Id",Page.ResolveUrl("~/Administracion/Cocheras.aspx?Id={0}")) %>" class="btn btn-primary">
                                  Administrar
                              </a>--%>
                          </div>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:ListView>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="contenidoFooter" runat="server">
</asp:Content>
