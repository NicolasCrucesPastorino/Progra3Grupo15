<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="TiendaGrupo15Progra3.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .bg-custom {
            background-image: url('images/fondo.png');
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

        .center-container {
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
            flex-direction: column;
        }

        .form-container {
            text-align: center;
            background-color: rgba(255, 255, 255, 0.8); /* Fondo semitransparente */
            padding: 30px;
            border-radius: 10px;
            box-shadow: 0 4px 8px rgba(0,0,0,0.1);
            width: 80%; /* Ajusta según sea necesario */
            max-width: 600px;
        }

        .btn-custom {
            padding: 20px 40px;
            font-size: 1.8rem;
            background-color: black;
            color: yellow;
            border: none;
            border-radius: 5px;
            margin-top: 20px;
        }

        .btn-custom:hover {
            background-color: darkgray;
            color: yellow;
        }

        input[type="text"], input[type="number"] {
            width: 100%;
            padding: 15px;
            margin-top: 10px;
            margin-bottom: 20px;
            font-size: 1.2rem;
            border: 1px solid #ccc;
            border-radius: 5px;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="bg-custom"></div>
    <div class="center-container">
        <div class="form-container">
            <asp:Label ID="Label1" runat="server" Text="Ingresa el valor de tu Voucher" CssClass="header-custom"></asp:Label>
            <asp:TextBox ID="CodigoVoucherText" runat="server" placeholder="XXXXXXXXXXXX" CssClass="form-control"></asp:TextBox>
            <asp:Button ID="EnviarCodigoVoucher" runat="server" Text="Enviar" OnClick="EnviarCodigoVoucher_Click" CssClass="btn btn-custom" />
        </div>
    </div>
</asp:Content>



