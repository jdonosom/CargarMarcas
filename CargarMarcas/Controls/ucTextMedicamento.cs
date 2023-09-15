using Farmacia.BL;
using Farmacia.Common.Models;
using Farmacia.Common.Tools;
using iFarmacia.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iFarmacia.Controls
{

    public partial class ucTextMedicamento : UserControl
    {

        #region Eventos
        public delegate void ItemSeleccionadoDelegate(object sender, ProductoSeleccionadoArgs e);
        public event ItemSeleccionadoDelegate ItemSeleccionado;
        public delegate void ValueChangedEventHandler(object sender, ValueChangedEventsArgs e);


        [Category("Acciones")]
        [Description("Envia el cambio al formulario")]
        public event ValueChangedEventHandler ValueChanged;

        protected virtual void OnValueChanged(ValueChangedEventsArgs e)
        {
            // Raise the event
            if (productos != null)
                ValueChanged(this, e);
        }

        #endregion

        #region Propiedades
        private List<Kardex> productos;
        
        public List<Kardex> Productos
        {
            get { return productos; }
            set
            {
                productos = value;
                if (value == null)
                {
                    lvProductos.Items.Clear();
                }
            }
        }

        [DefaultValue("")]
        public override string Text
        {
            get
            {
                return base.Text;
            }
            set
            {
                base.Text = value;
                txtProducto.Text = value;
                if ( ((string)value).Length == 0)
                {
                    lvProductos.Items.Clear();
                }

            }
        }
        #endregion
        
        public ucTextMedicamento()
        {
            InitializeComponent();

            lvProductos.FullRowSelect = true;

        }

        private void insumosLv_ItemSeleccionado(object sender, EventArgs e)
        {
            ListViewItem lvi = ( (ListView)sender).SelectedItems[0];

            bool ProductoExistente = lvi.SubItems[4].Text.Equals("Si");

            if (ProductoExistente) {

                string codigo       = lvi.SubItems[7].Text;
                string descripcion  = lvi.SubItems[1].Text;
                double StockTotal   = double.Parse(lvi.SubItems[2].Text);
                bool Afecto         = bool.Parse(lvi.SubItems[5].Text);
                double Impuesto     = double.Parse(lvi.SubItems[6].Text);

                txtProducto.Text    = descripcion;
                lvProductos.Visible = false;

                ActualizaVisualizacion();

                ItemSeleccionado( this, new ProductoSeleccionadoArgs(codigo, descripcion, StockTotal, Afecto, Impuesto) );

            }
            else
            {
                MessageBox.Show("Producto seleccionado no existe en bodega", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void ucTextMedicamento_Load(object sender, EventArgs e)
        {
            this.BringToFront();

            ActualizaVisualizacion();

            if (productos == null)
                return;

            BindingListView();

        }

        public void BindingListView()
        {
            lvProductos.Items.Clear();
            lvProductos.View = View.Details;
            foreach (Kardex producto in Productos)
            {
                if (producto.IdProducto.ToLower().Contains(txtProducto.Text.ToLower()) ||
                    producto.Descripcion.ToLower().Contains(txtProducto.Text.ToLower()))
                {

                    ListViewItem ne = new ListViewItem();
                    ne.SubItems.Add(string.IsNullOrEmpty(producto.Barcode) ? producto.IdProducto : producto.Barcode);
                    ne.SubItems.Add(producto.Descripcion);
                    ne.SubItems.Add(Math.Round(producto.StockTotal).ToString());
                    ne.SubItems.Add(producto.RequiereReceta ? "Si" : "No");
                    ne.SubItems.Add(producto.Existente ? "Si" : "No");
                    ne.SubItems.Add(producto.Afecto.ToString());
                    ne.SubItems.Add(producto.TipoImpuestoAdicional.ToString());
                    ne.SubItems.Add(producto.IdProducto);
                    ne.BackColor = producto.Existente ? Color.White : Color.FromArgb(255, 216, 222);
                    ne.ForeColor = producto.Existente ? Color.Black : Color.FromArgb(82, 0, 12);
                    lvProductos.Items.Add(ne);
                }
            }
        }

 
        #region Metodos
        private void txtProducto_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Down)
            {

                if (lvProductos.Items.Count == 0)
                {
                    clsKardex prod = new clsKardex();
                    productos = prod.Get( Utiles.ObtenerBodega(), string.Empty);
                    BindingListView();
                }
                lvProductos.Visible = true;
                ActualizaVisualizacion();


                lvProductos.Focus();

            } 
            else if(e.KeyCode == Keys.Escape)
            {
                
                OnValueChanged( new ValueChangedEventsArgs(string.Empty) );

                lvProductos.Items.Clear();
                productos = null;

                lvProductos.Visible = false;
                this.Height = txtProducto.Height+3;

                txtProducto.Text = String.Empty;
                txtProducto.Focus();

            }

        }


        private void txtProducto_TextChanged(object sender, EventArgs e)
        {

            if (productos == null)
            {
                clsKardex prod = new clsKardex();
                
                productos = prod.Get(Utiles.ObtenerBodega(), ""); // Cargar todos los productos en bodega
                return;
            }
                

            if (txtProducto.Text.Length == 0)
            {
                productos = null;
                lvProductos.Items.Clear();
                lvProductos.Visible = false;
                lvProductos.Dock = DockStyle.None;
                ActualizaVisualizacion();
                return;
            }
            lvProductos.Items.Clear();

            foreach (Kardex producto in Productos)
            {
                if (producto.Barcode.ToLower().Contains(txtProducto.Text.ToLower()) ||
                    producto.IdProducto.ToLower().Contains(txtProducto.Text.ToLower()) ||
                    producto.Descripcion.ToLower().Contains(txtProducto.Text.ToLower()))
                {

                    ListViewItem ne = new ListViewItem(string.IsNullOrEmpty(producto.Barcode) ? producto.IdProducto : producto.Barcode);
                    ne.SubItems.Add(producto.Descripcion);
                    ne.SubItems.Add(Math.Round(producto.StockTotal).ToString());
                    ne.SubItems.Add(producto.RequiereReceta? "Si" : "No");
                    ne.SubItems.Add(producto.Existente ? "Si" : "No");
                    ne.SubItems.Add(producto.Afecto.ToString());
                    ne.SubItems.Add(producto.TipoImpuestoAdicional.ToString());
                    ne.SubItems.Add(producto.IdProducto);
                    ne.BackColor = producto.Existente ? Color.White : Color.FromArgb(255, 216, 222);
                    ne.ForeColor = producto.Existente ? Color.Black : Color.FromArgb(82, 0, 12);
                    lvProductos.Items.Add(ne);

                }
            }

            if (lvProductos.Items.Count > 0)
            {

                lvProductos.Top = txtProducto.Height + 3;
                lvProductos.Left = txtProducto.Left;
                lvProductos.Visible = true;
            }

            ActualizaVisualizacion();

        }
        #endregion

        private void ActualizaVisualizacion()
        {
            txtProducto.Top = this.Top;
            txtProducto.Left = this.Left;
            txtProducto.Width = this.Width - 1;
            lvProductos.Width = this.Width - 2;

               lvProductos.Columns[0].Width = (2 * lvProductos.Width - 20) / 11;
               lvProductos.Columns[1].Width = (4 * lvProductos.Width - 20) / 11;
               lvProductos.Columns[2].Width = (2 * lvProductos.Width - 20) / 11;
               lvProductos.Columns[3].Width = 0;
               lvProductos.Columns[4].Width = (2 * lvProductos.Width - 20) / 11;
               lvProductos.Columns[5].Width = 0;
               lvProductos.Columns[6].Width = 0;
               lvProductos.Columns[7].Width = 0;

            if (lvProductos.Items.Count == 0)
                lvProductos.Visible = false;
            else
                lvProductos.Items[0].Selected = true;

            if (lvProductos.Visible)
                this.Height = txtProducto.Height + lvProductos.Height + 3;
            else
                this.Height = txtProducto.Height + 3;
        }

        private void ucTextMedicamento_FontChanged(object sender, EventArgs e)
        {
            lvProductos.Font = this.Font;
            txtProducto.Font = this.Font;
        }

        private void ucTextMedicamento_Resize(object sender, EventArgs e)
        {
            txtProducto.Size = this.Size;
            ActualizaVisualizacion();
        }

        private void ucTextMedicamento_Leave(object sender, EventArgs e)
        {
            this.SendToBack();
        }

        private void ucTextMedicamento_Enter(object sender, EventArgs e)
        {
            this.BringToFront();
        }

        private void lvProductos_KeyDown(object sender, KeyEventArgs e)
        {

            if ( e.KeyCode == Keys.Escape)
            {
                lvProductos.Visible = false;
                lvProductos.Items.Clear();

                ActualizaVisualizacion();
                txtProducto.Text = String.Empty;
                txtProducto.Focus();
                
            } 
            else if ( e.KeyCode == Keys.Return )
            {
                insumosLv_ItemSeleccionado(sender, e);
            }

        }

        private void medicamentosTxt_Leave(object sender, EventArgs e)
        {

            if (lvProductos.Visible)
                this.Height = txtProducto.Height + lvProductos.Height + 3;
            else
                this.Height = txtProducto.Height + 3;

        }

    }


}
