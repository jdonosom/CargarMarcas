using BLSGM.infraestructura;
using BLSGM.interfaces;
using Models;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace CargarMarcas
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


            GetDataTipoCombos();


            LimpiaFormulario();

        }

        private void GetDataTipoCombos()
        {
            GetDataTipoContratos();
            GetDataCargos();
        }

        private void GetDataCargos()
        {
            List<Cargo> cargos =
                bl.Cargo.GetAll();

            //cmbCargos.Items.Clear();
            cmbCargos.ValueMember = "IdCargo";
            cmbCargos.DisplayMember = "Descripcion";
            if (cargos != null)
            {
                cmbCargos.DataSource = cargos;
            }
            cmbCargos.SelectedIndex = -1;
        }

        private void GetDataTipoContratos()
        {
            List<TipoContrato> contratos =
                    bl.TipoContrato.GetAll();

            //cmbContratos.Items.Clear();
            cmbContratos.ValueMember = "IdTipoContrato";
            cmbContratos.DisplayMember = "Descripcion";

            if (contratos != null)
            {
                cmbContratos.DataSource = contratos;
            }
            cmbContratos.SelectedIndex = -1;
        }

        private void LimpiaFormulario()
        {
            InicializaEdicion(false);

            txtRut.Text = string.Empty;
            txtNombres.Text = string.Empty;
            txtApePaterno.Text = string.Empty;
            txtApeMaterno.Text = string.Empty;
            txtEmail.Text = string.Empty;
            picFoto.Image = null;
            txtRut.Focus();

        }

        private void InicializaEdicion(bool lflag)
        {

            txtRut.Enabled = !lflag;

            txtNombres.Enabled = lflag;
            txtApePaterno.Enabled = lflag;
            txtApeMaterno.Enabled = lflag;
            txtEmail.Enabled = lflag;
            //lsvTipoContratos.Items.Clear();
            //lsvTipoContratos.Enabled = lflag;
            //cmbContratos.Items.Clear();
            cmbContratos.Enabled = lflag;
            // cmbCargos.Items.Clear();
            cmbCargos.Enabled = lflag;

        }


        private void btnPhoto_Click(object sender, EventArgs e)
        {
            Form formBackground = new Form();
            try
            {
                // Se crea el OpenFileDialog
                using (OpenFileDialog dialog = new OpenFileDialog())
                {
                    formBackground.FormBorderStyle = FormBorderStyle.None;
                    formBackground.Opacity = 0.5;
                    formBackground.BackColor = Color.Black;
                    formBackground.WindowState = FormWindowState.Maximized;
                    formBackground.ShowInTaskbar = false;
                    formBackground.Show();

                    // Se filtran los archivos
                    dialog.Filter = "Image Files(*.BMP;*.JPG;*.PNG,*.HEIC,*JPEG)|*.BMP;*.JPG;*.PNG;*.HEIC; *JPEG";
                    // Se muestra al usuario esperando una acción
                    DialogResult result = dialog.ShowDialog();
                    // Si seleccionó un archivo (asumiendo que es una imagen lo que seleccionó)
                    // la mostramos en el PictureBox de la inferfaz
                    if (result == DialogResult.OK)
                    {
                        // ResizeImage(GetImage(empleado.Foto), 154, 231);

                        picFoto.BackgroundImage = null;
                        picFoto.Image = ResizeImage(System.Drawing.Image.FromFile(dialog.FileName), 154, 231);

                        // pbCancelCedPost.Location = new Point(picCedPos.Location.X + picCedPos.Size.Width - pbCancelCedPost.Size.Width / 2, picCedPos.Location.Y + picCedPos.Size.Height - pbCancelCedPost.Size.Height / 2);
                        // pbCancelCedPost.Visible = true;
                        picFoto.Location = new Point(737, 12);

                        if (picFoto.Image != null)
                        {
                            btnPhoto.Image = imageList1.Images[1];
                        }
                    }

                    formBackground.Dispose();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error {ex.Message}",
                "Information Icon",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            finally
            {
                formBackground.Dispose();
            }

            // picFoto.Location = new Point(499, 12);


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
            InicializaEdicion(true);

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
            txtEmail.Text = empleado.Email;
            picFoto.Image = GetImage(empleado.Foto);

            btnPhoto.Image = imageList1.Images[0];
            if (picFoto.Image != null)
                btnPhoto.Image = imageList1.Images[1];

            // Mostrar tipo de contrato
            //
            var tipoContrato = 
                bl.FuncionarioTipoContrato.Get(nRut);

            cmbCargos.SelectedIndex = -1;
            cmbContratos.SelectedIndex = -1;
            if (tipoContrato is not null)
            {
                cmbCargos.SelectedValue = tipoContrato.IdCargo;
                cmbContratos.SelectedValue = tipoContrato.TipoContrato;
            }

        }

        /// <summary>
        /// Resize the image to the specified width and height.
        /// </summary>
        /// <param name="image">The image to resize.</param>
        /// <param name="width">The width to resize to.</param>
        /// <param name="height">The height to resize to.</param>
        /// <returns>The resized image.</returns>
        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }


        /// <summary>
        /// Obtener la imagen desde el arreglo de bytea
        /// </summary>
        /// <param name="imagen">Imagen expresada en arreglo de bytes</param>
        /// <returns>Imagen</returns>
        private System.Drawing.Image GetImage(byte[] imagen)
        {
            if (imagen is null)
                return null;

            System.IO.MemoryStream ms = new System.IO.MemoryStream(imagen);
            return System.Drawing.Image.FromStream(ms);

        }

        private void btnPhoto_MouseHover(object sender, EventArgs e)
        {
            mostrarImg(picFoto);
        }

        private void mostrarImg(PictureBox picture)
        {
            if (picture.Image == null)
                return;

            picFoto.Location = new Point(499, 12);

            //picFoto.Image = picture.Image;
            //picFoto.Size = new Size(429, 265);
            //picFoto.Visible = true;
        }

        private void btnPhoto_MouseLeave(object sender, EventArgs e)
        {
            picFoto.Location = new Point(712, 12);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            byte[] image = { };
            if (picFoto.Image != null)
            {
                // Obtener imagen del picturebox
                //
                var ms = new System.IO.MemoryStream(); ;
                picFoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                image = ms.ToArray();
            }
            var funcionario = new Funcionario();

            var aRut = txtRut.Text.Split("-");
            int IdEmpleado = int.Parse(aRut[0]);

            funcionario.IdEmpleado = IdEmpleado;
            funcionario.Rut = txtRut.Text;
            funcionario.Nombres = txtNombres.Text;
            funcionario.ApellidoPaterno = txtApePaterno.Text;
            funcionario.ApellidoMaterno = txtApeMaterno.Text;
            funcionario.Email = txtEmail.Text;
            funcionario.Foto = new byte[] { };
            funcionario.Foto = image;

            bl.Funcionario.Clear();
            bl.Funcionario.Current = funcionario;
            bl.Funcionario.Update();

            var funcionarioTipoContrato = 
                new FuncionarioTipoContrato
                {
                    IdEmpleado = IdEmpleado,
                    TipoContrato = (int)cmbContratos.SelectedValue,
                    IdCargo = (int)cmbCargos.SelectedValue,
                };

            bl.FuncionarioTipoContrato.Current = funcionarioTipoContrato;
            bl.FuncionarioTipoContrato.Update();

            using (new CenterWinDialog(this))
            {
                MessageBox.Show("Datos almacenados correctamente", "Diálogo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            InicializaForm();

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            InicializaForm();
        }

        private void FrmFuncionario_Load(object sender, EventArgs e)
        {

            GetDataTipoCombos();

        }

        private void cmbContratos_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Escape)
            {
                cmbContratos.SelectedIndex = -1;
            }

        }

        private void cmbCargos_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Escape)
            {
                cmbCargos.SelectedIndex = -1;
            }

        }
    }
}