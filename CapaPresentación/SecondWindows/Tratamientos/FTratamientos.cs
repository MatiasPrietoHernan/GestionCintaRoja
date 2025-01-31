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

namespace CapaPresentación.SecondWindows
{
    public partial class FTratamientos : Form
    {
        public FTratamientos()
        {
            InitializeComponent();
        }
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FTratamientos_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (var scope = Program.ServiceProvider.CreateScope())
            {
                var globalPacientes = scope.ServiceProvider.GetRequiredService<FAgregarTratamiento>();
                globalPacientes.Owner = this;
                globalPacientes.ShowDialog();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
