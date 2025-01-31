namespace CapaPresentación.SecondWindows
{
    partial class FConsultas
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
            panelConsultas = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            btnActualizar = new Button();
            btnBuscarPaciente = new Button();
            label2 = new Label();
            txtBuscarConsulta = new TextBox();
            btnEliminarConsulta = new Button();
            btnEditarConsulta = new Button();
            btnAgregarConsulta = new Button();
            panelClose = new Panel();
            pictureBox1 = new PictureBox();
            panelConsultas.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panelClose.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelConsultas
            // 
            panelConsultas.Controls.Add(panel2);
            panelConsultas.Controls.Add(panel1);
            panelConsultas.Controls.Add(panelClose);
            panelConsultas.Dock = DockStyle.Fill;
            panelConsultas.Location = new Point(0, 0);
            panelConsultas.Name = "panelConsultas";
            panelConsultas.Size = new Size(800, 450);
            panelConsultas.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 39);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(564, 411);
            panel2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(117, 25);
            label1.TabIndex = 3;
            label1.Text = "Consultas";
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
            dataGridView1.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnActualizar);
            panel1.Controls.Add(btnBuscarPaciente);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtBuscarConsulta);
            panel1.Controls.Add(btnEliminarConsulta);
            panel1.Controls.Add(btnEditarConsulta);
            panel1.Controls.Add(btnAgregarConsulta);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(564, 39);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(236, 411);
            panel1.TabIndex = 2;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(7, 221);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 8;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnBuscarPaciente
            // 
            btnBuscarPaciente.Location = new Point(88, 221);
            btnBuscarPaciente.Name = "btnBuscarPaciente";
            btnBuscarPaciente.Size = new Size(75, 23);
            btnBuscarPaciente.TabIndex = 10;
            btnBuscarPaciente.Text = "Buscar";
            btnBuscarPaciente.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 177);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 9;
            label2.Text = "Buscar consulta";
            // 
            // txtBuscarConsulta
            // 
            txtBuscarConsulta.Location = new Point(6, 195);
            txtBuscarConsulta.Name = "txtBuscarConsulta";
            txtBuscarConsulta.Size = new Size(158, 23);
            txtBuscarConsulta.TabIndex = 7;
            // 
            // btnEliminarConsulta
            // 
            btnEliminarConsulta.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminarConsulta.Image = Properties.Resources.trash_solid;
            btnEliminarConsulta.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminarConsulta.Location = new Point(6, 125);
            btnEliminarConsulta.Name = "btnEliminarConsulta";
            btnEliminarConsulta.Padding = new Padding(4);
            btnEliminarConsulta.Size = new Size(122, 33);
            btnEliminarConsulta.TabIndex = 4;
            btnEliminarConsulta.Text = "       Eliminar";
            btnEliminarConsulta.TextAlign = ContentAlignment.MiddleLeft;
            btnEliminarConsulta.UseVisualStyleBackColor = true;
            btnEliminarConsulta.Click += btnEliminarConsulta_Click;
            // 
            // btnEditarConsulta
            // 
            btnEditarConsulta.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditarConsulta.Image = Properties.Resources.pen_solid;
            btnEditarConsulta.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditarConsulta.Location = new Point(6, 86);
            btnEditarConsulta.Name = "btnEditarConsulta";
            btnEditarConsulta.Padding = new Padding(4);
            btnEditarConsulta.Size = new Size(122, 33);
            btnEditarConsulta.TabIndex = 5;
            btnEditarConsulta.Text = "       Editar";
            btnEditarConsulta.TextAlign = ContentAlignment.MiddleLeft;
            btnEditarConsulta.UseVisualStyleBackColor = true;
            btnEditarConsulta.Click += btnEditarConsulta_Click;
            // 
            // btnAgregarConsulta
            // 
            btnAgregarConsulta.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarConsulta.Image = Properties.Resources.plus_solid;
            btnAgregarConsulta.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregarConsulta.Location = new Point(6, 47);
            btnAgregarConsulta.Name = "btnAgregarConsulta";
            btnAgregarConsulta.Padding = new Padding(4);
            btnAgregarConsulta.Size = new Size(122, 33);
            btnAgregarConsulta.TabIndex = 6;
            btnAgregarConsulta.Text = "       Agregar";
            btnAgregarConsulta.TextAlign = ContentAlignment.MiddleLeft;
            btnAgregarConsulta.UseVisualStyleBackColor = true;
            btnAgregarConsulta.Click += btnAgregarConsulta_Click;
            // 
            // panelClose
            // 
            panelClose.Controls.Add(pictureBox1);
            panelClose.Dock = DockStyle.Top;
            panelClose.Location = new Point(0, 0);
            panelClose.Name = "panelClose";
            panelClose.Size = new Size(800, 39);
            panelClose.TabIndex = 1;
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
            // FConsultas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelConsultas);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FConsultas";
            Text = "FConsultas";
            Load += FConsultas_Load;
            panelConsultas.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelClose.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelConsultas;
        private Panel panelClose;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel panel1;
        private Button btnActualizar;
        private Button btnBuscarPaciente;
        private Label label2;
        private TextBox txtBuscarConsulta;
        private Button btnEliminarConsulta;
        private Button btnEditarConsulta;
        private Button btnAgregarConsulta;
        private Label label1;
        private DataGridView dataGridView1;
    }
}