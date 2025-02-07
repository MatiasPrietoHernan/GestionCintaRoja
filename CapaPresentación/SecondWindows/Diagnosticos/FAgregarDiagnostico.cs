using CapaLogica.Interfaces;
using CapaPresentación.DTO;
using CapaPresentación.Factories;
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
using Diagnosticos1 = CapaDatos.Models.Diagnosticos;

namespace CapaPresentación.SecondWindows.Diagnosticos
{
    public partial class FAgregarDiagnostico : Form
    {
        private readonly IDiagnosticosServices diagnosticosServices;
        private readonly Diagnosticos1 diagnosticosEditar;
        public FAgregarDiagnostico(IDiagnosticosServices _diganosticosServices, Diagnosticos1 diagnosticosEditar = null)
        {
            InitializeComponent();
            diagnosticosServices = _diganosticosServices;
            this.diagnosticosEditar = diagnosticosEditar;
            CargarDatosDiagnosticos();
        }

        private void CargarDatosDiagnosticos()
        {
            if (diagnosticosEditar != null)
            {
                txtID.Text = diagnosticosEditar.Id.ToString();
                dateDiagnostico.Text = diagnosticosEditar.FechaDiagnostico.ToString();
                txtDescripcion.Text = diagnosticosEditar.Descripcion;
                txtID.Enabled = false;
                btnSeleccionar.Enabled = false;
                btnGuardar.Text = "Actualizar";
            }
            else
            {
                txtID.Enabled = true;
                btnSeleccionar.Enabled = true;
                btnGuardar.Text = "Guardar";
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            using (var scope = Program.ServiceProvider.CreateScope()) 
            {
                var factory = scope.ServiceProvider.GetRequiredService<GlobalPacientesFactory>();
                var globalPacientes = factory.Crear(ModoFormularioPacientes.Diagnostico);
                globalPacientes.Owner = this;

                globalPacientes.PacienteSeleccionado += (id, idPaciente) =>
                {
                    txtID.Text = id.ToString(); // Mostrar el ID en el textbox
                };

                globalPacientes.ShowDialog();
            }
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidationHelper.AreFieldsNotEmpty(txtID.Text, txtDescripcion.Text))
            {
                MessageBox.Show("Todos los campos deben estar llenos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!ValidationHelper.AreFieldsNumeric(txtID.Text))
            {
                MessageBox.Show("El campo ID debe ser numerico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (diagnosticosEditar == null)
            {
                Diagnosticos1 diagnostico = new Diagnosticos1
                {
                    IdConsulta = int.Parse(txtID.Text),
                    FechaDiagnostico = dateDiagnostico.Value.Date,
                    Descripcion = txtDescripcion.Text
                };
                await diagnosticosServices.AddDiagnosticoAsync(diagnostico);
                MessageBox.Show("Diagnostico agregado correctamente.", "Diagnostico agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                diagnosticosEditar.FechaDiagnostico = dateDiagnostico.Value.Date;
                diagnosticosEditar.Descripcion = txtDescripcion.Text;
                await diagnosticosServices.UpdateDiagnosticoAsync(diagnosticosEditar);
                MessageBox.Show("Diagnostico actualizado correctamente.", "Diagnostico actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
