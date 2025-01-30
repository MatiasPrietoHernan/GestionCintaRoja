using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentación.Helpers;
using Microsoft.VisualBasic.Logging;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CapaPresentación.SecondWindows.Consultas
{
    public partial class FAgregarConsulta : Form
    {
        public FAgregarConsulta()
        {
            InitializeComponent();
        }
        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (!ValidationHelper.AreFieldsNotEmpty(
                txtDNI.Text,
                txtFecha.Text,
                txtMotivo.Text,
                txtObservaciones.Text))
            {
                MessageBox.Show("Todos los campos deben estar llenos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!ValidationHelper.AreFieldsNumeric(txtDNI.Text))
            {
                MessageBox.Show("El campo DNI deben contener solo números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!ValidationHelper.IsValidDNI(txtDNI.Text))
            {
                MessageBox.Show("El campo DNI debe contener 7 o 8 caractermes minimo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!ValidationHelper.IsValidDate(txtFecha.Text))
            {
                MessageBox.Show("La fecha de nacimiento no tiene un formato válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] datos =
            {
                txtDNI.Text, txtFecha.Text, txtMotivo.Text, txtObservaciones.Text
            };

        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
