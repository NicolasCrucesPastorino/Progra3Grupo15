<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TiendaGrupo15Progra3.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

                <asp:Label ID="LoginLabelUsuario" runat="server" Text="IngreseUsuario">Ingrese Usuario:</asp:Label>
                <asp:TextBox id="LoginTextUsuario" runat="server" placeholder="XXXUsuarioXXX"></asp:TextBox>
    <div>
        <asp:Label ID="LoginLabelContrasenia" runat="server" Text="IngreseContrasenia">Ingrese Contrasenia:</asp:Label>                    
        <asp:TextBox id="LoginTextContrasenia" runat="server" placeholder="XXX*******XXX"></asp:TextBox>

    </div>
    <div>
        <asp:Button ID="LoginButton" runat="server" Text="Loguearse" />

    </div>
        
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder3" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
