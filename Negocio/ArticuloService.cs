using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using Dominio;
using System.Data.SqlClient;

namespace Negocio
{
    public class ArticuloService
    {

        public List<Articulo> GetPremios()
        {
            List<Articulo> premios = new List<Articulo>();
            List<Articulo> premiosFinal = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            Imagen imagen = new Imagen();
            {

                datos.setearConsulta("SELECT Id, Nombre, Descripcion, Codigo FROM ARTICULOS");
                datos.ejecutarLectura();

                    {
                        while (datos.Lector.Read())
                        {
                            Articulo premio = new Articulo();
                            premio.Id = Convert.ToInt32(datos.Lector["Id"]);
                            premio.Nombre = Convert.ToString(datos.Lector["Nombre"]);
                            premio.CodigoArticulo = Convert.ToString(datos.Lector["Codigo"]);
                            premio.Descripcion = Convert.ToString(datos.Lector["Descripcion"]);


                            premios.Add(premio);
                        }
                    }
                }
                int index = 0;
                foreach (Articulo premioFor in premios)
                {
                datos.setearConsulta("SELECT ImagenUrl FROM IMAGENES WHERE IdArticulo = @IdArticulo");
                datos.setearParametro("@IdArticulo", premioFor.Id);
                datos.ejecutarAccion();

                            while (datos.Lector.Read())
                            {
                                imagen.UrlImagen = Convert.ToString(datos.Lector["ImagenUrl"]);
                                premioFor.Imagenes[index] = imagen;
                                index++;
                            }
                            premiosFinal.Add(premioFor);
                index = 0;
                }
            
            return premiosFinal;
        }
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos accesoDatos = new AccesoDatos();
            ImagenService imagenService = new ImagenService();

            try
            {
                accesoDatos.setearConsulta("SELECT A.Id, Codigo, Nombre, A.Descripcion, A.IdMarca, A.IdCategoria, M.Descripcion Nombre_Marca,C.Descripcion Nombre_Categoria, M.Id Id_Marca, C.Id Id_Categoria, A.Precio FROM ARTICULOS A JOIN CATEGORIAS C ON A.IdCategoria = C.Id JOIN MARCAS M ON A.IdMarca = M.Id ORDER BY A.Id ASC");
                accesoDatos.ejecutarLectura();

                while (accesoDatos.Lector.Read())
                {
                    Articulo articulo = new Articulo();

                    articulo.Id = (int)accesoDatos.Lector["Id"];
                    articulo.CodigoArticulo = (string)accesoDatos.Lector["Codigo"];
                    articulo.Nombre = (string)accesoDatos.Lector["Nombre"];
                    articulo.Descripcion = (string)accesoDatos.Lector["Descripcion"];

                    //Creacion de Marca y relacion en datagrid
                    articulo.Marca = new Marca();
                    articulo.Marca.Descripcion = (string)accesoDatos.Lector["Nombre_Marca"];
                    articulo.Marca.Id = (int)accesoDatos.Lector["IdMarca"];

                    //Creacion de Categoria y relacion en datagrid
                    articulo.Categoria = new Categoria();
                    articulo.Categoria.Descripcion = (string)accesoDatos.Lector["Nombre_Categoria"];
                    articulo.Categoria.Id = (int)accesoDatos.Lector["IdCategoria"];

                    articulo.Precio = (decimal)accesoDatos.Lector["Precio"];

                    lista.Add(articulo);
                }

                foreach (var a in lista)
                {
                    List<Imagen> imagens = imagenService.listarPorIdArticulo(a.Id);
                    a.Imagenes = imagens;
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                accesoDatos.cerrarConexion();

            }
        }
    }
}
