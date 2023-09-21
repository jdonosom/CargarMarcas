using BLSGM.infraestructura;
using ToolTip = System.Windows.Forms.ToolTip;

namespace CargarMarcas
{
    public partial class FrmHorario : Form
    {

        private readonly BusinessRequest bl;
        // private readonly Credencial credencial;

        public FrmHorario( BusinessRequest bl)
        {
            InitializeComponent();
            this.bl = bl;

            #region ToolTips
            ToolTip tool = new ToolTip();
            tool.SetToolTip(this.btnTurno, "Configurar Turno");
            #endregion
        }

        private void FrmHorario_Load(object sender, EventArgs e)
        {

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
            if (txtRut.Text.Length == 0)
            {
                return;
            }
            var aRut = txtRut.Text.Split("-");
            int nRut = int.Parse(aRut[0]);
            string Dv = aRut[1];

            var empleado = bl.Funcionario.Get( nRut );

            
            

        }
    }
}
