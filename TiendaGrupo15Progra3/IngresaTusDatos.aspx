<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="IngresaTusDatos.aspx.cs" Inherits="TiendaGrupo15Progra3.IngresaTusDatos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" rel="stylesheet" />
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.bundle.min.js"></script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <h2 class="text-center mb-4">Ingresa tus datos</h2>
        
        <form id="FormularioDatos" class="row g-3">
            <!-- DNI -->
            <div class="col-md-6">
                <label for="DNInumero" class="form-label">DNI:</label>
                <asp:TextBox ID="DNInumero" textmode="Number" CssClass="form-control" placeholder="12345678" runat="server"></asp:TextBox>
            </div>
            
            <!-- Nombre -->
            <div class="col-md-6">
                <label for="nombreText" class="form-label">Nombre:</label>
                <asp:TextBox ID="nombreText" CssClass="form-control" placeholder="Nombre" runat="server"></asp:TextBox>
            </div>

            <!-- Apellido -->
            <div class="col-md-6">
                <label for="apellidoText" class="form-label">Apellido:</label>
                <asp:TextBox ID="apellidoText" CssClass="form-control" placeholder="Apellido" runat="server"></asp:TextBox>
            </div>

            <!-- Email -->
            <div class="col-md-6">
                <label for="EmailInput" class="form-label">Email:</label>
                <asp:TextBox ID="EmailInput" CssClass="form-control" placeholder="Email" textmode="Email" runat="server"></asp:TextBox>
            </div>

            <!-- Dirección -->
            <div class="col-md-6">
                <label for="direccionText" class="form-label">Dirección:</label>
                <asp:TextBox ID="direccionText" CssClass="form-control" placeholder="Dirección" runat="server"></asp:TextBox>
            </div>

            <!-- Ciudad -->
            <div class="col-md-6">
                <label for="ciudadText" class="form-label">Ciudad:</label>
                <asp:TextBox ID="ciudadText" CssClass="form-control" placeholder="Ciudad" runat="server"></asp:TextBox>
            </div>

            <!-- Código Postal -->
            <div class="col-md-6">
                <label for="codigoPostalText" class="form-label">Código Postal:</label>
                <asp:TextBox ID="codigoPostalText" CssClass="form-control" placeholder="Código Postal" runat="server"></asp:TextBox>
            </div>

            <!-- Aceptar términos -->
            <div class="col-12">
                <div class="form-check">
                    <asp:CheckBox ID="terminosCheckBox" CssClass="form-check-input" runat="server" />
                    <label for="terminosCheckBox" class="form-check-label">Acepto los términos y condiciones</label>
                </div>
            </div>

            <!-- Botón de envío -->
            <div class="col-12 text-center">
                <asp:Button type="submit" ID="ParticiparButton" CssClass="btn btn-primary" runat="server" Text="Participar" OnClick="ParticiparButton_Click" />
            </div>
        </form>
    </div>
</asp:Content>
