﻿using CapaLogica.Interfaces;
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
using Tratamientos1 = CapaDatos.Models.Tratamientos;

namespace CapaPresentación.SecondWindows.Tratamientos
{
    public partial class FAgregarTratamiento : Form
    {
        private readonly ITratamientosServices tratamientosServices;
        private readonly Tratamientos1 tratamientoEditar;
        public int idPaciente { get; set; }
        public FAgregarTratamiento(ITratamientosServices tratamientosServices, Tratamientos1 tratamientoEditar = null)
        {
            InitializeComponent();
            this.tratamientosServices = tratamientosServices;
            this.tratamientoEditar = tratamientoEditar;
            CargarDatosEditar();
        }

        private void CargarDatosEditar()
        {
            if (tratamientoEditar != null)
            {
                txtID.Text = tratamientoEditar.Id.ToString();
                txtTratamiento.Text = tratamientoEditar.NombreTratamiento;
                txtFechaInicio.Text = tratamientoEditar.FechaInicio.ToString();
                txtFechaFin.Text = tratamientoEditar.FechaFin.ToString();
                txtDescripcion.Text = tratamientoEditar.Detalles;
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
                var globalPacientes = factory.Crear(ModoFormularioPacientes.Consulta);
                globalPacientes.Owner = this;

                globalPacientes.PacienteSeleccionado += (id) =>
                {
                    idPaciente = id;
                    txtID.Text = id.ToString(); // Mostrar el ID en el textbox
                };

                globalPacientes.ShowDialog();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidationHelper.AreFieldsNotEmpty(txtID.Text, txtTratamiento.Text, txtFechaInicio.Text, txtFechaFin.Text, txtDescripcion.Text))
                {
                    MessageBox.Show("Todos los campos deben estar llenos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!ValidationHelper.AreFieldsNumeric(txtID.Text))
                {
                    MessageBox.Show("El campo de ID Pciente deben contener solo números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!ValidationHelper.IsValidDate(txtFechaInicio.Text) || !ValidationHelper.IsValidDate(txtFechaFin.Text))
                {
                    MessageBox.Show("La fecha no tiene un formato válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (tratamientoEditar == null)
                {
                    var tratamiento = new Tratamientos1
                    {
                        NombreTratamiento = txtTratamiento.Text,
                        IdPaciente = int.Parse(txtID.Text),
                        FechaInicio = DateTime.Parse(txtFechaInicio.Text),
                        FechaFin = DateTime.Parse(txtFechaFin.Text),
                        Detalles = txtDescripcion.Text
                    };
                    await tratamientosServices.AddTratamientoAsync(tratamiento);
                    MessageBox.Show("Tratamiento agregado correctamente.", "Tratamiento agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    tratamientoEditar.NombreTratamiento = txtTratamiento.Text;
                    tratamientoEditar.FechaInicio = DateTime.Parse(txtFechaInicio.Text);
                    tratamientoEditar.FechaFin = DateTime.Parse(txtFechaFin.Text);
                    tratamientoEditar.Detalles = txtDescripcion.Text;
                    MessageBox.Show("Tratamiento actualizado correctamente.", "Tratamiento actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await tratamientosServices.UpdateTratamientoAsync(tratamientoEditar);
                }

                this.Close();
            } catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

           
        }
    }
}
