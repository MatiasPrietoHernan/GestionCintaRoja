using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica.Interfaces;
using CapaPresentación.DTO;
using CapaPresentación.SecondWindows.Consultas;
using Microsoft.Extensions.DependencyInjection;

namespace CapaPresentación.SecondWindows.GlobalWidows
{
    public partial class GlobalPacientes : Form
    {
        private readonly IPacientesServices pacientesServices;
        private readonly IConsultasServices consultasServices;
        public event Action<int, int?> PacienteSeleccionado;

        private ModoFormularioPacientes modo;
        public GlobalPacientes(IPacientesServices _pacientesServices, IConsultasServices consultasServices)
        {
            InitializeComponent();
            pacientesServices = _pacientesServices;
            this.consultasServices = consultasServices;
        }

        public void SetModo(ModoFormularioPacientes _modo)
        {
            modo = _modo;
        }

        private async void GlobalPacientes_Load(object sender, EventArgs e)
        {
            if(modo == ModoFormularioPacientes.Consulta)
            {
                ConfigurarListViewParaConsulta();
                await GetPacientesAsync();
            }
            else if(modo == ModoFormularioPacientes.Diagnostico)
            {
                ConfigurarListViewParaDiagnostico();
                await GetConsultasAsync();
            }

        }
        private void ConfigurarListViewParaConsulta()
        {
            listView1.View = View.Details; // Modo tabla
            listView1.FullRowSelect = true; // Selección de toda la fila
            listView1.GridLines = true;
            listView1.Columns.Add("ID", 100);
            listView1.Columns.Add("DNI", 150);
            listView1.Columns.Add("Nombre", 150);
            listView1.Columns.Add("Apellido", 150);
        }

        private void ConfigurarListViewParaDiagnostico()
        {
            listView1.View = View.Details; // Modo tabla
            listView1.FullRowSelect = true; // Selección de toda la fila
            listView1.GridLines = true;
            listView1.Columns.Add("ID Consulta", 100);
            listView1.Columns.Add("DNI", 150);
            listView1.Columns.Add("Nombre", 150);
            listView1.Columns.Add("Apellido", 150);
            listView1.Columns.Add("Fecha de visita", 150);
            listView1.Columns.Add("Motivo", 150);
            
        }

        private void CargarPacientes(List<PacientesDTO> pacientes)
        {
            listView1.Items.Clear();
            foreach (var paciente in pacientes)
            {
                ListViewItem item = new ListViewItem(paciente.Id.ToString()); // Primera columna (ID)
                item.SubItems.Add(paciente.DNI.ToString()); // Segunda columna (DNI)
                item.SubItems.Add(paciente.Nombre); // Tercera columna (Nombre)
                item.SubItems.Add(paciente.Apellido); // Cuarta columna (Apellido)

                listView1.Items.Add(item);
            }
        }

        private void CargarConsultas(List<ConsultasDTO> consultas)
        {
            listView1.Items.Clear();
            foreach (var consulta in consultas)
            {
                ListViewItem item = new ListViewItem(consulta.Id.ToString()); // Primera columna (ID)
                item.SubItems.Add(consulta.DNI.ToString()); // Segunda columna (DNI)
                item.SubItems.Add(consulta.Nombre); // Tercera columna (Nombre)
                item.SubItems.Add(consulta.Apellido); // Cuarta columna (Apellido)
                item.SubItems.Add(consulta.Fecha); // Quinta columna (Fecha)
                item.SubItems.Add(consulta.Motivo); // Sexta columna (Motivo)

                item.Tag = consulta.IdPaciente;
                listView1.Items.Add(item);
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var item = listView1.SelectedItems[0];

                if (modo == ModoFormularioPacientes.Consulta)
                {
                    // En este modo, el listView muestra pacientes.
                    int idPaciente = int.Parse(item.Text); // Primera columna es el idPaciente
                                                           // Como no hay consulta, mandamos null para el idConsulta.
                    PacienteSeleccionado?.Invoke(idPaciente, null);
                }
                else if (modo == ModoFormularioPacientes.Diagnostico)
                {
                    // En este modo, el listView muestra consultas.
                    // La primera columna es el idConsulta.
                    int idConsulta = int.Parse(item.Text);
                    // Recuperamos el idPaciente del Tag.
                    int idPaciente = int.Parse(item.Tag.ToString());
                    PacienteSeleccionado?.Invoke(idPaciente, idConsulta);
                }
                this.Close();
            }
        }


        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string term = txtBuscador.Text;
                if (string.IsNullOrWhiteSpace(term))
                {
                    MessageBox.Show("Ingrese un término de búsqueda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (modo == ModoFormularioPacientes.Consulta)
                {
                    var datos = await pacientesServices.SearchPaciente(term.ToLower());
                    if (!datos.Any())
                    {
                        MessageBox.Show("No se encontraron pacientes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    CargarPacientes(datos.Select(p => new PacientesDTO
                    {
                        Id = p.Id,
                        DNI = p.DNI,
                        Nombre = p.Nombre,
                        Apellido = p.Apellido
                    }).ToList());
                }
                else if (modo == ModoFormularioPacientes.Diagnostico)
                {
                    var datos = await consultasServices.SearchByTerm(term.ToLower());
                    if (!datos.Any())
                    {
                        MessageBox.Show("No se encontraron consultas para este paciente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    CargarConsultas(datos.Select(c => new ConsultasDTO
                    {
                        Id = c.Id,
                        DNI = c.Paciente.DNI,
                        Nombre = c.Paciente.Nombre,
                        Apellido = c.Paciente.Apellido,
                        Fecha = c.Fecha,
                        Motivo = c.Motivo
                    }).ToList());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task GetPacientesAsync()
        {
            try
            {
                var datos = await pacientesServices.GetPacientesAsync();

                var pacientes = datos.Select(p => new PacientesDTO
                {
                    Id = p.Id,
                    DNI = p.DNI,
                    Nombre = p.Nombre,
                    Apellido = p.Apellido
                }).ToList();

                CargarPacientes(pacientes);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task GetConsultasAsync()
        {
            try
            {
                var datos = await consultasServices.GetConsultasWithRealtiosnAsync();

                var consultas = datos.Select(c => new ConsultasDTO
                {
                    Id = c.Id,
                    IdPaciente = c.idPaciente,
                    DNI = c.Paciente.DNI,
                    Nombre = c.Paciente.Nombre,
                    Apellido = c.Paciente.Apellido,
                    Fecha = c.Fecha,
                    Motivo = c.Motivo
                }).ToList();

                CargarConsultas(consultas);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            await GetPacientesAsync();
        }

        private void txtBuscador_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnBuscar.PerformClick();
            }
            else if(e.KeyCode == Keys.Escape)
            {
                txtBuscador.Text = "";
                btnActualizar.PerformClick();
            }
        }
    }
}
