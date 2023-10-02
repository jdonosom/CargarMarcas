using BLSGM.infraestructura;
using System.Windows.Forms;

namespace MantFuncionarios
{
    public partial class FrmFuncionario : Form
    {

        private readonly BusinessRequest bl;
        private readonly IFormFactory forms;


        public FrmFuncionario(
              IFormFactory forms
            , BusinessRequest bl
            )
        {
            InitializeComponent();

            this.forms = forms;
            this.bl = bl;

            InicializaForm();
        }

        private void InicializaForm()
        {
            SetarToolTip();
            picFoto.Location = new Point(737, 12);

            LimpiaFormulario();

        }

        private void LimpiaFormulario()
        {

            txtRut.Text = string.Empty;

        }

        private void InicializaEdicion(bool lflag)
        {

            txtRut.Enabled = !lflag;

            txtNombres.Enabled = lflag;
            txtApePaterno.Enabled = lflag;
            txtApeMaterno.Enabled = lflag;
            txtEmail.Enabled = lflag;
            lsvTipoContratos.Items.Clear();
            lsvTipoContratos.Enabled = lflag;
            lsvCargos.Items.Clear();
            lsvCargos.Enabled = lflag;

        }

        private void btnPhoto_Click(object sender, EventArgs e)
        {

            picFoto.Location = new Point(499, 12);


        }

        private void SetarToolTip()
        {
            ToolTip tool = new ToolTip();
            tool.SetToolTip(btnPhoto, "Ver o seleccionar fotografia");
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

            var empleado = bl.Funcionario.Get(nRut);
            if (empleado is null)
            {
                MessageBox.Show("El rut ingresado no pertenece a un funcionario", "Diálogo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            txtNombres.Text = empleado.Nombres.Trim();
            txtApePaterno.Text = empleado.ApellidoPaterno.Trim();
            txtApeMaterno.Text = empleado.ApellidoMaterno.Trim();
            InicializaEdicion(true);

        }
    }
}