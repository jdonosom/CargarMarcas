using BLSGM.infraestructura;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Web.WebView2.Wpf;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            if (unidades != null)
                unidades = unidades.OrderBy(x => x.Descripcion).ToList();

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
                return;
            }

            //  
            //
            var datosEnvioCorreo = GeneraDetalles(funcionarios);

            //  Enviar correo a las unidades
            //
            foreach (var envio in datosEnvioCorreo)
            {
                EnviarCorreoHtml(envio.correoUnidad, envio.html);
            }

            var correo = datosEnvioCorreo[0].correoUnidad;
            var html = datosEnvioCorreo[0].html;

            WebBrowser web = new WebBrowser();
            web.DocumentText = html;
            web.Location = new Point(0, 0);
            web.Visible = true;
            web.Width = 800;
            web.Height = 600;
            web.Show();



        }

        private void EnviarCorreoHtml(string correoUnidad, string html)
        {
            Console.WriteLine(correoUnidad);
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

                var IdUnidad = funcionario.IdUnidad;
                var CorreoUnidad = funcionario.CorreoUnidad;
                var Unidad = funcionarios.Where(x => x.IdUnidad == IdUnidad).ToList();

                // Crear Lista de funcionarios
                //
                var html = CrearDetalleHtml(Unidad);

                datos.Add(
                    new Envio()
                    {
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
            string txtCuerpo = "<table style='border: 1px #000000 solid; width: 50%' align='center' border='1'>";
            txtCuerpo += "<thead>";
            txtCuerpo += "  <tr>";
            txtCuerpo += "    <th scope='col'>Unidad</th>";
            txtCuerpo += "    <th scope='col'>Id Empleado</th>";
            txtCuerpo += "    <th scope='col'>Rut</th>";
            txtCuerpo += "    <th scope='col'>Nombre</th>";
            txtCuerpo += "    <th scope='col'>Fecha</th>";
            txtCuerpo += "    <th scope='col'>Hora</th>";
            txtCuerpo += "    <th scope='col'>Estado</th>";
            txtCuerpo += "    <th scope='col'>Permiso</th>";
            txtCuerpo += "  </tr>";
            txtCuerpo += "</thead>";

            txtCuerpo += "<tbody>";
            foreach (Models.FuncionarioSinMarca f in unidad)
            {
                var permiso = string.IsNullOrWhiteSpace(f.HoraMarca) ? f.Permiso : (f.Atraso > 0 ? "Atrasado" : "&nbsp");
                // var linea = $"{f.Unidad}\t{f.IdEmpleado}\t{f.NombreCompleto}\t{f.FechaMarca}\t{f.HoraMarca}\t{f.Atraso}\t{permiso}\r\n";
                txtCuerpo += "<tr>";
                txtCuerpo += $"<td>{f.Unidad}</td>";
                txtCuerpo += $"<td>{f.IdEmpleado}</td>";
                txtCuerpo += $"<td>{f.Rut}</td>";
                txtCuerpo += $"<td>{f.NombreCompleto}</td>";
                txtCuerpo += $"<td>{f.FechaMarca}</td>";
                txtCuerpo += $"<td>{f.HoraMarca}</td>";
                txtCuerpo += $"<td>{f.Atraso}</td>";
                txtCuerpo += $"<td>{permiso}</td>";
                txtCuerpo += "</tr>";

                // txtCuerpo += linea;
                Console.WriteLine(txtCuerpo);
            }
            txtCuerpo += "</tbody>";
            txtCuerpo += "</table>";

            return txtCuerpo;
        }
    }
}
