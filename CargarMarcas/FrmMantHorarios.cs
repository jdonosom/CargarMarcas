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
    public partial class FrmMantHorarios : Form
    {
        private BusinessRequest bl;
        private IFormFactory forms;

        public FrmMantHorarios(
               IFormFactory forms
              , BusinessRequest bl
            )
        {
            InitializeComponent();
            this.bl = bl;
            this.forms = forms;
        }

        private void btnHlpEmpleado_Click(object sender, EventArgs e)
        {
            var frm = forms.Create<FrmBusquedaHorarios>();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();

        }
    }
}
