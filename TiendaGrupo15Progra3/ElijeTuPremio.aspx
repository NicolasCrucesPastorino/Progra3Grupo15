<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ElijeTuPremio.aspx.cs" Inherits="TiendaGrupo15Progra3.ElijeTuPremio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2 class="text-center mb-4">Elige tu premio</h2>

    <div class="row">
        <% foreach (var premio in premios)
            { %>
        <div class="col-md-4 mb-4">
            <div class="card h-100">
                <div class="card-body text-center">
                    <h5 class="card-title"><%= premio.Nombre %></h5>

                    <!-- Carousel -->
                    <div id="carousel<%= premio.Id %>" class="carousel slide mb-3" data-bs-ride="carousel">
                        <div class="carousel-inner">
                            <% for (int i = 0; i < premio.Imagenes.Count; i++)
                                { %>
                            <div class="carousel-item <%= i == 0 ? "active" : "" %>">
                                <img src="<%= premio.Imagenes[i] %>" class="d-block w-100" alt="imagen" style="height: 250px; object-fit: contain; object-position: center;">
                            </div>
                            <% } %>
                        </div>
                        <!-- Controles de Carousel-->
                        <button class="carousel-control-prev" type="button" data-bs-target="#carousel<%= premio.Id %>" data-bs-slide="prev">
                            <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                            <span class="visually-hidden">Anterior</span>
                        </button>
                        <button class="carousel-control-next" type="button" data-bs-target="#carousel<%= premio.Id %>" data-bs-slide="next">
                            <span class="carousel-control-next-icon" aria-hidden="true"></span>
                            <span class="visually-hidden">Siguiente</span>
                        </button>
                    </div>

                    <a href="/IngresaTusDatos.aspx?option=<%= premio.Id %>" class="btn btn-primary" onClick="PremioElegido">Elígeme</a>
                </div>
            </div>
        </div>
        <% } %>
    </div>
</asp:Content>
