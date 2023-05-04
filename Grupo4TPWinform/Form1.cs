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
    public partial class Form1 : Form
    {
        private List<Articulo> listaArticulos;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            listaArticulos = negocio.listar();
            dgvArticulos.DataSource = listaArticulos;
        }




        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pbImagen.Load(imagen);
            }
            catch (Exception ex)
            {
                pbImagen.Load("https://thumbs.dreamstime.com/b/concepto-no-encontrado-de-la-p%C3%A1gina-tierra-caida-web-errores-plano-del-ejemplo-para-el-y-dise%C3%B1o-m%C3%B3vil-106336303.jpg");
            }
        }

        private void dgvImagen_CellContentClick(object sender, DataGridViewCellEventArgs e)      
        {

        }
    }
}
