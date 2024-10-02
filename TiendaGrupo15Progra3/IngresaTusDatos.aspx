<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="IngresaTusDatos.aspx.cs" Inherits="TiendaGrupo15Progra3.IngresaTusDatos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h2>Ingresa tus datos</h2>
    <form id="FormularioDatos">
    <asp:Label ID="DNILabel" runat="server" Text="Label">DNI:</asp:Label>
    <input id="DNIText" type="number" placeholder="12345678" />

    <asp:Label ID="nombreLabel" runat="server" Text="Label">Nombre:</asp:Label>
    <input id="nombreText" type="text" placeholder="Nombre"/>

    <asp:Label ID="apellidoLabel" runat="server" Text="Label">Apellido:</asp:Label>
    <input id="apellidoText" type="text" placeholder="Apellido"/>

    <asp:Label ID="EmailLabel" runat="server" Text="Label">Email:</asp:Label>
    <input id="EmailInput" type="email" placeholder="Email"/>

    <asp:Label ID="direccionLabel" runat="server" Text="Label">Direccion:</asp:Label>
    <input id="direccionText" type="text" placeholder="Direccion"/>

    <asp:Label ID="ciudadLabel" runat="server" Text="Label">Ciudad:</asp:Label>
    <input id="ciudadText" type="text" placeholder="Ciudad"/>

    <asp:Label ID="codigoPostalLabel" runat="server" Text="Label">Codigo Postal:</asp:Label>
    <input id="codigoPostalText" type="text" placeholder="Codigo Postal"/>

    <asp:CheckBox ID="terminosCheckBox" runat="server" />
    <asp:Label ID="terminosLabel" runat="server" Text="Label">Acepto los terminos y condiciones</asp:Label>

    <asp:Button ID="ParticiparButton" runat="server" Text="Participar" />

    </form>
</asp:Content>
