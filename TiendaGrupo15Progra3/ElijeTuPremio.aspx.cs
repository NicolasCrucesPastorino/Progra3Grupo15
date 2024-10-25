using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TiendaGrupo15Progra3.Models;

namespace TiendaGrupo15Progra3
{
    public partial class ElijeTuPremio : System.Web.UI.Page
    {
        public List<Articulo> premios;
        ArticuloService articuloService = new ArticuloService();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string codigoVoucher = Request.QueryString["CodigoVoucher"];
                if (!string.IsNullOrEmpty(codigoVoucher))
                {
                    // Guardar el código del voucher en una variable de sesión o un control oculto para su uso posterior
                    Session["CodigoVoucher"] = codigoVoucher;
                }
            }

            premios=articuloService.GetPremios();

        }
        
    }
}