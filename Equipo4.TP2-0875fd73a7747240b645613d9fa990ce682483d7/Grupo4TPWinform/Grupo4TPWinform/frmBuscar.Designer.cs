
namespace Grupo4TPWinform
{
    partial class frmBuscar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gpbBuscar = new System.Windows.Forms.GroupBox();
            this.txtFiltroAvanzado = new System.Windows.Forms.TextBox();
            this.cboCriterio = new System.Windows.Forms.ComboBox();
            this.cboCampo = new System.Windows.Forms.ComboBox();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lbCampo = new System.Windows.Forms.Label();
            this.dgvListarBusqueda = new System.Windows.Forms.DataGridView();
            this.lblArticulosBuscados = new System.Windows.Forms.Label();
            this.gpbDatos = new System.Windows.Forms.GroupBox();
            this.txbDatoCategoria = new System.Windows.Forms.TextBox();
            this.txbDatoMarca = new System.Windows.Forms.TextBox();
            this.pbxImagenBuscar = new System.Windows.Forms.PictureBox();
            this.lblDatoDescipcion = new System.Windows.Forms.Label();
            this.txbDatoDescripcion = new System.Windows.Forms.TextBox();
            this.txbDatoPrecio = new System.Windows.Forms.TextBox();
            this.lblDatoPrecio = new System.Windows.Forms.Label();
            this.lblDatoCategoria = new System.Windows.Forms.Label();
            this.lblDatoMarca = new System.Windows.Forms.Label();
            this.txbDatoNombre = new System.Windows.Forms.TextBox();
            this.lblDatoNombre = new System.Windows.Forms.Label();
            this.txbDatosCodigo = new System.Windows.Forms.TextBox();
            this.lblDatosCodigo = new System.Windows.Forms.Label();
            this.gpbBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarBusqueda)).BeginInit();
            this.gpbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbBuscar
            // 
            this.gpbBuscar.Controls.Add(this.txtFiltroAvanzado);
            this.gpbBuscar.Controls.Add(this.cboCriterio);
            this.gpbBuscar.Controls.Add(this.cboCampo);
            this.gpbBuscar.Controls.Add(this.btnFiltro);
            this.gpbBuscar.Controls.Add(this.lblCategoria);
            this.gpbBuscar.Controls.Add(this.lblMarca);
            this.gpbBuscar.Controls.Add(this.lbCampo);
            this.gpbBuscar.Location = new System.Drawing.Point(23, 21);
            this.gpbBuscar.Name = "gpbBuscar";
            this.gpbBuscar.Size = new System.Drawing.Size(569, 133);
            this.gpbBuscar.TabIndex = 0;
            this.gpbBuscar.TabStop = false;
            this.gpbBuscar.Text = "Buscar";
            this.gpbBuscar.Enter += new System.EventHandler(this.gpbBuscar_Enter);
            // 
            // txtFiltroAvanzado
            // 
            this.txtFiltroAvanzado.Location = new System.Drawing.Point(114, 82);
            this.txtFiltroAvanzado.Name = "txtFiltroAvanzado";
            this.txtFiltroAvanzado.Size = new System.Drawing.Size(340, 20);
            this.txtFiltroAvanzado.TabIndex = 15;
            // 
            // cboCriterio
            // 
            this.cboCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriterio.FormattingEnabled = true;
            this.cboCriterio.Location = new System.Drawing.Point(114, 55);
            this.cboCriterio.Name = "cboCriterio";
            this.cboCriterio.Size = new System.Drawing.Size(340, 21);
            this.cboCriterio.TabIndex = 14;
            // 
            // cboCampo
            // 
            this.cboCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCampo.FormattingEnabled = true;
            this.cboCampo.Location = new System.Drawing.Point(114, 28);
            this.cboCampo.Name = "cboCampo";
            this.cboCampo.Size = new System.Drawing.Size(340, 21);
            this.cboCampo.TabIndex = 12;
            this.cboCampo.SelectedIndexChanged += new System.EventHandler(this.cmbBuscarMarca_SelectedIndexChanged);
            // 
            // btnFiltro
            // 
            this.btnFiltro.Location = new System.Drawing.Point(473, 80);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(75, 23);
            this.btnFiltro.TabIndex = 11;
            this.btnFiltro.Text = "Buscar";
            this.btnFiltro.UseVisualStyleBackColor = true;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(21, 85);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(82, 13);
            this.lblCategoria.TabIndex = 9;
            this.lblCategoria.Text = "Filtro avanzado:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(61, 58);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(42, 13);
            this.lblMarca.TabIndex = 6;
            this.lblMarca.Text = "Criterio:";
            // 
            // lbCampo
            // 
            this.lbCampo.AutoSize = true;
            this.lbCampo.Location = new System.Drawing.Point(60, 31);
            this.lbCampo.Name = "lbCampo";
            this.lbCampo.Size = new System.Drawing.Size(43, 13);
            this.lbCampo.TabIndex = 0;
            this.lbCampo.Text = "Campo:";
            // 
            // dgvListarBusqueda
            // 
            this.dgvListarBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarBusqueda.Location = new System.Drawing.Point(23, 200);
            this.dgvListarBusqueda.Name = "dgvListarBusqueda";
            this.dgvListarBusqueda.RowTemplate.ReadOnly = true;
            this.dgvListarBusqueda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListarBusqueda.Size = new System.Drawing.Size(704, 126);
            this.dgvListarBusqueda.TabIndex = 1;
            this.dgvListarBusqueda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListarBusqueda_CellContentClick);
            // 
            // lblArticulosBuscados
            // 
            this.lblArticulosBuscados.AutoSize = true;
            this.lblArticulosBuscados.Location = new System.Drawing.Point(23, 181);
            this.lblArticulosBuscados.Name = "lblArticulosBuscados";
            this.lblArticulosBuscados.Size = new System.Drawing.Size(97, 13);
            this.lblArticulosBuscados.TabIndex = 2;
            this.lblArticulosBuscados.Text = "Articulos Buscados";
            // 
            // gpbDatos
            // 
            this.gpbDatos.Controls.Add(this.txbDatoCategoria);
            this.gpbDatos.Controls.Add(this.txbDatoMarca);
            this.gpbDatos.Controls.Add(this.pbxImagenBuscar);
            this.gpbDatos.Controls.Add(this.lblDatoDescipcion);
            this.gpbDatos.Controls.Add(this.txbDatoDescripcion);
            this.gpbDatos.Controls.Add(this.txbDatoPrecio);
            this.gpbDatos.Controls.Add(this.lblDatoPrecio);
            this.gpbDatos.Controls.Add(this.lblDatoCategoria);
            this.gpbDatos.Controls.Add(this.lblDatoMarca);
            this.gpbDatos.Controls.Add(this.txbDatoNombre);
            this.gpbDatos.Controls.Add(this.lblDatoNombre);
            this.gpbDatos.Controls.Add(this.txbDatosCodigo);
            this.gpbDatos.Controls.Add(this.lblDatosCodigo);
            this.gpbDatos.Location = new System.Drawing.Point(23, 343);
            this.gpbDatos.Name = "gpbDatos";
            this.gpbDatos.Size = new System.Drawing.Size(703, 177);
            this.gpbDatos.TabIndex = 4;
            this.gpbDatos.TabStop = false;
            this.gpbDatos.Text = "Datos";
            // 
            // txbDatoCategoria
            // 
            this.txbDatoCategoria.Location = new System.Drawing.Point(369, 48);
            this.txbDatoCategoria.Name = "txbDatoCategoria";
            this.txbDatoCategoria.ReadOnly = true;
            this.txbDatoCategoria.Size = new System.Drawing.Size(100, 20);
            this.txbDatoCategoria.TabIndex = 14;
            // 
            // txbDatoMarca
            // 
            this.txbDatoMarca.Location = new System.Drawing.Point(369, 23);
            this.txbDatoMarca.Name = "txbDatoMarca";
            this.txbDatoMarca.ReadOnly = true;
            this.txbDatoMarca.Size = new System.Drawing.Size(100, 20);
            this.txbDatoMarca.TabIndex = 13;
            // 
            // pbxImagenBuscar
            // 
            this.pbxImagenBuscar.Location = new System.Drawing.Point(508, 21);
            this.pbxImagenBuscar.Name = "pbxImagenBuscar";
            this.pbxImagenBuscar.Size = new System.Drawing.Size(180, 141);
            this.pbxImagenBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImagenBuscar.TabIndex = 12;
            this.pbxImagenBuscar.TabStop = false;
            // 
            // lblDatoDescipcion
            // 
            this.lblDatoDescipcion.AutoSize = true;
            this.lblDatoDescipcion.Location = new System.Drawing.Point(8, 112);
            this.lblDatoDescipcion.Name = "lblDatoDescipcion";
            this.lblDatoDescipcion.Size = new System.Drawing.Size(63, 13);
            this.lblDatoDescipcion.TabIndex = 11;
            this.lblDatoDescipcion.Text = "Descipcion:";
            // 
            // txbDatoDescripcion
            // 
            this.txbDatoDescripcion.Location = new System.Drawing.Point(75, 109);
            this.txbDatoDescripcion.Multiline = true;
            this.txbDatoDescripcion.Name = "txbDatoDescripcion";
            this.txbDatoDescripcion.ReadOnly = true;
            this.txbDatoDescripcion.Size = new System.Drawing.Size(415, 53);
            this.txbDatoDescripcion.TabIndex = 10;
            // 
            // txbDatoPrecio
            // 
            this.txbDatoPrecio.Location = new System.Drawing.Point(75, 74);
            this.txbDatoPrecio.Name = "txbDatoPrecio";
            this.txbDatoPrecio.ReadOnly = true;
            this.txbDatoPrecio.Size = new System.Drawing.Size(210, 20);
            this.txbDatoPrecio.TabIndex = 9;
            // 
            // lblDatoPrecio
            // 
            this.lblDatoPrecio.AutoSize = true;
            this.lblDatoPrecio.Location = new System.Drawing.Point(31, 78);
            this.lblDatoPrecio.Name = "lblDatoPrecio";
            this.lblDatoPrecio.Size = new System.Drawing.Size(40, 13);
            this.lblDatoPrecio.TabIndex = 8;
            this.lblDatoPrecio.Text = "Precio:";
            // 
            // lblDatoCategoria
            // 
            this.lblDatoCategoria.AutoSize = true;
            this.lblDatoCategoria.Location = new System.Drawing.Point(308, 52);
            this.lblDatoCategoria.Name = "lblDatoCategoria";
            this.lblDatoCategoria.Size = new System.Drawing.Size(55, 13);
            this.lblDatoCategoria.TabIndex = 5;
            this.lblDatoCategoria.Text = "Categoria:";
            // 
            // lblDatoMarca
            // 
            this.lblDatoMarca.AutoSize = true;
            this.lblDatoMarca.Location = new System.Drawing.Point(323, 26);
            this.lblDatoMarca.Name = "lblDatoMarca";
            this.lblDatoMarca.Size = new System.Drawing.Size(40, 13);
            this.lblDatoMarca.TabIndex = 4;
            this.lblDatoMarca.Text = "Marca:";
            // 
            // txbDatoNombre
            // 
            this.txbDatoNombre.Location = new System.Drawing.Point(75, 48);
            this.txbDatoNombre.Name = "txbDatoNombre";
            this.txbDatoNombre.ReadOnly = true;
            this.txbDatoNombre.Size = new System.Drawing.Size(210, 20);
            this.txbDatoNombre.TabIndex = 3;
            // 
            // lblDatoNombre
            // 
            this.lblDatoNombre.AutoSize = true;
            this.lblDatoNombre.Location = new System.Drawing.Point(24, 51);
            this.lblDatoNombre.Name = "lblDatoNombre";
            this.lblDatoNombre.Size = new System.Drawing.Size(47, 13);
            this.lblDatoNombre.TabIndex = 2;
            this.lblDatoNombre.Text = "Nombre:";
            // 
            // txbDatosCodigo
            // 
            this.txbDatosCodigo.Location = new System.Drawing.Point(75, 22);
            this.txbDatosCodigo.Name = "txbDatosCodigo";
            this.txbDatosCodigo.ReadOnly = true;
            this.txbDatosCodigo.Size = new System.Drawing.Size(100, 20);
            this.txbDatosCodigo.TabIndex = 1;
            // 
            // lblDatosCodigo
            // 
            this.lblDatosCodigo.AutoSize = true;
            this.lblDatosCodigo.Location = new System.Drawing.Point(28, 26);
            this.lblDatosCodigo.Name = "lblDatosCodigo";
            this.lblDatosCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblDatosCodigo.TabIndex = 0;
            this.lblDatosCodigo.Text = "Codigo:";
            // 
            // frmBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 532);
            this.Controls.Add(this.gpbDatos);
            this.Controls.Add(this.lblArticulosBuscados);
            this.Controls.Add(this.dgvListarBusqueda);
            this.Controls.Add(this.gpbBuscar);
            this.Name = "frmBuscar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Articulos";
            this.Load += new System.EventHandler(this.frmBuscar_Load);
            this.gpbBuscar.ResumeLayout(false);
            this.gpbBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarBusqueda)).EndInit();
            this.gpbDatos.ResumeLayout(false);
            this.gpbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbBuscar;
        private System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lbCampo;
        private System.Windows.Forms.DataGridView dgvListarBusqueda;
        private System.Windows.Forms.Label lblArticulosBuscados;
        private System.Windows.Forms.ComboBox cboCampo;
        private System.Windows.Forms.ComboBox cboCriterio;
        private System.Windows.Forms.TextBox txtFiltroAvanzado;
        private System.Windows.Forms.GroupBox gpbDatos;
        private System.Windows.Forms.TextBox txbDatoCategoria;
        private System.Windows.Forms.TextBox txbDatoMarca;
        private System.Windows.Forms.PictureBox pbxImagenBuscar;
        private System.Windows.Forms.Label lblDatoDescipcion;
        private System.Windows.Forms.TextBox txbDatoDescripcion;
        private System.Windows.Forms.TextBox txbDatoPrecio;
        private System.Windows.Forms.Label lblDatoPrecio;
        private System.Windows.Forms.Label lblDatoCategoria;
        private System.Windows.Forms.Label lblDatoMarca;
        private System.Windows.Forms.TextBox txbDatoNombre;
        private System.Windows.Forms.Label lblDatoNombre;
        private System.Windows.Forms.TextBox txbDatosCodigo;
        private System.Windows.Forms.Label lblDatosCodigo;
    }
}