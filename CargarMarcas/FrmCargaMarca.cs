using System.Data;
using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CargarMarcas
{
    public partial class FrmCargaMarca : Form
    {
        public FrmCargaMarca()
        {
            InitializeComponent();

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
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);

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
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void PreProcesar(string file)
        {
            // lstArchivos.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);

            int NroRegistros = 0;
            NroRegistros = CuentaNroRegistros(file);

            ListViewItem item = new ListViewItem();

            item.Text = Path.GetFileName(file);
            var nombrearchivo = item.Text.Split('_');
            DateTime fecha;
            if (!nombrearchivo[0].ToLower().Equals("marcas"))
                throw new Exception("Error en nombre de archivo");

            if (!DateTime.TryParseExact($"{nombrearchivo[1].Split('.')[0]}", "yyyyMMdd",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None, out fecha))
                throw new Exception("La fecha del archivo no es valida");

            item.SubItems.Add(NroRegistros.ToString());
            lstArchivos.Items.Add(item);

            lstArchivos.Columns[0].Width = item.Text.Length * 8;

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
            lstArchivos.Items.Clear();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {

        }
    }
}
