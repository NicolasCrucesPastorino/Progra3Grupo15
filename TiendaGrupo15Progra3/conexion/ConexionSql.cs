using Negocio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;
using System.Xml.Linq;
using TiendaGrupo15Progra3.Models;

namespace TiendaGrupo15Progra3.conexion
{
    public class ConexionSql
    {
        private string connectionString = "server=localhost; database =PROMOS_DB; integrated security = true";

        public bool ExisteCodigo(string CodigoVoucher)
        {
            List<string> codigos = new List<string>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT CodigoVoucher FROM Vouchers";

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            codigos.Add(Convert.ToString(reader["CodigoVoucher"]));
                        }
                    }
                }

                return codigos.Find(codigo => codigo.Equals(CodigoVoucher)) != null;

            }
        }

        public List<Premio> GetPremios()
        {
            List<Premio> premios = new List<Premio>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT Id, Nombre, Descripcion, Codigo FROM ARTICULOS";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Premio premio = new Premio();
                            premio.Id = Convert.ToInt32(reader["Id"]);
                            premio.Nombre = Convert.ToString(reader["Nombre"]);
                            premio.Codigo = Convert.ToString(reader["Codigo"]);
                            premio.Descripcion = Convert.ToString(reader["Descripcion"]);

                           
                            premios.Add(premio);
                        }
                    }
                }

                foreach(var premio in premios)
                {
                    string subquery = "SELECT ImagenUrl FROM IMAGENES WHERE IdArticulo = @IdArticulo";
                    using (SqlCommand subCommand = new SqlCommand(subquery, connection))
                    {
                        subCommand.Parameters.AddWithValue("@IdArticulo", premio.Id);
                        using (SqlDataReader subReader = subCommand.ExecuteReader())
                        {
                            while (subReader.Read())
                            {
                                string imagen = Convert.ToString(subReader["ImagenUrl"]);
                                premio.Imagenes.Add(imagen);
                            }
                        }
                    }
                }
            }
            return premios;
        }
        //CLIENTE SERVICE
        public void insertarCliente(string Documento, string Nombre, string Apellido, string Email, string Direccion, string Ciudad, int CP)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"
                INSERT INTO Clientes (Documento, Nombre, Apellido, Email, Direccion, Ciudad, CP) 
                VALUES (@Documento, @Nombre, @Apellido, @Email, @Direccion, @Ciudad, @CP)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Documento", Documento);
                        command.Parameters.AddWithValue("@Nombre", Nombre);
                        command.Parameters.AddWithValue("@Apellido", Apellido);
                        command.Parameters.AddWithValue("@Email", Email);
                        command.Parameters.AddWithValue("@Direccion", Direccion);
                        command.Parameters.AddWithValue("@Ciudad", Ciudad);
                        command.Parameters.AddWithValue("@CP", CP);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("Cliente insertado correctamente.");
                        }
                        else
                        {
                            Console.WriteLine("No se pudo insertar el cliente.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ocurrió un error: {ex.Message}");
                }
            }
        }
    }
}
