using BLSGM.infraestructura;
using Models;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace CargarMarcas
{
    public partial class FrmMantHorarios : Form
    {
        Horario current = null;
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

            ToolTip tool = new ToolTip();
            tool.SetToolTip(btnLimpiar, "Limpiar");

            // Habilita la entrada inicial al formulario
            Habilitar(true);
        }

        private void btnHlpEmpleado_Click(object sender, EventArgs e)
        {
            txtIdHorario.Enabled = true;

            var frm = forms.Create<FrmBusquedaHorarios>();
            frm.StartPosition = FormStartPosition.CenterParent;
            DialogResult dr = frm.ShowDialog();

            if (dr == DialogResult.OK)
            {
                txtIdHorario.Text = frm.Id.ToString();
                txtIdHorario.Focus();
                SendKeys.Send("{TAB}");
            }

        }

        private void txtIdHorario_Leave(object sender, EventArgs e)
        {
            if (txtIdHorario.Value == 0)
            {
                txtIdHorario.Focus();
                return;
            }
            int Id;
            Id = (int)txtIdHorario.Value;

            // Obtener horario
            //
            var horario =
                bl.Horario.Get(Id);

            if (horario is null)
            {
                MessageBox.Show("El código de horario ingresado no existe.",
                    "Diálogo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ucCtrlHorario1.Clear();
            ucCtrlHorario1.Horario = horario;
            ucCtrlHorario1.Descripcion = horario.Descripcion;

            Habilitar(false);

            txtDescripcion.Text = horario.Descripcion;
            txtDescripcion.Focus();

            current = horario;

        }

        private void txtIdHorario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario(true);

        }

        private void LimpiarFormulario(bool lflag)
        {
            current = null;
            ucCtrlHorario1.Clear();

            txtIdHorario.Text = "";
            txtDescripcion.Text = "";

            Habilitar(true);
        }

        private void Habilitar(bool lflag)
        {

            txtIdHorario.Enabled = lflag;
            txtDescripcion.Enabled = !lflag;
            if (lflag)
                txtIdHorario.Focus();
            else
                txtDescripcion.Focus();

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (current is null)
            {
                MessageBox.Show("Debe tener un horario seleccionado antes de grabarlo",
                    "Diálogo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            current = new Horario();
            try
            {

                current.IdHorario = (int)txtIdHorario.Value;
                current.Descripcion = txtDescripcion.Text;
                current.TotalHorasSemanales = 0;
                current.Desde = DateTime.Parse("1900-01-01");
                current.Hasta = DateTime.Parse("1900-01-01");

                current.Lunes = (true) ? "S" : "N";
                current.L_EntradaMañana = DateTime.ParseExact($"1900-01-01 {ucCtrlHorario1.Horario.L_EntradaMañana?.ToString("HH:mm")}", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
                current.L_SalidaMañana = DateTime.ParseExact($"1900-01-01 {ucCtrlHorario1.Horario.L_SalidaMañana?.ToString("HH:mm")}", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
                current.L_ToleranciaEntrada = ucCtrlHorario1.Horario.L_ToleranciaEntrada;
                current.L_EntradaTarde = DateTime.ParseExact($"1900-01-01 {ucCtrlHorario1.Horario.L_EntradaTarde?.ToString("HH:mm")}", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
                current.L_SalidaTarde = DateTime.ParseExact($"1900-01-01 {ucCtrlHorario1.Horario.L_SalidaTarde?.ToString("HH:mm")}", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
                current.L_ToleranciaSalida = ucCtrlHorario1.Horario.L_ToleranciaSalida;

                current.Martes = "S";
                current.M_EntradaMañana = DateTime.ParseExact($"1900-01-01 {ucCtrlHorario1.Horario.M_EntradaMañana?.ToString("HH:mm")}", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
                current.M_SalidaMañana = DateTime.ParseExact($"1900-01-01 {ucCtrlHorario1.Horario.M_SalidaMañana?.ToString("HH:mm")}", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
                current.M_ToleranciaEntrada = ucCtrlHorario1.Horario.M_ToleranciaEntrada;
                current.M_EntradaTarde = DateTime.ParseExact($"1900-01-01 {ucCtrlHorario1.Horario.M_EntradaTarde?.ToString("HH:mm")}", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
                current.M_SalidaTarde = DateTime.ParseExact($"1900-01-01 {ucCtrlHorario1.Horario.M_SalidaTarde?.ToString("HH:mm")}", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
                current.M_ToleranciaSalida = ucCtrlHorario1.Horario.M_ToleranciaSalida;

                current.Miercoles = "S";
                current.X_EntradaMañana = DateTime.ParseExact($"1900-01-01 {ucCtrlHorario1.Horario.X_EntradaMañana?.ToString("HH:mm")}", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
                current.X_SalidaMañana = DateTime.ParseExact($"1900-01-01 {ucCtrlHorario1.Horario.X_SalidaMañana?.ToString("HH:mm")}", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
                current.X_ToleranciaEntrada = ucCtrlHorario1.Horario.X_ToleranciaEntrada;
                current.X_EntradaTarde = DateTime.ParseExact($"1900-01-01 {ucCtrlHorario1.Horario.X_EntradaTarde?.ToString("HH:mm")}", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
                current.X_SalidaTarde = DateTime.ParseExact($"1900-01-01 {ucCtrlHorario1.Horario.X_SalidaTarde?.ToString("HH:mm")}", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
                current.X_ToleranciaSalida = ucCtrlHorario1.Horario.X_ToleranciaSalida;

                current.Jueves = "S";
                current.J_EntradaMañana = DateTime.ParseExact($"1900-01-01 {ucCtrlHorario1.Horario.J_EntradaMañana?.ToString("HH:mm")}", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
                current.J_SalidaMañana = DateTime.ParseExact($"1900-01-01 {ucCtrlHorario1.Horario.J_SalidaMañana?.ToString("HH:mm")}", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
                current.J_ToleranciaEntrada = ucCtrlHorario1.Horario.J_ToleranciaEntrada;
                current.J_EntradaTarde = DateTime.ParseExact($"1900-01-01 {ucCtrlHorario1.Horario.J_EntradaTarde?.ToString("HH:mm")}", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
                current.J_SalidaTarde = DateTime.ParseExact($"1900-01-01 {ucCtrlHorario1.Horario.J_SalidaTarde?.ToString("HH:mm")}", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
                current.J_ToleranciaSalida = ucCtrlHorario1.Horario.J_ToleranciaSalida;

                current.Viernes = "S";
                current.V_EntradaMañana = DateTime.ParseExact($"1900-01-01 {ucCtrlHorario1.Horario.V_EntradaMañana?.ToString("HH:mm")}", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
                current.V_SalidaMañana = DateTime.ParseExact($"1900-01-01 {ucCtrlHorario1.Horario.V_SalidaMañana?.ToString("HH:mm")}", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
                current.V_ToleranciaEntrada = ucCtrlHorario1.Horario.V_ToleranciaEntrada;
                current.V_EntradaTarde = DateTime.ParseExact($"1900-01-01 {ucCtrlHorario1.Horario.V_EntradaTarde?.ToString("HH:mm")}", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
                current.V_SalidaTarde = DateTime.ParseExact($"1900-01-01 {ucCtrlHorario1.Horario.V_SalidaTarde?.ToString("HH:mm")}", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
                current.V_ToleranciaSalida = ucCtrlHorario1.Horario.V_ToleranciaSalida;

                current.Sabado = "S";
                current.S_EntradaMañana = DateTime.ParseExact($"1900-01-01 {ucCtrlHorario1.Horario.S_EntradaMañana?.ToString("HH:mm")}", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
                current.S_SalidaMañana = DateTime.ParseExact($"1900-01-01 {ucCtrlHorario1.Horario.S_SalidaMañana?.ToString("HH:mm")}", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
                current.S_ToleranciaEntrada = ucCtrlHorario1.Horario.S_ToleranciaEntrada;
                current.S_EntradaTarde = DateTime.ParseExact($"1900-01-01 {ucCtrlHorario1.Horario.S_EntradaTarde?.ToString("HH:mm")}", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
                current.S_SalidaTarde = DateTime.ParseExact($"1900-01-01 {ucCtrlHorario1.Horario.S_SalidaTarde?.ToString("HH:mm")}", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
                current.S_ToleranciaSalida = ucCtrlHorario1.Horario.S_ToleranciaSalida;

                current.Domingo = "S";
                current.D_EntradaMañana = DateTime.ParseExact($"1900-01-01 {ucCtrlHorario1.Horario.D_EntradaMañana?.ToString("HH:mm")}", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
                current.D_SalidaMañana = DateTime.ParseExact($"1900-01-01 {ucCtrlHorario1.Horario.D_SalidaMañana?.ToString("HH:mm")}", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
                current.D_ToleranciaEntrada = ucCtrlHorario1.Horario.D_ToleranciaEntrada;
                current.D_EntradaTarde = DateTime.ParseExact($"1900-01-01 {ucCtrlHorario1.Horario.D_EntradaTarde?.ToString("HH:mm")}", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
                current.D_SalidaTarde = DateTime.ParseExact($"1900-01-01 {ucCtrlHorario1.Horario.D_SalidaTarde?.ToString("HH:mm")}", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
                current.D_ToleranciaSalida = ucCtrlHorario1.Horario.D_ToleranciaSalida;

                bl.Horario.Current = current;
                bl.Horario.Update();

                using (new CenterWinDialog(this))
                {
                    MessageBox.Show("Horario almacenado correctamente", "Diálog", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                LimpiarFormulario(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Diálog", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
