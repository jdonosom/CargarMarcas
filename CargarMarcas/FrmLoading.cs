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

    public partial class FrmLoading : Form
    {
        private readonly IFormFactory forms;
        private object formulario = null;

        public object Formulario
        {
            get { return formulario = null; }
            set { formulario = value; }
        }

        public FrmLoading(
            IFormFactory forms
            )
        {
            InitializeComponent();
            this.forms = forms;
        }

        private void FrmLoading_Enter(object sender, EventArgs e)
        {

        }

        private void FrmLoading_Shown(object sender, EventArgs e)
        {
            if (formulario is null)
            {
                this.Close();
                return;
            }

            var frm = forms.Create<FrmFuncionarioDispositivo>();
            frm.ShowDialog();
        }
    }
}
