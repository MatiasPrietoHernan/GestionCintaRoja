namespace CapaPresentación.SecondWindows
{
    partial class FTratamientos
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
            panelTratamientos = new Panel();
            panel3 = new Panel();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            btnActualizar = new Button();
            btnBuscarPaciente = new Button();
            label2 = new Label();
            txtBuscar = new TextBox();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnAgregar = new Button();
            panelClose = new Panel();
            pictureBox1 = new PictureBox();
            panelTratamientos.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            panelClose.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelTratamientos
            // 
            panelTratamientos.Controls.Add(panel3);
            panelTratamientos.Controls.Add(panel2);
            panelTratamientos.Controls.Add(panelClose);
            panelTratamientos.Dock = DockStyle.Fill;
            panelTratamientos.Location = new Point(0, 0);
            panelTratamientos.Name = "panelTratamientos";
            panelTratamientos.Size = new Size(800, 450);
            panelTratamientos.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(label1);
            panel3.Controls.Add(dataGridView1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 39);
            panel3.Name = "panel3";
            panel3.Size = new Size(564, 411);
            panel3.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(149, 25);
            label1.TabIndex = 1;
            label1.Text = "Tratamientos";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 37);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(520, 181);
            dataGridView1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnActualizar);
            panel2.Controls.Add(btnBuscarPaciente);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtBuscar);
            panel2.Controls.Add(btnEliminar);
            panel2.Controls.Add(btnEditar);
            panel2.Controls.Add(btnAgregar);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(564, 39);
            panel2.Name = "panel2";
            panel2.Size = new Size(236, 411);
            panel2.TabIndex = 12;
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
            // txtBuscar
            // 
            txtBuscar.Location = new Point(6, 195);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(158, 23);
            txtBuscar.TabIndex = 1;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Image = Properties.Resources.trash_solid;
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(6, 125);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Padding = new Padding(4);
            btnEliminar.Size = new Size(122, 33);
            btnEliminar.TabIndex = 0;
            btnEliminar.Text = "       Eliminar";
            btnEliminar.TextAlign = ContentAlignment.MiddleLeft;
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.Image = Properties.Resources.pen_solid;
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.Location = new Point(6, 86);
            btnEditar.Name = "btnEditar";
            btnEditar.Padding = new Padding(4);
            btnEditar.Size = new Size(122, 33);
            btnEditar.TabIndex = 0;
            btnEditar.Text = "       Editar";
            btnEditar.TextAlign = ContentAlignment.MiddleLeft;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Image = Properties.Resources.plus_solid;
            btnAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregar.Location = new Point(6, 47);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Padding = new Padding(4);
            btnAgregar.Size = new Size(122, 33);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "       Agregar";
            btnAgregar.TextAlign = ContentAlignment.MiddleLeft;
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // panelClose
            // 
            panelClose.Controls.Add(pictureBox1);
            panelClose.Dock = DockStyle.Top;
            panelClose.Location = new Point(0, 0);
            panelClose.Name = "panelClose";
            panelClose.Size = new Size(800, 39);
            panelClose.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Dock = DockStyle.Right;
            pictureBox1.Image = Properties.Resources.circle_xmark_solid1;
            pictureBox1.Location = new Point(767, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(33, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // FTratamientos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelTratamientos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FTratamientos";
            Text = "FTratamientos";
            Load += FTratamientos_Load;
            panelTratamientos.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panelClose.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTratamientos;
        private Panel panelClose;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Button btnActualizar;
        private Button btnBuscarPaciente;
        private Label label2;
        private TextBox txtBuscar;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnAgregar;
        private Panel panel3;
        private Label label1;
        private DataGridView dataGridView1;
    }
}