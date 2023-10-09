using BLSGM.infraestructura;
using SGFDataLayer;
using System.Data;
using System.Data.Common;
using System.Globalization;
using System.Reflection;

namespace CargarMarcas
{
    public partial class FrmCargaMarca : Form
    {

        private readonly BusinessRequest Bl;
        private readonly IFormFactory forms;

        private int Id = 0;
        private DateTime? Fecha;
        private string Time = null;
        private int Tipo = -1;
        private string Serie = null;

        public FrmCargaMarca(
              IFormFactory frm
            , BusinessRequest Bl
            )
        {
            InitializeComponent();

            this.forms = frm;
            this.Bl = Bl;

            System.Windows.Forms.ToolTip toolTip = new System.Windows.Forms.ToolTip();

            toolTip.SetToolTip(this.btnLimpiar, "Limpiar archivos");
            toolTip.SetToolTip(this.btnCargar, "Cargar archivos");

            btnCargar.Enabled = false;
        }

        private void FrmCargaMarca_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void FrmCargaMarca_DragDrop(object sender, DragEventArgs e)
        {
            // recuperar los datos del archivo que fue arrastrado
            //
            string[] files = (string[]) e.Data.GetData(DataFormats.FileDrop, false);

            ProcesarArchivos(files);

            // Thread newThread = new Thread(ProcesarArchivos);
            // newThread.Start(files);

        }

        private void ProcesarArchivos( object args )
        {
            string[] files = args as string[];

            files = files.OrderBy(x => x).ToArray();
            foreach (var file in files)
            {
                try
                {
                    // MessageBox.Show(file);
                    //
                    PreProcesar(file);

                }
                catch (Exception ex)
                {
                    using (new CenterWinDialog(this))
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void PreProcesar(string file)
        {
            int NroRegistros = 0;
            NroRegistros = CuentaNroRegistros(file);
            ListViewItem item = new ListViewItem();
            item.Text = Path.GetFileName(file);

            // Validar estructura del archivo
            //
            var nombrearchivo = item.Text.Split('_');

            // Validar el nombre del archivo
            //
            DateTime fecha;
            if (!nombrearchivo[0].ToLower().Equals("marcas"))
                throw new Exception("Error en nombre de archivo");

            // Validar la fecha del archivo
            //
            if (!DateTime.TryParseExact($"{nombrearchivo[1].Split('.')[0]}", "yyyyMMdd",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None, out fecha))
                throw new Exception("La fecha del archivo no es valida");

            // Borrar las marcas de la fecha a cargar
            //
            Bl.Registro.Delete(fecha);

            // Agregar al list View
            //
            item.SubItems.Add(NroRegistros.ToString());
            item.Tag = file;
            lstArchivos.Items.Add(item);
            lstArchivos.Columns[0].Width = item.Text.Length * 8;

            // Habilitar Botos si hay registros para almacenar
            //
            btnCargar.Enabled = lstArchivos.Items.Count > 0 ? true : false;

        }


        private int CuentaNroRegistros(string file)
        {
            string[] lines =
                File.ReadAllLines(file);
            int NroRegistros = lines.Count();
            int nRegistros = 0;
            foreach (var line in lines)
            {
                var data = line.Split(',');
                if (data.Length.Equals(4))
                {
                    try
                    {
                        int.Parse(data[0]);
                        nRegistros++;
                    }
                    catch
                    {
                        continue;
                    }
                }
            }
            return (nRegistros == NroRegistros ? NroRegistros : nRegistros);
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            LimpiarForm();

        }


        private void LimpiarForm()
        {

            progressBar1.Maximum = 100;
            progressBar1.Minimum = 0;
            progressBar1.Value = 0;
            progressBar1.Visible = false;
            lblPorc.Visible = false;
            lblPorc.Text = "";

            txtBuffer.Text = "";
            lstArchivos.Items.Clear();
        }


        private void btnCargar_Click(object sender, EventArgs e)
        {
            //Thread newThread = new Thread(GrabarMarcas);
            //newThread.Start();
            GrabarMarcas();
        }


        private void GrabarMarcas()
        {

            BaseDatos DB = new BaseDatos();

            List<Node> nodes = new List<Node>();
            txtBuffer.Text = "";
            foreach (ListViewItem item in lstArchivos.Items)
            {

                string filecsv = (string)item.Tag;
                string path = Path.GetDirectoryName( filecsv );

                string pathFileFuncionarioInexistente = path + @"\FuncionarioInexistente.txt";
                string pathFileFuncionarioSinHorario = path + @"\FuncionarioSinHorario.txt";


                File.Delete(pathFileFuncionarioInexistente);
                File.Delete(pathFileFuncionarioSinHorario);

                IEnumerable<string> lines =
                    File.ReadAllLines(filecsv);

                var eFechas = FechasCarga(lines);
                foreach (DateTime fecha in eFechas)
                {
                    Bl
                    .Registro
                    .Delete(fecha);
                }


                lblPorc.Visible      = true;
                progressBar1.Visible = true;
                progressBar1.Minimum = 1;
                progressBar1.Maximum = (int)lines.Count();


                var nElement = 0;
                txtBuffer.Text = txtBuffer.Text + $"{Environment.NewLine}Procesando archivo {item.Text}{Environment.NewLine}";
                foreach (string line in lines)
                {
                    
                    //this.progressBar1.Invoke(() =>
                        progressBar1.Value = ++nElement;
                        var porc = Math.Round(((float)nElement / progressBar1.Maximum * 100), 0);

                        lblPorc.Text = $"{porc.ToString()} %";
                        lblPorc.BackColor = Color.Transparent;
                        lblPorc.Refresh();
                        lblPorc.BringToFront();

                    //});

                    // Limpiar Datos
                    //
                    var datos = line.Split(',');
                    try
                    {

                        Id = int.Parse(datos[0]);
                        Fecha = Convert.ToDateTime(datos[1]);
                        Time = Convert.ToDateTime(datos[2]).ToString("HHmm");
                        Tipo = datos[3].Contains("Salida") ? 0 : 1;
                        Serie = "322800121011";

                        if (!ExisteFuncionario(Id))
                        {
                            txtBuffer.Text = txtBuffer.Text + $"Error Id Empleado:{Id}, No existe en la tabla de Funcionarios.{Environment.NewLine}";
                            File.AppendAllText(pathFileFuncionarioInexistente, Id + Environment.NewLine);
                            continue;
                        }

                        var tmpFecha = DateTime.ParseExact($"{((DateTime)Fecha).ToString("yyyyMMdd")} {Time}", "yyyyMMdd HHmm", CultureInfo.InvariantCulture);
                        if (ObtenerHorario(Id, ((DateTime)Fecha).ToString("yyyyMMdd"), tmpFecha.DayOfWeek) is null)
                        {
                            txtBuffer.Text = txtBuffer.Text + $"Error Id Empleado:{Id}, No tiene horario asignado.{Environment.NewLine}";
                            File.AppendAllText(pathFileFuncionarioSinHorario, Id + Environment.NewLine);
                            continue;
                        }
                        txtBuffer.Text = txtBuffer.Text + $"Id : {Id} procesado correctamente!{Environment.NewLine}";

                    }
                    catch
                    {
                        continue;
                    }

                    //  
                    //
                    nodes.Add(new Node
                    {
                        Id = Id,
                        Fecha = ((DateTime)Fecha).ToString("yyyyMMdd"),
                        Hora = Time,
                        TipoMarca = Tipo,
                        Serie = string.Empty,
                    });

                    var Sql = "RegistroMarcaInsProc @IdEmpleado, @Fecha, @Hora, @Tipo, @Serie";

                    DB.Conectar();
                    DB.CrearComando(Sql);
                    DB.AsignarParametroEntero("@IdEmpleado", Id);
                    DB.AsignarParametroCadena("@Fecha", ((DateTime)Fecha).ToString("yyyyMMdd"));
                    DB.AsignarParametroCadena("@Hora", Time);
                    DB.AsignarParametroEntero("@Tipo", Tipo);
                    DB.AsignarParametroCadena("@Serie", Serie);
                    DB.EjecutarComando();

                }
            }
        }


        private List<DateTime> FechasCarga(IEnumerable<string> lines)
        {
            var fechas = new List<DateTime>();

            foreach (string line in lines)
            {
                var datos = line.Split(',');
                try
                {

                    Id = int.Parse(datos[0]);
                    Fecha = Convert.ToDateTime(datos[1]);
                    Time = Convert.ToDateTime(datos[2]).ToString("HHmm");
                    Tipo = datos[3].Contains("Salida") ? 0 : 1;
                    Serie = "322800121011";

                    if (!fechas.Exists(x => x == Fecha))
                        fechas.Add((DateTime)Fecha);

                }
                catch { continue; }

            }
            return fechas;
        }


        private bool ExisteFuncionario(int id)
        {
            bool lRet = false;
            BaseDatos DB = new();

            DB.Conectar();
            DB.CrearComando($"SELECT 1 FROM SGM..Funcionario WHERE IdEmpleado = {id}");
            DbDataReader dr = DB.EjecutarConsulta();

            DataTable dt = new DataTable();
            dt.TableName = MethodBase.GetCurrentMethod().DeclaringType.Name;
            dt.Load(dr);

            DataTableReader reader = new DataTableReader(dt);
            if (reader == null)
            {
                lRet = false;

            }
            if (reader.Read())
            {
                lRet = true;
            }
            return lRet;
        }


        private static HorarioDia ObtenerHorario(int Id, string fecha, DayOfWeek dayOfWeek)
        {
            BaseDatos DB = new BaseDatos();

            var result = GetAbrebiacionDia(dayOfWeek);
            string Dia = result.Item2;
            string AbDia = result.Item1;

            string sql = $"select " +
                $"H.IdHorario, " +
                $"H.Descripcion, " +
                $"H.Desde, " +
                $"H.Hasta, " +
                $"H.{Dia}, " +
                $"H.{AbDia}_EntradaMañana, " +
                $"H.{AbDia}_SalidaMañana, " +
                $"H.{AbDia}_EntradaTarde, " +
                $"H.{AbDia}_SalidaTarde, " +
                $"H.{AbDia}_ToleranciaEntrada, " +
                $"H.{AbDia}_ToleranciaSalida, " +
                $"H.TotalHorasSemanales " +
                $"from SGM..Funcionario F " +
                $"LEFT JOIN SGM..HorarioFuncionario HF ON F.IdEmpleado = HF.IdEmpleado " +
                $"LEFT JOIN SGM..Horario H ON H.IdHorario = HF.IdHorario " +
                $"WHERE F.IdEmpleado = {Id} ";//+
                                              //$"AND '{fecha}' >= Convert(char(8), Desde, 112) AND '{fecha}' <= Convert(char(8), Hasta, 112) " +
                                              //$"AND {Id} = F.IdEmpleado";

            DB.Conectar();
            DB.CrearComando(sql);
            DbDataReader dr = DB.EjecutarConsulta();

            DataTable dt = new DataTable();
            dt.TableName = MethodBase.GetCurrentMethod().DeclaringType.Name;
            dt.Load(dr);

            DataTableReader reader = new DataTableReader(dt);
            if (reader == null)
            {
                return null;
            }
            if (reader.Read())
            {
                try
                {
                    var EMañana = $"{AbDia}_EntradaMañana";
                    var SMañana = $"{AbDia}_SalidaMañana";
                    var ETarde = $"{AbDia}_EntradaTarde";
                    var STarde = $"{AbDia}_SalidaTarde";
                    var TEntrada = $"{AbDia}_ToleranciaEntrada";
                    var TSalida = $"{AbDia}_ToleranciaSalida";
                    //                    var tmpFecha = DateTime.ParseExact( (fecha + " " + ((TimeSpan)reader.GetValue(reader.GetOrdinal(EMañana))).ToString(@"hh\:mm\:ss")), "yyyyMMdd HH:mm:ss",CultureInfo.InvariantCulture);
                    HorarioDia e = new HorarioDia()
                    {
                        DiaSemana = AbDia,
                        Fecha = fecha,
                        HoraEntradaMañana = reader.IsDBNull(reader.GetOrdinal(EMañana)) ? null : DateTime.ParseExact(fecha + " " + reader.GetDateTime(reader.GetOrdinal(EMañana)).ToString(@"HH\:mm\:ss"), "yyyyMMdd HH:mm:ss", CultureInfo.InvariantCulture),
                        HoraSalidaMañana = reader.IsDBNull(reader.GetOrdinal(SMañana)) ? null : DateTime.ParseExact(fecha + " " + reader.GetDateTime(reader.GetOrdinal(SMañana)).ToString(@"HH\:mm\:ss"), "yyyyMMdd HH:mm:ss", CultureInfo.InvariantCulture),
                        HoraEntradaTarde = reader.IsDBNull(reader.GetOrdinal(ETarde)) ? null : DateTime.ParseExact(fecha + " " + reader.GetDateTime(reader.GetOrdinal(ETarde)).ToString(@"HH\:mm\:ss"), "yyyyMMdd HH:mm:ss", CultureInfo.InvariantCulture),
                        HoraSalidaTarde = reader.IsDBNull(reader.GetOrdinal(STarde)) ? null : DateTime.ParseExact(fecha + " " + reader.GetDateTime(reader.GetOrdinal(STarde)).ToString(@"HH\:mm\:ss"), "yyyyMMdd HH:mm:ss", CultureInfo.InvariantCulture),
                        ToleranciaEntradaMañana = reader.IsDBNull(reader.GetOrdinal(TEntrada)) ? 0 : reader.GetInt32(reader.GetOrdinal(TEntrada)),
                        ToleranciaSalidaMañana = reader.IsDBNull(reader.GetOrdinal(TSalida)) ? 0 : reader.GetInt32(reader.GetOrdinal(TSalida)),
                        TotalHorasSemanales = reader.IsDBNull(reader.GetOrdinal($"TotalHorasSemanales")) ? 0 : reader.GetInt32(reader.GetOrdinal($"TotalHorasSemanales")),
                    };
                    return e;
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dayOfWeek"></param>
        /// <returns></returns>
        private static (string, string) GetAbrebiacionDia(DayOfWeek dayOfWeek)
        {
            switch (dayOfWeek)
            {
                case DayOfWeek.Sunday:
                    return ("D", "Domingo");
                    break;
                case DayOfWeek.Monday:
                    return ("L", "Lunes");
                    break;
                case DayOfWeek.Tuesday:
                    return ("M", "Martes");
                    break;
                case DayOfWeek.Wednesday:
                    return ("X", "Miercoles");
                    break;
                case DayOfWeek.Thursday:
                    return ("J", "Jueves");
                    break;
                case DayOfWeek.Friday:
                    return ("V", "Viernes");
                    break;
                case DayOfWeek.Saturday:
                    return ("S", "Sabado");
                    break;
            }
            return (null, null);
        }

        void Limpiar()
        {
            Id = 0;
            Fecha = null;
            Time = null;
            Tipo = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuReports.Visible = true;
            MenuReports.Show(Cursor.Position.X, Cursor.Position.Y);
        }

        private void adignaciónHorariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var frm = forms.Create<FrmHorarioFuncionario>();
            frm.ShowDialog();
        }

        private void mantenciónDeHorariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var frm = forms.Create<FrmMantHorarios>();
            frm.ShowDialog();

        }

        private void mantenciónDeFuncionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var frm = forms.Create<FrmFuncionario>();
            frm.ShowDialog();

        }

        private void asignaciónDispositivosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var frm = forms.Create<FrmFuncionarioDispositivo>();
            frm.ShowDialog();

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

            var frm = forms.Create<FrmFuncionarioSinMarca>();
            frm.ShowDialog();

        }

        private void FrmCargaMarca_Load(object sender, EventArgs e)
        {
            LimpiarForm();
        }

    }
}
