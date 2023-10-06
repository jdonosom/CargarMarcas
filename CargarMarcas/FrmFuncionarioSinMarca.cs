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
    public partial class FrmFuncionarioSinMarca : Form
    {

        private readonly BusinessRequest bl;
        private readonly IFormFactory forms;

        public FrmFuncionarioSinMarca(
            BusinessRequest bl,
            IFormFactory forms
            )
        {
            InitializeComponent();

            this.bl = bl;
            this.forms = forms;

            dtpFecha.MaxDate = DateTime.Now;
            CargarDatos();

        }

        private void CargarDatos()
        {
            var unidades =
                bl.Unidad.GetAll();

            if ( unidades != null )
            {
                unidades = unidades.OrderBy( x => x.Descripcion).ToList();
            }


            unidades.Insert(0, new Models.Unidad
            {
                IdUnidad = -1,
                Descripcion = " *** Todas las unidades *** "
            });
            cmbDepartamento.ValueMember = "IdUnidad";
            cmbDepartamento.DisplayMember = "Descripcion";
            cmbDepartamento.DataSource = unidades;

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {

            var funcionarios =
                bl.Funcionario.GetEmpleadosSinMarca(
                    dtpFecha.Value.ToString("yyyyMMdd"),
                    (int)cmbDepartamento.SelectedValue
                );

            if (funcionarios is null)
            {
                using (new CenterWinDialog(this))
                {
                    MessageBox.Show("No se encontraron funcionarios con alguna falta", "Diálogo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return;
            }






        }
    }
}
