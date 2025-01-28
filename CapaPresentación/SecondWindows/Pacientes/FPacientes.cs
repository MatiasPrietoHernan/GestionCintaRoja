using CapaPresentación.SecondWindows.Pacientes;
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

namespace CapaPresentación.SecondWindows
{
    public partial class FPacientes : Form
    {
        public FPacientes()
        {
            InitializeComponent();
            formDesing();
            dataGridView1.Columns.Add("Nombre", "Nombre");
            dataGridView1.Columns.Add("Apellido", "Apellido");
            dataGridView1.Columns.Add("Edad", "Edad");
            dataGridView1.Columns.Add("DNI", "DNI");
            dataGridView1.Columns.Add("Direccion", "Dirección");
            dataGridView1.Columns.Add("Telefono", "Teléfono");
            dataGridView1.Columns.Add("Email", "Email");
            dataGridView1.Columns.Add("FechaNacimiento", "Fecha de Nacimiento");
            dataGridView1.Columns.Add("TipoSangre", "Tipo de Sangre");

        }
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAgregarPaciente_Click(object sender, EventArgs e)
        {
            FAgregarPaciente formAgregar = new FAgregarPaciente();
            formAgregar.Owner = this;
            formAgregar.ShowDialog();

        }
        public void AgregarFila(string[] datos)
        {
            // Verificar que los datos coincidan con las columnas del DataGridView
            if (datos.Length == dataGridView1.Columns.Count)
            {
                // Agregar una nueva fila al DataGridView con los datos
                dataGridView1.Rows.Add(datos);
            }
            else
            {
                MessageBox.Show("La cantidad de datos no coincide con las columnas del DataGridView.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnEditarPaciente_Click(object sender, EventArgs e)
        {

        }
        private void formDesing()
        {
            // Placeholder inicial
            string placeholderText = "Ingrese DNI";

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

        private void btnEliminarPaciente_Click(object sender, EventArgs e)
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
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                MessageBox.Show("Fila eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
