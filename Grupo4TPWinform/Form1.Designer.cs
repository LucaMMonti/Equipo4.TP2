namespace Grupo4TPWinform
{
    partial class Form1
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
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.dgvImagen = new System.Windows.Forms.DataGridView();
            this.lbVisualizacionArticulos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Location = new System.Drawing.Point(24, 71);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.Size = new System.Drawing.Size(746, 197);
            this.dgvArticulos.TabIndex = 0;
            // 
            // pbImagen
            // 
            this.pbImagen.Location = new System.Drawing.Point(240, 274);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(250, 164);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen.TabIndex = 1;
            this.pbImagen.TabStop = false;
            // 
            // dgvImagen
            // 
            this.dgvImagen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImagen.Location = new System.Drawing.Point(24, 274);
            this.dgvImagen.Name = "dgvImagen";
            this.dgvImagen.Size = new System.Drawing.Size(210, 164);
            this.dgvImagen.TabIndex = 2;
            this.dgvImagen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvImagen_CellContentClick);
            this.dgvImagen.SelectionChanged += new System.EventHandler(this.Form1_Load);
            // 
            // lbVisualizacionArticulos
            // 
            this.lbVisualizacionArticulos.AutoSize = true;
            this.lbVisualizacionArticulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbVisualizacionArticulos.Font = new System.Drawing.Font("Rockwell Condensed", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVisualizacionArticulos.ForeColor = System.Drawing.SystemColors.Control;
            this.lbVisualizacionArticulos.Location = new System.Drawing.Point(189, 6);
            this.lbVisualizacionArticulos.Name = "lbVisualizacionArticulos";
            this.lbVisualizacionArticulos.Size = new System.Drawing.Size(408, 64);
            this.lbVisualizacionArticulos.TabIndex = 3;
            this.lbVisualizacionArticulos.Text = "LISTA DE ARTICULOS";
            this.lbVisualizacionArticulos.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbVisualizacionArticulos);
            this.Controls.Add(this.dgvImagen);
            this.Controls.Add(this.pbImagen);
            this.Controls.Add(this.dgvArticulos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.DataGridView dgvImagen;
        private System.Windows.Forms.Label lbVisualizacionArticulos;
    }
}

