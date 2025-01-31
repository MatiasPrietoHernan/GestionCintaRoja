using CapaPresentación.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentación.SecondWindows.Diagnosticos
{
    public partial class FAgregarDiagnostico : Form
    {
        public FAgregarDiagnostico()
        {
            InitializeComponent();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidationHelper.AreFieldsNotEmpty(txtID.Text, txtFecha.Text, txtDescripcion.Text))
            {
                MessageBox.Show("Todos los campos deben estar llenos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!ValidationHelper.AreFieldsNumeric(txtID.Text))
            {
                MessageBox.Show("El campo ID debe ser numerico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!ValidationHelper.IsValidDate(txtFecha.Text))
            {
                MessageBox.Show("La fecha no tiene un formato válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
