using BLSGM.infraestructura;

namespace CargarMarcas
{
    public partial class FrmEnvioTicket : Form
    {
        private readonly BusinessRequest bl;
        private readonly IFormFactory forms;

        public FrmEnvioTicket(
              BusinessRequest bl
            , IFormFactory forms

          )
        {
            InitializeComponent();

            //
            //
            this.bl = bl;
            this.forms = forms;

            dtpFecha.MaxDate = DateTime.Now;
            CargarDatos();

        }

        private void CargarDatos()
        {

            var unidades =
                bl.Unidad.GetAll();

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
            var registros = bl.Registro.GetByFecha(
                dtpFecha.Value.ToString("yyyyMMdd"), (int)cmbDepartamento.SelectedValue
                );

            foreach( Models.RegistroMarca registro in registros )
            {

                Console.WriteLine( registro.ToString() );
            }

        }
    }
}
