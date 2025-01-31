using CapaPresentación.Helpers;
using CapaPresentación.SecondWindows.GlobalWidows;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentación.SecondWindows.Tratamientos
{
    public partial class FAgregarTratamiento : Form
    {
        public FAgregarTratamiento()
        {
            InitializeComponent();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            using (var scope = Program.ServiceProvider.CreateScope())
            {
                var globalPacientes = scope.ServiceProvider.GetRequiredService<GlobalPacientes>();
                globalPacientes.Owner = this;
                globalPacientes.ShowDialog();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidationHelper.AreFieldsNotEmpty(txtID.Text, txtTratamiento.Text, txtFechaInicio.Text, txtFechaFin.Text, txtDescripcion.Text))
            {
                MessageBox.Show("Todos los campos deben estar llenos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!ValidationHelper.AreFieldsNumeric(txtID.Text))
            {
                MessageBox.Show("El campo de ID Pciente deben contener solo números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!ValidationHelper.IsValidDate(txtFechaInicio.Text) || !ValidationHelper.IsValidDate(txtFechaFin.Text))
            {
                MessageBox.Show("La fecha no tiene un formato válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
