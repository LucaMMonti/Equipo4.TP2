using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;
using System.Data.SqlClient;


namespace Grupo4TPWinform
{
    public partial class frmBuscar : Form
    {
        public frmBuscar()
        {
            InitializeComponent();
        }

        private void frmBuscar_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocioListarBusqueda = new ArticuloNegocio();
            dgvListarBusqueda.DataSource = negocioListarBusqueda.listar();

            /*ArticuloNegocio articulo = new Articulo();
            try
            {
                cmbBuscarCategoria.DataSource = articulo.listar();
                cmbBuscarMarca.DataSource = articulo.listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }*/
        }
   
        private void btnBuscarNombre_Click(object sender, EventArgs e)
        {
            
            string connectionString = "server =.\\SQLEXPRESS; database = CATALOGO_P3_DB; integrated security = true";
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT * FROM Articulos WHERE Nombre LIKE '%" + txbBuscarNombre.Text + "%'";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader datos = command.ExecuteReader();
            List<Articulo> lista = new List<Articulo>();

            try
            {
                while (datos.Read())
                {
                    Articulo aux = new Articulo();
                    //Marca marca = new Marca();
                    aux.Codigo = (string)datos["Codigo"];
                    aux.Nombre = (string)datos["Nombre"];
                    aux.Descripcion = (string)datos["Descripcion"];
                    aux.Precio = (decimal)datos["Precio"];
                    //aux.DescMarca = new Marca();
                    //aux.DescMarca.Descripcion = (string)datos["MARCA"];
                    lista.Add(aux);
                }

                dgvListarBusqueda.DataSource = null;
                dgvListarBusqueda.DataSource = lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.Close();
                connection.Close();
            }
        }

        private void dgvListarBusqueda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txbDatosCodigo.Text = dgvListarBusqueda.SelectedCells[0].Value.ToString();
                txbDatoNombre.Text = dgvListarBusqueda.SelectedCells[1].Value.ToString();
                txbDatoDescripcion.Text = dgvListarBusqueda.SelectedCells[2].Value.ToString();
                //txbDatoMarca.Text = dgvListarBusqueda.SelectedCells[3].Value.ToString();
                //txbDatoCategoria.Text = dgvListarBusqueda.SelectedCells[4].Value.ToString();
                txbDatoPrecio.Text = dgvListarBusqueda.SelectedCells[5].Value.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            

        }

        private void btnBuscarCodigo_Click(object sender, EventArgs e)
        {
            string connectionString = "server =.\\SQLEXPRESS; database = CATALOGO_P3_DB; integrated security = true";
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT * FROM Articulos WHERE Codigo LIKE '%" + txtBuscarCodigo.Text + "%'";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            SqlDataReader datos = command.ExecuteReader();
            List<Articulo> lista = new List<Articulo>();

            try
            {
                while (datos.Read())
                {
                    Articulo aux = new Articulo();
                    //Marca marca = new Marca();
                    aux.Codigo = (string)datos["Codigo"];
                    aux.Nombre = (string)datos["Nombre"];
                    aux.Descripcion = (string)datos["Descripcion"];
                    aux.Precio = (decimal)datos["Precio"];
                    //aux.DescMarca = new Marca();
                    //aux.DescMarca.Descripcion = (string)datos["MARCA"];
                    lista.Add(aux);
                }

                dgvListarBusqueda.DataSource = null;
                dgvListarBusqueda.DataSource = lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.Close();
                connection.Close();
            }
        }
    }
}
