using BLSGM.infraestructura;
using Models;
using System.Globalization;
using ToolTip = System.Windows.Forms.ToolTip;

namespace CargarMarcas
{
    public partial class FrmHorarioFuncionario : Form
    {
        private string ValorEdit = null;
        private TextBox editBox;
        private bool lChange = false;

        private readonly IFormFactory forms;
        private readonly BusinessRequest bl;

        // private readonly Credencial credencial;

        public FrmHorarioFuncionario(
             BusinessRequest bl
            , IFormFactory forms)
        {
            InitializeComponent();
            this.bl = bl;
            this.forms = forms;

            #region ToolTips
            ToolTip tool = new ToolTip();
            tool.SetToolTip(this.btnTurno, "Configurar Turno");
            #endregion

        }

        private void FrmHorario_Load(object sender, EventArgs e)
        {
            ClearDataGridViewRows(dgHorario);

            HabilitaFormulario(false);
        }

        private void txtRut_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo numeros
            if (!(char.IsNumber(e.KeyChar) || (char)Keys.Back == e.KeyChar || (char)Keys.K == e.KeyChar))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtRut_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            txt.Text = txt.Text.Replace("-", "");
            string sRut = txt.Text;
            string sDig = string.Empty;

            int nLen = txt.Text.Length;
            if (nLen > 1)
            {
                sRut = SauroClases.StringExtensions.Left(txt.Text, nLen - 1);
                // sRut = txt.Text.Substring(0, nLen - 1);
                sDig = SauroClases.StringExtensions.Right(txt.Text, 1);
                // sDig = txt.Text.Left(nLen - 1);
                txt.Text = string.Format("{0}-{1}", sRut, sDig);
                // SendKeys.Send("{END}");
                // txtRut.Focus();
            }
            txtRut.Select(txtRut.Text.Length, 0);
            /// Console.WriteLine("KeyUP");
        }

        private void txtRut_Leave(object sender, EventArgs e)
        {
            // 
            if (txtRut.Text.Length == 0)
            {
                return;
            }

            var aRut = txtRut.Text.Split("-");
            int nRut = int.Parse(aRut[0]);
            char Dv = char.Parse(aRut[1]);

            if (!Global.GlobalVar.ValidaRut(nRut, Dv))
            {
                MessageBox.Show("El rut ingresado es erroneo", "Diálogo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // 
            //
            var empleado = bl.Funcionario.Get(nRut);
            if (empleado is null)
            {
                MessageBox.Show("El rut ingresado no pertenece a un funcionario", "Diálogo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtNombre.Text = $"{empleado.Nombres.Trim()} {empleado.ApellidoPaterno.Trim()} {empleado.ApellidoMaterno.Trim()}";

            // Cargar Horario Asignado
            //
            var horario = bl.Horario.GetFuncionario(nRut);
            if (horario is null)
            {
                MessageBox.Show("El funcionario no tiene horarios asignados.", "Diálogo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DespliegaHorario(horario);
            HabilitaFormulario(true);

        }

        private void DespliegaHorario(Horario horario)
        {
            lblHorario.Text = horario.Descripcion.TrimEnd().TrimStart();

            // 
            // ClearDataGridViewRows(dgHorario);
            this.dgHorario.Rows.Clear();

            dgHorario.Rows.Add("Lunes", horario.L_EntradaMañana, horario.L_SalidaMañana, horario.L_ToleranciaEntrada, horario.L_EntradaTarde, horario.L_SalidaTarde);
            dgHorario.Rows.Add("Martes", horario.M_EntradaMañana, horario.M_SalidaMañana, horario.M_ToleranciaEntrada, horario.M_EntradaTarde, horario.M_SalidaTarde);
            dgHorario.Rows.Add("Miércoles", horario.X_EntradaMañana, horario.X_SalidaMañana, horario.X_ToleranciaEntrada, horario.X_EntradaTarde, horario.X_SalidaTarde);
            dgHorario.Rows.Add("Jueves", horario.J_EntradaMañana, horario.J_SalidaMañana, horario.J_ToleranciaEntrada, horario.J_EntradaTarde, horario.J_SalidaTarde);
            dgHorario.Rows.Add("Viernes", horario.V_EntradaMañana, horario.V_SalidaMañana, horario.V_ToleranciaEntrada, horario.V_EntradaTarde, horario.V_SalidaTarde);
            dgHorario.Rows.Add("Sábado", horario.S_EntradaMañana, horario.S_SalidaMañana, horario.S_ToleranciaEntrada, horario.S_EntradaTarde, horario.S_SalidaTarde);
            dgHorario.Rows.Add("Domingo", horario.D_EntradaMañana, horario.D_SalidaMañana, horario.D_ToleranciaEntrada, horario.D_EntradaTarde, horario.D_SalidaTarde);
        }

        public static void ClearDataGridViewRows(DataGridView dataGridView)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (dataGridView.Rows.Count == 1) continue;
                dataGridView.Rows.RemoveAt(dataGridView.Rows.Count - 1);
            }
        }

        private void HabilitaFormulario(bool flag)
        {
            txtRut.Enabled = !flag;
            dgHorario.Enabled = flag;
        }

        private void dgHorario_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            // DateTime Hora = default;
            // string headerText = ((DataGridView)sender).Columns[e.ColumnIndex].HeaderText;
            // string valor = e.FormattedValue.ToString();
            // 
            // 
            // if (headerText.Equals("H.E.M.") || headerText.Equals("H.S.M.") || headerText.Equals("H.E.T.") || headerText.Equals("H.S.T."))
            // {
            // 
            //     if (string.IsNullOrEmpty(valor))
            //     {
            //         dgHorario.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = "00:00";
            //         e.Cancel = false;
            //         return;
            //     }
            // 
            //     bool ldospuntos = valor.Contains(":");
            //     bool lNumerico = IsNumeric(ldospuntos ? valor.Replace(":", "") : valor);
            // 
            //     if (lNumerico)
            //     {
            //         if (ldospuntos)
            //             Hora = DateTime.ParseExact(valor, "HH:mm", CultureInfo.InvariantCulture);
            //         else
            //             Hora = DateTime.ParseExact(valor, "HHmm", CultureInfo.InvariantCulture);
            //     }
            //     dgHorario.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Hora.ToString("HH:mm");
            //     e.Cancel = false;
            // }
            // dgHorario.Refresh();
        }

        public bool IsNumeric(string value)
        {
            return value.All(char.IsNumber);
        }

        private void dgHorario_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is TextBox)
                editBox = e.Control as TextBox;

            editBox.MaxLength = 4;
            editBox.KeyPress += EditBox_KeyPress;
            editBox.Leave += EditBox_Leave;

        }

        private void EditBox_Leave(object? sender, EventArgs e)
        {
            DateTime Hora = default;
            var cell = dgHorario.SelectedCells[0];
            try
            {
                // var cell = dgHorario.SelectedCells[0];
                Hora = DateTime.ParseExact(((TextBox)sender).Text, "HHmm", CultureInfo.InvariantCulture);
                dgHorario.Rows[cell.RowIndex].Cells[cell.ColumnIndex].Value = Hora.ToString("HH:mm");
            }
            catch
            {
                dgHorario.Rows[cell.RowIndex].Cells[cell.ColumnIndex].Value = "00:00";
            }
        }

        private void EditBox_KeyPress(object? sender, KeyPressEventArgs e)
        {
            // Permite solo numeros y dos puntos
            if (!(char.IsNumber(e.KeyChar) || (char)Keys.Back == e.KeyChar || (char)':' == e.KeyChar))
            {
                e.Handled = true;
                return;
            }
        }

        private void dgHorario_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            lChange = false;
        }

        private void dgHorario_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            lChange = true;
            var cell = dgHorario.SelectedCells[0];
            ValorEdit = dgHorario.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
        }

        private void dgHorario_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (!lChange)
                dgHorario.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = ValorEdit;

        }

        private void txtRut_KeyDown(object sender, KeyEventArgs e)
        {
            if (string.IsNullOrEmpty(txtRut.Text))
            {
                e.Handled = true;
                return;
            }
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void btnHlpEmpleado_Click(object sender, EventArgs e)
        {
            var frm = forms.Create<FrmBusquedaEmpleados>();
            frm.StartPosition = FormStartPosition.CenterParent;
            DialogResult dr = frm.ShowDialog();

            if (dr == DialogResult.OK)
            {

                if (string.IsNullOrEmpty(frm.RutAux))
                    return;

                txtRut.Enabled = true;
                txtRut.Text = frm.RutAux;
                txtRut.Focus();

                SendKeys.Send("{TAB}");
            }
        }
    }
}
