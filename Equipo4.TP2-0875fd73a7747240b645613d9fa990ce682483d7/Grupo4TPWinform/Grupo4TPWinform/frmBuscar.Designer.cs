
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
            this.btnBuscarCategoria = new System.Windows.Forms.Button();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.btbBuscarMarca = new System.Windows.Forms.Button();
            this.lblMarca = new System.Windows.Forms.Label();
            this.btnBuscarCodigo = new System.Windows.Forms.Button();
            this.txtBuscarCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnBuscarNombre = new System.Windows.Forms.Button();
            this.txbBuscarNombre = new System.Windows.Forms.TextBox();
            this.lblBuscarNombre = new System.Windows.Forms.Label();
            this.dgvListarBusqueda = new System.Windows.Forms.DataGridView();
            this.lblArticulosBuscados = new System.Windows.Forms.Label();
            this.gpbDatos = new System.Windows.Forms.GroupBox();
            this.txbDatoCategoria = new System.Windows.Forms.TextBox();
            this.txbDatoMarca = new System.Windows.Forms.TextBox();
            this.pcbDatoImagen = new System.Windows.Forms.PictureBox();
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
            this.cmbBuscarMarca = new System.Windows.Forms.ComboBox();
            this.cmbBuscarCategoria = new System.Windows.Forms.ComboBox();
            this.gpbBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarBusqueda)).BeginInit();
            this.gpbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDatoImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbBuscar
            // 
            this.gpbBuscar.Controls.Add(this.cmbBuscarCategoria);
            this.gpbBuscar.Controls.Add(this.cmbBuscarMarca);
            this.gpbBuscar.Controls.Add(this.btnBuscarCategoria);
            this.gpbBuscar.Controls.Add(this.lblCategoria);
            this.gpbBuscar.Controls.Add(this.btbBuscarMarca);
            this.gpbBuscar.Controls.Add(this.lblMarca);
            this.gpbBuscar.Controls.Add(this.btnBuscarCodigo);
            this.gpbBuscar.Controls.Add(this.txtBuscarCodigo);
            this.gpbBuscar.Controls.Add(this.lblCodigo);
            this.gpbBuscar.Controls.Add(this.btnBuscarNombre);
            this.gpbBuscar.Controls.Add(this.txbBuscarNombre);
            this.gpbBuscar.Controls.Add(this.lblBuscarNombre);
            this.gpbBuscar.Location = new System.Drawing.Point(33, 27);
            this.gpbBuscar.Name = "gpbBuscar";
            this.gpbBuscar.Size = new System.Drawing.Size(538, 135);
            this.gpbBuscar.TabIndex = 0;
            this.gpbBuscar.TabStop = false;
            this.gpbBuscar.Text = "Buscar";
            // 
            // btnBuscarCategoria
            // 
            this.btnBuscarCategoria.Location = new System.Drawing.Point(439, 99);
            this.btnBuscarCategoria.Name = "btnBuscarCategoria";
            this.btnBuscarCategoria.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarCategoria.TabIndex = 11;
            this.btnBuscarCategoria.Text = "Buscar";
            this.btnBuscarCategoria.UseVisualStyleBackColor = true;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(14, 104);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(55, 13);
            this.lblCategoria.TabIndex = 9;
            this.lblCategoria.Text = "Categoria:";
            // 
            // btbBuscarMarca
            // 
            this.btbBuscarMarca.Location = new System.Drawing.Point(439, 72);
            this.btbBuscarMarca.Name = "btbBuscarMarca";
            this.btbBuscarMarca.Size = new System.Drawing.Size(75, 23);
            this.btbBuscarMarca.TabIndex = 8;
            this.btbBuscarMarca.Text = "Buscar";
            this.btbBuscarMarca.UseVisualStyleBackColor = true;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(29, 77);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(40, 13);
            this.lblMarca.TabIndex = 6;
            this.lblMarca.Text = "Marca:";
            // 
            // btnBuscarCodigo
            // 
            this.btnBuscarCodigo.Location = new System.Drawing.Point(439, 46);
            this.btnBuscarCodigo.Name = "btnBuscarCodigo";
            this.btnBuscarCodigo.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarCodigo.TabIndex = 5;
            this.btnBuscarCodigo.Text = "Buscar";
            this.btnBuscarCodigo.UseVisualStyleBackColor = true;
            this.btnBuscarCodigo.Click += new System.EventHandler(this.btnBuscarCodigo_Click);
            // 
            // txtBuscarCodigo
            // 
            this.txtBuscarCodigo.Location = new System.Drawing.Point(75, 48);
            this.txtBuscarCodigo.Name = "txtBuscarCodigo";
            this.txtBuscarCodigo.Size = new System.Drawing.Size(342, 20);
            this.txtBuscarCodigo.TabIndex = 4;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(26, 51);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 3;
            this.lblCodigo.Text = "Codigo:";
            // 
            // btnBuscarNombre
            // 
            this.btnBuscarNombre.Location = new System.Drawing.Point(439, 20);
            this.btnBuscarNombre.Name = "btnBuscarNombre";
            this.btnBuscarNombre.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarNombre.TabIndex = 2;
            this.btnBuscarNombre.Text = "Buscar";
            this.btnBuscarNombre.UseVisualStyleBackColor = true;
            this.btnBuscarNombre.Click += new System.EventHandler(this.btnBuscarNombre_Click);
            // 
            // txbBuscarNombre
            // 
            this.txbBuscarNombre.Location = new System.Drawing.Point(75, 22);
            this.txbBuscarNombre.Name = "txbBuscarNombre";
            this.txbBuscarNombre.Size = new System.Drawing.Size(342, 20);
            this.txbBuscarNombre.TabIndex = 1;
            // 
            // lblBuscarNombre
            // 
            this.lblBuscarNombre.AutoSize = true;
            this.lblBuscarNombre.Location = new System.Drawing.Point(22, 25);
            this.lblBuscarNombre.Name = "lblBuscarNombre";
            this.lblBuscarNombre.Size = new System.Drawing.Size(47, 13);
            this.lblBuscarNombre.TabIndex = 0;
            this.lblBuscarNombre.Text = "Nombre:";
            // 
            // dgvListarBusqueda
            // 
            this.dgvListarBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarBusqueda.Location = new System.Drawing.Point(33, 198);
            this.dgvListarBusqueda.Name = "dgvListarBusqueda";
            this.dgvListarBusqueda.RowTemplate.ReadOnly = true;
            this.dgvListarBusqueda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListarBusqueda.Size = new System.Drawing.Size(538, 126);
            this.dgvListarBusqueda.TabIndex = 1;
            this.dgvListarBusqueda.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListarBusqueda_CellClick);
            // 
            // lblArticulosBuscados
            // 
            this.lblArticulosBuscados.AutoSize = true;
            this.lblArticulosBuscados.Location = new System.Drawing.Point(33, 179);
            this.lblArticulosBuscados.Name = "lblArticulosBuscados";
            this.lblArticulosBuscados.Size = new System.Drawing.Size(97, 13);
            this.lblArticulosBuscados.TabIndex = 2;
            this.lblArticulosBuscados.Text = "Articulos Buscados";
            // 
            // gpbDatos
            // 
            this.gpbDatos.Controls.Add(this.txbDatoCategoria);
            this.gpbDatos.Controls.Add(this.txbDatoMarca);
            this.gpbDatos.Controls.Add(this.pcbDatoImagen);
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
            this.gpbDatos.Location = new System.Drawing.Point(33, 348);
            this.gpbDatos.Name = "gpbDatos";
            this.gpbDatos.Size = new System.Drawing.Size(703, 177);
            this.gpbDatos.TabIndex = 3;
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
            // pcbDatoImagen
            // 
            this.pcbDatoImagen.Location = new System.Drawing.Point(508, 21);
            this.pcbDatoImagen.Name = "pcbDatoImagen";
            this.pcbDatoImagen.Size = new System.Drawing.Size(180, 141);
            this.pcbDatoImagen.TabIndex = 12;
            this.pcbDatoImagen.TabStop = false;
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
            // cmbBuscarMarca
            // 
            this.cmbBuscarMarca.FormattingEnabled = true;
            this.cmbBuscarMarca.Location = new System.Drawing.Point(75, 74);
            this.cmbBuscarMarca.Name = "cmbBuscarMarca";
            this.cmbBuscarMarca.Size = new System.Drawing.Size(342, 21);
            this.cmbBuscarMarca.TabIndex = 12;
            // 
            // cmbBuscarCategoria
            // 
            this.cmbBuscarCategoria.FormattingEnabled = true;
            this.cmbBuscarCategoria.Location = new System.Drawing.Point(75, 101);
            this.cmbBuscarCategoria.Name = "cmbBuscarCategoria";
            this.cmbBuscarCategoria.Size = new System.Drawing.Size(342, 21);
            this.cmbBuscarCategoria.TabIndex = 13;
            // 
            // frmBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 537);
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
            ((System.ComponentModel.ISupportInitialize)(this.pcbDatoImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbBuscar;
        private System.Windows.Forms.Button btnBuscarCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Button btbBuscarMarca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Button btnBuscarCodigo;
        private System.Windows.Forms.TextBox txtBuscarCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnBuscarNombre;
        private System.Windows.Forms.TextBox txbBuscarNombre;
        private System.Windows.Forms.Label lblBuscarNombre;
        private System.Windows.Forms.DataGridView dgvListarBusqueda;
        private System.Windows.Forms.Label lblArticulosBuscados;
        private System.Windows.Forms.GroupBox gpbDatos;
        private System.Windows.Forms.TextBox txbDatoNombre;
        private System.Windows.Forms.Label lblDatoNombre;
        private System.Windows.Forms.TextBox txbDatosCodigo;
        private System.Windows.Forms.Label lblDatosCodigo;
        private System.Windows.Forms.PictureBox pcbDatoImagen;
        private System.Windows.Forms.Label lblDatoDescipcion;
        private System.Windows.Forms.TextBox txbDatoDescripcion;
        private System.Windows.Forms.TextBox txbDatoPrecio;
        private System.Windows.Forms.Label lblDatoPrecio;
        private System.Windows.Forms.Label lblDatoCategoria;
        private System.Windows.Forms.Label lblDatoMarca;
        private System.Windows.Forms.TextBox txbDatoCategoria;
        private System.Windows.Forms.TextBox txbDatoMarca;
        private System.Windows.Forms.ComboBox cmbBuscarCategoria;
        private System.Windows.Forms.ComboBox cmbBuscarMarca;
    }
}