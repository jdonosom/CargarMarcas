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
    }
}
