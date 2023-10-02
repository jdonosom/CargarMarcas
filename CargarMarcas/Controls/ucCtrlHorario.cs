using BLSGM.interfaces;
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

        #region Evento
        public event EventHandler Recalcular;
        #endregion

        #region Metodo publico

        public void Clear()
        {
            horario = null;

            this.lblHorario.Text = string.Empty;
            this.dgHorario.Rows.Clear();

            if (this.Recalcular is not null)
            {
                CalculaHorasSemanales(horario);
                this.Recalcular(this, null);
            }
        }

        private Horario horario;
        private string descripcion;
        private int horasSemanales;

        public int HorasSemanales
        {
            get { return horasSemanales; }
            private set { horasSemanales = value; }
        }


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

                if (value is not null)
                {
                    #region Asignacion de datos
                    value.Lunes = (true) ? "S" : "N";
                    value.L_EntradaMañana = IsNull(((Horario)value).L_EntradaMañana, "");
                    value.L_SalidaMañana = IsNull(((Horario)value).L_SalidaMañana, "");
                    value.L_ToleranciaEntrada = IsNull(((Horario)value).L_ToleranciaEntrada, null);
                    value.L_EntradaTarde = IsNull(((Horario)value).L_EntradaTarde, "");
                    value.L_SalidaTarde = IsNull(((Horario)value).L_SalidaTarde, "");
                    value.L_ToleranciaSalida = IsNull(((Horario)value).L_ToleranciaSalida, null);

                    value.Martes = "S";
                    value.M_EntradaMañana = IsNull(((Horario)value).M_EntradaMañana, null);
                    value.M_SalidaMañana = IsNull(((Horario)value).M_SalidaMañana, null);
                    value.M_ToleranciaEntrada = IsNull(((Horario)value).M_ToleranciaEntrada, null);
                    value.M_EntradaTarde = IsNull(((Horario)value).M_EntradaTarde, null);
                    value.M_SalidaTarde = IsNull(((Horario)value).M_SalidaTarde, null);
                    value.M_ToleranciaSalida = IsNull(((Horario)value).M_ToleranciaSalida, null);

                    value.Miercoles = "S";
                    value.X_EntradaMañana = IsNull(((Horario)value).X_EntradaMañana, null);
                    value.X_SalidaMañana = IsNull(((Horario)value).X_SalidaMañana, null);
                    value.X_ToleranciaEntrada = IsNull(((Horario)value).X_ToleranciaEntrada, null);
                    value.X_EntradaTarde = IsNull(((Horario)value).X_EntradaTarde, null);
                    value.X_SalidaTarde = IsNull(((Horario)value).X_SalidaTarde, null);
                    value.X_ToleranciaSalida = IsNull(((Horario)value).X_ToleranciaSalida, null);

                    value.Jueves = "S";
                    value.J_EntradaMañana = IsNull(((Horario)value).J_EntradaMañana, null);
                    value.J_SalidaMañana = IsNull(((Horario)value).J_SalidaMañana, null);
                    value.J_ToleranciaEntrada = IsNull(((Horario)value).J_ToleranciaEntrada, null);
                    value.J_EntradaTarde = IsNull(((Horario)value).J_EntradaTarde, null);
                    value.J_SalidaTarde = IsNull(((Horario)value).J_SalidaTarde, null);
                    value.J_ToleranciaSalida = IsNull(((Horario)value).J_ToleranciaSalida, null);

                    value.Viernes = "S";
                    value.V_EntradaMañana = IsNull(((Horario)value).V_EntradaMañana, null);
                    value.V_SalidaMañana = IsNull(((Horario)value).V_SalidaMañana, null);
                    value.V_ToleranciaEntrada = IsNull(((Horario)value).V_ToleranciaEntrada, null);
                    value.V_EntradaTarde = IsNull(((Horario)value).V_EntradaTarde, null);
                    value.V_SalidaTarde = IsNull(((Horario)value).V_SalidaTarde, null);
                    value.V_ToleranciaSalida = IsNull(((Horario)value).V_ToleranciaSalida, null);

                    value.Sabado = "S";
                    value.S_EntradaMañana = IsNull(((Horario)value).S_EntradaMañana, null);
                    value.S_SalidaMañana = IsNull(((Horario)value).S_SalidaMañana, null);
                    value.S_ToleranciaEntrada = IsNull(((Horario)value).S_ToleranciaEntrada, null);
                    value.S_EntradaTarde = IsNull(((Horario)value).S_EntradaTarde, null);
                    value.S_SalidaTarde = IsNull(((Horario)value).S_SalidaTarde, null);
                    value.S_ToleranciaSalida = IsNull(((Horario)value).S_ToleranciaSalida, null);

                    value.Domingo = "S";
                    value.D_EntradaMañana = IsNull(((Horario)value).D_EntradaMañana, null);
                    value.D_SalidaMañana = IsNull(((Horario)value).D_SalidaMañana, null);
                    value.D_ToleranciaEntrada = IsNull(((Horario)value).D_ToleranciaEntrada, null);
                    value.D_EntradaTarde = IsNull(((Horario)value).D_EntradaTarde, null);
                    value.D_SalidaTarde = IsNull(((Horario)value).D_SalidaTarde, null);
                    value.D_ToleranciaSalida = IsNull(((Horario)value).D_ToleranciaSalida, null);
                    #endregion
                    horario = value;
                    CalculaHorasSemanales(horario);
                    DespliegaHorario();
                }
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
            //if (dgHorario.Rows[cell.RowIndex].Cells[cell.ColumnIndex].Value is null)
            if (string.IsNullOrWhiteSpace(cell.Value.ToString()) || cell is null)
                return;

            lChange = true;
            // Convertir HH:mm a HHmm para la edición
            //
            var dato = dgHorario.Rows[cell.RowIndex].Cells[cell.ColumnIndex].Value.ToString();
            var hora = DateTime.ParseExact(dato, "HH:mm", CultureInfo.InvariantCulture).ToString("HHmm");
            dgHorario.Rows[cell.RowIndex].Cells[cell.ColumnIndex].Value = hora;
            ValorEdit = hora;

        }




        private void dgHorario_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(editBox.Text))
                return;

            if (lEdit)
            {
                if (e.ColumnIndex == 3 || e.ColumnIndex == 6)
                {
                    dgHorario.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = editBox.Text;
                }
                else
                {
                    var dateTime = $"1900-01-01 {editBox.Text}";
                    var Hora = DateTime.ParseExact(dateTime, "yyyy-MM-dd HHmm", CultureInfo.InvariantCulture).ToString("HH:mm");
                    dgHorario.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Hora;
                }
                ActualizaRegistro(e.RowIndex, e.ColumnIndex, dgHorario.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                if (this.Recalcular is not null)
                    this.Recalcular(this, null);
            }
            lEdit = false;
        }

        private void ActualizaRegistro(int row, int col, string value)
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
                    horario.L_ToleranciaEntrada = string.IsNullOrWhiteSpace(value) ? "" : value;
                else if (row == 0 && col == 6) // Salida mañana
                    horario.L_ToleranciaSalida = string.IsNullOrWhiteSpace(value) ? "" : value;

                // Martes
                if (row == 1 && col == 3) // Entrada mañana
                    horario.M_ToleranciaEntrada = string.IsNullOrWhiteSpace(value) ? "" : value;
                else if (row == 1 && col == 6) // Salida mañana
                    horario.M_ToleranciaSalida = string.IsNullOrWhiteSpace(value) ? "" : value;

                // Miercoles
                if (row == 2 && col == 3) // Entrada mañana
                    horario.X_ToleranciaEntrada = string.IsNullOrWhiteSpace(value) ? "" : value;
                else if (row == 2 && col == 6) // Salida mañana
                    horario.X_ToleranciaSalida = string.IsNullOrWhiteSpace(value) ? "" : value;

                // Jueves
                if (row == 3 && col == 3) // Entrada mañana
                    horario.J_ToleranciaEntrada = string.IsNullOrWhiteSpace(value) ? "" : value;
                else if (row == 3 && col == 6) // Salida mañana
                    horario.J_ToleranciaSalida = string.IsNullOrWhiteSpace(value) ? "" : value;

                // Viernes
                if (row == 4 && col == 3) // Entrada mañana
                    horario.V_ToleranciaEntrada = string.IsNullOrWhiteSpace(value) ? "" : value;
                else if (row == 4 && col == 6) // Salida mañana
                    horario.V_ToleranciaSalida = string.IsNullOrWhiteSpace(value) ? "" : value;

                // Sabado
                if (row == 5 && col == 3) // Entrada mañana
                    horario.S_ToleranciaEntrada = string.IsNullOrWhiteSpace(value) ? "" : value;
                else if (row == 5 && col == 6) // Salida mañana
                    horario.S_ToleranciaSalida = string.IsNullOrWhiteSpace(value) ? "" : value;

                // Domingo
                if (row == 6 && col == 3) // Entrada mañana
                    horario.D_ToleranciaEntrada = string.IsNullOrWhiteSpace(value) ? "" : value;
                else if (row == 6 && col == 6) // Salida mañana
                    horario.D_ToleranciaSalida = string.IsNullOrWhiteSpace(value) ? "" : value;
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

            CalculaHorasSemanales(horario);


        }

        /// <summary>
        /// Calcular la cantidad de hora semanales del horario
        /// </summary>
        /// <param name="horario">Horario a calcular</param>
        private void CalculaHorasSemanales(Horario horario)
        {
            horasSemanales = 0;
            if (horario is null)
                return;
            // Lunes
            horasSemanales += string.IsNullOrWhiteSpace(horario.L_EntradaMañana) || string.IsNullOrEmpty(horario.L_SalidaMañana) ? 0 :
             (
                 DateTime.ParseExact(horario.L_SalidaMañana, "HH:mm", CultureInfo.InvariantCulture).Subtract(
                 DateTime.ParseExact(horario.L_EntradaMañana, "HH:mm", CultureInfo.InvariantCulture)).Hours
             );

            horasSemanales += string.IsNullOrWhiteSpace(horario.L_SalidaTarde) || string.IsNullOrEmpty(horario.L_EntradaTarde) ? 0 :
                (
                    DateTime.ParseExact(horario.L_SalidaTarde, "HH:mm", CultureInfo.InvariantCulture).Subtract(
                    DateTime.ParseExact(horario.L_EntradaTarde, "HH:mm", CultureInfo.InvariantCulture)).Hours +
                    (string.IsNullOrWhiteSpace(horario.L_EntradaTarde) ||
                     string.IsNullOrWhiteSpace(horario.L_SalidaTarde) ? 0 : 1)
                );

            // Martes
            horasSemanales += string.IsNullOrWhiteSpace(horario.M_EntradaMañana) || string.IsNullOrEmpty(horario.M_SalidaMañana) ? 0 :
                (
                    DateTime.ParseExact(horario.M_SalidaMañana, "HH:mm", CultureInfo.InvariantCulture).Subtract(
                    DateTime.ParseExact(horario.M_EntradaMañana, "HH:mm", CultureInfo.InvariantCulture)).Hours
                );

            horasSemanales += string.IsNullOrWhiteSpace(horario.M_SalidaTarde) || string.IsNullOrEmpty(horario.M_EntradaTarde) ? 0 :
                (
                    DateTime.ParseExact(horario.M_SalidaTarde, "HH:mm", CultureInfo.InvariantCulture).Subtract(
                    DateTime.ParseExact(horario.M_EntradaTarde, "HH:mm", CultureInfo.InvariantCulture)).Hours +
                    (string.IsNullOrWhiteSpace(horario.M_EntradaTarde) ||
                     string.IsNullOrWhiteSpace(horario.M_SalidaTarde) ? 0 : 1)
                );

            // Miercoles
            horasSemanales += string.IsNullOrWhiteSpace(horario.X_EntradaMañana) || string.IsNullOrEmpty(horario.X_SalidaMañana) ? 0 :
                (
                    DateTime.ParseExact(horario.X_SalidaMañana, "HH:mm", CultureInfo.InvariantCulture).Subtract(
                    DateTime.ParseExact(horario.X_EntradaMañana, "HH:mm", CultureInfo.InvariantCulture)).Hours
                );

            horasSemanales += string.IsNullOrWhiteSpace(horario.X_SalidaTarde) || string.IsNullOrEmpty(horario.X_EntradaTarde) ? 0 :
                (
                    DateTime.ParseExact(horario.X_SalidaTarde, "HH:mm", CultureInfo.InvariantCulture).Subtract(
                    DateTime.ParseExact(horario.X_EntradaTarde, "HH:mm", CultureInfo.InvariantCulture)).Hours +
                    (string.IsNullOrWhiteSpace(horario.X_EntradaTarde) ||
                     string.IsNullOrWhiteSpace(horario.X_SalidaTarde) ? 0 : 1)
                );

            // Jueves
            horasSemanales += string.IsNullOrWhiteSpace(horario.J_EntradaMañana) || string.IsNullOrEmpty(horario.J_SalidaMañana) ? 0 :
                (
                    DateTime.ParseExact(horario.J_SalidaMañana, "HH:mm", CultureInfo.InvariantCulture).Subtract(
                    DateTime.ParseExact(horario.J_EntradaMañana, "HH:mm", CultureInfo.InvariantCulture)).Hours
                );

            horasSemanales += string.IsNullOrWhiteSpace(horario.J_SalidaTarde) || string.IsNullOrEmpty(horario.J_EntradaTarde) ? 0 :
                (
                    DateTime.ParseExact(horario.J_SalidaTarde, "HH:mm", CultureInfo.InvariantCulture).Subtract(
                    DateTime.ParseExact(horario.J_EntradaTarde, "HH:mm", CultureInfo.InvariantCulture)).Hours +
                    (string.IsNullOrWhiteSpace(horario.J_EntradaTarde) ||
                     string.IsNullOrWhiteSpace(horario.J_SalidaTarde) ? 0 : 1)
                );
            // Viernes
            horasSemanales += string.IsNullOrWhiteSpace(horario.V_EntradaMañana) || string.IsNullOrEmpty(horario.V_SalidaMañana) ? 0 :
                (
                    DateTime.ParseExact(horario.V_SalidaMañana, "HH:mm", CultureInfo.InvariantCulture).Subtract(
                    DateTime.ParseExact(horario.V_EntradaMañana, "HH:mm", CultureInfo.InvariantCulture)).Hours
                );

            horasSemanales += string.IsNullOrWhiteSpace(horario.V_SalidaTarde) || string.IsNullOrEmpty(horario.V_EntradaTarde) ? 0 :
                (
                    DateTime.ParseExact(horario.V_SalidaTarde, "HH:mm", CultureInfo.InvariantCulture).Subtract(
                    DateTime.ParseExact(horario.V_EntradaTarde, "HH:mm", CultureInfo.InvariantCulture)).Hours +
                    (string.IsNullOrWhiteSpace(horario.V_EntradaTarde) ||
                     string.IsNullOrWhiteSpace(horario.V_SalidaTarde) ? 0 : 1)
                );
            // Sabado
            horasSemanales += string.IsNullOrWhiteSpace(horario.S_EntradaMañana) || string.IsNullOrEmpty(horario.S_SalidaMañana) ? 0 :
                (
                    DateTime.ParseExact(horario.S_SalidaMañana, "HH:mm", CultureInfo.InvariantCulture).Subtract(
                    DateTime.ParseExact(horario.S_EntradaMañana, "HH:mm", CultureInfo.InvariantCulture)).Hours
                );

            horasSemanales += string.IsNullOrWhiteSpace(horario.S_SalidaTarde) || string.IsNullOrEmpty(horario.S_EntradaTarde) ? 0 :
                (
                    DateTime.ParseExact(horario.S_SalidaTarde, "HH:mm", CultureInfo.InvariantCulture).Subtract(
                    DateTime.ParseExact(horario.S_EntradaTarde, "HH:mm", CultureInfo.InvariantCulture)).Hours +
                    (string.IsNullOrWhiteSpace(horario.S_EntradaTarde) ||
                     string.IsNullOrWhiteSpace(horario.S_SalidaTarde) ? 0 : 1)
                );
            // Domingo
            horasSemanales += string.IsNullOrWhiteSpace(horario.D_EntradaMañana) || string.IsNullOrEmpty(horario.D_SalidaMañana) ? 0 :
                (
                    DateTime.ParseExact(horario.D_SalidaMañana, "HH:mm", CultureInfo.InvariantCulture).Subtract(
                    DateTime.ParseExact(horario.D_EntradaMañana, "HH:mm", CultureInfo.InvariantCulture)).Hours
                );

            horasSemanales += string.IsNullOrWhiteSpace(horario.D_SalidaTarde) || string.IsNullOrEmpty(horario.D_EntradaTarde) ? 0 :
                (
                    DateTime.ParseExact(horario.D_SalidaTarde, "HH:mm", CultureInfo.InvariantCulture).Subtract(
                    DateTime.ParseExact(horario.D_EntradaTarde, "HH:mm", CultureInfo.InvariantCulture)).Hours +
                    (string.IsNullOrWhiteSpace(horario.D_EntradaTarde) ||
                     string.IsNullOrWhiteSpace(horario.D_SalidaTarde) ? 0 : 1)
                );
        }

        private void dgHorario_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is TextBox)
            {
                editBox = e.Control as TextBox;
                editBox.MaxLength = 4;
                editBox.KeyPress += EditBox_KeyPress;
                editBox.KeyDown += EditBox_KeyDown;
                editBox.Leave += EditBox_Leave;
            }
        }

        private void EditBox_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void dgHorario_Leave(object sender, EventArgs e)
        {
            DateTime Hora = default;
            string Tolerancia = "";
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
                        Tolerancia = "";
                    else
                        Tolerancia = ((TextBox)sender).Text;

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
            this.dgHorario.Rows.Add(
                "Lunes",
                IsNull(horario.L_EntradaMañana, ""),
                IsNull(horario.L_SalidaMañana, ""),
                IsNull(horario.L_ToleranciaEntrada, "") == "-1" ? "" : horario.L_ToleranciaEntrada,
                IsNull(horario.L_EntradaTarde, ""),
                IsNull(horario.L_SalidaTarde, ""),
                IsNull(horario.L_ToleranciaSalida, "") == "-1" ? "" : horario.L_ToleranciaSalida
                );

            this.dgHorario.Rows.Add(
                "Martes",
                IsNull(horario.M_EntradaMañana, ""),
                IsNull(horario.M_SalidaMañana, ""),
                IsNull(horario.M_ToleranciaEntrada, "") == "-1" ? "" : horario.M_ToleranciaEntrada,
                IsNull(horario.M_EntradaTarde, ""),
                IsNull(horario.M_SalidaTarde, ""),
                IsNull(horario.M_ToleranciaSalida, "") == "-1" ? "" : horario.M_ToleranciaSalida
                );

            this.dgHorario.Rows.Add(
                "Miércoles",
                IsNull(horario.X_EntradaMañana, ""),
                IsNull(horario.X_SalidaMañana, ""),
                IsNull(horario.X_ToleranciaEntrada, "") == "-1" ? "" : horario.X_ToleranciaEntrada,
                IsNull(horario.X_EntradaTarde, ""),
                IsNull(horario.X_SalidaTarde, ""),
                IsNull(horario.X_ToleranciaSalida, "") == "-1" ? "" : horario.X_ToleranciaSalida
                );

            this.dgHorario.Rows.Add(
                "Jueves",
                IsNull(horario.J_EntradaMañana, ""),
                IsNull(horario.J_SalidaMañana, ""),
                IsNull(horario.J_ToleranciaEntrada, "") == "-1" ? "" : horario.J_ToleranciaEntrada,
                IsNull(horario.J_EntradaTarde, ""),
                IsNull(horario.J_SalidaTarde, ""),
                IsNull(horario.J_ToleranciaSalida, "") == "-1" ? "" : horario.J_ToleranciaSalida
                );

            this.dgHorario.Rows.Add(
                "Viernes",
                IsNull(horario.V_EntradaMañana, ""),
                IsNull(horario.V_SalidaMañana, ""),
                IsNull(horario.V_ToleranciaEntrada, "") == "-1" ? "" : horario.V_ToleranciaEntrada,
                IsNull(horario.V_EntradaTarde, "") == "-1" ? "" : horario.V_EntradaTarde,
                IsNull(horario.V_SalidaTarde, ""),
                IsNull(horario.V_ToleranciaSalida, "") == "-1" ? "" : horario.V_ToleranciaSalida
                );

            this.dgHorario.Rows.Add(
                "Sábado",
                IsNull(horario.S_EntradaMañana, ""),
                IsNull(horario.S_SalidaMañana, ""),
                IsNull(horario.S_ToleranciaEntrada, "") == "-1" ? "" : horario.S_ToleranciaEntrada,
                IsNull(horario.S_EntradaTarde, ""),
                IsNull(horario.S_SalidaTarde, ""),
                IsNull(horario.S_ToleranciaSalida, "") == "-1" ? "" : horario.S_ToleranciaSalida
                );

            this.dgHorario.Rows.Add(
                "Domingo",
                IsNull(horario.D_EntradaMañana, ""),
                IsNull(horario.D_SalidaMañana, ""),
                IsNull(horario.D_ToleranciaEntrada, "") == "-1" ? "" : horario.D_ToleranciaEntrada,
                IsNull(horario.D_EntradaTarde, ""),
                IsNull(horario.D_SalidaTarde, ""),
                IsNull(horario.D_ToleranciaSalida, "") == "-1" ? "" : horario.D_ToleranciaSalida
                );
        }

        private string IsNull(string expresion, string valorDefecto)
        {
            if (string.IsNullOrWhiteSpace(expresion))
                return valorDefecto;
            else
                return expresion;
        }
        #endregion

        #region Editor Texto
        private void EditBox_Leave(object? sender, EventArgs e)
        {
            DateTime Hora = default;
            int Ta = 0;
            var cell = dgHorario.SelectedCells[0];
            try
            {
                if (cell.ColumnIndex == 3 || cell.ColumnIndex == 6)
                {
                    Ta = int.Parse(((TextBox)sender).Text, CultureInfo.InvariantCulture);
                    dgHorario.Rows[cell.RowIndex].Cells[cell.ColumnIndex].Value = Ta.ToString();
                }
                else
                {
                    // var cell = dgHorario.SelectedCells[0];
                    Hora = DateTime.ParseExact(((TextBox)sender).Text, "HHmm", CultureInfo.InvariantCulture);
                    dgHorario.Rows[cell.RowIndex].Cells[cell.ColumnIndex].Value = Hora.ToString("HH:mm");
                }
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
                dgHorario.Rows[cell.RowIndex].Cells[cell.ColumnIndex].Value = " ";
                ActualizaRegistro(cell.RowIndex, cell.ColumnIndex, cell.Value.ToString());

                if (this.Recalcular is not null)
                    this.Recalcular(this, null);
            }
        }

        private void dgHorario_KeyPress(object sender, KeyPressEventArgs e)
        {

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
