using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using System.Net;
using System.Xml.Linq;
using System.Globalization;
using static System.Net.Mime.MediaTypeNames;

namespace negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar() 
        {
            List<Articulo> lista = new List<Articulo>(); 
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Select Codigo, Nombre, A.Descripcion, Precio, C.Descripcion CATEGORIA , M.Descripcion Marca, ImagenUrl IMAGEN  From ARTICULOS A, CATEGORIAS C, MARCAS M, IMAGENES I Where C.Id = A.IdCategoria AND M.id = A.idMarca AND I.IdArticulo = A.Id");
                datos.ejecutarLectura();


                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
     
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Precio = (decimal)datos.Lector["Precio"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.Descripcion = (string)datos.Lector["CATEGORIA"];
                    aux.Marca = new Marca();
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];
                    aux.Url = new Imagen();
                    aux.Url.ImagenUrl = (string)datos.Lector["IMAGEN"];
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


        public void agregar(Articulo nuevo)
        {
          AccesoDatos datos = new AccesoDatos();
            try
            {
            //   datos.setearConsulta("insert into ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) values( '" + nuevo.Codigo + "', '" + nuevo.Nombre + "', '" + nuevo.Descripcion + "'," + nuevo.IdMarca + "," + nuevo.IdCategoria + "," + nuevo.Precio + ")");
               datos.ejecutarAccion();
              
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

        public void eliminar(int id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("dele from Articulos where id = @id");
                datos.setearParametro("@id", id);
            }
            catch(Exception ex)
            {
                throw ex;   
            }
        }
    }
}
