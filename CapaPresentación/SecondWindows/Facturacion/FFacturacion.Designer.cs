namespace CapaPresentación.SecondWindows
{
    partial class FFacturacion
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
            panelClose = new Panel();
            pictureBox1 = new PictureBox();
            panelFacturacion = new Panel();
            panel2 = new Panel();
            dataGridPagos = new DataGridView();
            label12 = new Label();
            panel1 = new Panel();
            btnActualizar = new Button();
            btnBuscarPaciente = new Button();
            label10 = new Label();
            txtBuscar = new TextBox();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnAgregar = new Button();
            panel3 = new Panel();
            comboBoxMetodoPago = new ComboBox();
            label9 = new Label();
            txtIdConsulta = new TextBox();
            idConsulta = new Label();
            txtMonto = new TextBox();
            label8 = new Label();
            txtFecha = new TextBox();
            label7 = new Label();
            txtApellido = new TextBox();
            label4 = new Label();
            txtNumeroFactura = new TextBox();
            label6 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            txtDNI = new TextBox();
            label5 = new Label();
            txtID = new TextBox();
            label2 = new Label();
            btnSeleccionar = new Button();
            label1 = new Label();
            panelClose.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelFacturacion.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridPagos).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panelClose
            // 
            panelClose.BackColor = Color.FromArgb(224, 224, 224);
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
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panelFacturacion
            // 
            panelFacturacion.Controls.Add(panel2);
            panelFacturacion.Controls.Add(panel1);
            panelFacturacion.Controls.Add(panel3);
            panelFacturacion.Controls.Add(panelClose);
            panelFacturacion.Dock = DockStyle.Fill;
            panelFacturacion.Location = new Point(0, 0);
            panelFacturacion.Name = "panelFacturacion";
            panelFacturacion.Size = new Size(800, 450);
            panelFacturacion.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridPagos);
            panel2.Controls.Add(label12);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 172);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(581, 278);
            panel2.TabIndex = 4;
            // 
            // dataGridPagos
            // 
            dataGridPagos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridPagos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridPagos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridPagos.Location = new Point(8, 23);
            dataGridPagos.Name = "dataGridPagos";
            dataGridPagos.RowHeadersWidth = 51;
            dataGridPagos.Size = new Size(544, 205);
            dataGridPagos.TabIndex = 7;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(8, 3);
            label12.Name = "label12";
            label12.Size = new Size(97, 17);
            label12.TabIndex = 6;
            label12.Text = "Lista de pagos";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnActualizar);
            panel1.Controls.Add(btnBuscarPaciente);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(txtBuscar);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(btnEditar);
            panel1.Controls.Add(btnAgregar);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(581, 172);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(219, 278);
            panel1.TabIndex = 3;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(6, 197);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 8;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnBuscarPaciente
            // 
            btnBuscarPaciente.Location = new Point(88, 197);
            btnBuscarPaciente.Name = "btnBuscarPaciente";
            btnBuscarPaciente.Size = new Size(75, 23);
            btnBuscarPaciente.TabIndex = 10;
            btnBuscarPaciente.Text = "Buscar";
            btnBuscarPaciente.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(5, 153);
            label10.Name = "label10";
            label10.Size = new Size(82, 15);
            label10.TabIndex = 9;
            label10.Text = "Buscar factura";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(5, 171);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(158, 23);
            txtBuscar.TabIndex = 7;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Image = Properties.Resources.trash_solid;
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(5, 101);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Padding = new Padding(4);
            btnEliminar.Size = new Size(122, 33);
            btnEliminar.TabIndex = 4;
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
            btnEditar.Location = new Point(5, 62);
            btnEditar.Name = "btnEditar";
            btnEditar.Padding = new Padding(4);
            btnEditar.Size = new Size(122, 33);
            btnEditar.TabIndex = 5;
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
            btnAgregar.Location = new Point(5, 23);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Padding = new Padding(4);
            btnAgregar.Size = new Size(122, 33);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "       Agregar";
            btnAgregar.TextAlign = ContentAlignment.MiddleLeft;
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(224, 224, 224);
            panel3.Controls.Add(comboBoxMetodoPago);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(txtIdConsulta);
            panel3.Controls.Add(idConsulta);
            panel3.Controls.Add(txtMonto);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(txtFecha);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(txtApellido);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(txtNumeroFactura);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(txtNombre);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(txtDNI);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(txtID);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(btnSeleccionar);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 39);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 133);
            panel3.TabIndex = 2;
            // 
            // comboBoxMetodoPago
            // 
            comboBoxMetodoPago.FormattingEnabled = true;
            comboBoxMetodoPago.Items.AddRange(new object[] { "Efectivo", "Transferencia", "Debito", "Credito", "QR" });
            comboBoxMetodoPago.Location = new Point(494, 72);
            comboBoxMetodoPago.Margin = new Padding(3, 2, 3, 2);
            comboBoxMetodoPago.Name = "comboBoxMetodoPago";
            comboBoxMetodoPago.Size = new Size(133, 23);
            comboBoxMetodoPago.TabIndex = 11;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(385, 77);
            label9.Name = "label9";
            label9.Size = new Size(95, 15);
            label9.TabIndex = 10;
            label9.Text = "Metodo de pago";
            // 
            // txtIdConsulta
            // 
            txtIdConsulta.Location = new Point(494, 101);
            txtIdConsulta.Margin = new Padding(3, 2, 3, 2);
            txtIdConsulta.Name = "txtIdConsulta";
            txtIdConsulta.Size = new Size(110, 23);
            txtIdConsulta.TabIndex = 9;
            // 
            // idConsulta
            // 
            idConsulta.AutoSize = true;
            idConsulta.Location = new Point(412, 106);
            idConsulta.Name = "idConsulta";
            idConsulta.Size = new Size(68, 15);
            idConsulta.TabIndex = 8;
            idConsulta.Text = "ID Consulta";
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(494, 43);
            txtMonto.Margin = new Padding(3, 2, 3, 2);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(110, 23);
            txtMonto.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(445, 48);
            label8.Name = "label8";
            label8.Size = new Size(43, 15);
            label8.TabIndex = 8;
            label8.Text = "Monto";
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(272, 101);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(100, 23);
            txtFecha.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(226, 106);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 6;
            label7.Text = "Fecha";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(69, 101);
            txtApellido.Name = "txtApellido";
            txtApellido.ReadOnly = true;
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 106);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 6;
            label4.Text = "Apellido";
            // 
            // txtNumeroFactura
            // 
            txtNumeroFactura.Location = new Point(272, 72);
            txtNumeroFactura.Name = "txtNumeroFactura";
            txtNumeroFactura.Size = new Size(100, 23);
            txtNumeroFactura.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(200, 77);
            label6.Name = "label6";
            label6.Size = new Size(63, 15);
            label6.TabIndex = 6;
            label6.Text = "N° Factura";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(69, 72);
            txtNombre.Name = "txtNombre";
            txtNombre.ReadOnly = true;
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 77);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 6;
            label3.Text = "Nombre";
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(272, 43);
            txtDNI.Name = "txtDNI";
            txtDNI.ReadOnly = true;
            txtDNI.Size = new Size(100, 23);
            txtDNI.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(236, 48);
            label5.Name = "label5";
            label5.Size = new Size(27, 15);
            label5.TabIndex = 6;
            label5.Text = "DNI";
            // 
            // txtID
            // 
            txtID.Location = new Point(69, 43);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 48);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 6;
            label2.Text = "ID";
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.Location = new Point(164, 9);
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.Size = new Size(136, 25);
            btnSeleccionar.TabIndex = 5;
            btnSeleccionar.Text = "Seleccionar Consulta";
            btnSeleccionar.UseVisualStyleBackColor = true;
            btnSeleccionar.Click += btnSeleccionar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(136, 25);
            label1.TabIndex = 4;
            label1.Text = "Facturacion";
            // 
            // FFacturacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelFacturacion);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FFacturacion";
            Text = "FFacturacion";
            Load += FFacturacion_Load;
            panelClose.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelFacturacion.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridPagos).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelClose;
        private PictureBox pictureBox1;
        private Panel panelFacturacion;
        private Panel panel3;
        private TextBox txtFecha;
        private Label label7;
        private TextBox txtApellido;
        private Label label4;
        private TextBox txtNumeroFactura;
        private Label label6;
        private TextBox txtNombre;
        private Label label3;
        private TextBox txtDNI;
        private Label label5;
        private TextBox txtID;
        private Label label2;
        private Button btnSeleccionar;
        private Label label1;
        private TextBox txtMonto;
        private Label label8;
        private ComboBox comboBoxMetodoPago;
        private Label label9;
        private Panel panel2;
        private Panel panel1;
        private DataGridView dataGridPagos;
        private Label label12;
        private Button btnActualizar;
        private Button btnBuscarPaciente;
        private Label label10;
        private TextBox txtBuscar;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnAgregar;
        private TextBox txtIdConsulta;
        private Label idConsulta;
    }
}