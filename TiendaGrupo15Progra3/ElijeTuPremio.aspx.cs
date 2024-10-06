using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TiendaGrupo15Progra3.conexion;
using TiendaGrupo15Progra3.Models;

namespace TiendaGrupo15Progra3
{
    public partial class ElijeTuPremio : System.Web.UI.Page
    {
        public List<Premio> premios;
        private ConexionSql conexionSql = new ConexionSql();

        public ElijeTuPremio()
        {
            conexionSql = new ConexionSql();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
          
                premios = conexionSql.GetPremios();
        }
    }
}