using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;
using TiendaGrupo15Progra3.conexion;

namespace TiendaGrupo15Progra3
{
    public partial class IngresaTusDatos : System.Web.UI.Page
    {
        string CodigoVoucherTraido { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["CodigoVoucher"] != null)
                {
                    string codigoVoucher = Session["CodigoVoucher"].ToString();
                    CodigoVoucherTraido = codigoVoucher; 
                }
                

            }
        }
       
        public void ParticiparButton_Click(object sender, EventArgs e)
        {
            ClienteService clienteService = new ClienteService();
            bool clienteExistente = false;

            try
            {

                string numeroDNI = DNInumero.Text.Trim();
                string nombre = nombreText.Text.Trim();
                string apellido = apellidoText.Text.Trim();
                string email = EmailInput.Text.Trim();
                string direccion = direccionText.Text.Trim();
                string ciudad = ciudadText.Text.Trim();
               
                int codigoPostal = Int32.Parse(codigoPostalText.Text.Trim());
                
                clienteService.insertarCliente(numeroDNI, nombre, apellido, email, direccion, ciudad, codigoPostal);
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('El usuario se ha cargado con exito');", true);

            }
            catch (Exception ex)
            {
                string excepcion = ex.ToString();

            }

            
        }


    }
}