using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public enum TipoUsuario
    {
        Admin = 1,
        usuario = 2
    }
    public class Usuario
    {
        public int idUsuario { get; set; }
        public string nombre { get; set; }
        public string contrasenia { get; set; }
        public int rol { get; set; }
        public TipoUsuario TipoUsuario{ get; set;}

        public Usuario(string nombreEntrante,string contraseniaEntrante)
        { 
            nombre = nombreEntrante;
            contrasenia = contraseniaEntrante;
        }

        public Usuario() { }
    }
}
