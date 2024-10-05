using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TiendaGrupo15Progra3
{
    public partial class IngresaTusDatos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
            
        }

        public void ParticiparButton_Click(object sender, EventArgs e)
        {
            int numeroDNI = Int32.Parse(DNInumero.Text);
            string nombre = nombreText.Text;
            string apellido = apellidoText.Text;
            string email = EmailInput.Text;
            string direccion = direccionText.Text;
            string ciudad = ciudadText.Text;
            string codigoPostal = codigoPostalText.Text;

            


        }


    }
}