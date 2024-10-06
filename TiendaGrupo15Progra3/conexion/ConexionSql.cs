using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;
using TiendaGrupo15Progra3.Models;

namespace TiendaGrupo15Progra3.conexion
{
    public class ConexionSql
    {
        private string connectionString = "Server=localhost;Database=PROMOS_DB;User Id=sa;Password=Password123;";

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
    }
}
