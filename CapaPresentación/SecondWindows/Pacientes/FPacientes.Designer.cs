namespace CapaPresentación.SecondWindows
{
    partial class FPacientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            panelPacientes = new Panel();
            panel3 = new Panel();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            btnActualizar = new Button();
            btnBuscarPaciente = new Button();
            label2 = new Label();
            txtBuscarPaciente = new TextBox();
            btnEliminarPaciente = new Button();
            btnEditarPaciente = new Button();
            btnAgregarPaciente = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelPacientes.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Dock = DockStyle.Right;
            pictureBox1.Image = Properties.Resources.circle_xmark_solid1;
            pictureBox1.Location = new Point(765, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // panelPacientes
            // 
            panelPacientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelPacientes.Controls.Add(panel3);
            panelPacientes.Controls.Add(panel2);
            panelPacientes.Controls.Add(panel1);
            panelPacientes.Location = new Point(0, 0);
            panelPacientes.Name = "panelPacientes";
            panelPacientes.Size = new Size(800, 450);
            panelPacientes.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(label1);
            panel3.Controls.Add(dataGridView1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 39);
            panel3.Name = "panel3";
            panel3.Size = new Size(564, 411);
            panel3.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(207, 25);
            label1.TabIndex = 1;
            label1.Text = "Lista de Pacientes";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 37);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(521, 181);
            dataGridView1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnActualizar);
            panel2.Controls.Add(btnBuscarPaciente);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtBuscarPaciente);
            panel2.Controls.Add(btnEliminarPaciente);
            panel2.Controls.Add(btnEditarPaciente);
            panel2.Controls.Add(btnAgregarPaciente);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(564, 39);
            panel2.Name = "panel2";
            panel2.Size = new Size(236, 411);
            panel2.TabIndex = 11;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(7, 221);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 2;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnBuscarPaciente
            // 
            btnBuscarPaciente.Location = new Point(88, 221);
            btnBuscarPaciente.Name = "btnBuscarPaciente";
            btnBuscarPaciente.Size = new Size(75, 23);
            btnBuscarPaciente.TabIndex = 3;
            btnBuscarPaciente.Text = "Buscar";
            btnBuscarPaciente.UseVisualStyleBackColor = true;
            btnBuscarPaciente.Click += btnBuscarPaciente_Click;
            btnBuscarPaciente.KeyDown += btnBuscarPaciente_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 177);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 2;
            label2.Text = "Buscar paciente";
            // 
            // txtBuscarPaciente
            // 
            txtBuscarPaciente.Location = new Point(6, 195);
            txtBuscarPaciente.Name = "txtBuscarPaciente";
            txtBuscarPaciente.Size = new Size(158, 23);
            txtBuscarPaciente.TabIndex = 1;
            txtBuscarPaciente.KeyDown += txtBuscarPaciente_KeyDown;
            // 
            // btnEliminarPaciente
            // 
            btnEliminarPaciente.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminarPaciente.Image = Properties.Resources.trash_solid;
            btnEliminarPaciente.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminarPaciente.Location = new Point(6, 125);
            btnEliminarPaciente.Name = "btnEliminarPaciente";
            btnEliminarPaciente.Padding = new Padding(4);
            btnEliminarPaciente.Size = new Size(122, 33);
            btnEliminarPaciente.TabIndex = 0;
            btnEliminarPaciente.Text = "       Eliminar";
            btnEliminarPaciente.TextAlign = ContentAlignment.MiddleLeft;
            btnEliminarPaciente.UseVisualStyleBackColor = true;
            btnEliminarPaciente.Click += btnEliminarPaciente_Click;
            // 
            // btnEditarPaciente
            // 
            btnEditarPaciente.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditarPaciente.Image = Properties.Resources.pen_solid;
            btnEditarPaciente.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditarPaciente.Location = new Point(6, 86);
            btnEditarPaciente.Name = "btnEditarPaciente";
            btnEditarPaciente.Padding = new Padding(4);
            btnEditarPaciente.Size = new Size(122, 33);
            btnEditarPaciente.TabIndex = 0;
            btnEditarPaciente.Text = "       Editar";
            btnEditarPaciente.TextAlign = ContentAlignment.MiddleLeft;
            btnEditarPaciente.UseVisualStyleBackColor = true;
            btnEditarPaciente.Click += btnEditarPaciente_Click;
            // 
            // btnAgregarPaciente
            // 
            btnAgregarPaciente.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarPaciente.Image = Properties.Resources.plus_solid;
            btnAgregarPaciente.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregarPaciente.Location = new Point(6, 47);
            btnAgregarPaciente.Name = "btnAgregarPaciente";
            btnAgregarPaciente.Padding = new Padding(4);
            btnAgregarPaciente.Size = new Size(122, 33);
            btnAgregarPaciente.TabIndex = 0;
            btnAgregarPaciente.Text = "       Agregar";
            btnAgregarPaciente.TextAlign = ContentAlignment.MiddleLeft;
            btnAgregarPaciente.UseVisualStyleBackColor = true;
            btnAgregarPaciente.Click += btnAgregarPaciente_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 39);
            panel1.TabIndex = 10;
            // 
            // FPacientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelPacientes);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FPacientes";
            Text = "FormDePrueba";
            Load += FPacientes_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelPacientes.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private Panel panelPacientes;
        private Panel panel1;
        private Panel panel3;
        private Label label1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Button btnAgregarPaciente;
        private Button btnEliminarPaciente;
        private Button btnEditarPaciente;
        private Label label2;
        private TextBox txtBuscarPaciente;
        private Button btnBuscarPaciente;
        private Button btnActualizar;
    }
}