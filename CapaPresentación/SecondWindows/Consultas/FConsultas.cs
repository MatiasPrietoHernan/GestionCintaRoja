using CapaPresentación.Helpers;
using CapaPresentación.SecondWindows.Pacientes;
using CapaPresentación.SecondWindows.Consultas;
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
using CapaLogica.Interfaces;
using CapaLogica.Servicios;
using Consulta1 = CapaDatos.Models.Consultas;

namespace CapaPresentación.SecondWindows
{
    public partial class FConsultas : Form
    {
        private readonly IConsultasServices consultasServices;
        public FConsultas(IConsultasServices _consultasServices)
        {
            InitializeComponent();
            AggStyles.ApplyPlaceholder(txtBuscarConsulta, "Ingrese Nombre o Apellido");
            consultasServices = _consultasServices;
        }
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void FConsultas_Load(object sender, EventArgs e)
        {
            await GetConsultasAsync();
        }

        private void btnAgregarConsulta_Click(object sender, EventArgs e)
        {
            using (var scope = Program.ServiceProvider.CreateScope())
            {
                var formAgregar = scope.ServiceProvider.GetRequiredService<FAgregarConsulta>();
                formAgregar.Owner = this;
                formAgregar.FormClosed += async (s, args) => await GetConsultasAsync();
                formAgregar.ShowDialog();
            }
        }

        private async void btnEditarConsulta_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.Index < 0)
            {
                MessageBox.Show("Por favor, selecciona una consulta para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int idConsulta = (int)dataGridView1.CurrentRow.Cells[0].Value;
            Consulta1 consulta = await consultasServices.GetConsultaAsync(idConsulta);

            using (var scope = Program.ServiceProvider.CreateScope())
            {
                FAgregarConsulta fAgregarConsulta = new FAgregarConsulta(consultasServices, consulta);
                fAgregarConsulta.Owner = this;  // Pasamos la consulta para editar
                fAgregarConsulta.FormClosed += async (s, args) => await GetConsultasAsync(); // Recargamos las consultas después de editar
                fAgregarConsulta.ShowDialog();
            }
        }

        private async Task GetConsultasAsync()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                var datos = await consultasServices.GetConsultasWithRealtiosnAsync();
                var consultas = datos.Select(c => new
                {
                    c.Id,
                    c.Paciente.Nombre,
                    c.Paciente.Apellido,
                    c.Fecha,
                    c.Motivo,
                    c.Observaciones
                }).ToList();

                dataGridView1.DataSource = consultas;
                dataGridView1.Columns["Id"].Visible = false;
                dataGridView1.Columns["Motivo"].Width = 150;
                dataGridView1.Columns["Observaciones"].Width = 230;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private async void btnEliminarConsulta_Click(object sender, EventArgs e)
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
                    await consultasServices.DeleteConsultaAsync((int)dataGridView1.CurrentRow.Cells[0].Value);
                    await GetConsultasAsync();
                    MessageBox.Show("Fila eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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
                string term = txtBuscarConsulta.Text;
                if (string.IsNullOrWhiteSpace(term))
                {
                    MessageBox.Show("Por favor, ingrese un termino para buscar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var datos = await consultasServices.SearchByTerm(term.ToLower());
                var consultas = datos.Select(c => new
                {
                    c.Id,
                    c.Paciente.Nombre,
                    c.Paciente.Apellido,
                    c.Fecha,
                    c.Motivo,
                    c.Observaciones
                }).ToList();

                dataGridView1.DataSource = consultas;
                dataGridView1.Columns["Id"].Visible = false;
                dataGridView1.Columns["Motivo"].Width = 150;
                dataGridView1.Columns["Observaciones"].Width = 230;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            await GetConsultasAsync();
        }

        private void txtBuscarConsulta_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnBuscarPaciente.PerformClick();
            }
            else if(e.KeyCode == Keys.Escape)
            {
                txtBuscarConsulta.Text = "";
                btnActualizar.PerformClick();
            }
        }
    }
}
