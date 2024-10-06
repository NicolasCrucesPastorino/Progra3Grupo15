using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TiendaGrupo15Progra3.conexion;

namespace TiendaGrupo15Progra3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private ConexionSql conexionSql;

        public WebForm1()
        {
            conexionSql = new ConexionSql();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void EnviarCodigoVoucher_Click(object sender, EventArgs e)
        {
            string CodigoVoucher = CodigoVoucherText.Text;
            
            bool existe = conexionSql.ExisteCodigo(CodigoVoucher);

            if (existe)
            {
                Response.Redirect("/ElijeTuPremio.aspx");    
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('El código del voucher no existe');", true);
            }
        }
    }
}