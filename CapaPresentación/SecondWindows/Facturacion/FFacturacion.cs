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

namespace CapaPresentación.SecondWindows
{
    public partial class FFacturacion : Form
    {
        public FFacturacion()
        {
            InitializeComponent();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            using (var scope = Program.ServiceProvider.CreateScope())
            {
                var factory = scope.ServiceProvider.GetRequiredService<GlobalPacientesFactory>();
                var globalPacientes = factory.Crear(ModoFormularioPacientes.Consulta);
                globalPacientes.Owner = this;
                globalPacientes.ShowDialog();
            }
        }

        private void FFacturacion_Load(object sender, EventArgs e)
        {

        }
    }
}
