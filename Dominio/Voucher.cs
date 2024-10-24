using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Voucher
    {
        //codogo, idcliente fecha canje idArticulo
        public string codigoVoucher { get; set; }
        public int cliente { get; set; }
        public int ArticuloId { get; set; }
        public DateTime? FechaCanje { get; set; }
    }
}
