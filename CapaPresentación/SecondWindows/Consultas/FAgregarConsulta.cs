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
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualBasic.Logging;
using static System.Runtime.InteropServices.JavaScript.JSType;
using CapaPresentación.SecondWindows.GlobalWidows;
using CapaLogica.Interfaces;
using Consutlas1 = CapaDatos.Models.Consultas;
using CapaPresentación.Factories;
using CapaPresentación.DTO;

namespace CapaPresentación.SecondWindows.Consultas
{
    public partial class FAgregarConsulta : Form
    {
        public int IdPaciente { get; set; }
        private readonly IConsultasServices consultasServices;
        private readonly Consutlas1 ConsultaEditar;
        public FAgregarConsulta(IConsultasServices _consultasServices, Consutlas1 ConsultaEditar = null)
        {
            InitializeComponent();
            consultasServices = _consultasServices;
            this.ConsultaEditar = ConsultaEditar;
            CargarDatosConsultas();
        }

        private void CargarDatosConsultas()
        {
            if (ConsultaEditar != null)
            {
                // Cargamos los datos para edición
                txtDNI.Text = ConsultaEditar.idPaciente.ToString();
                txtFecha.Text = ConsultaEditar.Fecha;
                txtMotivo.Text = ConsultaEditar.Motivo;
                txtObservaciones.Text = ConsultaEditar.Observaciones;

                // Deshabilitamos los controles de paciente en modo edición
                txtDNI.Enabled = false; // No puede editar el DNI
                btnSeleccionar.Enabled = false; // No puede seleccionar otro paciente

                // Cambiamos el texto del botón para reflejar que es una edición
                btnGuardar.Text = "Actualizar";
            }
            else
            {
                // Si estamos agregando una consulta, habilitamos los controles
                txtDNI.Enabled = true;
                btnSeleccionar.Enabled = true;
                btnGuardar.Text = "Guardar";
            }
        }
        private async void btnGuardar_Click_1(object sender, EventArgs e)
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
                MessageBox.Show("El campo de ID Pciente deben contener solo números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!ValidationHelper.IsValidDate(txtFecha.Text))
            {
                MessageBox.Show("La fecha no tiene un formato válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verificación de paciente
            if (ConsultaEditar == null && IdPaciente == 0)
            {
                MessageBox.Show("Debe seleccionar un paciente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Crear consulta, si estamos editando, no hace falta instanciar un nuevo objeto
            Consutlas1 consulta;
            if (ConsultaEditar == null)
            {
                consulta = new Consutlas1
                {
                    idPaciente = IdPaciente,
                    Fecha = txtFecha.Text,
                    Motivo = txtMotivo.Text,
                    Observaciones = txtObservaciones.Text
                };

                // Agregar nueva consulta
                await consultasServices.AddConsultaAsync(consulta);
                MessageBox.Show("Consulta agregada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Si estamos editando, solo actualizamos los datos
                var consultaActualizada = new Consutlas1
                {
                    Id = ConsultaEditar.Id, // Mantener el mismo ID
                    idPaciente = ConsultaEditar.idPaciente,
                    Fecha = txtFecha.Text,
                    Motivo = txtMotivo.Text,
                    Observaciones = txtObservaciones.Text
                };

                await consultasServices.UpdateConsultaAsync(consultaActualizada);
                MessageBox.Show("Consulta actualizada correctamente.");
            }

            this.Close();

        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            using (var scope = Program.ServiceProvider.CreateScope())
            {
                var factory = scope.ServiceProvider.GetRequiredService<GlobalPacientesFactory>();
                var globalPacientes = factory.Crear(ModoFormularioPacientes.Consulta);
                globalPacientes.Owner = this;

                // Suscribirse al evento para recibir el ID del paciente seleccionado
                globalPacientes.PacienteSeleccionado += (id) =>
                {
                    IdPaciente = id;
                    txtDNI.Text = id.ToString(); // Mostrar el ID en el textbox (opcional)
                };

                globalPacientes.ShowDialog();
            }
        }

        private void FAgregarConsulta_Load(object sender, EventArgs e)
        {

        }
    }

}
