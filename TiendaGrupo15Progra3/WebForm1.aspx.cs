using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace TiendaGrupo15Progra3
{
    public partial class WebForm1 : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void EnviarCodigoVoucher_Click(object sender, EventArgs e)
        {

            VoucherService voucherService = new VoucherService();

            string CodigoVoucher = CodigoVoucherText.Text.Trim();

            bool CuponValido = false;
            /*bool existe = voucherService.ExisteCodigo(CodigoVoucher)**/

            try
            {
                CuponValido = voucherService.FechaCanjeESnull(CodigoVoucher);
            }
            catch (Exception ex)
            {

                throw ex;
            }


            if (CuponValido)
            {

                Response.Redirect("/ElijeTuPremio.aspx?CodigoVoucher=" + CodigoVoucher);
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('El código del voucher no existe o ya fue utilizado');", true);
            }
        }
    }
}