using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel.Design;
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

            try
            {
               
                datos.setearConsulta(
                    @"INSERT INTO Clientes (Documento, Nombre, Apellido, Email, Direccion, Ciudad, CP)  
                      VALUES (@Documento, @Nombre, @Apellido, @Email, @Direccion, @Ciudad, @CP)");

              
                datos.setearParametro("@Documento", Documento);
                datos.setearParametro("@Nombre", Nombre);
                datos.setearParametro("@Apellido", Apellido);
                datos.setearParametro("@Email", Email);
                datos.setearParametro("@Direccion", Direccion);
                datos.setearParametro("@Ciudad", Ciudad);
                datos.setearParametro("@CP", CP);

           
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
             
                throw new Exception("Error al insertar el cliente: " + ex.Message);
            }
            finally
            {
         
                datos.cerrarConexion();
            }
        }

        public bool dniExiste(string Documento)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT COUNT(*) FROM Clientes WHERE Documento = @Documento");
                datos.setearParametro("@Documento", Documento);
                datos.ejecutarLectura();
               
                int count = 0;

                if (datos.Lector.Read())
                {
                    count = datos.Lector.GetInt32(0);
                }
                if (count > 0) {return true;}
                else { return false;}

              
            }
            catch (Exception ex)
            {
                throw new Exception("Error al verificar el DNI: " + ex.Message, ex);
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public int ObtenerIdCliente(string Documento)
        {
            int Id;
            AccesoDatos datos = new AccesoDatos();
            datos.setearConsulta("select Id from Clientes where Documento=@Documento");
            datos.setearParametro("@Documento", int.Parse(Documento));
            datos.ejecutarLectura();

            try
            {
                if (datos.Lector.Read())
                {
                    Id = Convert.ToInt32(datos.Lector["Id"]);
                    
                    return Id;
                }

            }
            catch(Exception ex) 
            {
                throw new Exception("Error ObtenerIdCliente " + ex.Message);
            }
            finally
            {

            }
            return 0;
        }
        public Cliente PrellenarDatos (string dni)
        {
            AccesoDatos datos = new AccesoDatos();
            Cliente existente = new Cliente();
            try
            {
                datos.setearConsulta("SELECT Id,Nombre,Apellido,Email,Direccion,Ciudad,Cp,Documento FROM Clientes WHERE DOCUMENTO=@dni");
                datos.setearParametro("@dni",dni);
                datos.ejecutarLectura();

                while(datos.Lector.Read())
                {
                    existente.idCliente = (int)datos.Lector["Id"];
                    existente.nombre = (string)datos.Lector["Nombre"];
                    existente.apellido = (string)datos.Lector["Apellido"];
                    existente.email = (string)datos.Lector["Email"];
                    existente.direccion = (string)datos.Lector["Direccion"];
                    existente.ciudad = (string)datos.Lector["Ciudad"];
                    existente.cp = (int)datos.Lector["Cp"];
                    existente.dni =  int.Parse(dni);
                }
                
                return existente;
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