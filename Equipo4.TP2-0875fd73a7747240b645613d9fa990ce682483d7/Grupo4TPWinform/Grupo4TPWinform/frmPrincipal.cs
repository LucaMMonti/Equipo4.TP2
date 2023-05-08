using dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupo4TPWinform
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListarNuevo ventanaListar = new frmListarNuevo();
            ventanaListar.Show();
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscar ventanaBuscar = new frmBuscar();
            ventanaBuscar.Show();
        }

        private void agregarArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void modificarArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {

             

        }

        private void eliminarArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEliminar ventanaEliminar = new frmEliminar();
            ventanaEliminar.Show();
        }
    }
}
