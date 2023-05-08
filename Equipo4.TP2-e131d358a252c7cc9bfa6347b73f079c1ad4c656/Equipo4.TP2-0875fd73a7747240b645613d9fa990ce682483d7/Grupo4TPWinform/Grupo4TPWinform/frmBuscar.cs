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
        private List<Articulo> listaArticulos;
        public frmBuscar()
        {
            InitializeComponent();
        }

        private void frmBuscar_Load(object sender, EventArgs e)
        {
            cargar();
            cboCampo.Items.Add("Codigo");
            cboCampo.Items.Add("Marca");
            cboCampo.Items.Add("Precio");
            cboCampo.Items.Add("Categoria");
            cboCampo.Items.Add("Nombre");
        }
        private void cargar()
        {

            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                listaArticulos = negocio.listar();
                dgvListarBusqueda.DataSource = listaArticulos;
                dgvListarBusqueda.Columns["Id"].Visible = false;
                dgvListarBusqueda.Columns["Imagen"].Visible = false;
                pbxImagenBuscar.Load(listaArticulos[0].Imagen.ImagenUrl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cmbBuscarMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboCampo.SelectedItem.ToString();
            if (opcion == "Precio")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Mayor a");
                cboCriterio.Items.Add("Igual a");
                cboCriterio.Items.Add("Menor a");
            }
            else
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Comienza con");
                cboCriterio.Items.Add("Termina con");
                cboCriterio.Items.Add("Contiene");
            }
        }

        private void gpbBuscar_Enter(object sender, EventArgs e)
        {

        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            ArticuloNegocio art = new ArticuloNegocio();
            try
            {
                string campo = cboCampo.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();
                string filtro = txtFiltroAvanzado.Text;
                dgvListarBusqueda.DataSource = art.filtar(campo, criterio, filtro);
                dgvListarBusqueda.Columns["Id"].Visible = false;
                dgvListarBusqueda.Columns["Imagen"].Visible = false;
                //pbxImagenBuscar.Load(listaArticulos[0].Imagen.ImagenUrl);



            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

        private void dgvListarBusqueda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txbDatosCodigo.Text = dgvListarBusqueda.SelectedCells[1].Value.ToString();
            txbDatoNombre.Text = dgvListarBusqueda.SelectedCells[2].Value.ToString();
            txbDatoDescripcion.Text = dgvListarBusqueda.SelectedCells[3].Value.ToString();
            txbDatoMarca.Text = dgvListarBusqueda.SelectedCells[4].Value.ToString();
            txbDatoCategoria.Text = dgvListarBusqueda.SelectedCells[5].Value.ToString();
            txbDatoPrecio.Text = dgvListarBusqueda.SelectedCells[6].Value.ToString();

            Articulo seleccionado = (Articulo)dgvListarBusqueda.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.Imagen.ImagenUrl);
            
        }


        private void cargarImagen(string imagen) 
        {
            try
            {
                pbxImagenBuscar.Load(imagen);
            }
            catch (Exception ex)
            {

                pbxImagenBuscar.Load("https://static.vecteezy.com/system/resources/previews/004/141/669/non_2x/no-photo-or-blank-image-icon-loading-images-or-missing-image-mark-image-not-available-or-image-coming-soon-sign-simple-nature-silhouette-in-frame-isolated-illustration-vector.jpg");
            }
        }
    }
}
