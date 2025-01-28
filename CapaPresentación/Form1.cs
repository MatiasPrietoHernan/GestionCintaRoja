using CapaLogica.Interfaces;
using CapaLogica.Servicios;
using CapaPresentación.SecondWindows;

namespace CapaPresentación
{
    public partial class Form1 : Form
    {
        private readonly IPacientesServices pacientesServices;
        public Form1()
        {
            InitializeComponent();
            this.Icon = new Icon("Resources/Icons/cinta-de-cancer-de-mama.ico");
            this.FormClosing += new FormClosingEventHandler(MainForm_FormClosing);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        private void btnPacientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FPacientes>();
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FConsultas>();
        }

        private void btnDiagnosticos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FDiagnosticos>();
        }

        private void btnTratamientos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FTratamientos>();
        }

        private void btnHistorialClinico_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FHistorialClinico>();
        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FFacturacion>();
        }

        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelInicio.Controls.OfType<MiForm>().FirstOrDefault();
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelInicio.Controls.Add(formulario);
                panelInicio.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();
            }
        }
        
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var resultado = MessageBox.Show(
                "¿Estás seguro de que deseas cerrar la aplicación?",
                "Confirmar cierre",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (resultado == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
