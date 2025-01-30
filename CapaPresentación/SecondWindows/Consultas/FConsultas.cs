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

namespace CapaPresentación.SecondWindows
{
    public partial class FConsultas : Form
    {
        public FConsultas()
        {
            InitializeComponent();
            AggStyles.ApplyPlaceholder(txtBuscarConsulta, "Ingrese DNI");
        }
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FConsultas_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregarConsulta_Click(object sender, EventArgs e)
        {
            using (var scope = Program.ServiceProvider.CreateScope())
            {
                var formAgregar = scope.ServiceProvider.GetRequiredService<FAgregarConsulta>();
                formAgregar.Owner = this;
                formAgregar.ShowDialog();
            }
        }

        private void btnEditarConsulta_Click(object sender, EventArgs e)
        {
            
        }
    }
}
