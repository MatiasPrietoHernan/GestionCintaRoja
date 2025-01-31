using CapaDatos.Models;
using CapaLogica.Interfaces;
using CapaLogica.Servicios;
using CapaPresentación.SecondWindows.Diagnosticos;
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

namespace CapaPresentación.SecondWindows
{
    public partial class FDiagnosticos : Form
    {
        private readonly IDiagnosticosServices diagnosticosServices;
        public FDiagnosticos(IDiagnosticosServices _diagnosticosServices)
        {
            InitializeComponent();
            diagnosticosServices = _diagnosticosServices;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void FDiagnosticos_Load(object sender, EventArgs e)
        {
            await GetDiagnosticosAsync();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (var scope = Program.ServiceProvider.CreateScope())
            {
                var formAgregar = scope.ServiceProvider.GetRequiredService<FAgregarDiagnostico>();
                formAgregar.Owner = this;
                formAgregar.FormClosed += async (s, args) => await GetDiagnosticosAsync();
                formAgregar.ShowDialog();
            }
        }

        private async void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.Index < 0)
            {
                MessageBox.Show("Por favor, selecciona una consulta para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int idDiagnostico = (int)dataGridView1.CurrentRow.Cells[0].Value;

            Diagnosticos1 diagnostico = await diagnosticosServices.GetDiagnosticoAsync(idDiagnostico);

            using (var scope = Program.ServiceProvider.CreateScope())
            {
                FAgregarDiagnostico formEditar = new FAgregarDiagnostico(diagnosticosServices, diagnostico);
                formEditar.Owner = this;
                formEditar.FormClosed += async (s, args) => await GetDiagnosticosAsync();
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
                    await diagnosticosServices.DeleteDiagnosticoAsync((int)dataGridView1.CurrentRow.Cells[0].Value);
                    await GetDiagnosticosAsync();
                    MessageBox.Show("Fila eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            await GetDiagnosticosAsync();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private async Task GetDiagnosticosAsync()
        {
            try
            {
                var datos = await diagnosticosServices.GetAllRelationsAsync();

                var diagnosticos = datos.Select(d => new
                {
                    d.Id,
                    d.FechaDiagnostico,
                    d.Consulta.Motivo,
                    d.Descripcion,
                }).ToList();

                dataGridView1.DataSource = diagnosticos;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
