using CapaDatos.Models;
using CapaLogica.Interfaces;
using CapaPresentación.Helpers;
using CapaPresentación.SecondWindows.Pacientes;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Pacientes1 = CapaDatos.Models.Pacientes;

namespace CapaPresentación.SecondWindows
{
    public partial class FPacientes : Form
    {
        private readonly IPacientesServices pacientesServices;
        public FPacientes(IPacientesServices _pacientesServices)
        {
            InitializeComponent();
            pacientesServices = _pacientesServices;
            AggStyles.ApplyPlaceholder(txtBuscarPaciente, "Ingrese el DNI");


        }
        private void formDesing()
        {
            // Placeholder inicial
            string placeholderText = "Ingrese DNI, Nombre o Apellido";

            // Establecer el texto inicial y el color
            txtBuscarPaciente.Text = placeholderText;
            txtBuscarPaciente.ForeColor = Color.Gray;

            // Evento para cuando el TextBox gana el foco
            txtBuscarPaciente.GotFocus += (sender, e) =>
            {
                if (txtBuscarPaciente.Text == placeholderText)
                {
                    txtBuscarPaciente.Text = ""; // Limpiar el campo
                    txtBuscarPaciente.ForeColor = Color.Black; // Cambiar el color del texto
                }
            };

            // Evento para cuando el TextBox pierde el foco
            txtBuscarPaciente.LostFocus += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtBuscarPaciente.Text))
                {
                    txtBuscarPaciente.Text = placeholderText; // Restaurar el placeholder
                    txtBuscarPaciente.ForeColor = Color.Gray; // Cambiar el color del texto a gris
                }
            };
        }
        private async void FPacientes_Load(object sender, EventArgs e)
        {
            await GetDatosAsync();
        }
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAgregarPaciente_Click(object sender, EventArgs e)
        {
            using (var scope = Program.ServiceProvider.CreateScope())
            {
                var formAgregar = scope.ServiceProvider.GetRequiredService<FAgregarPaciente>();
                formAgregar.Owner = this;
                formAgregar.ShowDialog();
            }
        }
        public async void AgregarFila(string[] datos, int idPaciente = 0)
        {
            // Verificar que los datos coincidan con las columnas del DataGridView
            try
            {
                Pacientes1 paciente;
                if (idPaciente > 0)
                {
                    paciente = await pacientesServices.GetPacienteAsync(idPaciente);
                    if (paciente == null)
                    {
                        MessageBox.Show("El paciente no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    paciente = new Pacientes1();
                }

                // Agregar una nueva fila al DataGridView con los datos
                paciente.Nombre = datos[0];
                paciente.Apellido = datos[1];
                paciente.Edad = int.TryParse(datos[2], out int edad) ? edad : 0;
                paciente.DNI = int.TryParse(datos[3], out int dni) ? dni : 0;
                paciente.Direccion = datos[4];
                paciente.Telefono = datos[5];
                paciente.Email = datos[6];
                paciente.FechaNacimiento = DateTime.TryParse(datos[7], out DateTime fechaNac) ? fechaNac : DateTime.MinValue;
                paciente.TipoSangre = datos[8];

                if (idPaciente == 0)
                {
                    await pacientesServices.AddPacienteAsync(paciente);
                    MessageBox.Show("Paciente agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    await pacientesServices.UpdatePacienteAsync(paciente);
                    MessageBox.Show("Paciente actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


                await GetDatosAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
        private async void btnEditarPaciente_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.Index < 0)
            {
                MessageBox.Show("Por favor, selecciona un paciente para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int idPaciente = (int)dataGridView1.CurrentRow.Cells[0].Value;
            Pacientes1 paciente = await pacientesServices.GetPacienteAsync(idPaciente);

            if (paciente != null)
            {
                using (var scope = Program.ServiceProvider.CreateScope())
                {
                    FAgregarPaciente formEditar = new FAgregarPaciente(pacientesServices, paciente);
                    formEditar.Owner = this;
                    formEditar.ShowDialog();
                }
            }
        }

        private async void btnEliminarPaciente_Click(object sender, EventArgs e)
        {
            // Validar si hay una fila seleccionada
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.Index < 0)
            {
                MessageBox.Show("Por favor, selecciona una fila para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Confirmar eliminación
            DialogResult resultado = MessageBox.Show(
                "¿Estás seguro de que deseas eliminar esta fila?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (resultado == DialogResult.Yes)
            {
                // Eliminar la fila seleccionada
                await pacientesServices.DeletePacienteAsync((int)dataGridView1.CurrentRow.Cells[0].Value);
                await GetDatosAsync();
                MessageBox.Show("Fila eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private async Task GetDatosAsync()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                dataGridView1.DataSource = null;
                var pacientes = await pacientesServices.GetPacientesAsync();
                var datos = pacientes.Select(p => new
                {
                    p.Id,
                    p.Nombre,
                    p.Apellido,
                    p.Edad,
                    p.DNI,
                    p.Direccion,
                    p.Telefono,
                    p.Email,
                    p.FechaNacimiento,
                    p.TipoSangre
                }).ToList();
                dataGridView1.DataSource = datos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
        private async void btnBuscarPaciente_Click(object sender, EventArgs e)
        {
            try
            {
                string term = txtBuscarPaciente.Text;
                if (string.IsNullOrWhiteSpace(term) || term == "Ingrese DNI")
                {
                    MessageBox.Show("Por favor, ingrese un DNI para buscar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    await GetDatosAsync();
                    return;
                }
                var datos = await pacientesServices.SearchPaciente(term);
                if (datos.Count() == 0)
                {
                    MessageBox.Show("No se encontraron resultados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    dataGridView1.DataSource = datos.Select(p => new
                    {
                        p.Id,
                        p.Nombre,
                        p.Apellido,
                        p.Edad,
                        p.DNI,
                        p.Direccion,
                        p.Telefono,
                        p.Email,
                        p.FechaNacimiento,
                        p.TipoSangre
                    }).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                await GetDatosAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnBuscarPaciente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBuscarPaciente.PerformClick();
            }
        }

        private async void txtBuscarPaciente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBuscarPaciente.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                txtBuscarPaciente.Text = "";
                await GetDatosAsync();
            }
        }
    }
}
