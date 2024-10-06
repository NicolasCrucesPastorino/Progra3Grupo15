<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="TiendaGrupo15Progra3.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <asp:Label ID="Label1" runat="server" Text="Label">Ingresa El valor de tu Voucher</asp:Label>
    <asp:TextBox ID="CodigoVoucherText" runat="server" placeholder="XXXXXXXXXXXX"></asp:TextBox>

	<asp:Button ID="EnviarCodigoVoucher" runat="server" Text="Enviar" OnClick="EnviarCodigoVoucher_Click" />

</asp:Content>


