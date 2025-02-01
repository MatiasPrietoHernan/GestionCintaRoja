using CapaLogica.Interfaces;
using CapaPresentación.DTO;
using CapaPresentación.Factories;
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

namespace CapaPresentación.SecondWindows
{
    public partial class FHistorialClinico : Form
    {
        private int idPaciente;
        private readonly IPacientesServices pacientesServices;
        private readonly IConsultasServices consultasServices;
        private readonly IPagosServices pagosServices;
        private readonly IDiagnosticosServices diagnosticosServices;
        private readonly ITratamientosServices tratamientosServices;
        private readonly IHistorialServices historialServices;

        public FHistorialClinico(IPacientesServices pacientesServices, IConsultasServices consultasServices, IPagosServices pagosServices, IDiagnosticosServices diagnosticosServices, ITratamientosServices tratamientosServices, IHistorialServices historialServices)
        {
            InitializeComponent();
            this.pacientesServices = pacientesServices;
            this.consultasServices = consultasServices;
            this.pagosServices = pagosServices;
            this.diagnosticosServices = diagnosticosServices;
            this.tratamientosServices = tratamientosServices;
            this.historialServices = historialServices;
        }
        private void pictureBox1_Click_1(object sender, EventArgs e)
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

                globalPacientes.PacienteSeleccionado += async (id) =>
                {
                    txtID.Text = id.ToString(); // Mostrar el ID en el textbox
                    await GetDatosPacientes(id);
                    await GetConsultas(id);
                    await GetDiagnosticos(id);
                    await GetTratamientos(id);
                    await GetPagos(id);
                };

                globalPacientes.ShowDialog();
            }
        }

        private async Task GetDatosPacientes(int id)
        {
            try
            {
                var datos = await pacientesServices.GetPacienteAsync(id);
                txtNombre.Text = datos.Nombre;
                txtApellido.Text = datos.Apellido;
                txtEdad.Text = datos.Edad.ToString();
                txtTelefono.Text = datos.Telefono;
                txtDireccion.Text = datos.Direccion;
                txtEmail.Text = datos.Email;
                txtTipoSangre.Text = datos.TipoSangre;
                txtFechaNacimiento.Text = datos.FechaNacimiento.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async Task GetConsultas(int id)
        {
            try
            {
                var datos = await consultasServices.GetConsultasPacienteAsync(id);
                var pacienteConsultas = datos.Select(pc => new
                {
                    pc.Paciente.Nombre,
                    pc.Paciente.Apellido,
                    pc.Paciente.DNI,
                    pc.Fecha,
                    pc.Motivo
                }).ToList();
                if (pacienteConsultas.Count == 0)
                {
                    MessageBox.Show("El paciente no tiene consultas registradas.", "Sin consultas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                dataGridConsultas.DataSource = pacienteConsultas;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async Task GetDiagnosticos(int id)
        {
            try
            {
                var datos = await diagnosticosServices.GetDiagnosticosPacienteAsync(id);
                var pacienteDiagnosticos = datos.Select(pd => new
                {
                    pd.IdConsulta,
                    pd.FechaDiagnostico,
                    pd.Descripcion
                }).ToList();
                if (pacienteDiagnosticos.Count == 0)
                {
                    MessageBox.Show("El paciente no tiene diagnosticos registrados.", "Sin diagnosticos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                dataGridDiagnosticos.DataSource = pacienteDiagnosticos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async Task GetTratamientos(int id)
        {
            try
            {
                var datos = await tratamientosServices.GetTratamientosPacientesAsync(id);
                var pacienteTratamientos = datos.Select(pt => new
                {
                    pt.Id,
                    pt.NombreTratamiento,
                    pt.FechaInicio,
                    pt.FechaFin,
                    pt.Detalles
                }).ToList();
                if(pacienteTratamientos.Count == 0)
                {
                    MessageBox.Show("El paciente no tiene tratamientos registrados.", "Sin tratamientos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                dataGridTratamientos.DataSource = pacienteTratamientos;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async Task GetPagos(int id)
        {
            try
            {
                var datos = await pagosServices.GetPagosPacientesAsync(id);
                var pacientePagos = datos.Select(pp => new
                {
                    pp.Id,
                    pp.FechaPago,
                    pp.Monto,
                    pp.MetodoPago,
                }).ToList();
                if(pacientePagos.Count == 0)
                {
                    MessageBox.Show("El paciente no tiene pagos registrados.", "Sin pagos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                dataGridPagos.DataSource = pacientePagos;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
