using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class UsuarioService
    {
        public int Login(Usuario usuario)
        {
            int rol = 0;
            AccesoDatos datos = new AccesoDatos();          
            try
            {
                datos.setearConsulta("SELECT Rol from USUARIOS WHERE Nombre = @nombre AND Contrasenia = @contrasenia");
                datos.setearParametro("@nombre", usuario.nombre);
                datos.setearParametro("@contrasenia", usuario.contrasenia);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                  
                   rol = (int)datos.Lector["Rol"];
                   
                   
                }
                return rol;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally {
                datos.cerrarConexion();
            } 
        }
    }
}
