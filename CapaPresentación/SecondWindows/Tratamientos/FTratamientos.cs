using CapaLogica.Interfaces;
using CapaLogica.Servicios;
using CapaPresentación.SecondWindows.GlobalWidows;
using CapaPresentación.SecondWindows.Tratamientos;
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
using Tratamientos1= CapaDatos.Models.Tratamientos;

namespace CapaPresentación.SecondWindows
{
    public partial class FTratamientos : Form
    {
        private readonly ITratamientosServices tratamientosServices;
        public FTratamientos(ITratamientosServices tratamientosServices)
        {
            InitializeComponent();
            this.tratamientosServices = tratamientosServices;
        }
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void FTratamientos_Load(object sender, EventArgs e)
        {
            await GetTratamientosAsync();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (var scope = Program.ServiceProvider.CreateScope())
            {
                var globalPacientes = scope.ServiceProvider.GetRequiredService<FAgregarTratamiento>();
                globalPacientes.Owner = this;
                globalPacientes.FormClosed += async (s, ev) => await GetTratamientosAsync();
                globalPacientes.ShowDialog();
            }
        }

        private async void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.Index < 0)
            {
                MessageBox.Show("Por favor, selecciona una consulta para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int idTratamiento = (int)dataGridView1.CurrentRow.Cells[0].Value;
            Tratamientos1 tratamiento = await tratamientosServices.GetTratamientoAsync(idTratamiento);
            using (var scope = Program.ServiceProvider.CreateScope())
            {
                FAgregarTratamiento formEditar = new FAgregarTratamiento(tratamientosServices, tratamiento);
                formEditar.Owner = this;
                formEditar.FormClosed += async (s, ev) => await GetTratamientosAsync();
                formEditar.ShowDialog();
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.Index < 0)
                {
                    MessageBox.Show("Por favor, selecciona una fila para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult resultado = MessageBox.Show(
               "¿Estás seguro de que deseas eliminar esta fila?",
               "Confirmar eliminación",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Warning
           );

                if (resultado == DialogResult.Yes)
                {
                    // Eliminar la fila seleccionada
                    await tratamientosServices.DeleteTratamientoAsync((int)dataGridView1.CurrentRow.Cells[0].Value);
                    await GetTratamientosAsync();
                    MessageBox.Show("Fila eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task GetTratamientosAsync()
        {
            try
            {
                var datos = await tratamientosServices.GetTratamientosWithRealtiosnAsync();

                var tratamientos = datos.Select(t => new
                {
                    t.Id,
                    t.NombreTratamiento,
                    t.Paciente.Nombre,
                    t.Paciente.Apellido,
                    t.FechaInicio,
                    t.FechaFin,
                    t.Detalles
                }).ToList();

                dataGridView1.DataSource = tratamientos;

                dataGridView1.Columns["Id"].HeaderText = "ID Tratamiento";
                dataGridView1.Columns["NombreTratamiento"].HeaderText = "Nombre del Tratamiento";
                dataGridView1.Columns["Nombre"].HeaderText = "Nombre";
                dataGridView1.Columns["Apellido"].HeaderText = "Apellido";
                dataGridView1.Columns["FechaInicio"].HeaderText = "Fecha de Inicio";
                dataGridView1.Columns["FechaFin"].HeaderText = "Fecha de Fin";
                dataGridView1.Columns["Detalles"].HeaderText = "Detalles";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnBuscarPaciente_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtBuscar.Text))
                {
                    MessageBox.Show("Por favor, ingrese un termino para buscar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var datos = await tratamientosServices.SearchByTermAsync(txtBuscar.Text);
                var tratamientos = datos.Select(t => new
                {
                    t.Id,
                    t.NombreTratamiento,
                    t.Paciente.Nombre,
                    t.Paciente.Apellido,
                    t.FechaInicio,
                    t.FechaFin,
                    t.Detalles
                }).ToList();

                dataGridView1.DataSource = tratamientos;

                dataGridView1.Columns["Id"].HeaderText = "ID Tratamiento";
                dataGridView1.Columns["NombreTratamiento"].HeaderText = "Nombre del Tratamiento";
                dataGridView1.Columns["Nombre"].HeaderText = "Nombre";
                dataGridView1.Columns["Apellido"].HeaderText = "Apellido";
                dataGridView1.Columns["FechaInicio"].HeaderText = "Fecha de Inicio";
                dataGridView1.Columns["FechaFin"].HeaderText = "Fecha de Fin";
                dataGridView1.Columns["Detalles"].HeaderText = "Detalles";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            await GetTratamientosAsync();
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnBuscarPaciente.PerformClick();
            }
            else if(e.KeyCode == Keys.Escape)
            {
                txtBuscar.Clear();
                btnActualizar.PerformClick();
            }
        }
    }
}
