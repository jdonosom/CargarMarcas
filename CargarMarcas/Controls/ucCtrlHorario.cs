using Models;
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

namespace CargarMarcas.Controls
{
    public partial class ucCtrlHorario : UserControl
    {
        private bool lEdit = false;
        private string ValorEdit = null;
        private TextBox editBox;
        private bool lChange = false;

        public ucCtrlHorario()
        {
            InitializeComponent();
        }

        #region Metodo publico

        public void Clear()
        {
            horario = null;
            this.dgHorario.Rows.Clear();
        }

        private Horario horario;
        private string descripcion;

        public string Descripcion
        {
            get { return descripcion; }
            set
            {
                descripcion = value;
                lblHorario.Text = descripcion;
            }
        }

        public Horario Horario
        {
            get
            {
                return horario;
            }
            set
            {
                horario = value;
                if (horario is not null)
                    DespliegaHorario();
            }
        }
        #endregion

        #region Metodos DataGrid
        private void dgHorario_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            lChange = false;
        }

        private void dgHorario_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            lEdit = true;
            var cell = dgHorario.SelectedCells[0];
            if (dgHorario.Rows[cell.RowIndex].Cells[cell.ColumnIndex].Value is null)
                return;

            lChange = true;
            ValorEdit = dgHorario.Rows[cell.RowIndex].Cells[cell.ColumnIndex].Value.ToString();

        }

        private void dgHorario_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (lEdit)
            {
                if (e.ColumnIndex == 3 || e.ColumnIndex == 6)
                {
                    dgHorario.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = editBox.Text;
                }
                else
                {
                    var dateTime = $"1900-01-01 {editBox.Text}";
                    var Hora = DateTime.ParseExact(dateTime, "yyyy-MM-dd HHmm", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd HH:mm");
                    dgHorario.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Hora;
                }
                ActualizaRegistro(e.RowIndex, e.ColumnIndex, dgHorario.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);

            }
            lEdit = false;
        }

        private void ActualizaRegistro(int row, int col, object? value)
        {
            if (col == 3 || col == 6)
            {
                if (value.GetType() == typeof(string))
                {
                    if (string.IsNullOrEmpty((string)value))
                    {
                        value = null;
                    }
                }

                // Lunes
                if (row == 0 && col == 3) // Entrada mañana
                    horario.L_ToleranciaEntrada = value is null ? -1 : (int)value;
                else if (row == 0 && col == 6) // Salida mañana
                    horario.L_ToleranciaSalida = value is null ? -1 : (int)value;

                // Martes
                if (row == 1 && col == 3) // Entrada mañana
                    horario.M_ToleranciaEntrada = value is null ? -1 : (int)value;
                else if (row == 1 && col == 6) // Salida mañana
                    horario.M_ToleranciaSalida = value is null ? -1 : (int)value;

                // Miercoles
                if (row == 2 && col == 3) // Entrada mañana
                    horario.X_ToleranciaEntrada = value is null ? -1 : (int)value;
                else if (row == 2 && col == 6) // Salida mañana
                    horario.X_ToleranciaSalida = value is null ? -1 : (int)value;

                // Jueves
                if (row == 3 && col == 3) // Entrada mañana
                    horario.J_ToleranciaEntrada = value is null ? -1 : (int)value;
                else if (row == 3 && col == 6) // Salida mañana
                    horario.J_ToleranciaSalida = value is null ? -1 : (int)value;

                // Viernes
                if (row == 4 && col == 3) // Entrada mañana
                    horario.V_ToleranciaEntrada = value is null ? -1 : (int)value;
                else if (row == 4 && col == 5) // Salida mañana
                    horario.V_ToleranciaSalida = value is null ? -1 : (int)value;

                // Sabado
                if (row == 5 && col == 3) // Entrada mañana
                    horario.S_ToleranciaEntrada = value is null ? -1 : (int)value;
                else if (row == 5 && col == 6) // Salida mañana
                    horario.S_ToleranciaSalida = value is null ? -1 : (int)value;

                // Domingo
                if (row == 6 && col == 3) // Entrada mañana
                    horario.D_ToleranciaEntrada = value is null ? -1 : (int)value;
                else if (row == 6 && col == 6) // Salida mañana
                    horario.D_ToleranciaSalida = value is null ? -1 : (int)value;
            }
            else
            {
                DateTime? valor;
                var lflag = DateTime.TryParse((string)value, out DateTime result);

                // Lunes 
                //
                if (row == 0 && col == 1) // Entrada mañana
                    horario.L_EntradaMañana = !lflag ? "" : result.ToString("HH:mm");
                else if (row == 0 && col == 2) // Salida mañana
                    horario.L_SalidaMañana = !lflag ? "" : result.ToString("HH:mm");
                else if (row == 0 && col == 4) // Entrada Tarde
                    horario.L_EntradaTarde = !lflag ? "" : result.ToString("HH:mm");
                else if (row == 0 && col == 5) // Salida Tarde
                    horario.L_SalidaTarde = !lflag ? "" : result.ToString("HH:mm");

                // Martes
                //
                if (row == 1 && col == 1) // Entrada mañana
                    horario.M_EntradaMañana = !lflag ? "" : result.ToString("HH:mm");
                else if (row == 1 && col == 2) // Salida mañana
                    horario.M_SalidaMañana = !lflag ? "" : result.ToString("HH:mm");
                else if (row == 1 && col == 4) // Entrada Tarde
                    horario.M_EntradaTarde = !lflag ? "" : result.ToString("HH:mm");
                else if (row == 1 && col == 5) // Salida Tarde
                    horario.M_SalidaTarde = !lflag ? "" : result.ToString("HH:mm");

                // Miercoles
                //
                if (row == 2 && col == 1) // Entrada mañana
                    horario.X_EntradaMañana = !lflag ? "" : result.ToString("HH:mm");
                else if (row == 2 && col == 2) // Salida mañana
                    horario.X_SalidaMañana = !lflag ? "" : result.ToString("HH:mm");
                else if (row == 2 && col == 4) // Entrada Tarde
                    horario.X_EntradaTarde = !lflag ? "" : result.ToString("HH:mm");
                else if (row == 2 && col == 5) // Salida Tarde
                    horario.X_SalidaTarde = !lflag ? "" : result.ToString("HH:mm");

                // Jueves
                //
                if (row == 3 && col == 1) // Entrada mañana
                    horario.J_EntradaMañana = !lflag ? "" : result.ToString("HH:mm");
                else if (row == 3 && col == 2) // Salida mañana
                    horario.J_SalidaMañana = !lflag ? "" : result.ToString("HH:mm");
                else if (row == 3 && col == 4) // Entrada Tarde
                    horario.J_EntradaTarde = !lflag ? "" : result.ToString("HH:mm");
                else if (row == 3 && col == 5) // Salida Tarde
                    horario.J_SalidaTarde = !lflag ? "" : result.ToString("HH:mm");

                // Viernes
                //
                if (row == 4 && col == 1) // Entrada mañana
                    horario.V_EntradaMañana = !lflag ? "" : result.ToString("HH:mm");
                else if (row == 4 && col == 2) // Salida mañana
                    horario.V_SalidaMañana = !lflag ? "" : result.ToString("HH:mm");
                else if (row == 4 && col == 4) // Entrada Tarde
                    horario.V_EntradaTarde = !lflag ? "" : result.ToString("HH:mm");
                else if (row == 4 && col == 5) // Salida Tarde
                    horario.V_SalidaTarde = !lflag ? "" : result.ToString("HH:mm");

                // Sábado
                //
                if (row == 5 && col == 1) // Entrada mañana
                    horario.S_EntradaMañana = !lflag ? "" : result.ToString("HH:mm");
                else if (row == 5 && col == 2) // Salida mañana
                    horario.S_SalidaMañana = !lflag ? "" : result.ToString("HH:mm");
                else if (row == 5 && col == 4) // Entrada Tarde
                    horario.S_EntradaTarde = !lflag ? "" : result.ToString("HH:mm");
                else if (row == 5 && col == 5) // Salida Tarde
                    horario.S_SalidaTarde = !lflag ? "" : result.ToString("HH:mm");

                // Domingo
                //
                if (row == 6 && col == 1) // Entrada mañana
                    horario.D_EntradaMañana = !lflag ? "" : result.ToString("HH:mm");
                else if (row == 6 && col == 2) // Salida mañana
                    horario.D_SalidaMañana = !lflag ? "" : result.ToString("HH:mm");
                else if (row == 6 && col == 4) // Entrada Tarde
                    horario.D_EntradaTarde = !lflag ? "" : result.ToString("HH:mm");
                else if (row == 6 && col == 5) // Salida Tarde
                    horario.D_SalidaTarde = !lflag ? "" : result.ToString("HH:mm");
            }
        }

        private void dgHorario_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is TextBox)
            {
                editBox = e.Control as TextBox;
                editBox.MaxLength = 4;
                editBox.KeyPress += EditBox_KeyPress;
                editBox.Leave += EditBox_Leave;
            }
        }

        private void dgHorario_Leave(object sender, EventArgs e)
        {
            DateTime Hora = default;
            int Tolerancia = 0;
            var cell = dgHorario.SelectedCells[0];
            try
            {
                // Horas
                if (cell.ColumnIndex == 1 ||
                    cell.ColumnIndex == 2 ||
                    cell.ColumnIndex == 4 ||
                    cell.ColumnIndex == 5)
                {
                    Hora = DateTime.ParseExact(((TextBox)sender).Text, "HHmm", CultureInfo.InvariantCulture);
                    dgHorario.Rows[cell.RowIndex].Cells[cell.ColumnIndex].Value = Hora.ToString("HH:mm");

                    // Lunes 
                    //
                    if (cell.RowIndex == 0 && cell.ColumnIndex == 1) // Entrada mañana
                        horario.L_EntradaMañana = Hora.ToString("HH:mm");
                    else if (cell.RowIndex == 0 && cell.ColumnIndex == 2) // Salida mañana
                        horario.L_SalidaMañana = Hora.ToString("HH:mm");
                    else if (cell.RowIndex == 0 && cell.ColumnIndex == 3) // Entrada Tarde
                        horario.L_EntradaTarde = Hora.ToString("HH:mm");
                    else if (cell.RowIndex == 0 && cell.ColumnIndex == 4) // Salida Tarde
                        horario.L_SalidaTarde = Hora.ToString("HH:mm");

                    // Martes
                    //
                    if (cell.RowIndex == 0 && cell.ColumnIndex == 1) // Entrada mañana
                        horario.M_EntradaMañana = Hora.ToString("HH:mm");
                    else if (cell.RowIndex == 0 && cell.ColumnIndex == 2) // Salida mañana
                        horario.M_SalidaMañana = Hora.ToString("HH:mm");
                    else if (cell.RowIndex == 0 && cell.ColumnIndex == 3) // Entrada Tarde
                        horario.M_EntradaTarde = Hora.ToString("HH:mm");
                    else if (cell.RowIndex == 0 && cell.ColumnIndex == 4) // Salida Tarde
                        horario.M_SalidaTarde = Hora.ToString("HH:mm");

                    // Miercoles
                    //
                    if (cell.RowIndex == 0 && cell.ColumnIndex == 1) // Entrada mañana
                        horario.X_EntradaMañana = Hora.ToString("HH:mm");
                    else if (cell.RowIndex == 0 && cell.ColumnIndex == 2) // Salida mañana
                        horario.X_SalidaMañana = Hora.ToString("HH:mm");
                    else if (cell.RowIndex == 0 && cell.ColumnIndex == 3) // Entrada Tarde
                        horario.X_EntradaTarde = Hora.ToString("HH:mm");
                    else if (cell.RowIndex == 0 && cell.ColumnIndex == 4) // Salida Tarde
                        horario.X_SalidaTarde = Hora.ToString("HH:mm");

                    // Jueves
                    //
                    if (cell.RowIndex == 0 && cell.ColumnIndex == 1) // Entrada mañana
                        horario.J_EntradaMañana = Hora.ToString("HH:mm");
                    else if (cell.RowIndex == 0 && cell.ColumnIndex == 2) // Salida mañana
                        horario.J_SalidaMañana = Hora.ToString("HH:mm");
                    else if (cell.RowIndex == 0 && cell.ColumnIndex == 3) // Entrada Tarde
                        horario.J_EntradaTarde = Hora.ToString("HH:mm");
                    else if (cell.RowIndex == 0 && cell.ColumnIndex == 4) // Salida Tarde
                        horario.J_SalidaTarde = Hora.ToString("HH:mm");

                    // Viernes
                    //
                    if (cell.RowIndex == 0 && cell.ColumnIndex == 1) // Entrada mañana
                        horario.V_EntradaMañana = Hora.ToString("HH:mm");
                    else if (cell.RowIndex == 0 && cell.ColumnIndex == 2) // Salida mañana
                        horario.V_SalidaMañana = Hora.ToString("HH:mm");
                    else if (cell.RowIndex == 0 && cell.ColumnIndex == 3) // Entrada Tarde
                        horario.V_EntradaTarde = Hora.ToString("HH:mm");
                    else if (cell.RowIndex == 0 && cell.ColumnIndex == 4) // Salida Tarde
                        horario.V_SalidaTarde = Hora.ToString("HH:mm");

                    // Sábado
                    //
                    if (cell.RowIndex == 0 && cell.ColumnIndex == 1) // Entrada mañana
                        horario.S_EntradaMañana = Hora.ToString("HH:mm");
                    else if (cell.RowIndex == 0 && cell.ColumnIndex == 2) // Salida mañana
                        horario.S_SalidaMañana = Hora.ToString("HH:mm");
                    else if (cell.RowIndex == 0 && cell.ColumnIndex == 3) // Entrada Tarde
                        horario.S_EntradaTarde = Hora.ToString("HH:mm");
                    else if (cell.RowIndex == 0 && cell.ColumnIndex == 4) // Salida Tarde
                        horario.S_SalidaTarde = Hora.ToString("HH:mm");

                    // Domingo
                    //
                    if (cell.RowIndex == 0 && cell.ColumnIndex == 1) // Entrada mañana
                        horario.D_EntradaMañana = Hora.ToString("HH:mm");
                    else if (cell.RowIndex == 0 && cell.ColumnIndex == 2) // Salida mañana
                        horario.D_SalidaMañana = Hora.ToString("HH:mm");
                    else if (cell.RowIndex == 0 && cell.ColumnIndex == 3) // Entrada Tarde
                        horario.D_EntradaTarde = Hora.ToString("HH:mm");
                    else if (cell.RowIndex == 0 && cell.ColumnIndex == 4) // Salida Tarde
                        horario.D_SalidaTarde = Hora.ToString("HH:mm");
                }
                // Tolerancias
                //
                else if (cell.ColumnIndex == 3 || cell.ColumnIndex == 6)
                {
                    if (string.IsNullOrEmpty(((TextBox)sender).Text))
                        Tolerancia = 0;
                    else
                        Tolerancia = int.Parse(((TextBox)sender).Text);

                    // Lunes
                    //
                    if (cell.RowIndex == 0 && cell.ColumnIndex == 3)
                        horario.L_ToleranciaEntrada = Tolerancia;
                    else if (cell.RowIndex == 0 && cell.RowIndex == 6)
                        horario.L_ToleranciaSalida = Tolerancia;

                    // Martes
                    //
                    if (cell.RowIndex == 1 && cell.ColumnIndex == 3)
                        horario.M_ToleranciaEntrada = Tolerancia;
                    else
                        horario.M_ToleranciaSalida = Tolerancia;

                    // Miercoles
                    // 
                    if (cell.RowIndex == 2 && cell.ColumnIndex == 3)
                        horario.X_ToleranciaEntrada = Tolerancia;
                    else if (cell.RowIndex == 2 && cell.RowIndex == 6)
                        horario.X_ToleranciaSalida = Tolerancia;

                    // Jueves
                    //
                    if (cell.RowIndex == 3 && cell.ColumnIndex == 3)
                        horario.J_ToleranciaEntrada = Tolerancia;
                    else if (cell.RowIndex == 3 && cell.ColumnIndex == 6)
                        horario.J_ToleranciaSalida = Tolerancia;

                    // Viernes
                    //
                    if (cell.RowIndex == 4 && cell.ColumnIndex == 3)
                        horario.V_ToleranciaEntrada = Tolerancia;
                    else if (cell.RowIndex == 4 && cell.ColumnIndex == 6)
                        horario.V_ToleranciaSalida = Tolerancia;

                    // Sabado
                    // 
                    if (cell.RowIndex == 5 && cell.ColumnIndex == 3)
                        horario.S_ToleranciaEntrada = Tolerancia;
                    else if (cell.RowIndex == 5 && cell.ColumnIndex == 6)
                        horario.S_ToleranciaSalida = Tolerancia;

                    // Domingo
                    //
                    if (cell.RowIndex == 6 && cell.ColumnIndex == 3)
                        horario.D_ToleranciaEntrada = Tolerancia;
                    else if (cell.RowIndex == 6 && cell.ColumnIndex == 6)
                        horario.D_ToleranciaSalida = Tolerancia;
                }

            }
            catch
            {

            }

        }

        private void DespliegaHorario()
        {
            if (this.horario is null)
                return;

            this.dgHorario.Rows.Clear();
            this.dgHorario.Rows.Add("Lunes", horario.L_EntradaMañana, horario.L_SalidaMañana, horario.L_ToleranciaEntrada, horario.L_EntradaTarde, horario.L_SalidaTarde);
            this.dgHorario.Rows.Add("Martes", horario.M_EntradaMañana, horario.M_SalidaMañana, horario.M_ToleranciaEntrada, horario.M_EntradaTarde, horario.M_SalidaTarde);
            this.dgHorario.Rows.Add("Miércoles", horario.X_EntradaMañana, horario.X_SalidaMañana, horario.X_ToleranciaEntrada, horario.X_EntradaTarde, horario.X_SalidaTarde);
            this.dgHorario.Rows.Add("Jueves", horario.J_EntradaMañana, horario.J_SalidaMañana, horario.J_ToleranciaEntrada, horario.J_EntradaTarde, horario.J_SalidaTarde);
            this.dgHorario.Rows.Add("Viernes", horario.V_EntradaMañana, horario.V_SalidaMañana, horario.V_ToleranciaEntrada, horario.V_EntradaTarde, horario.V_SalidaTarde);
            this.dgHorario.Rows.Add("Sábado", horario.S_EntradaMañana, horario.S_SalidaMañana, horario.S_ToleranciaEntrada, horario.S_EntradaTarde, horario.S_SalidaTarde);
            this.dgHorario.Rows.Add("Domingo", horario.D_EntradaMañana, horario.D_SalidaMañana, horario.D_ToleranciaEntrada, horario.D_EntradaTarde, horario.D_SalidaTarde);
        }
        #endregion

        #region Editor Texto
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
        #endregion


        private void dgHorario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                var cell = dgHorario.SelectedCells[0];
                dgHorario.Rows[cell.RowIndex].Cells[cell.ColumnIndex].Value = "";
                ActualizaRegistro(cell.RowIndex, cell.ColumnIndex, cell.Value);
            }
        }
    }

    public enum DiaSemana
    {
        Lunes = 0,
        Martes = 1,
        Miércoles = 2,
        Jueves = 3,
        Viernes = 4,
        Sábado = 5,
        Domingo = 6
    }

}
