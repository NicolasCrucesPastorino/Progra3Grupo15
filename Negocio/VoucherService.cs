using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class VoucherService
    {

     

        public bool FechaCanjeESnull(string CodigoVoucher)
        {
            AccesoDatos datos = new AccesoDatos ();
            Voucher aux = new Voucher ();

            try
            {
                datos.setearConsulta("SELECT CodigoVoucher,FechaCanje FROM VOUCHERS where CodigoVoucher=@CodigoVoucher");
                datos.setearParametro("@CodigoVoucher",CodigoVoucher);
                datos.ejecutarLectura();
                datos.Lector.Read();

                if (!datos.Lector.HasRows)
                {
                    return false;
                }

                if (datos.Lector != null)
                {
                   aux.FechaCanje = datos.Lector["FechaCanje"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(datos.Lector["FechaCanje"]) : null;  
                }
                if(aux.FechaCanje == null)
                {
                    return true;
                }

                    return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
            
        }

    }
}
