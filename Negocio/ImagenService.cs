using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class ImagenService
    {
            public List<Imagen> listar()
            {
                List<Imagen> lista = new List<Imagen>();
                AccesoDatos datos = new AccesoDatos();

                try
                {
                    datos.setearConsulta("Select Id,IdArticulo,ImagenUrl FROM Imagenes");
                    datos.ejecutarLectura();

                    while (datos.Lector.Read())
                    {

                        Imagen aux = new Imagen();
                        aux.Id = (int)datos.Lector["Id"];
                        aux.IdArticulo = (int)datos.Lector["IdArticulo"];
                        aux.UrlImagen = (string)datos.Lector["ImagenUrl"];

                        lista.Add(aux);
                    }
                    return lista;
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
            public List<string> ImagenesUrlporId(int id)
            {
                List<string> lista = new List<string>();
                AccesoDatos datos = new AccesoDatos();

                try
                {
                    datos.setearConsulta("select ImagenUrl from IMAGENES inner join ARTICULOS on ARTICULOS.Id=IMAGENES.IdArticulo where ARTICULOS.Id=@id");
                    datos.setearParametro("@id", id);

                    datos.ejecutarLectura();

                    while (datos.Lector.Read())
                    {
                        string auxiliar = (string)datos.Lector["ImagenUrl"];

                        lista.Add(auxiliar);
                    }
                    return lista;
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


            public List<Imagen> listarPorIdArticulo(int id)
            {
                List<Imagen> lista = new List<Imagen>();
                AccesoDatos datos = new AccesoDatos();

                try
                {
                    datos.setearConsulta("Select * FROM IMAGENES WHERE IDArticulo=@id_articulo");
                    datos.setearParametro("@id_articulo", id);
                    datos.ejecutarLectura();

                    while (datos.Lector.Read())
                    {

                        Imagen aux = new Imagen();
                        aux.Id = (int)datos.Lector["Id"];
                        aux.IdArticulo = (int)datos.Lector["IdArticulo"];
                        aux.UrlImagen = (string)datos.Lector["ImagenUrl"];
                        lista.Add(aux);
                    }
                    return lista;
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
