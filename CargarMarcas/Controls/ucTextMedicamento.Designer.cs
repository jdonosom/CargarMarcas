namespace iFarmacia.Controls
{
    partial class ucTextMedicamento
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.lvProductos = new System.Windows.Forms.ListView();
            this.colCodigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDescripcion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStockTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colReceta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colExistente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAfecto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colImpuesto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // txtProducto
            // 
            this.txtProducto.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProducto.Location = new System.Drawing.Point(1, 1);
            this.txtProducto.Margin = new System.Windows.Forms.Padding(0);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(757, 20);
            this.txtProducto.TabIndex = 10;
            this.txtProducto.TextChanged += new System.EventHandler(this.txtProducto_TextChanged);
            this.txtProducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProducto_KeyDown);
            // 
            // lvProductos
            // 
            this.lvProductos.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvProductos.BackColor = System.Drawing.Color.White;
            this.lvProductos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colCodigo,
            this.colDescripcion,
            this.colStockTotal,
            this.colReceta,
            this.colExistente,
            this.colAfecto,
            this.colImpuesto,
            this.colCode});
            this.lvProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvProductos.ForeColor = System.Drawing.Color.Black;
            this.lvProductos.FullRowSelect = true;
            this.lvProductos.GridLines = true;
            this.lvProductos.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvProductos.HideSelection = false;
            this.lvProductos.HoverSelection = true;
            this.lvProductos.Location = new System.Drawing.Point(1, 23);
            this.lvProductos.Margin = new System.Windows.Forms.Padding(1);
            this.lvProductos.MultiSelect = false;
            this.lvProductos.Name = "lvProductos";
            this.lvProductos.Size = new System.Drawing.Size(755, 155);
            this.lvProductos.TabIndex = 9;
            this.lvProductos.TileSize = new System.Drawing.Size(10, 30);
            this.lvProductos.UseCompatibleStateImageBehavior = false;
            this.lvProductos.View = System.Windows.Forms.View.Details;
            this.lvProductos.Visible = false;
            this.lvProductos.DoubleClick += new System.EventHandler(this.insumosLv_ItemSeleccionado);
            this.lvProductos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvProductos_KeyDown);
            // 
            // colCodigo
            // 
            this.colCodigo.Text = "Código";
            this.colCodigo.Width = 195;
            // 
            // colDescripcion
            // 
            this.colDescripcion.Text = "Descripción";
            this.colDescripcion.Width = 445;
            // 
            // colStockTotal
            // 
            this.colStockTotal.Text = "Stock total";
            this.colStockTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colStockTotal.Width = 144;
            // 
            // colReceta
            // 
            this.colReceta.Text = "Receta";
            this.colReceta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colReceta.Width = 0;
            // 
            // colExistente
            // 
            this.colExistente.Text = "Existente";
            this.colExistente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colExistente.Width = 113;
            // 
            // colAfecto
            // 
            this.colAfecto.Text = "Afecto";
            this.colAfecto.Width = 0;
            // 
            // colImpuesto
            // 
            this.colImpuesto.Text = "imp";
            this.colImpuesto.Width = 0;
            // 
            // colCode
            // 
            this.colCode.Text = "colCode";
            this.colCode.Width = 0;
            // 
            // ucTextMedicamento
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.lvProductos);
            this.Name = "ucTextMedicamento";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Size = new System.Drawing.Size(759, 22);
            this.Load += new System.EventHandler(this.ucTextMedicamento_Load);
            this.FontChanged += new System.EventHandler(this.ucTextMedicamento_FontChanged);
            this.Enter += new System.EventHandler(this.ucTextMedicamento_Enter);
            this.Leave += new System.EventHandler(this.ucTextMedicamento_Leave);
            this.Resize += new System.EventHandler(this.ucTextMedicamento_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.ListView lvProductos;
        private System.Windows.Forms.ColumnHeader colAfecto;
        private System.Windows.Forms.ColumnHeader colImpuesto;
        private System.Windows.Forms.ColumnHeader colCodigo;
        private System.Windows.Forms.ColumnHeader colDescripcion;
        private System.Windows.Forms.ColumnHeader colStockTotal;
        private System.Windows.Forms.ColumnHeader colReceta;
        private System.Windows.Forms.ColumnHeader colCode;
        private System.Windows.Forms.ColumnHeader colExistente;
    }
}
