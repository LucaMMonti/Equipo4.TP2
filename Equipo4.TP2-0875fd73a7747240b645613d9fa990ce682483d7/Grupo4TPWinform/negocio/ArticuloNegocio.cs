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
                datos.setearConsulta("Select Codigo, Nombre, A.Descripcion, Precio, C.Descripcion as MARCA From ARTICULOS A, CATEGORIAS C Where C.Id = A.IdCategoria");
                datos.ejecutarLectura();


                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    Marca marca = new Marca();
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Precio = (decimal)datos.Lector["Precio"];
                    aux.DescMarca = new Marca();
                    aux.DescMarca.Descripcion = (string)datos.Lector["MARCA"];
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
