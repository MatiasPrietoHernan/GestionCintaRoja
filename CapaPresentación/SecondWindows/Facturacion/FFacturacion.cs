using CapaLogica.Interfaces;
using CapaLogica.Servicios;
using CapaPresentación.DTO;
using CapaPresentación.Factories;
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
using Pagos1 = CapaDatos.Models.Pagos;

namespace CapaPresentación.SecondWindows
{
    public partial class FFacturacion : Form
    {
        private readonly IPacientesServices pacientesServices;
        private readonly IPagosServices pagosServices;
        // Declará estas variables a nivel de la clase FFacturacion:
        private bool isEditing = false;
        private int editingPagoId = 0;

        public FFacturacion(IPacientesServices pacientesServices, IPagosServices pagosServices)
        {
            InitializeComponent();
            this.pacientesServices = pacientesServices;
            this.pagosServices = pagosServices;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var scope = Program.ServiceProvider.CreateScope())
                {
                    var factory = scope.ServiceProvider.GetRequiredService<GlobalPacientesFactory>();
                    var globalPacientes = factory.Crear(ModoFormularioPacientes.Diagnostico);
                    globalPacientes.Owner = this;
                    globalPacientes.PacienteSeleccionado += async (idConsulta, idPaciente) =>
                    {
                        txtID.Text = idPaciente.ToString(); // Mostrar el ID en el textbox
                        txtIdConsulta.Text = idConsulta.ToString();
                        await GetDatosPacientes((int)idPaciente);
                    };
                    globalPacientes.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void FFacturacion_Load(object sender, EventArgs e)
        {
            await GetPagosAsync();
        }

        private async Task GetDatosPacientes(int id)
        {
            try
            {
                var datos = await pacientesServices.GetPacienteAsync(id);
                if (datos == null)
                {
                    MessageBox.Show("No se encontraron datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                txtNombre.Text = datos.Nombre;
                txtApellido.Text = datos.Apellido;
                txtID.Text = datos.Id.ToString();
                txtDNI.Text = datos.DNI.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async Task GetPagosAsync()
        {
            try
            {
                var datos = await pagosServices.GetPagosConsultasPacientesAsync();
                var pagos = datos.Select(x => new
                {
                    x.Id,
                    x.Consulta.Paciente.Nombre,
                    x.Consulta.Paciente.Apellido,
                    x.Consulta.Fecha,
                    x.FechaPago,
                    x.Monto,
                    x.MetodoPago,
                }).ToList();
                // Deshabilitamos la generación automática de columnas
                dataGridPagos.AutoGenerateColumns = false;
                dataGridPagos.Columns.Clear();

                // Creá y agregá cada columna con el alias que quieras
                var colId = new DataGridViewTextBoxColumn();
                colId.Name = "Id";
                colId.HeaderText = "ID de Pago";
                colId.DataPropertyName = "Id";
                dataGridPagos.Columns.Add(colId);

                var colNombre = new DataGridViewTextBoxColumn();
                colNombre.Name = "Nombre";
                colNombre.HeaderText = "Nombre Paciente";
                colNombre.DataPropertyName = "Nombre";
                dataGridPagos.Columns.Add(colNombre);

                var colApellido = new DataGridViewTextBoxColumn();
                colApellido.Name = "Apellido";
                colApellido.HeaderText = "Apellido Paciente";
                colApellido.DataPropertyName = "Apellido";
                dataGridPagos.Columns.Add(colApellido);

                var colFechaConsulta = new DataGridViewTextBoxColumn();
                colFechaConsulta.Name = "Fecha";
                colFechaConsulta.HeaderText = "Fecha Consulta";
                colFechaConsulta.DataPropertyName = "Fecha";
                dataGridPagos.Columns.Add(colFechaConsulta);

                var colFechaPago = new DataGridViewTextBoxColumn();
                colFechaPago.Name = "FechaPago";
                colFechaPago.HeaderText = "Fecha Pago";
                colFechaPago.DataPropertyName = "FechaPago";
                dataGridPagos.Columns.Add(colFechaPago);

                var colMonto = new DataGridViewTextBoxColumn();
                colMonto.Name = "Monto";
                colMonto.HeaderText = "Monto Pagado";
                colMonto.DataPropertyName = "Monto";
                dataGridPagos.Columns.Add(colMonto);

                var colMetodoPago = new DataGridViewTextBoxColumn();
                colMetodoPago.Name = "MetodoPago";
                colMetodoPago.HeaderText = "Método de Pago";
                colMetodoPago.DataPropertyName = "MetodoPago";
                dataGridPagos.Columns.Add(colMetodoPago);

                // Ahora asigná el DataSource
                dataGridPagos.DataSource = pagos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtID.Text))
                {
                    MessageBox.Show("Debe seleccionar un paciente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (string.IsNullOrEmpty(txtMonto.Text))
                {
                    MessageBox.Show("Debe ingresar un monto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (string.IsNullOrEmpty(comboBoxMetodoPago.Text))
                {
                    MessageBox.Show("Debe ingresar un método de pago", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (txtFecha.Text == "  /  /")
                {
                    MessageBox.Show("Debe ingresar una fecha", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (string.IsNullOrEmpty(txtNumeroFactura.Text))
                {
                    MessageBox.Show("Debe ingresar un número de factura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (string.IsNullOrEmpty(txtIdConsulta.Text))
                {
                    MessageBox.Show("Debe ingresar un ID de consulta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!isEditing)
                {
                    // Si no estamos en modo edición, creamos un nuevo pago.
                    var idPagos = await pagosServices.GetPagoAsync(int.Parse(txtNumeroFactura.Text));
                    if (idPagos != null)
                    {
                        MessageBox.Show("El número de factura ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    var nuevoPago = new Pagos1
                    {
                        Id = int.Parse(txtNumeroFactura.Text),
                        FechaPago = txtFecha.Text,
                        Monto = double.Parse(txtMonto.Text),
                        MetodoPago = comboBoxMetodoPago.Text,
                        IdConsulta = int.Parse(txtIdConsulta.Text)
                    };

                    await pagosServices.AddPagoAsync(nuevoPago);
                    MessageBox.Show("Pago agregado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Si estamos en modo edición, actualizamos el pago.
                    var pagoActualizado = new Pagos1
                    {
                        Id = editingPagoId,  // Usamos el id del pago que estamos editando
                        FechaPago = txtFecha.Text,
                        Monto = double.Parse(txtMonto.Text),
                        MetodoPago = comboBoxMetodoPago.Text,
                        IdConsulta = int.Parse(txtIdConsulta.Text)
                    };

                    await pagosServices.UpdatePagoAsync(pagoActualizado);
                    MessageBox.Show("Pago actualizado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Salimos del modo edición
                    isEditing = false;
                    editingPagoId = 0;
                    // Restaurá los textos originales de los botones y habilitá los controles
                    btnAgregar.Text = "      Agregar";
                    btnEliminar.Text = "      Eliminar";
                    txtNombre.Enabled = true;
                    txtApellido.Enabled = true;
                    txtDNI.Enabled = true;
                    txtIdConsulta.Enabled = true;
                    btnSeleccionar.Enabled = true;
                }

                await GetPagosAsync();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            await GetPagosAsync();
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (isEditing)
                {
                    // Cancelar la edición
                    isEditing = false;
                    editingPagoId = 0;
                    btnAgregar.Text = "      Agregar";
                    btnEliminar.Text = "      Eliminar";

                    // Restaurá los controles a su estado normal
                    txtNombre.Enabled = true;
                    txtApellido.Enabled = true;
                    txtDNI.Enabled = true;
                    txtIdConsulta.Enabled = true;
                    btnSeleccionar.Enabled = true;

                    // Limpiar los campos, si es lo que querés
                    txtID.Clear();
                    txtNombre.Clear();
                    txtApellido.Clear();
                    txtDNI.Clear();
                    txtIdConsulta.Clear();
                    txtNumeroFactura.Clear();
                    txtMonto.Clear();
                    txtFecha.Clear();
                    comboBoxMetodoPago.SelectedIndex = -1;

                    MessageBox.Show("Edición cancelada", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Proceder a eliminar el pago, como ya lo tenías
                    if (dataGridPagos.CurrentRow == null || dataGridPagos.CurrentRow.Index < 0)
                    {
                        MessageBox.Show("Por favor, selecciona una fila para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    DialogResult resultado = MessageBox.Show(
                        "¿Estás seguro de que deseas eliminar esta fila? ESTO ES PERMANENTE",
                        "Confirmar eliminación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (resultado == DialogResult.Yes)
                    {
                        await pagosServices.DeletePagoAsync((int)dataGridPagos.CurrentRow.Cells[0].Value);
                        await GetPagosAsync();
                        MessageBox.Show("Fila eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridPagos.CurrentRow == null || dataGridPagos.CurrentRow.Index < 0)
                {
                    MessageBox.Show("Por favor, selecciona un pago para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int idPagos = (int)dataGridPagos.CurrentRow.Cells[0].Value;
                Pagos1 pago = await pagosServices.GetPagoWithRelationsAsync(idPagos);
                txtID.Text = pago.Consulta.idPaciente.ToString();
                txtNombre.Text = pago.Consulta.Paciente.Nombre;
                txtApellido.Text = pago.Consulta.Paciente.Apellido;
                txtDNI.Text = pago.Consulta.Paciente.DNI.ToString();
                txtIdConsulta.Text = pago.IdConsulta.ToString();
                txtNumeroFactura.Text = pago.Id.ToString();
                txtMonto.Text = pago.Monto.ToString();
                txtFecha.Text = pago.FechaPago;
                comboBoxMetodoPago.Text = pago.MetodoPago;


                txtNombre.Enabled = false;
                txtApellido.Enabled = false;
                txtDNI.Enabled = false;
                txtIdConsulta.Enabled = false;
                txtNumeroFactura.Enabled = false;
                btnSeleccionar.Enabled = false;

                isEditing = true;
                editingPagoId = pago.Id;

                btnAgregar.Text = "      Actualizar";
                btnEliminar.Text = "      Cancelar";
            } catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
