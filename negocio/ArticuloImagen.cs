using dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class ImagenNegocio
    {

        public List<Imagen> listarImagenes()
        {
            List<Imagen> listaImagenes = new List<Imagen>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;


            try
            {

                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT IDARTICULO, IMAGENURL FROM IMAGENES";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {

                    Imagen img = new Imagen();
                    Articulo art = new Articulo();
                    art.idArticulo = lector.GetInt32(0);
                    img.idArticulo = art.idArticulo;
                    img.ImagenUrl = (string)lector["ImagenUrl"];
                    listaImagenes.Add(img);

                }

                conexion.Close();
                return listaImagenes;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

}

