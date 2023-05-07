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
    public partial class frmListar : Form
    {
        private List<Articulo> listaArt;
        public frmListar()
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
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /*
                private void cargarImagen(string imagen)
                {
                    try
                    {
                        pbxArticulos.Load(imagen);
                    }
                    catch (Exception ex)
                    {
                        pbxArticulos.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
                    }
                }*/

        private void dgvImagen_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

            frmAgregar ventanaModificar = new frmAgregar(seleccionado);
            ventanaModificar.ShowDialog();
            

            
            

        }
    }
}
