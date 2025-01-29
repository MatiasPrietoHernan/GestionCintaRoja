using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using CapaLogica.Interfaces;
using Pacientes1 = CapaDatos.Models.Pacientes;

namespace CapaPresentación.SecondWindows.Pacientes
{
    public partial class FAgregarPaciente : Form
    {
        private readonly IPacientesServices pacientesServices;
        private readonly Pacientes1 pacienteAEditar;
        public FAgregarPaciente(IPacientesServices _pacietesServices, Pacientes1 pacienteAEditar = null)
        {
            pacientesServices = _pacietesServices;
            InitializeComponent();
            comboBoxTipoSangre.Text = "Seleccionar";
            this.pacienteAEditar = pacienteAEditar;
            CargarDatosPaciente();
        }

        private void CargarDatosPaciente()
        {
            if (pacienteAEditar != null)
            {
                txtIdPaciente.Text = pacienteAEditar.Id.ToString();
                txtNombre.Text = pacienteAEditar.Nombre;
                txtApellido.Text = pacienteAEditar.Apellido;
                txtEdad.Text = pacienteAEditar.Edad.ToString();
                txtDNI.Text = pacienteAEditar.DNI.ToString();
                txtDireccion.Text = pacienteAEditar.Direccion;
                txtTelefono.Text = pacienteAEditar.Telefono;
                txtEmail.Text = pacienteAEditar.Email;
                txtFechaNacimiento.Text = pacienteAEditar.FechaNacimiento.ToString("yyyy-MM-dd");
                comboBoxTipoSangre.SelectedItem = pacienteAEditar.TipoSangre;
                btnGuardar.Text = "Actualizar"; // Cambiar el texto del botón
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validar campos vacíos
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtEdad.Text) ||
                string.IsNullOrWhiteSpace(txtDNI.Text) ||
                string.IsNullOrWhiteSpace(txtDireccion.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtFechaNacimiento.Text) ||
                comboBoxTipoSangre.SelectedItem == null)
            {
                MessageBox.Show("Todos los campos deben estar llenos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar que los campos numéricos contengan solo números
            if (!int.TryParse(txtEdad.Text, out _) ||
                !long.TryParse(txtDNI.Text, out _) ||
                !long.TryParse(txtTelefono.Text, out _))
            {
                MessageBox.Show("Los campos Edad, DNI y Teléfono deben contener solo números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar formato de correo electrónico
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("El correo electrónico no tiene un formato válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar formato de fecha
            if (!DateTime.TryParse(txtFechaNacimiento.Text, out _))
            {
                MessageBox.Show("La fecha de nacimiento no tiene un formato válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Si todas las validaciones pasan, guardar los datos
            string[] datos = 
                {
                    txtNombre.Text, txtApellido.Text, txtEdad.Text, txtDNI.Text,
                    txtDireccion.Text, txtTelefono.Text, txtEmail.Text,
                    txtFechaNacimiento.Text, comboBoxTipoSangre.SelectedItem.ToString()
                };

            int idPaciente = string.IsNullOrWhiteSpace(txtIdPaciente.Text) ? 0 : int.Parse(txtIdPaciente.Text);
            if (Owner is FPacientes formPacientes)
            {
                formPacientes.AgregarFila(datos, idPaciente);
            }


            MessageBox.Show("Datos guardados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
