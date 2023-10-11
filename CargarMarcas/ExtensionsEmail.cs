using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using System.Drawing;

namespace CargarMarcas
{
    public static class ExtensionsEmail
    {


        /// <summary>
        /// Envio de correo diario con las marcaciones del personal de la unidad
        /// </summary>
        /// <param name="emailTo">Correo al que se informa</param>
        /// <param name="emailCCTo">Lista de correos a que se envia copia</param>
        /// <param name="message">El mensaje en formato HTML que se envia</param>
        /// <param name="type">Tipo de correo que se envia, según enumerador EnumTypeMails</param>
        public static void ToEmailAsistenciaPersonal(string emailTo, string emailCCTo, string message, EnumTypeMails type)
        {

            if (!RegexUtilities.IsValidEmail(emailTo))
                return;

            // Parte 1
            //
            MailMessage msg = new MailMessage();

            msg.From = new MailAddress("Sistema Gestión de Marcaciones (SGM) <sinergyalertas@gmail.com>");
            msg.Sender = new MailAddress("Sistema Gestión de Marcaciones (SGM) <sinergyalertas@gmail.com>");

            // Prepara la lista de distribucion como CCO
            if (!string.IsNullOrEmpty(emailCCTo))
            {
                string[] aMails = emailCCTo.Split(";");

                MailAddressCollection addrColl = new MailAddressCollection();
                foreach (var email in aMails)
                {
                    if (RegexUtilities.IsValidEmail(email))
                        msg.Bcc.Add(email);
                }
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

        /// <summary>
        /// Envio de ticket de marcación al correo empleado
        /// </summary>
        /// <param name="emails">Email al que se envia el ticket con el registro de marcación</param>
        public static void ToMailTicket(Models.Funcionario funcionario, Models.RegistroMarca registro)
        {

            if (!RegexUtilities.IsValidEmail(funcionario.Email.Trim()))
                return;

            //  Preparar el envio
            //
            MailMessage msg = new MailMessage();

            msg.From = new MailAddress("Sistema Gestión de Marcaciones (SGM) <sinergyalertas@gmail.com>");
            msg.Sender = new MailAddress("Sistema Gestión de Marcaciones (SGM) <sinergyalertas@gmail.com>");

            //
            //
#if DEBUG
            msg.To.Add("jpdonosom@gmail.com");
#else
            msg.To.Add(funcionario.Email);
#endif
            msg.IsBodyHtml = true;
            msg.Subject = "Registro de marcas personales";

            msg.Body = $"Estimada(o) {funcionario.Nombres}, <br>" +
                       "El sistema SGM informa que su marcación fue registrada y se le envia una copia: <br>";

            var message = CrearDetalleHtmlTicket(funcionario, registro);

            msg.Body += string.Format("<p>{0}</p>", message);
            msg.Body += "<br>";
            msg.Body += "Atentamente,<br>";
            msg.Body += "Departamento Personal de Salud<br>";

            Enviar(msg);

        }

        private static void Enviar(MailMessage msg)
        {
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


        public enum EnumTypeMails
        {
            ERROR,
            WARNING,
            INFO
        }


        private static string CrearDetalleHtmlTicket(Models.Funcionario f, Models.RegistroMarca r)
        {

            string txtCuerpo = "<style>table{border-width:1px;border-style:solid;border-color:#000000; }</style> " +
                               "<table style='border: 1px #000000 solid; width: 100% ' cellpadding='0' cellspacing='1' align='center' border='1'>";

            txtCuerpo += "<tbody>";

            txtCuerpo += "<tr>";
            txtCuerpo += $"<td>Nombre empresa</td><td>Ilustre Municipalidad de la Granja</td>";
            txtCuerpo += "</tr>";
            txtCuerpo += "<tr>";
            txtCuerpo += $"<td>Rut Empresa   </td><td>69.072.400-6</td>";
            txtCuerpo += "</tr>";
            txtCuerpo += "<tr>";
            txtCuerpo += $"<td>Dirección     </td><td>Av. Americo Vespucio 2 - La Granja. Region Metropolitana</td>";
            txtCuerpo += "</tr>";
            txtCuerpo += "<tr>";
            txtCuerpo += $"<td>Empleado      </td><td>{f.NombreCompleto}</td>";
            txtCuerpo += "</tr>";
            txtCuerpo += "<tr>";
            txtCuerpo += $"<td>Rut Empleado  </td><td>{f.Rut}</td>";
            txtCuerpo += "</tr>";
            txtCuerpo += "<tr>";
            txtCuerpo += $"<td>Fecha         </td><td>{r.Fecha.ToString("dd/MM/yyyy")}</td>";
            txtCuerpo += "</tr>";
            txtCuerpo += "<tr>";
            txtCuerpo += $"<td>Hora          </td><td>{r.Hora}</td>";
            txtCuerpo += "</tr>";
            txtCuerpo += "<tr>";
            txtCuerpo += $"<td>Rejoj         </td><td>{r.Serie}</td>";
            txtCuerpo += "</tr>";
            txtCuerpo += "<tr>";
            txtCuerpo += $"<td>Tipo Marca    </td><td>{(r.TipoMarca == 1 ? "Entrada" : "Salida")}</td>";
            txtCuerpo += "</tr>";

            // txtCuerpo += linea;
            Console.WriteLine(txtCuerpo);

            txtCuerpo += "</tbody>";
            txtCuerpo += "</table>";

            return txtCuerpo;
        }

    }
}
