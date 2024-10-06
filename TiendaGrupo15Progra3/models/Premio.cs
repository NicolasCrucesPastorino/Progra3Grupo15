using System;
using System.Collections.Generic;

namespace TiendaGrupo15Progra3.Models
{
    public class Premio
    {
        public int Id { get; set; }
        public String Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public List<string> Imagenes { get; set; }

        public Premio()
        {
            Imagenes = new List<string>();
        }
    }
}
