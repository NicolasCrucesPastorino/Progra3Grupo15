<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="IngresaTusDatos.aspx.cs" Inherits="TiendaGrupo15Progra3.IngresaTusDatos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .bg-custom {
            background-color: darkorange;
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
        }

        .form-container {
            text-align: center;
            padding: 30px;
            border-radius: 10px;
            box-shadow: 0 4px 8px rgba(0,0,0,0.1);
            width: 100%;
            max-width: 600px;
        }

        .btn-custom {
            padding: 15px 30px;
            font-size: 1.2rem;
            background-color: black;
            color: yellow;
            border: none;
            border-radius: 5px;
            margin-left: 10px;
        }

        .form-custom .form-group {
            display: flex;
            align-items: center;
            gap: 10px;
        }

        .header-custom {
            color: black;
        }

        .row-custom {
            display: flex;
            align-items: center;
        }
    </style>
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="bg-custom"></div>
    <div class="center-container">
        <div class="form-container">
            <h1 class="header-custom">Ingresa tus Datos</h1>
            <div class="form-group">
                <label for="DNInumero" class="form-label">DNI:</label>
                <asp:TextBox ID="DNInumero" textmode="Number" CssClass="form-control" placeholder="12345678" runat="server"></asp:TextBox>
                <asp:Button ID="Button2" CssClass="btn btn-custom" runat="server" Text="Validar DNI" OnClick="ValidarClickButton_Click" />
            </div>
            <div class="form-group">
                <label for="nombreText" class="form-label">Nombre:</label>
                <asp:TextBox ID="nombreText" CssClass="form-control" placeholder="Nombre" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="apellidoText" class="form-label">Apellido:</label>
                <asp:TextBox ID="apellidoText" CssClass="form-control" placeholder="Apellido" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="EmailInput" class="form-label">Email:</label>
                <asp:TextBox ID="EmailInput" textmode="Email" CssClass="form-control" placeholder="Email" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="direccionText" class="form-label">Dirección:</label>
                <asp:TextBox ID="direccionText" CssClass="form-control" placeholder="Dirección" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="ciudadText" class="form-label">Ciudad:</label>
                <asp:TextBox ID="ciudadText" CssClass="form-control" placeholder="Ciudad" runat="server"></asp:TextBox>
            </div>
        <!-- Código Postal -->
        <div class="form-group">
            <label for="codigoPostalText" class="form-label">Código Postal:</label>
            <asp:TextBox ID="codigoPostalText" CssClass="form-control" placeholder="Código Postal" runat="server" textmode="Number"></asp:TextBox>
        </div>
        <!-- Aceptar términos -->
        <div class="form-group">
            <div class="form-check">
                <asp:CheckBox ID="terminosCheckBox" CssClass="form-check-input" runat="server" />
                <label for="terminosCheckBox" class="form-check-label">Acepto los términos y condiciones</label>
            </div>
        </div>
        <!-- Botón de envío -->
        <div class="form-group">
            <asp:Button type="submit" ID="ParticiparButton" CssClass="btn btn-custom" runat="server" Text="Participar" OnClick="ParticiparButton_Click" />
        </div>
      </div>
    </div>
  </div>
</asp:Content>

