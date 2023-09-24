using BLSGM.infraestructura;
using Models;

namespace CargarMarcas
{
    public partial class FrmBusquedaEmpleados : Form
    {
        private readonly BusinessRequest bl;

        private int? idbusqueda = null;
        private const int cGrip = 16;      // Grip size
        private const int cCaption = 32;   // Caption bar height;

        #region Propiedades
        public string RutAux;
        public string DvSeleccionado;

        public bool lExcluidos = false;
        public string sIdExcluidos = null;
        public int IdListaPrecio;
        #endregion

        #region Formulario
        public FrmBusquedaEmpleados(
            BusinessRequest bl
            )
        {
            InitializeComponent();
            txtCliente.Focus();

            this.bl = bl;
        }

        private void frmBusquedaClientes_Load(object sender, EventArgs e)
        {
            lstClientes.View = View.Details;
            lstClientes.Items.Clear();
            txtCliente.Focus();
        }
        #endregion

        #region Metodos formulario
        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            if (txtCliente.Text.Length > 2)
            {
                lstClientes.Items.Clear();
                var funcionarios =
                    bl.Funcionario.GetAll();

                var nombre = ((TextBox)sender).Text;

                lstClientes.View = View.Details;
                lstClientes.Items.Clear();

                List<Funcionario> lst =
                    bl.Funcionario.GetByNombre(nombre);

                //
                //  Cargar empleados
                foreach (var o in lst)
                {
                    ListViewItem item = new ListViewItem(o.Rut);
                    item.SubItems.Add($"{o.ApellidoPaterno} {o.ApellidoMaterno} {o.Nombres}");
                    lstClientes.Items.Add(item);
                }
            }
        }

        private void txtCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (lstClientes.Items.Count > 0)
            {
                switch (e.KeyCode)
                {
                    case Keys.Down:
                        lstClientes.Items[0].Selected = true;
                        lstClientes.Focus();
                        break;
                    case Keys.Enter:
                        lstClientes.Items[0].Selected = true;
                        AsignaDatos();
                        break;
                    default:
                        break;
                }
            }
        }

        #endregion

        #region Botones

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            AsignaDatos();
        }

        private void lstClientes_DoubleClick(object sender, EventArgs e)
        {
            AsignaDatos();
        }
        #endregion

        #region Otros metodos

        private void AsignaDatos()
        {
            if (lstClientes.SelectedItems.Count == 1)
            {
                RutAux = lstClientes.SelectedItems[0].Text;

                this.DialogResult = DialogResult.OK;
            }
            else if (lstClientes.Items.Count > 0)
            {
                RutAux = lstClientes.Items[0].Text;
                this.DialogResult = DialogResult.OK;
            }

        }

        private decimal ComprobarRutNombre()
        {
            string dato = "";
            decimal number = -1;
            if (txtCliente.Text.Trim().Length > 0)
            {
                dato = txtCliente.Text.Replace(".", "").Replace("-", "");
                dato = dato.Substring(0, dato.Length - 2);
                Decimal.TryParse(dato, out number);
                return number;
            }

            return -1;
        }

        #endregion

    }
}
