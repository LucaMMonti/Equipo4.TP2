namespace Grupo4TPWinform
{
    partial class frmListar
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.lblListar = new System.Windows.Forms.Label();
            this.pbxArticulos = new System.Windows.Forms.PictureBox();
            this.lbImagen = new System.Windows.Forms.Label();
            this.dgvImagen = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulos.Location = new System.Drawing.Point(12, 91);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(736, 305);
            this.dgvArticulos.TabIndex = 0;
            // 
            // lblListar
            // 
            this.lblListar.AutoSize = true;
            this.lblListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblListar.Location = new System.Drawing.Point(252, 43);
            this.lblListar.Name = "lblListar";
            this.lblListar.Size = new System.Drawing.Size(251, 31);
            this.lblListar.TabIndex = 1;
            this.lblListar.Text = "Listado de Articulos";
            // 
            // pbxArticulos
            // 
            this.pbxArticulos.Location = new System.Drawing.Point(422, 402);
            this.pbxArticulos.Name = "pbxArticulos";
            this.pbxArticulos.Size = new System.Drawing.Size(245, 147);
            this.pbxArticulos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArticulos.TabIndex = 2;
            this.pbxArticulos.TabStop = false;
            // 
            // lbImagen
            // 
            this.lbImagen.AutoSize = true;
            this.lbImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbImagen.Location = new System.Drawing.Point(116, 413);
            this.lbImagen.Name = "lbImagen";
            this.lbImagen.Size = new System.Drawing.Size(213, 24);
            this.lbImagen.TabIndex = 4;
            this.lbImagen.Text = "Visualizador de articulos";
            this.lbImagen.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvImagen
            // 
            this.dgvImagen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvImagen.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvImagen.Location = new System.Drawing.Point(29, 440);
            this.dgvImagen.MultiSelect = false;
            this.dgvImagen.Name = "dgvImagen";
            this.dgvImagen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvImagen.Size = new System.Drawing.Size(379, 109);
            this.dgvImagen.TabIndex = 3;
            this.dgvImagen.SelectionChanged += new System.EventHandler(this.dgvImagen_SelectionChanged);
            this.dgvImagen.Click += new System.EventHandler(this.dgvImagen_SelectionChanged);
            // 
            // frmListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(794, 561);
            this.Controls.Add(this.lbImagen);
            this.Controls.Add(this.dgvImagen);
            this.Controls.Add(this.pbxArticulos);
            this.Controls.Add(this.lblListar);
            this.Controls.Add(this.dgvArticulos);
            this.Name = "frmListar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.Label lblListar;
        private System.Windows.Forms.PictureBox pbxArticulos;
        private System.Windows.Forms.Label lbImagen;
        private System.Windows.Forms.DataGridView dgvImagen;
    }
}

