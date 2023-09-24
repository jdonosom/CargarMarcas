using BLSGM.infraestructura;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CargarMarcas
{
    public partial class FrmBusquedaHorarios : Form
    {

        #region Propiedades 
        public int Id;
        #endregion
        private BusinessRequest bl;

        public FrmBusquedaHorarios(
            BusinessRequest bl)
        {
            InitializeComponent();
            this.bl = bl;
        }

        private void FrmBusquedaHorarios_Load(object sender, EventArgs e)
        {
            var horarios =
                bl.Horario.GetAll();

            lstHorario.Items.Clear();
            foreach (var h in horarios)
            {
                ListViewItem item = new ListViewItem(h.IdHorario.ToString());
                item.SubItems.Add(h.Descripcion);
                lstHorario.Items.Add(item);
            }
        }

        private void lstHorario_DoubleClick(object sender, EventArgs e)
        {
            if (((ListView)lstHorario).SelectedItems.Count == 0)
            {
                return;
            }
            try
            {
                this.Id = int.Parse(lstHorario.SelectedItems[0].Text);
            }
            catch
            {
                this.Id = -1;
            }
            this.DialogResult = DialogResult.OK;

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (((ListView)lstHorario).SelectedItems.Count == 0)
            {
                return;
            }

            try
            {
                this.Id = int.Parse(lstHorario.SelectedItems[0].Text);
            }
            catch
            {
                this.Id = -1;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
