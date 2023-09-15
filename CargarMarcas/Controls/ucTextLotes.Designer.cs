namespace iFarmacia.Controls
{
    partial class ucTextLotes
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
            this.txtLote = new System.Windows.Forms.TextBox();
            this.lvLotes = new System.Windows.Forms.ListView();
            this.colLote = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStockLote = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrecio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFechaVencimiento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // txtLote
            // 
            this.txtLote.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLote.Location = new System.Drawing.Point(1, 1);
            this.txtLote.Margin = new System.Windows.Forms.Padding(0);
            this.txtLote.Name = "txtLote";
            this.txtLote.Size = new System.Drawing.Size(670, 20);
            this.txtLote.TabIndex = 0;
            this.txtLote.TextChanged += new System.EventHandler(this.txtLotes_TextChanged);
            this.txtLote.Enter += new System.EventHandler(this.txtLote_Enter);
            this.txtLote.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLotes_KeyDown);
            this.txtLote.Leave += new System.EventHandler(this.txtLote_Leave);
            // 
            // lvLotes
            // 
            this.lvLotes.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvLotes.BackColor = System.Drawing.Color.White;
            this.lvLotes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colLote,
            this.colStockLote,
            this.colPrecio,
            this.colFechaVencimiento});
            this.lvLotes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvLotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvLotes.ForeColor = System.Drawing.Color.Black;
            this.lvLotes.FullRowSelect = true;
            this.lvLotes.GridLines = true;
            this.lvLotes.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvLotes.HideSelection = false;
            this.lvLotes.HoverSelection = true;
            this.lvLotes.Location = new System.Drawing.Point(1, 23);
            this.lvLotes.Margin = new System.Windows.Forms.Padding(1);
            this.lvLotes.MultiSelect = false;
            this.lvLotes.Name = "lvLotes";
            this.lvLotes.Size = new System.Drawing.Size(670, 155);
            this.lvLotes.TabIndex = 4;
            this.lvLotes.UseCompatibleStateImageBehavior = false;
            this.lvLotes.View = System.Windows.Forms.View.Details;
            this.lvLotes.Visible = false;
            this.lvLotes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvLotes_KeyDown);
            // 
            // colLote
            // 
            this.colLote.Text = "Lote/Serie";
            this.colLote.Width = 202;
            // 
            // colStockLote
            // 
            this.colStockLote.Text = "Stock lote";
            this.colStockLote.Width = 131;
            // 
            // colPrecio
            // 
            this.colPrecio.Text = "Precio venta";
            this.colPrecio.Width = 151;
            // 
            // colFechaVencimiento
            // 
            this.colFechaVencimiento.Text = "Vencimiento";
            this.colFechaVencimiento.Width = 181;
            // 
            // ucTextLotes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.lvLotes);
            this.Controls.Add(this.txtLote);
            this.Name = "ucTextLotes";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Size = new System.Drawing.Size(672, 21);
            this.Load += new System.EventHandler(this.ucTextLotes_Load);
            this.FontChanged += new System.EventHandler(this.ucTextLotes_FontChanged);
            this.Enter += new System.EventHandler(this.ucTextLotes_Enter);
            this.Leave += new System.EventHandler(this.ucTextLotes_Leave);
            this.Resize += new System.EventHandler(this.ucTextLotes_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLote;
        private System.Windows.Forms.ListView lvLotes;
        private System.Windows.Forms.ColumnHeader colLote;
        private System.Windows.Forms.ColumnHeader colStockLote;
        private System.Windows.Forms.ColumnHeader colPrecio;
        private System.Windows.Forms.ColumnHeader colFechaVencimiento;
    }
}
