<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ElegirProducto.aspx.cs" Inherits="TiendaGrupo15Progra3.ElijeTuPremio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
    .bg-custom {
        background-image: url('images/fondoAmarillo.png');
        background-size: cover;
        background-position: center center;
        background-repeat: no-repeat;
        position: fixed;
        top: 0;
        left: 0;
        width: 100%;
        height: 100%;
        z-index: -1;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="bg-custom"></div>
        <div class="container"> </div>
    <h2 class="text-center mb-4">Elige tu premio</h2>

    <div class="row">
        <% foreach (var articulo in Productos)
            { %>
        <div class="col-md-4 mb-4">
            <div class="card h-100">
                <div class="card-body text-center">
                    <h5 class="card-title"><%= articulo.Nombre %></h5>

                    <!-- Carousel -->
                    <div id="carousel<%= articulo.Id %>" class="carousel slide mb-3" data-bs-ride="carousel">
                        <div class="carousel-inner">
                            <% for (int i = 0; i < articulo.Imagenes.Count; i++)
                                { %>
                            <div class="carousel-item <%= i == 0 ? "active" : "" %>">
                                <img src="<%= articulo.Imagenes[i] %>" class="d-block w-100" alt="imagen" style="height: 250px; object-fit: contain; object-position: center;">
                            </div>
                            <% } %>
                        </div>
                        <!-- Controles de Carousel-->
                        <button class="carousel-control-prev" type="button" data-bs-target="#carousel<%= articulo.Id %>" data-bs-slide="prev">
                            <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                            <span class="visually-hidden">Anterior</span>
                        </button>
                        <button class="carousel-control-next" type="button" data-bs-target="#carousel<%= articulo.Id %>" data-bs-slide="next">
                            <span class="carousel-control-next-icon" aria-hidden="true"></span>
                            <span class="visually-hidden">Siguiente</span>
                        </button>
                    </div>

                    <a href="DetalleProducto.aspx?id=<%= articulo.Id %>" class="btn btn-primary">Lo Quiero YA</a>

                    
                     
                </div>
            </div>
        </div>
        <% } %>
    </div>
</asp:Content>
