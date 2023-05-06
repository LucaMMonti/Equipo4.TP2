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
    public partial class frmAgregar : Form
    {
        public frmAgregar()
        {
            InitializeComponent();
        }


        private void btnAceptar_Click(object sender, EventArgs e) //Funcionalidad botón Aceptar
        {
            Articulo art = new Articulo();
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                art.Codigo = txtCodigo.Text;
                art.Nombre = txtNombre.Text;
               // art.IdMarca = int.Parse(txtMarca.Text);
                // art.IdCategoria = int.Parse(txtCategoria.Text);
                art.Descripcion = txtDescripcion.Text;
                art.Precio = decimal.Parse(txtPrecio.Text);

                negocio.agregar(art);
                MessageBox.Show("Articulo agregado exitosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e) //Funcionalidad botón Cancelar
        {
            this.Close();
        }


    }
}
