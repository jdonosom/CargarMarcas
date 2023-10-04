using BLSGM.infraestructura;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CargarMarcas
{
    public partial class FrmFuncionarioDispositivo : Form
    {
        private readonly BusinessRequest bl;
        private readonly IFormFactory forms;

        public List<Funcionario> funcionario { get; private set; }

        public FrmFuncionarioDispositivo(
              IFormFactory forms
            , BusinessRequest bl
            )
        {
            InitializeComponent();

            this.bl = bl;
            this.forms = forms;

            CargarDatos();
        }

        private void CargarDatos()
        {
            var employees =
                bl.Funcionario.GetAll();

            funcionario = employees;

            var devices =
                bl.Dispositivos.GetAll();

            lstEmpleado.Items.Clear();
            lstEmpleado.DataSource = employees.OrderBy(x => x.NombreCompleto).ToList();
            lstEmpleado.ValueMember = "IdEmpleado";
            lstEmpleado.DisplayMember = "NombreCompleto";
            lstEmpleado.SelectedIndex = -1;

            lstDispositivo.Items.Clear();
            lstDispositivo.DataSource = devices.OrderBy(x => x.Descripcion).ToList();
            lstDispositivo.ValueMember = "IdDispositivo";
            lstDispositivo.DisplayMember = "Descripcion";
            lstDispositivo.SelectedIndex = -1;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.TextLength == 0)
            {
                lstEmpleado.ValueMember = "IdEmpleado";
                lstEmpleado.DisplayMember = "NombreCompleto";
                lstEmpleado.DataSource = funcionario;
            }


            if (txtNombre.TextLength >= 4)
            {
                var match = funcionario.Where(x => x.NombreCompleto.ToLower().Contains(txtNombre.Text)).ToList();

                // lstEmpleado.Items.Clear();
                lstEmpleado.ValueMember = "IdEmpleado";
                lstEmpleado.DisplayMember = "NombreCompleto";
                lstEmpleado.DataSource = match;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            // Verifica si el dispositivo esta asigando
            var element = lstAsignacion
                .Items
                .Cast<ListViewItem>()
                .Where(x => x.SubItems[2].Text == ((Dispositivos)lstDispositivo.SelectedItem)
                .IdDispositivo
                .ToString()).ToList();

            if (element.Count > 0)
                return;

            // Asignar dispositivo a la lista
            //
            ListViewItem item = new ListViewItem();
            item.Text = lstEmpleado.SelectedValue.ToString();
            item.SubItems.Add(((Dispositivos)lstDispositivo.SelectedItem).Descripcion);
            item.SubItems.Add(((Dispositivos)lstDispositivo.SelectedItem).IdDispositivo.ToString());

            lstAsignacion.Items.Add(item);

        }

        private void lstEmpleado_Click(object sender, EventArgs e)
        {
            if (lstEmpleado.SelectedItem)
        }
    }
}
