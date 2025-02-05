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
using Microsoft.Extensions.DependencyInjection;

namespace CapaPresentación.SecondWindows.Exportacion
{
    public partial class FExportar : Form
    {
        private readonly IExportarExcel _exportarExcel;
        private readonly IExportarPDF exportarPDF;
        public FExportar(IExportarExcel exportarExcel, IExportarPDF exportarPDF)
        {
            InitializeComponent();
            CargarCombox();
            _exportarExcel = exportarExcel;
            this.exportarPDF = exportarPDF;
        }

        private async void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    MessageBox.Show("Por favor, seleccione una tabla para exportar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Archivos de Excel (*.xlsx)|*.xlsx";
                    saveFileDialog.FileName = $"{comboBox1.Text}.xlsx";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        var rutaArchivo = saveFileDialog.FileName;
                        await _exportarExcel.ExportarAExcel(comboBox1.Text, rutaArchivo); // Pasás la ruta
                    }
                }
                MessageBox.Show("Tabla exportada con éxito!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void CargarCombox()
        {
            // Agregar la opción por defecto
            comboBox1.Items.Add("Seleccionar Tabla");

            // Agregar las otras opciones
            comboBox1.Items.Add("Pacientes");
            comboBox1.Items.Add("Consultas");
            comboBox1.Items.Add("Diagnosticos");
            comboBox1.Items.Add("Tratamientos");
            comboBox1.Items.Add("Pagos");

            // Establecer la opción por defecto seleccionada
            comboBox1.SelectedIndex = 0; // 0 es el índice de "Seleccionar Tabla"
        }

        private async void btnPdf_Click(object sender, EventArgs e)
        {
            try
            {
                if(comboBox1.SelectedIndex == 0)
                {
                    MessageBox.Show("Por favor, seleccione una tabla para exportar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Archivos PDF (*.pdf)|*.pdf";
                    saveFileDialog.FileName = $"{comboBox1.Text}.pdf";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        var rutaArchivo = saveFileDialog.FileName;
                       await exportarPDF.ExportarAPdf(comboBox1.Text, rutaArchivo);
                    }
                }
                MessageBox.Show("Tabla exportada con éxito!");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
