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
        public event Action<int> PacienteSeleccionado;
        public GlobalPacientes(IPacientesServices _pacientesServices)
        {
            InitializeComponent();
            pacientesServices = _pacientesServices;

        }

        private async void GlobalPacientes_Load(object sender, EventArgs e)
        {
            ConfigurarListView();
            await GetPacientesAsync();

        }
        private void ConfigurarListView()
        {
            listView1.View = View.Details; // Modo tabla
            listView1.FullRowSelect = true; // Selección de toda la fila
            listView1.GridLines = true;
            listView1.Columns.Add("ID", 100);
            listView1.Columns.Add("DNI", 150);
            listView1.Columns.Add("Nombre", 150);
            listView1.Columns.Add("Apellido", 150);
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

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var item = listView1.SelectedItems[0];
                int idPaciente = int.Parse(item.Text); // El ID está en la primera columna

                // Llamar al evento para pasar el ID
                PacienteSeleccionado?.Invoke(idPaciente);

                this.Close();
            }
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string term = txtBuscador.Text;
                if (term == "")
                {
                    MessageBox.Show("Ingrese un término de búsqueda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var datos = await pacientesServices.SearchPaciente(term);
                if (datos.Count() == 0)
                {
                    MessageBox.Show("No se encontraron resultados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    CargarPacientes(datos.Select(p => new PacientesDTO
                    {
                        Id = p.Id,
                        DNI = p.DNI,
                        Nombre = p.Nombre,
                        Apellido = p.Apellido
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
