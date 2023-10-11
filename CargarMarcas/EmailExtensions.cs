using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CargarMarcas
{
    public static class EmailExtensions
    {


        public static void ToEmailAsistenciaPersonal (string emailTo, string emailCCTo, string message, EnumTypeMails type)
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

        public static void ToMailTicket (string[] emails)
        {
            foreach (string email in emails)
            {

            }
        }


        public enum EnumTypeMails
        {
            ERROR,
            WARNING,
            INFO
        }
    }
}
