<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="IngresaTusDatos.aspx.cs" Inherits="TiendaGrupo15Progra3.IngresaTusDatos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h2>Ingresa tus datos</h2>
    <form id="FormularioDatos">
    <asp:Label ID="DNILabel" runat="server" Text="Label">DNI:</asp:Label>
    <asp:TextBox ID="DNInumero" textmode="Number" placeholder="12345678" runat="server"></asp:TextBox>

    <asp:Label ID="nombreLabel" runat="server" Text="Label">Nombre:</asp:Label>    
    <asp:TextBox ID="nombreText" runat="server" placeholder="Nombre"></asp:TextBox>

    <asp:Label ID="apellidoLabel" runat="server" Text="Label">Apellido:</asp:Label>
    <asp:TextBox ID="apellidoText" runat="server" placeholder="Apellido"></asp:TextBox>

    <asp:Label ID="EmailLabel" runat="server" Text="Label">Email:</asp:Label>
    <asp:TextBox ID="EmailInput" runat="server" placeholder="Email" textmode="Email"></asp:TextBox>

    <asp:Label ID="direccionLabel" runat="server" Text="Label">Direccion:</asp:Label>
    <asp:TextBox ID="direccionText" runat="server" placeholder="Direccion"></asp:TextBox>

    <asp:Label ID="ciudadLabel" runat="server" Text="Label">Ciudad:</asp:Label>
    <asp:TextBox ID="ciudadText" placeholder="Ciudad" runat="server"></asp:TextBox>

    <asp:Label ID="codigoPostalLabel" runat="server" Text="Label">Codigo Postal:</asp:Label>
    <asp:TextBox ID="codigoPostalText" placeholder="Codigo Postal" runat="server"></asp:TextBox>

    <asp:CheckBox ID="terminosCheckBox" runat="server" />
    <asp:Label ID="terminosLabel" runat="server" Text="Label">Acepto los terminos y condiciones</asp:Label>

    <asp:Button type="submit" ID="ParticiparButton" runat="server" Text="Participar" OnClick="ParticiparButton_Click" />

    </form>
</asp:Content>
