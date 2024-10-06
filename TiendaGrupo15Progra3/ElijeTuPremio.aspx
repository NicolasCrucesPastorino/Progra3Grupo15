<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ElijeTuPremio.aspx.cs" Inherits="TiendaGrupo15Progra3.ElijeTuPremio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Elije tu premio</h2>
    
    
    <% foreach (var premio in premios)
        
        {%>
                
            <li>
                <%= premio.Nombre %>
                <div>
                    <%foreach (var imagen in premio.Imagenes) {%>
                    <img src="<%= imagen %>" alt="imagen" width="150" height="150" />
                    <% } %>
                    <a href="/IngresaTusDatos.aspx?option=<%= premio.Id %>" class="btn btn-primary" >Eligeme</a>
                  
                </div>
            </li>
        <% } %>
           
</asp:Content>
