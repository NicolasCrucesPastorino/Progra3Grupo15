using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace TiendaGrupo15Progra3
{
    public partial class IngresaTusDatos : System.Web.UI.Page
    {
        string CodigoVoucherTraido { get; set; }
        string ArticuloId { get; set; }
        int IdCliente {  get; set; }
        //bool validarDNIcontraDB;

        protected void Page_Load(object sender, EventArgs e)
        {


            
                if (Session["CodigoVoucher"] != null)
                {
                   
                    string codigoVoucher = Session["CodigoVoucher"].ToString();
                    CodigoVoucherTraido = codigoVoucher; 
                }
            if (Request.QueryString["option"] != null)
            {
                string premioId = Request.QueryString["option"];
                ArticuloId = premioId;
            }
                
                if (!IsPostBack) 
                {
                    // Inicializa la variable global en false
                    Session["validarDNIcontraDB"] = false;
                }
          
        }

        public void ParticiparButton_Click(object sender, EventArgs e)
        {
            

            if (!terminosCheckBox.Checked)
            {
                MostrarAlerta("Por favor, acepte los términos y condiciones.");
                return;
            }

            try
            {
                string numeroDNI = DNInumero.Text.Trim();
                string nombre = nombreText.Text.Trim();
                string apellido = apellidoText.Text.Trim();
                string email = EmailInput.Text.Trim();
                string direccion = direccionText.Text.Trim();
                string ciudad = ciudadText.Text.Trim();

                if (string.IsNullOrEmpty(codigoPostalText.Text.Trim()))
                {
                    MostrarAlerta("El código postal es obligatorio.");
                    return;
                }

                if (string.IsNullOrEmpty(numeroDNI) ||
                    string.IsNullOrEmpty(nombre) ||
                    string.IsNullOrEmpty(apellido) ||
                    string.IsNullOrEmpty(email) ||
                    string.IsNullOrEmpty(direccion) ||
                    string.IsNullOrEmpty(ciudad))
                {
                    MostrarAlerta("Todos los campos son obligatorios. Por favor, complete todos los campos.");
                    return;
                }

                if (!int.TryParse(codigoPostalText.Text.Trim(), out int codigoPostal))
                {
                    MostrarAlerta("El código postal debe ser un número válido.");
                    return;
                }

                
                if (codigoPostal < 0)
                {
                    MostrarAlerta("El código postal no puede ser un número negativo.");
                    return;
                }
                ClienteService clienteService = new ClienteService();
                ClienteService existe = new ClienteService();

                //Si no existe//
                if ((!existe.dniExiste(numeroDNI)) && (bool)Session["validarDNIcontraDB"])

                {
                    clienteService.insertarCliente(numeroDNI, nombre, apellido, email, direccion, ciudad, codigoPostal);

                    IdCliente = clienteService.ObtenerIdCliente(numeroDNI);
                    VoucherService CanjeVoucherNuevoCliente = new VoucherService();
                    CanjeVoucherNuevoCliente.UpgradeVoucher(CodigoVoucherTraido, IdCliente, int.Parse(ArticuloId));
                    Response.Redirect("/UsuarioRegistrado.aspx");
                }
                else
                {
                    if ((bool)Session["validarDNIcontraDB"])
                    {
                        IdCliente = clienteService.ObtenerIdCliente(numeroDNI);
                        VoucherService CanjeVoucherClienteExistente = new VoucherService();
                        CanjeVoucherClienteExistente.UpgradeVoucher(CodigoVoucherTraido, IdCliente, int.Parse(ArticuloId));
                        Response.Redirect("/UsuarioRegistrado.aspx");
                    }
                    else 
                    { 
                        MostrarAlerta($"Debe validar su DNI apretando el boton");
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MostrarAlerta($"Ocurrió un error: {ex.Message}");
            }
        }

        private void MostrarAlerta(string mensaje)
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", $"alert('{mensaje}');", true);
        }

        protected void ValidarClickButton_Click(object sender, EventArgs e)
        {
            ClienteService clienteService = new ClienteService();
            ClienteService llenarCampos = new ClienteService();
            Cliente existente = new Cliente();
            
            try
            {
                string numeroDNI = DNInumero.Text.Trim();

                if (clienteService.dniExiste(numeroDNI))
                {
                    existente=llenarCampos.PrellenarDatos(numeroDNI);

                    DNInumero.Text = existente.dni.ToString();
                    nombreText.Text = existente.nombre;
                    apellidoText.Text = existente.apellido;
                    EmailInput.Text = existente.email;
                    direccionText.Text = existente.direccion;
                    ciudadText.Text = existente.ciudad;
                    codigoPostalText.Text = existente.cp.ToString();

                        Session["validarDNIcontraDB"] = true;

                    }
                else
                {
                    MostrarAlerta("El dni no se encuentra registrado complete el formulario .");
                    Session["validarDNIcontraDB"] = true;
                } 

            }
            catch (Exception ex)
            {

                MostrarAlerta($"Ocurrió un error: {ex.Message}");
            }
            
        }
    }
}