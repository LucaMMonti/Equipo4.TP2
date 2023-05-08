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

namespace Grupo4TPWinform
{
    public partial class frmListarNuevo : Form
    {
        private List<Articulo> listaArt;
        public frmListarNuevo()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            try
            {
                ArticuloNegocio negocio = new ArticuloNegocio();
                listaArt = negocio.listar();
                dgvArticulos.DataSource = listaArt;
                dgvArticulos.Columns["Id"].Visible = false;
                dgvArticulos.Columns["Imagen"].Visible = false;
                //pbxArticulos.Load(listaArt[0].Imagen.ImagenUrl);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            //cargarImagen(seleccionado.Imagen.ImagenUrl);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

            frmAgregar ventanaModificar = new frmAgregar(seleccionado);
            ventanaModificar.ShowDialog();
            Form1_Load(sender, e);



        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("¿Seguro que desea eliminar?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    negocio.Eliminar(seleccionado.id);
                    MessageBox.Show("Eliminado con exito");
                    Form1_Load(sender, e);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregar ventanaAgregar = new frmAgregar();
            ventanaAgregar.Show();
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscar ventanaBuscar = new frmBuscar();
            ventanaBuscar.Show();
        }



        //private void cargarImagen(string imagen)
        //{
        //    try
        //    {
        //        pbxArticulos.Load(imagen);
        //    }
        //    catch (Exception)
        //    {

        //        pbxArticulos.Load("https://static.vecteezy.com/system/resources/previews/004/141/669/non_2x/no-photo-or-blank-image-icon-loading-images-or-missing-image-mark-image-not-available-or-image-coming-soon-sign-simple-nature-silhouette-in-frame-isolated-illustration-vector.jpg");
        //    }
        //}
    }
}
