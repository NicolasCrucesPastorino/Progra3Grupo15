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
        protected void Page_Load(object sender, EventArgs e)
        {
          
            
        }

        private ConexionSql conexionSql = new ConexionSql();

        public void ParticiparButton_Click(object sender, EventArgs e)
        {

            conexionSql = new ConexionSql();

            string numeroDNI = DNInumero.Text;
            string nombre = nombreText.Text;
            string apellido = apellidoText.Text;
            string email = EmailInput.Text;
            string direccion = direccionText.Text;
            string ciudad = ciudadText.Text;
            int codigoPostal = Int32.Parse(codigoPostalText.Text);


            conexionSql.insertarCliente(numeroDNI, nombre, apellido, email, direccion, ciudad, codigoPostal);
            ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('El usuario se ha cargado con exito');", true);
        }


    }
}