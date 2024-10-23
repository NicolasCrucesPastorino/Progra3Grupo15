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
        public bool ExisteCodigo(string CodigoVoucher)
        {
            List<string> codigos = new List<string>();
            AccesoDatos datos = new AccesoDatos();

                datos.setearConsulta("SELECT CodigoVoucher FROM Vouchers");

                    
                        while (datos.Lector.Read())
                        {
                            codigos.Add(Convert.ToString(datos.Lector["CodigoVoucher"]));
                        }


                return codigos.Find(codigo => codigo.Equals(CodigoVoucher)) != null;

            
        }

    }
}
