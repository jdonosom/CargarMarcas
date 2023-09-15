using Farmacia.BL;
using Farmacia.Common.Extentions;
using Farmacia.Common.Models;
using Farmacia.Common.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iFarmacia.Controls
{
    public partial class ucTextLotes : UserControl
    {
        public delegate void LoteSeleccionadoDelegate(object sender, LoteSeleccionadoArgs e);
        public event LoteSeleccionadoDelegate ItemSeleccionado;

        #region Propiedades
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
                txtLote.Text = value;

            }
        }
        private List<Lote> lotes;
        private Kardex producto;

        public List<Lote> Lotes
        {
            get { return lotes; }
            set { lotes = value; }
        }
        public Kardex Producto
        {
            get { return producto; }
            set { producto = value; }
        }

        #endregion

        public ucTextLotes()
        {
            InitializeComponent();
            this.lvLotes.DoubleClick += new EventHandler(lvLotes_ItemSeleccionado);

            lvLotes.FullRowSelect = true;
        }

        private void lvLotes_ItemSeleccionado(object sender, EventArgs e)
        {
            ListViewItem lvi = ((ListView)sender).SelectedItems[0];

            string serie = lvi.Text;
            double stockLote = double.Parse(lvi.SubItems[1].Text);
            double precio = double.Parse(lvi.SubItems[2].Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("es-CL"));
            DateTime vencimiento = DateTime.Parse(lvi.SubItems[3].Text);

            txtLote.Text = serie;
            lvLotes.Visible = false;
            ActualizaVisualizacion();

            ItemSeleccionado(this, new LoteSeleccionadoArgs(serie, stockLote, precio, vencimiento));

            
        }

        private void ucTextLotes_Load(object sender, EventArgs e)
        {
            this.BringToFront();
            lvLotes.Visible = false;
            ActualizaVisualizacion();
            if ( lotes != null)
                BindingLotes();

        }


        private void BindingLotes()
        {

            lvLotes.Items.Clear();
            foreach (Lote lote in Lotes)
            {
                if (lote.Serie.ToLower().Contains(txtLote.Text.Trim().ToLower()) ||
                    lote.Serie.ToUpper().Contains(txtLote.Text.Trim().ToUpper()) ||
                    txtLote.Text.Equals(string.Empty))
                {

                    var PrecioVenta = (int)lote.ValorCenabast;

                    ListViewItem elemento = new ListViewItem(lote.Serie);
                    //elemento.SubItems.Add();
                    elemento.SubItems.Add(Math.Round(lote.Saldo).ToString());
                    elemento.SubItems.Add(PrecioVenta.ToString("C0", CultureInfo.GetCultureInfo("es-CL")));
                    elemento.SubItems.Add(lote.FechaVencimiento.ToShortDateString());
                    // elemento.UseItemStyleForSubItems = false;
                    elemento.BackColor = DateTime.Compare(Utiles.GetFechaHoy().Value.Date.AddDays(Utiles.getDiasVencimiento()), lote.FechaVencimiento.Date) < 0 ? Color.White : Color.FromArgb(255,216,222) ;
                    elemento.ForeColor = DateTime.Compare(Utiles.GetFechaHoy().Value.Date.AddDays(Utiles.getDiasVencimiento()), lote.FechaVencimiento.Date) < 0 ? Color.Black : Color.FromArgb(82, 0, 12);
                    
                    lvLotes.Items.Add(elemento);

                }
            }
            if (lvLotes.Items.Count > 0)
            {
                lvLotes.Top     = txtLote.Height + 3;
                lvLotes.Left    = txtLote.Left;
                lvLotes.Visible = true;
            }

            //if (lotes == null)
            //    return;

            //lvLotes.Items.Clear();
            //foreach (Lote lote in Lotes)
            //{
            //    ListViewItem elemento = new ListViewItem(lote.Serie);
            //    elemento.SubItems.Add(Math.Round(lote.Saldo).ToString());
            //    elemento.SubItems.Add(lote.ValorNeto.ToString("C0")); 
            //    elemento.SubItems.Add(lote.FechaVencimiento.ToShortDateString());
            //    lvLotes.Items.Add(elemento);

            //}
            //if (lvLotes.Items.Count > 0)
            //    lvLotes.Items[0].Selected = true;

        }

        private void ucTextLotes_Resize(object sender, EventArgs e)
        {
            txtLote.Size = this.Size;
            ActualizaVisualizacion();
        }

        private void ActualizaVisualizacion()
        {

            txtLote.Top   = this.Top;
            txtLote.Left  = this.Left;
            txtLote.Width = this.Width - 1;

            lvLotes.Top   = txtLote.Height + 1;
            lvLotes.Width = this.Width - 1;

            if (lvLotes.Visible)
            {
                this.Height = txtLote.Height + lvLotes.Height + 3;
                //lvLotes.Dock = DockStyle.Fill;
            }
            else
            {
                this.Height = txtLote.Height + 3;
                //lvLotes.Dock=DockStyle.None;
            }
        }

        private void txtLotes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                if (lvLotes.Items.Count == 0)
                {
                    txtLote.Focus();
                    return;
                }
                lvLotes.Visible = true;
                BindingLotes();
                ActualizaVisualizacion();
                lvLotes.Items[0].Selected = true;
                lvLotes.Focus();

            }
            else if (e.KeyCode == Keys.Escape)
            {
                lvLotes.Visible = false;
                this.Height = txtLote.Height + 3;

                txtLote.Focus();

            }
        }

        private void txtLotes_TextChanged(object sender, EventArgs e)
        {
            if (lotes == null) return;

            if (txtLote.Text.Length == 0)
            {
                //this.producto = null;
                //this.lotes = null;
                //lvLotes.Items.Clear();
                lvLotes.Visible = false;
                lvLotes.Dock = DockStyle.None;
                ActualizaVisualizacion();
                return;
            }
            BindingLotes();

            //lvLotes.Items.Clear();
            //foreach (Lote lote in Lotes)
            //{
            //    if (lote.Serie.ToLower().Contains(txtLote.Text.Trim().ToLower()) ||
            //        lote.Serie.ToUpper().Contains(txtLote.Text.Trim().ToUpper()) || 
            //        txtLote.Text.Equals(string.Empty) )
            //    {

            //        var PrecioVenta = (int)lote.ValorNeto;

            //        ListViewItem elemento = new ListViewItem(lote.Serie);
            //        elemento.SubItems.Add(Math.Round(lote.Saldo).ToString());
            //        elemento.SubItems.Add(PrecioVenta.ToString("C0"));
            //        elemento.SubItems.Add(lote.FechaVencimiento.ToShortDateString());
            //        lvLotes.Items.Add(elemento);

            //    }
            //}
            //if (lvLotes.Items.Count > 0)
            //{
            //    lvLotes.Top = txtLote.Height + 3;
            //    lvLotes.Left = txtLote.Left;
            //    lvLotes.Visible = true;
            //}
            ActualizaVisualizacion();
        }

        
        private void lvLotes_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Escape)
            {

                lvLotes.Visible = false;
                ActualizaVisualizacion();
                txtLote.Text = String.Empty;
                txtLote.Focus();

            }
            else if (e.KeyCode == Keys.Return)
            {
                lvLotes_ItemSeleccionado(sender, e);
            }
        }

        private void txtLote_Leave(object sender, EventArgs e)
        {

            if (lvLotes.Visible)
                this.Height = txtLote.Height + lvLotes.Height + 3;
            else
                this.Height = txtLote.Height + 3;

        }

        private void ucTextLotes_FontChanged(object sender, EventArgs e)
        {
            lvLotes.Font = this.Font;
            txtLote.Font = this.Font;
        }

        private void txtLote_Enter(object sender, EventArgs e)
        {
            
            if (lotes == null) return;

            BindingLotes();
            if (lotes.Count > 0)
            {
                lvLotes.Visible = true;
            }
            else
                lvLotes.Visible = false;

            ActualizaVisualizacion();
        }

        private void ucTextLotes_Leave(object sender, EventArgs e)
        {
            lvLotes.Visible = false;
            ActualizaVisualizacion();
            this.SendToBack();
        }

        private void ucTextLotes_Enter(object sender, EventArgs e)
        {
            this.BringToFront();
        }
    }


}
