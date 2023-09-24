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
            var horario =
                bl.Horario.Get(Id);

            if (horario is null)
            {
                MessageBox.Show("El código de horario ingresado no existe.",
                    "Diálogo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DesplegarHorario(horario);

            Habilitar(false);

            txtDescripcion.Text = horario.Descripcion;
            txtDescripcion.Focus();

            current = horario;

        }

        private void DesplegarHorario(Horario horario)
        {
            txtDescripcion.Text = horario.Descripcion.TrimEnd().TrimStart();

            // 
            // ClearDataGridViewRows(dgHorario);
            this.dgHorario.Rows.Clear();

            dgHorario.Rows.Add("Lunes", horario.L_EntradaMañana.ToString(@"HH\:mm"), horario.L_SalidaMañana.ToString(@"HH\:mm"), horario.L_ToleranciaEntrada, horario.L_EntradaTarde.ToString(@"HH\:mm"), horario.L_SalidaTarde.ToString(@"HH\:mm"));
            dgHorario.Rows.Add("Martes", horario.M_EntradaMañana.ToString(@"HH\:mm"), horario.M_SalidaMañana.ToString(@"HH\:mm"), horario.M_ToleranciaEntrada, horario.M_EntradaTarde.ToString(@"HH\:mm"), horario.M_SalidaTarde.ToString(@"HH\:mm"));
            dgHorario.Rows.Add("Miércoles", horario.X_EntradaMañana.ToString(@"HH\:mm"), horario.X_SalidaMañana.ToString(@"HH\:mm"), horario.X_ToleranciaEntrada, horario.X_EntradaTarde.ToString(@"HH\:mm"), horario.X_SalidaTarde.ToString(@"HH\:mm"));
            dgHorario.Rows.Add("Jueves", horario.J_EntradaMañana.ToString(@"HH\:mm"), horario.J_SalidaMañana.ToString(@"HH\:mm"), horario.J_ToleranciaEntrada, horario.J_EntradaTarde.ToString(@"HH\:mm"), horario.J_SalidaTarde.ToString(@"HH\:mm"));
            dgHorario.Rows.Add("Viernes", horario.V_EntradaMañana.ToString(@"HH\:mm"), horario.V_SalidaMañana.ToString(@"HH\:mm"), horario.V_ToleranciaEntrada, horario.V_EntradaTarde.ToString(@"HH\:mm"), horario.V_SalidaTarde.ToString(@"HH\:mm"));
            dgHorario.Rows.Add("Sábado", horario.S_EntradaMañana.ToString(@"HH\:mm"), horario.S_SalidaMañana.ToString(@"HH\:mm"), horario.S_ToleranciaEntrada, horario.S_EntradaTarde.ToString(@"HH\:mm"), horario.S_SalidaTarde.ToString(@"HH\:mm"));
            dgHorario.Rows.Add("Domingo", horario.D_EntradaMañana.ToString(@"HH\:mm"), horario.D_SalidaMañana.ToString(@"HH\:mm"), horario.D_ToleranciaEntrada, horario.D_EntradaTarde.ToString(@"HH\:mm"), horario.D_SalidaTarde.ToString(@"HH\:mm"));
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
            this.dgHorario.Rows.Clear();

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
                current.L_EntradaMañana = DateTime.ParseExact($"1900-01-01 {dgHorario[1, 0].Value.ToString()}", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
                current.L_SalidaMañana = DateTime.ParseExact($"1900-01-01 {dgHorario[2, 0].Value.ToString()}", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
                current.L_ToleranciaEntrada = int.Parse(dgHorario[3, 0].Value is null ? "0" : dgHorario[3, 0].Value.ToString());
                current.L_EntradaTarde = DateTime.ParseExact($"1900-01-01 {dgHorario[4, 0].Value.ToString()}", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
                current.L_SalidaTarde = DateTime.ParseExact($"1900-01-01 {dgHorario[5, 0].Value.ToString()}", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
                current.L_ToleranciaSalida = int.Parse(dgHorario[6, 0].Value is null ? "0" : dgHorario[6, 0].Value.ToString());

                current.Martes = "S";
                current.M_EntradaMañana = DateTime.ParseExact($"1900-01-01 {dgHorario[1, 1].Value.ToString()}", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
                current.M_SalidaMañana = DateTime.ParseExact($"1900-01-01 {dgHorario[2, 1].Value.ToString()}", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
                current.M_ToleranciaEntrada = int.Parse(dgHorario[3, 1].Value is null ? "0" : dgHorario[3, 1].Value.ToString());
                current.M_EntradaTarde = DateTime.ParseExact($"1900-01-01 {dgHorario[4, 1].Value.ToString()}", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
                current.M_SalidaTarde = DateTime.ParseExact($"1900-01-01 {dgHorario[5, 1].Value.ToString()}", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
                current.M_ToleranciaSalida = int.Parse(dgHorario[6, 1].Value is null ? "0" : dgHorario[6, 1].Value.ToString());

                current.Miercoles = "S";
                current.X_EntradaMañana = DateTime.ParseExact($"1900-01-01 {dgHorario[1, 2].Value.ToString()}", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
                current.X_SalidaMañana = DateTime.ParseExact($"1900-01-01 {dgHorario[2, 2].Value.ToString()}", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
                current.X_ToleranciaEntrada = int.Parse(dgHorario[3, 2].Value is null ? "0" : dgHorario[3, 2].Value.ToString());
                current.X_EntradaTarde = DateTime.ParseExact($"1900-01-01 {dgHorario[4, 2].Value.ToString()}", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
                current.X_SalidaTarde = DateTime.ParseExact($"1900-01-01 {dgHorario[5, 2].Value.ToString()}", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
                current.X_ToleranciaSalida = int.Parse(dgHorario[6, 2].Value is null ? "0" : dgHorario[6, 2].Value.ToString());

                current.Jueves = "S";
                current.J_EntradaMañana = DateTime.ParseExact($"1900-01-01 {dgHorario[1, 3].Value.ToString()}", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
                current.J_SalidaMañana = DateTime.ParseExact($"1900-01-01 {dgHorario[2, 3].Value.ToString()}", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
                current.J_ToleranciaEntrada = int.Parse(dgHorario[3, 3].Value is null ? "0" : dgHorario[3, 3].Value.ToString());
                current.J_EntradaTarde = DateTime.ParseExact($"1900-01-01 {dgHorario[4, 3].Value.ToString()}", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
                current.J_SalidaTarde = DateTime.ParseExact($"1900-01-01 {dgHorario[5, 3].Value.ToString()}", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
                current.J_ToleranciaSalida = int.Parse(dgHorario[6, 3].Value is null ? "0" : dgHorario[6, 3].Value.ToString());

                current.Viernes = "S";
                current.V_EntradaMañana = DateTime.ParseExact($"1900-01-01 {dgHorario[1, 4].Value.ToString()}", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
                current.V_SalidaMañana = DateTime.ParseExact($"1900-01-01 {dgHorario[2, 4].Value.ToString()}", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
                current.V_ToleranciaEntrada = int.Parse(dgHorario[3, 4].Value is null ? "0" : dgHorario[3, 4].Value.ToString());
                current.V_EntradaTarde = DateTime.ParseExact($"1900-01-01 {dgHorario[4, 4].Value.ToString()}", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
                current.V_SalidaTarde = DateTime.ParseExact($"1900-01-01 {dgHorario[5, 4].Value.ToString()}", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
                current.V_ToleranciaSalida = int.Parse(dgHorario[6, 4].Value is null ? "0" : dgHorario[6, 4].Value.ToString());

                current.Sabado = "S";
                current.S_EntradaMañana = DateTime.ParseExact($"1900-01-01 {dgHorario[1, 5].Value.ToString()}", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
                current.S_SalidaMañana = DateTime.ParseExact($"1900-01-01 {dgHorario[2, 5].Value.ToString()}", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
                current.S_ToleranciaEntrada = int.Parse(dgHorario[3, 5].Value is null ? "0" : dgHorario[3, 5].Value.ToString());
                current.S_EntradaTarde = DateTime.ParseExact($"1900-01-01 {dgHorario[4, 5].Value.ToString()}", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
                current.S_SalidaTarde = DateTime.ParseExact($"1900-01-01 {dgHorario[5, 5].Value.ToString()}", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
                current.S_ToleranciaSalida = int.Parse(dgHorario[6, 5].Value is null ? "0" : dgHorario[6, 5].Value.ToString());

                current.Domingo = "S";
                current.D_EntradaMañana = DateTime.ParseExact($"1900-01-01 {dgHorario[1, 6].Value.ToString()}", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
                current.D_SalidaMañana = DateTime.ParseExact($"1900-01-01 {dgHorario[2, 6].Value.ToString()}", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
                current.D_ToleranciaEntrada = int.Parse(dgHorario[3, 6].Value is null ? "0" : dgHorario[3, 6].Value.ToString());
                current.D_EntradaTarde = DateTime.ParseExact($"1900-01-01 {dgHorario[4, 6].Value.ToString()}", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
                current.D_SalidaTarde = DateTime.ParseExact($"1900-01-01 {dgHorario[5, 6].Value.ToString()}", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
                current.D_ToleranciaSalida = int.Parse(dgHorario[6, 6].Value is null ? "0" : dgHorario[6, 6].Value.ToString());



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

        private void FrmMantHorarios_Load(object sender, EventArgs e)
        {


        }
    }
}
