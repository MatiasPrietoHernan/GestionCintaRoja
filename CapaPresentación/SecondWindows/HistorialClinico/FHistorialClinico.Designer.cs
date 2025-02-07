namespace CapaPresentación.SecondWindows
{
    partial class FHistorialClinico
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
            panel1 = new Panel();
            panel4 = new Panel();
            tabControl1 = new TabControl();
            tabConsultas = new TabPage();
            dataGridConsultas = new DataGridView();
            label12 = new Label();
            tabDiagnosticos = new TabPage();
            dataGridDiagnosticos = new DataGridView();
            label13 = new Label();
            tabTratamientos = new TabPage();
            dataGridTratamientos = new DataGridView();
            label14 = new Label();
            tabPagos = new TabPage();
            dataGridPagos = new DataGridView();
            label15 = new Label();
            panel3 = new Panel();
            btnActualizar = new Button();
            txtFechaNacimiento = new TextBox();
            txtDireccion = new TextBox();
            label10 = new Label();
            label7 = new Label();
            txtApellido = new TextBox();
            label4 = new Label();
            txtEmail = new TextBox();
            txtDNI = new TextBox();
            label9 = new Label();
            label6 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            txtTipoSangre = new TextBox();
            label11 = new Label();
            txtTelefono = new TextBox();
            label8 = new Label();
            txtEdad = new TextBox();
            label5 = new Label();
            txtID = new TextBox();
            label2 = new Label();
            btnSeleccionar = new Button();
            label1 = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            tabControl1.SuspendLayout();
            tabConsultas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridConsultas).BeginInit();
            tabDiagnosticos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridDiagnosticos).BeginInit();
            tabTratamientos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridTratamientos).BeginInit();
            tabPagos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridPagos).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(tabControl1);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 172);
            panel4.Name = "panel4";
            panel4.Size = new Size(800, 278);
            panel4.TabIndex = 2;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabConsultas);
            tabControl1.Controls.Add(tabDiagnosticos);
            tabControl1.Controls.Add(tabTratamientos);
            tabControl1.Controls.Add(tabPagos);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 278);
            tabControl1.TabIndex = 1;
            // 
            // tabConsultas
            // 
            tabConsultas.Controls.Add(dataGridConsultas);
            tabConsultas.Controls.Add(label12);
            tabConsultas.Location = new Point(4, 24);
            tabConsultas.Name = "tabConsultas";
            tabConsultas.Padding = new Padding(3, 3, 3, 3);
            tabConsultas.Size = new Size(792, 250);
            tabConsultas.TabIndex = 0;
            tabConsultas.Text = "Consultas";
            tabConsultas.UseVisualStyleBackColor = true;
            // 
            // dataGridConsultas
            // 
            dataGridConsultas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridConsultas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridConsultas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridConsultas.Location = new Point(8, 23);
            dataGridConsultas.Name = "dataGridConsultas";
            dataGridConsultas.RowHeadersWidth = 51;
            dataGridConsultas.Size = new Size(544, 205);
            dataGridConsultas.TabIndex = 5;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(8, 3);
            label12.Name = "label12";
            label12.Size = new Size(68, 17);
            label12.TabIndex = 0;
            label12.Text = "Consultas";
            // 
            // tabDiagnosticos
            // 
            tabDiagnosticos.Controls.Add(dataGridDiagnosticos);
            tabDiagnosticos.Controls.Add(label13);
            tabDiagnosticos.Location = new Point(4, 24);
            tabDiagnosticos.Name = "tabDiagnosticos";
            tabDiagnosticos.Padding = new Padding(3, 3, 3, 3);
            tabDiagnosticos.Size = new Size(792, 250);
            tabDiagnosticos.TabIndex = 1;
            tabDiagnosticos.Text = "Diagnosticos";
            tabDiagnosticos.UseVisualStyleBackColor = true;
            // 
            // dataGridDiagnosticos
            // 
            dataGridDiagnosticos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridDiagnosticos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridDiagnosticos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridDiagnosticos.Location = new Point(8, 23);
            dataGridDiagnosticos.Name = "dataGridDiagnosticos";
            dataGridDiagnosticos.RowHeadersWidth = 51;
            dataGridDiagnosticos.Size = new Size(544, 205);
            dataGridDiagnosticos.TabIndex = 7;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(8, 3);
            label13.Name = "label13";
            label13.Size = new Size(88, 17);
            label13.TabIndex = 6;
            label13.Text = "Diagnosticos";
            // 
            // tabTratamientos
            // 
            tabTratamientos.Controls.Add(dataGridTratamientos);
            tabTratamientos.Controls.Add(label14);
            tabTratamientos.Location = new Point(4, 24);
            tabTratamientos.Name = "tabTratamientos";
            tabTratamientos.Padding = new Padding(3, 3, 3, 3);
            tabTratamientos.Size = new Size(792, 250);
            tabTratamientos.TabIndex = 2;
            tabTratamientos.Text = "Tratamientos";
            tabTratamientos.UseVisualStyleBackColor = true;
            // 
            // dataGridTratamientos
            // 
            dataGridTratamientos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridTratamientos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridTratamientos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridTratamientos.Location = new Point(8, 23);
            dataGridTratamientos.Name = "dataGridTratamientos";
            dataGridTratamientos.RowHeadersWidth = 51;
            dataGridTratamientos.Size = new Size(544, 205);
            dataGridTratamientos.TabIndex = 7;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(8, 3);
            label14.Name = "label14";
            label14.Size = new Size(89, 17);
            label14.TabIndex = 6;
            label14.Text = "Tratamientos";
            // 
            // tabPagos
            // 
            tabPagos.Controls.Add(dataGridPagos);
            tabPagos.Controls.Add(label15);
            tabPagos.Location = new Point(4, 24);
            tabPagos.Name = "tabPagos";
            tabPagos.Padding = new Padding(3, 3, 3, 3);
            tabPagos.Size = new Size(792, 250);
            tabPagos.TabIndex = 3;
            tabPagos.Text = "Pagos";
            tabPagos.UseVisualStyleBackColor = true;
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
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(8, 3);
            label15.Name = "label15";
            label15.Size = new Size(45, 17);
            label15.TabIndex = 6;
            label15.Text = "Pagos";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(224, 224, 224);
            panel3.Controls.Add(btnActualizar);
            panel3.Controls.Add(txtFechaNacimiento);
            panel3.Controls.Add(txtDireccion);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(txtApellido);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(txtEmail);
            panel3.Controls.Add(txtDNI);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(txtNombre);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(txtTipoSangre);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(txtTelefono);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(txtEdad);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(txtID);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(btnSeleccionar);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 39);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 133);
            panel3.TabIndex = 1;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(564, 102);
            btnActualizar.Margin = new Padding(3, 2, 3, 2);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(128, 22);
            btnActualizar.TabIndex = 8;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click_1;
            // 
            // txtFechaNacimiento
            // 
            txtFechaNacimiento.Location = new Point(697, 46);
            txtFechaNacimiento.Name = "txtFechaNacimiento";
            txtFechaNacimiento.ReadOnly = true;
            txtFechaNacimiento.Size = new Size(100, 23);
            txtFechaNacimiento.TabIndex = 7;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(246, 104);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.ReadOnly = true;
            txtDireccion.Size = new Size(100, 23);
            txtDireccion.TabIndex = 7;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(564, 51);
            label10.Name = "label10";
            label10.Size = new Size(117, 15);
            label10.TabIndex = 6;
            label10.Text = "Fecha de nacimiento";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(178, 109);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 6;
            label7.Text = "Direccion";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(69, 104);
            txtApellido.Name = "txtApellido";
            txtApellido.ReadOnly = true;
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 109);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 6;
            label4.Text = "Apellido";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(456, 75);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 7;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(246, 75);
            txtDNI.Name = "txtDNI";
            txtDNI.ReadOnly = true;
            txtDNI.Size = new Size(100, 23);
            txtDNI.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(414, 80);
            label9.Name = "label9";
            label9.Size = new Size(36, 15);
            label9.TabIndex = 6;
            label9.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(213, 80);
            label6.Name = "label6";
            label6.Size = new Size(27, 15);
            label6.TabIndex = 6;
            label6.Text = "DNI";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(69, 75);
            txtNombre.Name = "txtNombre";
            txtNombre.ReadOnly = true;
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 80);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 6;
            label3.Text = "Nombre";
            // 
            // txtTipoSangre
            // 
            txtTipoSangre.Location = new Point(456, 104);
            txtTipoSangre.Name = "txtTipoSangre";
            txtTipoSangre.ReadOnly = true;
            txtTipoSangre.Size = new Size(100, 23);
            txtTipoSangre.TabIndex = 7;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(356, 109);
            label11.Name = "label11";
            label11.Size = new Size(84, 15);
            label11.TabIndex = 6;
            label11.Text = "Tipo de sangre";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(456, 46);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.ReadOnly = true;
            txtTelefono.Size = new Size(100, 23);
            txtTelefono.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(392, 51);
            label8.Name = "label8";
            label8.Size = new Size(52, 15);
            label8.TabIndex = 6;
            label8.Text = "Telefono";
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(246, 46);
            txtEdad.Name = "txtEdad";
            txtEdad.ReadOnly = true;
            txtEdad.Size = new Size(100, 23);
            txtEdad.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(207, 51);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 6;
            label5.Text = "Edad";
            // 
            // txtID
            // 
            txtID.Location = new Point(69, 46);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 51);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 6;
            label2.Text = "ID";
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.Location = new Point(192, 9);
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.Size = new Size(136, 25);
            btnSeleccionar.TabIndex = 5;
            btnSeleccionar.Text = "Seleccionar paciente";
            btnSeleccionar.UseVisualStyleBackColor = true;
            btnSeleccionar.Click += btnSeleccionar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(174, 25);
            label1.TabIndex = 4;
            label1.Text = "Historial clinico";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(224, 224, 224);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 39);
            panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Dock = DockStyle.Right;
            pictureBox1.Image = Properties.Resources.circle_xmark_solid;
            pictureBox1.Location = new Point(767, 0);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(33, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // FHistorialClinico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FHistorialClinico";
            Text = "FHistorialClinico";
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabConsultas.ResumeLayout(false);
            tabConsultas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridConsultas).EndInit();
            tabDiagnosticos.ResumeLayout(false);
            tabDiagnosticos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridDiagnosticos).EndInit();
            tabTratamientos.ResumeLayout(false);
            tabTratamientos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridTratamientos).EndInit();
            tabPagos.ResumeLayout(false);
            tabPagos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridPagos).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Panel panel4;
        private Panel panel3;
        private Label label1;
        private Button btnSeleccionar;
        private TextBox txtNombre;
        private Label label3;
        private TextBox txtID;
        private Label label2;
        private TextBox txtApellido;
        private Label label4;
        private TextBox txtEdad;
        private Label label5;
        private TextBox txtDireccion;
        private Label label7;
        private TextBox txtDNI;
        private Label label6;
        private TextBox txtFechaNacimiento;
        private Label label10;
        private TextBox txtEmail;
        private Label label9;
        private TextBox txtTelefono;
        private Label label8;
        private TextBox txtTipoSangre;
        private Label label11;
        private TabControl tabControl1;
        private TabPage tabConsultas;
        private Label label12;
        private TabPage tabDiagnosticos;
        private TabPage tabTratamientos;
        private TabPage tabPagos;
        private DataGridView dataGridConsultas;
        private DataGridView dataGridDiagnosticos;
        private Label label13;
        private DataGridView dataGridTratamientos;
        private Label label14;
        private DataGridView dataGridPagos;
        private Label label15;
        private Button btnActualizar;
    }
}