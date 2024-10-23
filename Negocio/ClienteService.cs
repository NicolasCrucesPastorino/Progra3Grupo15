using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class ClienteService
    {
        public void insertarCliente(string Documento, string Nombre, string Apellido, string Email, string Direccion, string Ciudad, int CP)
        {
           AccesoDatos datos = new AccesoDatos();

            {
                
                datos.setearConsulta("INSERT INTO Clientes (Documento, Nombre, Apellido, Email, Direccion, Ciudad, CP)  VALUES  (@Documento, @Nombre, @Apellido, @Email, @Direccion, @Ciudad, @CP)");
                datos.setearParametro("@Documento", Documento);
                datos.setearParametro("@Nombre", Nombre);
                datos.setearParametro("@Apellido", Apellido);
                datos.setearParametro("@Email", Email);
                datos.setearParametro("@Direccion", Direccion);
                datos.setearParametro("@Ciudad", Ciudad);
                datos.setearParametro("@CP", CP);
            }

        }
    }
}
