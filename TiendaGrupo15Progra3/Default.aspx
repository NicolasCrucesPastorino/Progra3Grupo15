<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TiendaGrupo15Progra3.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .bg-custom {
            background-image: url('images/IMGbtnParticipar.png');
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

        .button-container {
            position: fixed;
            bottom: 20%;
            right: 20%;
        }

        .btn-custom {
            padding: 30px 40px;
            font-size: 2.4rem;
            background-color: black;
            color: white;
            border: none;
            border-radius: 5px;
        }

        .btn-custom:hover {
            background-color: yellow;
            color: white;
        }

        .form-custom {
            background-color: rgba(255, 255, 255, 0.8); /* Fondo semitransparente */
            padding: 20px;
            border-radius: 5px;
        }

        .header-custom {
            color: blue;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="bg-custom"></div>
    <div class="container">
     
        <div class="button-container">
            <asp:Button ID="btnParticipa" runat="server" Text="Participa" OnClick="btnParticipa_Click" CssClass="btn btn-custom" />
        </div>
    </div>
</asp:Content>










