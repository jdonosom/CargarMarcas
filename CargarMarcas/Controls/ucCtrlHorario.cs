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
                    var Hora = DateTime.ParseExact(dateTime, "yyyy-MM-dd HHmm", CultureInfo.InvariantCulture);
                    dgHorario.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Hora;
                }
                ActualizaRegistro(e.RowIndex, e.ColumnIndex, dgHorario.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);

            }
            lEdit = false;
        }

        private void ActualizaRegistro(int row, int col, object value)
        {
            if (col == 3 || col == 6)
            {
                // Lunes
                if (row == 0 && col == 3) // Entrada mañana
                    horario.L_ToleranciaEntrada = Convert.ToInt16(value);
                else if (row == 0 && col == 5) // Salida mañana
                    horario.L_ToleranciaSalida = Convert.ToInt16(value);

                // Lunes
                if (row == 1 && col == 3) // Entrada mañana
                    horario.M_ToleranciaEntrada = Convert.ToInt16(value);
                else if (row == 1 && col == 5) // Salida mañana
                    horario.M_ToleranciaSalida = Convert.ToInt16(value);

                // Lunes
                if (row == 2 && col == 3) // Entrada mañana
                    horario.X_ToleranciaEntrada = Convert.ToInt16(value);
                else if (row == 2 && col == 5) // Salida mañana
                    horario.X_ToleranciaSalida = Convert.ToInt16(value);

                // Lunes
                if (row == 3 && col == 3) // Entrada mañana
                    horario.J_ToleranciaEntrada = Convert.ToInt16(value);
                else if (row == 3 && col == 5) // Salida mañana
                    horario.J_ToleranciaSalida = Convert.ToInt16(value);

                // Lunes
                if (row == 4 && col == 3) // Entrada mañana
                    horario.V_ToleranciaEntrada = Convert.ToInt16(value);
                else if (row == 4 && col == 5) // Salida mañana
                    horario.V_ToleranciaSalida = Convert.ToInt16(value);

                // Lunes
                if (row == 5 && col == 3) // Entrada mañana
                    horario.S_ToleranciaEntrada = Convert.ToInt16(value);
                else if (row == 5 && col == 5) // Salida mañana
                    horario.S_ToleranciaSalida = Convert.ToInt16(value);

                // Lunes
                if (row == 6 && col == 3) // Entrada mañana
                    horario.D_ToleranciaEntrada = Convert.ToInt16(value);
                else if (row == 6 && col == 5) // Salida mañana
                    horario.D_ToleranciaSalida = Convert.ToInt16(value);
            }
            else
            {
                // Lunes 
                //
                if (row == 0 && col == 1) // Entrada mañana
                    horario.L_EntradaMañana = (DateTime)value;
                else if (row == 0 && col == 2) // Salida mañana
                    horario.L_SalidaMañana = (DateTime)value;
                else if (row == 0 && col == 3) // Entrada Tarde
                    horario.L_EntradaTarde = (DateTime)value;
                else if (row == 0 && col == 4) // Salida Tarde
                    horario.L_SalidaTarde = (DateTime)value;

                // Martes
                //
                if (row == 1 && col == 1) // Entrada mañana
                    horario.M_EntradaMañana = (DateTime)value;
                else if (row == 1 && col == 2) // Salida mañana
                    horario.M_SalidaMañana = (DateTime)value;
                else if (row == 1 && col == 3) // Entrada Tarde
                    horario.M_EntradaTarde = (DateTime)value;
                else if (row == 1 && col == 4) // Salida Tarde
                    horario.M_SalidaTarde = (DateTime)value;

                // Miercoles
                //
                if (row == 2 && col == 1) // Entrada mañana
                    horario.X_EntradaMañana = (DateTime)value;
                else if (row == 2 && col == 2) // Salida mañana
                    horario.X_SalidaMañana = (DateTime)value;
                else if (row == 2 && col == 3) // Entrada Tarde
                    horario.X_EntradaTarde = (DateTime)value;
                else if (row == 2 && col == 4) // Salida Tarde
                    horario.X_SalidaTarde = (DateTime)value;

                // Jueves
                //
                if (row == 3 && col == 1) // Entrada mañana
                    horario.J_EntradaMañana = (DateTime)value;
                else if (row == 3 && col == 2) // Salida mañana
                    horario.J_SalidaMañana = (DateTime)value;
                else if (row == 3 && col == 3) // Entrada Tarde
                    horario.J_EntradaTarde = (DateTime)value;
                else if (row == 3 && col == 4) // Salida Tarde
                    horario.J_SalidaTarde = (DateTime)value;

                // Viernes
                //
                if (row == 4 && col == 1) // Entrada mañana
                    horario.V_EntradaMañana = (DateTime)value;
                else if (row == 4 && col == 2) // Salida mañana
                    horario.V_SalidaMañana = (DateTime)value;
                else if (row == 4 && col == 3) // Entrada Tarde
                    horario.V_EntradaTarde = (DateTime)value;
                else if (row == 4 && col == 4) // Salida Tarde
                    horario.V_SalidaTarde = (DateTime)value;

                // Sábado
                //
                if (row == 5 && col == 1) // Entrada mañana
                    horario.S_EntradaMañana = (DateTime)value;
                else if (row == 5 && col == 2) // Salida mañana
                    horario.S_SalidaMañana = (DateTime)value;
                else if (row == 5 && col == 3) // Entrada Tarde
                    horario.S_EntradaTarde = (DateTime)value;
                else if (row == 5 && col == 4) // Salida Tarde
                    horario.S_SalidaTarde = (DateTime)value;

                // Domingo
                //
                if (row == 6 && col == 1) // Entrada mañana
                    horario.D_EntradaMañana = (DateTime)value;
                else if (row == 6 && col == 2) // Salida mañana
                    horario.D_SalidaMañana = (DateTime)value;
                else if (row == 6 && col == 3) // Entrada Tarde
                    horario.D_EntradaTarde = (DateTime)value;
                else if (row == 6 && col == 4) // Salida Tarde
                    horario.D_SalidaTarde = (DateTime)value;
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
                        horario.L_EntradaMañana = Hora;
                    else if (cell.RowIndex == 0 && cell.ColumnIndex == 2) // Salida mañana
                        horario.L_SalidaMañana = Hora;
                    else if (cell.RowIndex == 0 && cell.ColumnIndex == 3) // Entrada Tarde
                        horario.L_EntradaTarde = Hora;
                    else if (cell.RowIndex == 0 && cell.ColumnIndex == 4) // Salida Tarde
                        horario.L_SalidaTarde = Hora;

                    // Martes
                    //
                    if (cell.RowIndex == 0 && cell.ColumnIndex == 1) // Entrada mañana
                        horario.M_EntradaMañana = Hora;
                    else if (cell.RowIndex == 0 && cell.ColumnIndex == 2) // Salida mañana
                        horario.M_SalidaMañana = Hora;
                    else if (cell.RowIndex == 0 && cell.ColumnIndex == 3) // Entrada Tarde
                        horario.M_EntradaTarde = Hora;
                    else if (cell.RowIndex == 0 && cell.ColumnIndex == 4) // Salida Tarde
                        horario.M_SalidaTarde = Hora;

                    // Miercoles
                    //
                    if (cell.RowIndex == 0 && cell.ColumnIndex == 1) // Entrada mañana
                        horario.X_EntradaMañana = Hora;
                    else if (cell.RowIndex == 0 && cell.ColumnIndex == 2) // Salida mañana
                        horario.X_SalidaMañana = Hora;
                    else if (cell.RowIndex == 0 && cell.ColumnIndex == 3) // Entrada Tarde
                        horario.X_EntradaTarde = Hora;
                    else if (cell.RowIndex == 0 && cell.ColumnIndex == 4) // Salida Tarde
                        horario.X_SalidaTarde = Hora;

                    // Jueves
                    //
                    if (cell.RowIndex == 0 && cell.ColumnIndex == 1) // Entrada mañana
                        horario.J_EntradaMañana = Hora;
                    else if (cell.RowIndex == 0 && cell.ColumnIndex == 2) // Salida mañana
                        horario.J_SalidaMañana = Hora;
                    else if (cell.RowIndex == 0 && cell.ColumnIndex == 3) // Entrada Tarde
                        horario.J_EntradaTarde = Hora;
                    else if (cell.RowIndex == 0 && cell.ColumnIndex == 4) // Salida Tarde
                        horario.J_SalidaTarde = Hora;

                    // Viernes
                    //
                    if (cell.RowIndex == 0 && cell.ColumnIndex == 1) // Entrada mañana
                        horario.V_EntradaMañana = Hora;
                    else if (cell.RowIndex == 0 && cell.ColumnIndex == 2) // Salida mañana
                        horario.V_SalidaMañana = Hora;
                    else if (cell.RowIndex == 0 && cell.ColumnIndex == 3) // Entrada Tarde
                        horario.V_EntradaTarde = Hora;
                    else if (cell.RowIndex == 0 && cell.ColumnIndex == 4) // Salida Tarde
                        horario.V_SalidaTarde = Hora;

                    // Sábado
                    //
                    if (cell.RowIndex == 0 && cell.ColumnIndex == 1) // Entrada mañana
                        horario.S_EntradaMañana = Hora;
                    else if (cell.RowIndex == 0 && cell.ColumnIndex == 2) // Salida mañana
                        horario.S_SalidaMañana = Hora;
                    else if (cell.RowIndex == 0 && cell.ColumnIndex == 3) // Entrada Tarde
                        horario.S_EntradaTarde = Hora;
                    else if (cell.RowIndex == 0 && cell.ColumnIndex == 4) // Salida Tarde
                        horario.S_SalidaTarde = Hora;

                    // Domingo
                    //
                    if (cell.RowIndex == 0 && cell.ColumnIndex == 1) // Entrada mañana
                        horario.D_EntradaMañana = Hora;
                    else if (cell.RowIndex == 0 && cell.ColumnIndex == 2) // Salida mañana
                        horario.D_SalidaMañana = Hora;
                    else if (cell.RowIndex == 0 && cell.ColumnIndex == 3) // Entrada Tarde
                        horario.D_EntradaTarde = Hora;
                    else if (cell.RowIndex == 0 && cell.ColumnIndex == 4) // Salida Tarde
                        horario.D_SalidaTarde = Hora;
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
            this.dgHorario.Rows.Add("Lunes", horario.L_EntradaMañana?.ToString(@"HH\:mm"), horario.L_SalidaMañana?.ToString(@"HH\:mm"), horario.L_ToleranciaEntrada, horario.L_EntradaTarde?.ToString(@"HH\:mm"), horario.L_SalidaTarde?.ToString(@"HH\:mm"));
            this.dgHorario.Rows.Add("Martes", horario.M_EntradaMañana?.ToString(@"HH\:mm"), horario.M_SalidaMañana?.ToString(@"HH\:mm"), horario.M_ToleranciaEntrada, horario.M_EntradaTarde?.ToString(@"HH\:mm"), horario.M_SalidaTarde?.ToString(@"HH\:mm"));
            this.dgHorario.Rows.Add("Miércoles", horario.X_EntradaMañana?.ToString(@"HH\:mm"), horario.X_SalidaMañana?.ToString(@"HH\:mm"), horario.X_ToleranciaEntrada, horario.X_EntradaTarde?.ToString(@"HH\:mm"), horario.X_SalidaTarde?.ToString(@"HH\:mm"));
            this.dgHorario.Rows.Add("Jueves", horario.J_EntradaMañana?.ToString(@"HH\:mm"), horario.J_SalidaMañana?.ToString(@"HH\:mm"), horario.J_ToleranciaEntrada, horario.J_EntradaTarde?.ToString(@"HH\:mm"), horario.J_SalidaTarde?.ToString(@"HH\:mm"));
            this.dgHorario.Rows.Add("Viernes", horario.V_EntradaMañana?.ToString(@"HH\:mm"), horario.V_SalidaMañana?.ToString(@"HH\:mm"), horario.V_ToleranciaEntrada, horario.V_EntradaTarde?.ToString(@"HH\:mm"), horario.V_SalidaTarde?.ToString(@"HH\:mm"));
            this.dgHorario.Rows.Add("Sábado", horario.S_EntradaMañana?.ToString(@"HH\:mm"), horario.S_SalidaMañana?.ToString(@"HH\:mm"), horario.S_ToleranciaEntrada, horario.S_EntradaTarde?.ToString(@"HH\:mm"), horario.S_SalidaTarde?.ToString(@"HH\:mm"));
            this.dgHorario.Rows.Add("Domingo", horario.D_EntradaMañana?.ToString(@"HH\:mm"), horario.D_SalidaMañana?.ToString(@"HH\:mm"), horario.D_ToleranciaEntrada, horario.D_EntradaTarde?.ToString(@"HH\:mm"), horario.D_SalidaTarde?.ToString(@"HH\:mm"));
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
