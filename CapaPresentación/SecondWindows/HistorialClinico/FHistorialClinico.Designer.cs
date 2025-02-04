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
            btnActualizar = new Button();
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
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(914, 600);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(tabControl1);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 229);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(914, 371);
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
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(914, 371);
            tabControl1.TabIndex = 1;
            // 
            // tabConsultas
            // 
            tabConsultas.Controls.Add(btnActualizar);
            tabConsultas.Controls.Add(dataGridConsultas);
            tabConsultas.Controls.Add(label12);
            tabConsultas.Location = new Point(4, 29);
            tabConsultas.Margin = new Padding(3, 4, 3, 4);
            tabConsultas.Name = "tabConsultas";
            tabConsultas.Padding = new Padding(3, 4, 3, 4);
            tabConsultas.Size = new Size(906, 338);
            tabConsultas.TabIndex = 0;
            tabConsultas.Text = "Consultas";
            tabConsultas.UseVisualStyleBackColor = true;
            // 
            // dataGridConsultas
            // 
            dataGridConsultas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridConsultas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridConsultas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridConsultas.Location = new Point(9, 31);
            dataGridConsultas.Margin = new Padding(3, 4, 3, 4);
            dataGridConsultas.Name = "dataGridConsultas";
            dataGridConsultas.RowHeadersWidth = 51;
            dataGridConsultas.Size = new Size(622, 273);
            dataGridConsultas.TabIndex = 5;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(9, 4);
            label12.Name = "label12";
            label12.Size = new Size(86, 23);
            label12.TabIndex = 0;
            label12.Text = "Consultas";
            // 
            // tabDiagnosticos
            // 
            tabDiagnosticos.Controls.Add(dataGridDiagnosticos);
            tabDiagnosticos.Controls.Add(label13);
            tabDiagnosticos.Location = new Point(4, 29);
            tabDiagnosticos.Margin = new Padding(3, 4, 3, 4);
            tabDiagnosticos.Name = "tabDiagnosticos";
            tabDiagnosticos.Padding = new Padding(3, 4, 3, 4);
            tabDiagnosticos.Size = new Size(906, 338);
            tabDiagnosticos.TabIndex = 1;
            tabDiagnosticos.Text = "Diagnosticos";
            tabDiagnosticos.UseVisualStyleBackColor = true;
            // 
            // dataGridDiagnosticos
            // 
            dataGridDiagnosticos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridDiagnosticos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridDiagnosticos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridDiagnosticos.Location = new Point(9, 31);
            dataGridDiagnosticos.Margin = new Padding(3, 4, 3, 4);
            dataGridDiagnosticos.Name = "dataGridDiagnosticos";
            dataGridDiagnosticos.RowHeadersWidth = 51;
            dataGridDiagnosticos.Size = new Size(622, 241);
            dataGridDiagnosticos.TabIndex = 7;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(9, 4);
            label13.Name = "label13";
            label13.Size = new Size(112, 23);
            label13.TabIndex = 6;
            label13.Text = "Diagnosticos";
            // 
            // tabTratamientos
            // 
            tabTratamientos.Controls.Add(dataGridTratamientos);
            tabTratamientos.Controls.Add(label14);
            tabTratamientos.Location = new Point(4, 29);
            tabTratamientos.Margin = new Padding(3, 4, 3, 4);
            tabTratamientos.Name = "tabTratamientos";
            tabTratamientos.Padding = new Padding(3, 4, 3, 4);
            tabTratamientos.Size = new Size(906, 338);
            tabTratamientos.TabIndex = 2;
            tabTratamientos.Text = "Tratamientos";
            tabTratamientos.UseVisualStyleBackColor = true;
            // 
            // dataGridTratamientos
            // 
            dataGridTratamientos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridTratamientos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridTratamientos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridTratamientos.Location = new Point(9, 31);
            dataGridTratamientos.Margin = new Padding(3, 4, 3, 4);
            dataGridTratamientos.Name = "dataGridTratamientos";
            dataGridTratamientos.RowHeadersWidth = 51;
            dataGridTratamientos.Size = new Size(622, 241);
            dataGridTratamientos.TabIndex = 7;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(9, 4);
            label14.Name = "label14";
            label14.Size = new Size(115, 23);
            label14.TabIndex = 6;
            label14.Text = "Tratamientos";
            // 
            // tabPagos
            // 
            tabPagos.Controls.Add(dataGridPagos);
            tabPagos.Controls.Add(label15);
            tabPagos.Location = new Point(4, 29);
            tabPagos.Margin = new Padding(3, 4, 3, 4);
            tabPagos.Name = "tabPagos";
            tabPagos.Padding = new Padding(3, 4, 3, 4);
            tabPagos.Size = new Size(906, 338);
            tabPagos.TabIndex = 3;
            tabPagos.Text = "Pagos";
            tabPagos.UseVisualStyleBackColor = true;
            // 
            // dataGridPagos
            // 
            dataGridPagos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridPagos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridPagos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridPagos.Location = new Point(9, 31);
            dataGridPagos.Margin = new Padding(3, 4, 3, 4);
            dataGridPagos.Name = "dataGridPagos";
            dataGridPagos.RowHeadersWidth = 51;
            dataGridPagos.Size = new Size(622, 241);
            dataGridPagos.TabIndex = 7;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(9, 4);
            label15.Name = "label15";
            label15.Size = new Size(57, 23);
            label15.TabIndex = 6;
            label15.Text = "Pagos";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(224, 224, 224);
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
            panel3.Location = new Point(0, 52);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(914, 177);
            panel3.TabIndex = 1;
            // 
            // txtFechaNacimiento
            // 
            txtFechaNacimiento.Location = new Point(786, 57);
            txtFechaNacimiento.Margin = new Padding(3, 4, 3, 4);
            txtFechaNacimiento.Name = "txtFechaNacimiento";
            txtFechaNacimiento.ReadOnly = true;
            txtFechaNacimiento.Size = new Size(114, 27);
            txtFechaNacimiento.TabIndex = 7;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(281, 135);
            txtDireccion.Margin = new Padding(3, 4, 3, 4);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.ReadOnly = true;
            txtDireccion.Size = new Size(114, 27);
            txtDireccion.TabIndex = 7;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(646, 68);
            label10.Name = "label10";
            label10.Size = new Size(146, 20);
            label10.TabIndex = 6;
            label10.Text = "Fecha de nacimiento";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(209, 145);
            label7.Name = "label7";
            label7.Size = new Size(72, 20);
            label7.TabIndex = 6;
            label7.Text = "Direccion";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(79, 135);
            txtApellido.Margin = new Padding(3, 4, 3, 4);
            txtApellido.Name = "txtApellido";
            txtApellido.ReadOnly = true;
            txtApellido.Size = new Size(114, 27);
            txtApellido.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 145);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 6;
            label4.Text = "Apellido";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(521, 96);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(114, 27);
            txtEmail.TabIndex = 7;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(281, 96);
            txtDNI.Margin = new Padding(3, 4, 3, 4);
            txtDNI.Name = "txtDNI";
            txtDNI.ReadOnly = true;
            txtDNI.Size = new Size(114, 27);
            txtDNI.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(473, 107);
            label9.Name = "label9";
            label9.Size = new Size(46, 20);
            label9.TabIndex = 6;
            label9.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(243, 107);
            label6.Name = "label6";
            label6.Size = new Size(35, 20);
            label6.TabIndex = 6;
            label6.Text = "DNI";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(79, 96);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.ReadOnly = true;
            txtNombre.Size = new Size(114, 27);
            txtNombre.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 107);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 6;
            label3.Text = "Nombre";
            // 
            // txtTipoSangre
            // 
            txtTipoSangre.Location = new Point(521, 135);
            txtTipoSangre.Margin = new Padding(3, 4, 3, 4);
            txtTipoSangre.Name = "txtTipoSangre";
            txtTipoSangre.ReadOnly = true;
            txtTipoSangre.Size = new Size(114, 27);
            txtTipoSangre.TabIndex = 7;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(417, 145);
            label11.Name = "label11";
            label11.Size = new Size(108, 20);
            label11.TabIndex = 6;
            label11.Text = "Tipo de sangre";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(521, 57);
            txtTelefono.Margin = new Padding(3, 4, 3, 4);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.ReadOnly = true;
            txtTelefono.Size = new Size(114, 27);
            txtTelefono.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(454, 68);
            label8.Name = "label8";
            label8.Size = new Size(67, 20);
            label8.TabIndex = 6;
            label8.Text = "Telefono";
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(281, 57);
            txtEdad.Margin = new Padding(3, 4, 3, 4);
            txtEdad.Name = "txtEdad";
            txtEdad.ReadOnly = true;
            txtEdad.Size = new Size(114, 27);
            txtEdad.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(237, 68);
            label5.Name = "label5";
            label5.Size = new Size(43, 20);
            label5.TabIndex = 6;
            label5.Text = "Edad";
            // 
            // txtID
            // 
            txtID.Location = new Point(79, 57);
            txtID.Margin = new Padding(3, 4, 3, 4);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(114, 27);
            txtID.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 68);
            label2.Name = "label2";
            label2.Size = new Size(24, 20);
            label2.TabIndex = 6;
            label2.Text = "ID";
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.Location = new Point(219, 12);
            btnSeleccionar.Margin = new Padding(3, 4, 3, 4);
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.Size = new Size(155, 33);
            btnSeleccionar.TabIndex = 5;
            btnSeleccionar.Text = "Seleccionar paciente";
            btnSeleccionar.UseVisualStyleBackColor = true;
            btnSeleccionar.Click += btnSeleccionar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 12);
            label1.Name = "label1";
            label1.Size = new Size(213, 31);
            label1.TabIndex = 4;
            label1.Text = "Historial clinico";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(224, 224, 224);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(914, 52);
            panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Dock = DockStyle.Right;
            pictureBox1.Image = Properties.Resources.circle_xmark_solid;
            pictureBox1.Location = new Point(876, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(38, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(637, 31);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(94, 29);
            btnActualizar.TabIndex = 6;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // FHistorialClinico
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
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