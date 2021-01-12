<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Principal.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Estacionamiento.Web.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenidoPrincipal" runat="server">
    <div class="row">
        <div class="col-lg-8">
            <h3>Estacionamientos administrados</h3>
            
            <asp:panel runat="server" ID="pnlError" Visible="false">
                <div class="alert alert-danger" role="alert">
                  <asp:Label runat="server" ID="lblError"></asp:Label>
                </div>
            </asp:panel>           

            <asp:ListView runat="server" id="lstPlayasEstacionamiento">
                <LayoutTemplate>
                    <div class="row row-cols-1 row-cols-md-2">
                      
                          <asp:PlaceHolder runat="server" id="itemPlaceHolder"></asp:PlaceHolder>
                      
                    </div>
                </LayoutTemplate>
                <ItemTemplate>
                    <div class="col mb-4">
                        <div class="card">
                          <div class="card-body">
                            <h5 class="card-title"><%#Eval("Nombre") %></h5>
                              <%--<a href="<%=Page.ResolveUrl("~/Administracion/Cocheras.aspx?Id="+Eval("Nombre")) %>" class="btn btn-primary">--%>
                              <a href="<%#Eval("Id",Page.ResolveUrl("~/Administracion/Cocheras.aspx?Id={0}")) %>" class="btn btn-primary">
                                  Administrar
                              </a>
                          </div>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:ListView>

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
