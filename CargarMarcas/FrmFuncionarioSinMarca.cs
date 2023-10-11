using BLSGM.infraestructura;
using Microsoft.Win32.TaskScheduler;
using Models;
using System.Data;
using System.Globalization;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace CargarMarcas
{
    public partial class FrmFuncionarioSinMarca : Form
    {

        private readonly BusinessRequest bl;
        private readonly IFormFactory forms;

        public FrmFuncionarioSinMarca(
            BusinessRequest bl,
            IFormFactory forms
            )
        {
            InitializeComponent();

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

        private void CrearTareaProgramada()
        {

            // Get the service on the local machine
            using (TaskService ts = new TaskService())
            {
                // Create a new task definition and assign properties
                TaskDefinition td = ts.NewTask();
                td.RegistrationInfo.Description = "Does something";

                // Create a trigger that will fire the task at this time every other day
                td.Triggers.Add(new DailyTrigger { DaysInterval = 2 });

                // Create an action that will launch Notepad whenever the trigger fires
                td.Actions.Add(new ExecAction("notepad.exe", "c:\\test.log", null));

                // Register the task in the root folder
                ts.RootFolder.RegisterTaskDefinition(@"Test", td);

                // Remove the task we just created
                ts.RootFolder.DeleteTask("Test");
            }

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            var funcionarios =
                bl.Funcionario.GetEmpleadosSinMarca(
                    dtpFecha.Value.ToString("yyyyMMdd"),
                    (int)cmbDepartamento.SelectedValue
                );

            if (funcionarios is null)
            {
                using (new CenterWinDialog(this))
                {
                    MessageBox.Show("No se encontraron funcionarios con alguna falta", "Diálogo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                Cursor.Current = Cursors.Default;
                return;

            }
            //  Generar detalles por unidad
            //
            var datosEnvioCorreo = GeneraDetalles(funcionarios);


            // Enviar correo
            //
            if (chkEnvioCorreo.Checked)
            {

                //  Enviar correo a las unidades
                //
                foreach (var envio in datosEnvioCorreo)
                {
                    string emailCCTo = envio.correoBcc;

                    ExtensionsEmail.ToEmailAsistenciaPersonal(
                        envio.correoUnidad,
                        emailCCTo,
                        envio.html,
                        ExtensionsEmail.EnumTypeMails.INFO);

                    // EnviarCorreoHtml(envio.correoUnidad, envio.html);
                }

                using (new CenterWinDialog(this))
                {
                    MessageBox.Show("Reporte enviado correctamente!"
                        , "Diálogo"
                        , MessageBoxButtons.OK
                        , MessageBoxIcon.Information);
                }

            }
            Cursor.Current = Cursors.Default;


        }

        private void EnviarCorreoHtml(string correoUnidad, string html)
        {
            string emailCCTo = "pepeluna27@hotmail.com;donosohome@gmail.com";

            // 
            //
            // SendMsg("jpdonosom@gmail.com", emailCCTo, html, EnumTypeMails.INFO);
            SendMsg("jpdonosom@gmail.com", emailCCTo, html, EnumTypeMails.INFO);

        }

        private void SendMsg(string emailTo, string emailCCTo, string message, EnumTypeMails type)
        {

            if (!RegexUtilities.IsValidEmail(emailTo))
                return;

            // Parte 1
            //
            MailMessage msg = new MailMessage();

            msg.From = new MailAddress("Sistema Gestión de Marcaciones (SGM) <sinergyalertas@gmail.com>");
            msg.Sender = new MailAddress("Sistema Gestión de Marcaciones (SGM) <sinergyalertas@gmail.com>");

            // Prepara la lista de distribucion como CCO
            string[] aMails = emailCCTo.Split(";");

            MailAddressCollection addrColl = new MailAddressCollection();
            foreach (var email in aMails)
            {
                if (RegexUtilities.IsValidEmail(email))
                    msg.Bcc.Add(email);
            }
            //
            //

            msg.To.Add(emailTo);
            msg.IsBodyHtml = true;
            msg.Subject = "Registro de marcaciones diarias";

            if (type.Equals(EnumTypeMails.ERROR))
                msg.Body = "<h1>Se ha generado errores:</h1>";
            else if (type.Equals(EnumTypeMails.WARNING))
                msg.Body = "<h1>Se ha generado una alerta:</h1>";
            else if (type.Equals(EnumTypeMails.INFO))
                msg.Body = // "<h3>Sistema de gestión de marcas (SGM)</h3><br>" +
                           // "<h3>Se ha enviado información de las marcaciones de sus subordinados</h3><br>" +
                           "Estimada Jefatura, <br>" +
                    "Por favor, revice el cumplimiento de los empleados y sus horarios laborales, tome las medidas necesarias para que se cumplan.";

            msg.Body += string.Format("<p>{0}</p>", message);
            msg.Body += "<br>";
            msg.Body += "Atentamente,<br>";
            msg.Body += "Departamento Personal de Salud<br>";

            using (SmtpClient client = new SmtpClient())
            {

                client.EnableSsl = true;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("sinergyalertas@gmail.com", "yoqtviccrvakrsnm");
                client.Host = "smtp.gmail.com";
                client.Port = 587;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.Timeout = 30000;

                client.Send(msg);

            }
        }

        private enum EnumTypeMails
        {
            ERROR,
            WARNING,
            INFO
        }




        /// <summary>
        /// Genera los detalles de empleados en html
        /// </summary>
        /// <param name="funcionarios"></param>
        /// <returns></returns>
        private List<Envio> GeneraDetalles(List<FuncionarioSinMarca> funcionarios)
        {
            var datos = new List<Envio>();
            //
            foreach (var funcionario in funcionarios)
            {
                var correosBCC = funcionario.CorreosBCC;
                var IdUnidad = funcionario.IdUnidad;
                var CorreoUnidad = funcionario.CorreoUnidad;
                var Unidad = funcionarios.Where(x => x.IdUnidad == IdUnidad).OrderBy(x => x.NombreCompleto).ToList();

                // Crear Lista de funcionarios
                //
                var html = CrearDetalleHtml(Unidad);

                datos.Add(
                    new Envio()
                    {
                        correoBcc = correosBCC,
                        html = html,
                        correoUnidad = CorreoUnidad
                    });

                // Remover los registros procesados
                //
                funcionarios.RemoveAll(x => Unidad.All(i => i.IdUnidad == x.IdUnidad));

                if (funcionarios.Count == 0)
                    break;

            }
            return datos;

        }

        private string CrearDetalleHtml(List<FuncionarioSinMarca> unidad)
        {

            string txtCuerpo = "<style>table{border-width:1px;border-style:solid;border-color:#000000;}</style> " +

                "<table style='border: 1px #000000 solid; width: 100%' cellpadding = '0' cellspacing = '1' align='center' border='1'> ";
            txtCuerpo += "<thead>";
            txtCuerpo += "  <tr>";
            txtCuerpo += "    <th scope='col' align='left'>Unidad</th>";
            txtCuerpo += "    <th scope='col' align='left'>Id Empleado</th>";
            txtCuerpo += "    <th scope='col' align='left'>Rut</th>";
            txtCuerpo += "    <th scope='col' align='left'>Nombre</th>";
            txtCuerpo += "    <th scope='col' align='left'>Fecha</th>";
            txtCuerpo += "    <th scope='col' align='left'>Hora</th>";
            txtCuerpo += "    <th scope='col' align='left'>Tiempo Atraso</th>";
            txtCuerpo += "    <th scope='col' align='left'>Permiso</th>";
            txtCuerpo += "  </tr>";
            txtCuerpo += "</thead>";

            txtCuerpo += "<tbody>";
            foreach (Models.FuncionarioSinMarca f in unidad)
            {
                var permiso = string.IsNullOrWhiteSpace(f.HoraMarca) ? f.Permiso : (f.Atraso > 0 ? "Atrasado" : "");
                // var linea = $"{f.Unidad}\t{f.IdEmpleado}\t{f.NombreCompleto}\t{f.FechaMarca}\t{f.HoraMarca}\t{f.Atraso}\t{permiso}\r\n";
                txtCuerpo += "<tr>";
                txtCuerpo += $"<td>{f.Unidad}</td>";
                txtCuerpo += $"<td>{f.IdEmpleado}</td>";
                txtCuerpo += $"<td>{f.Rut}</td>";
                txtCuerpo += $"<td>{f.NombreCompleto}</td>";
                txtCuerpo += $"<td>{(IsNull(f.FechaMarca) ? "" : f.FechaMarca.Value.ToString("dd/MM/yyyy"))}</td>";
                txtCuerpo += $"<td>{(IsNull(f.HoraMarca) ? "" : f.HoraMarca)}</td>";
                txtCuerpo += $"<td>{(f.Atraso == 0 ? "" : f.Atraso.ToString() + " Minutos")}</td>";
                txtCuerpo += $"<td>{permiso}</td>";
                txtCuerpo += "</tr>";

                // txtCuerpo += linea;
                Console.WriteLine(txtCuerpo);
            }
            txtCuerpo += "</tbody>";
            txtCuerpo += "</table>";

            return txtCuerpo;
        }

        private bool IsNull(object o)
        {
            return o == null;
        }
    }

    class RegexUtilities
    {
        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Normalize the domain
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                // Examines the domain part of the email and normalizes it.
                string DomainMapper(Match match)
                {
                    // Use IdnMapping class to convert Unicode domain names.
                    var idn = new IdnMapping();

                    // Pull out and process domain name (throws ArgumentException on invalid)
                    string domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                return false;
            }
            catch (ArgumentException e)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }
    }

}
