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
        private Articulo articulo = null;
        //private Imagen imagen;
        public frmAgregar()
        {
            InitializeComponent();
        }

        public frmAgregar(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Articulo";

        }


        private void btnAceptar_Click(object sender, EventArgs e) //Funcionalidad botón Aceptar
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            ImagenNegocio negocioPic = new ImagenNegocio();
            try
            {
                if (articulo == null)
                    articulo = new Articulo();
                    //imagen = new Imagen();

                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.Precio = decimal.Parse(txtPrecio.Text);
                articulo.Categoria = (Categoria)cbCategoria.SelectedItem;
                articulo.Marca = (Marca)cbMarca.SelectedItem;
                //articulo.Imagen.ImagenUrl = txtImagen.Text;

                if (articulo.id != 0)
                {
                    negocio.Modificar(articulo);
                    //negocioPic.Modificar(imagen);
                    MessageBox.Show("Articulo modificado exitosamente");

                }
                else
                {
                    negocio.Agregar(articulo);
                    MessageBox.Show("Articulo agregado exitosamente");
                }

                //negocioPic.Agregar(imagen, articulo.id);
                Close();

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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmAgregar_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio catNegocio = new CategoriaNegocio();

            try
            {
                cbMarca.DataSource = marcaNegocio.listarMarcas();
                cbMarca.ValueMember = "id";
                cbMarca.DisplayMember = "Descripcion";
                cbCategoria.DataSource = catNegocio.listarCategorias();
                cbCategoria.ValueMember = "iDCategoria";
                cbCategoria.DisplayMember = "Descripcion";

                if (articulo != null)
                {
                    txtCodigo.Text = articulo.Codigo;
                    txtDescripcion.Text = articulo.Descripcion;
                    txtNombre.Text = articulo.Nombre;
                    txtPrecio.Text = articulo.Precio.ToString();
                    cbMarca.SelectedValue = articulo.Marca.id;
                    cbCategoria.SelectedValue = articulo.Categoria.iDCategoria;
                    //txtImagen.Text = articulo.Imagen.ImagenUrl;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        //private void txtImagen_Leave(object sender, EventArgs e)
        //{
        //    cargarImagen(txtImagen.Text);

        //}

        //private void cargarImagen(string imagen)
        //{
        //    try
        //    {

        //        pbxArticulo.Load(imagen);
        //    }
        //    catch (Exception ex)
        //    {
        //        pbxArticulo.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
        //    }
        //}


    }
}

