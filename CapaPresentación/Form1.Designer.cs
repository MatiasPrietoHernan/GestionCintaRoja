﻿namespace CapaPresentación
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnExportar = new Button();
            btnExit = new Button();
            panel2 = new Panel();
            lblLogo = new Label();
            pictureBox1 = new PictureBox();
            btnFacturacion = new Button();
            btnHistorialClinico = new Button();
            btnTratamientos = new Button();
            btnDiagnosticos = new Button();
            btnConsultas = new Button();
            btnPacientes = new Button();
            panelInicio = new Panel();
            panel4 = new Panel();
            panel6 = new Panel();
            pictureBox3 = new PictureBox();
            panel3 = new Panel();
            panel5 = new Panel();
            pictureBox2 = new PictureBox();
            lblTitle = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelInicio.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(29, 53, 87);
            panel1.Controls.Add(btnExportar);
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnFacturacion);
            panel1.Controls.Add(btnHistorialClinico);
            panel1.Controls.Add(btnTratamientos);
            panel1.Controls.Add(btnDiagnosticos);
            panel1.Controls.Add(btnConsultas);
            panel1.Controls.Add(btnPacientes);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 599);
            panel1.TabIndex = 3;
            // 
            // btnExportar
            // 
            btnExportar.BackColor = SystemColors.ControlLight;
            btnExportar.FlatStyle = FlatStyle.Flat;
            btnExportar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExportar.ForeColor = SystemColors.ActiveCaptionText;
            btnExportar.Image = Properties.Resources.file_arrow_down_solid;
            btnExportar.ImageAlign = ContentAlignment.MiddleLeft;
            btnExportar.Location = new Point(2, 472);
            btnExportar.Margin = new Padding(2);
            btnExportar.Name = "btnExportar";
            btnExportar.Padding = new Padding(6, 0, 0, 0);
            btnExportar.Size = new Size(200, 50);
            btnExportar.TabIndex = 7;
            btnExportar.Text = "            Exportar";
            btnExportar.TextAlign = ContentAlignment.MiddleLeft;
            btnExportar.UseVisualStyleBackColor = false;
            btnExportar.Click += btnExportar_Click;
            // 
            // btnExit
            // 
            btnExit.Dock = DockStyle.Bottom;
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Image = Properties.Resources.circle_xmark_solid;
            btnExit.ImageAlign = ContentAlignment.MiddleLeft;
            btnExit.Location = new Point(0, 555);
            btnExit.Margin = new Padding(2, 3, 2, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(200, 44);
            btnExit.TabIndex = 6;
            btnExit.Text = "           Salir";
            btnExit.TextAlign = ContentAlignment.MiddleLeft;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(29, 53, 87);
            panel2.Controls.Add(lblLogo);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 126);
            panel2.TabIndex = 5;
            // 
            // lblLogo
            // 
            lblLogo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblLogo.AutoSize = true;
            lblLogo.Font = new Font("Yu Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogo.ForeColor = SystemColors.Control;
            lblLogo.Location = new Point(114, 54);
            lblLogo.Margin = new Padding(2, 0, 2, 0);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(58, 27);
            lblLogo.TabIndex = 1;
            lblLogo.Text = "GCR";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(29, 53, 87);
            pictureBox1.Image = Properties.Resources.cinta_de_cancer_de_mama;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(2, 3, 2, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(86, 126);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnFacturacion
            // 
            btnFacturacion.BackColor = SystemColors.ControlLight;
            btnFacturacion.FlatStyle = FlatStyle.Flat;
            btnFacturacion.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFacturacion.ForeColor = SystemColors.ActiveCaptionText;
            btnFacturacion.Image = Properties.Resources.file_invoice_dollar_solid;
            btnFacturacion.ImageAlign = ContentAlignment.MiddleLeft;
            btnFacturacion.Location = new Point(0, 418);
            btnFacturacion.Margin = new Padding(2);
            btnFacturacion.Name = "btnFacturacion";
            btnFacturacion.Padding = new Padding(6, 0, 0, 0);
            btnFacturacion.Size = new Size(200, 50);
            btnFacturacion.TabIndex = 4;
            btnFacturacion.Text = "            Facturacion";
            btnFacturacion.TextAlign = ContentAlignment.MiddleLeft;
            btnFacturacion.UseVisualStyleBackColor = false;
            btnFacturacion.Click += btnFacturacion_Click;
            // 
            // btnHistorialClinico
            // 
            btnHistorialClinico.BackColor = SystemColors.ControlLight;
            btnHistorialClinico.FlatStyle = FlatStyle.Flat;
            btnHistorialClinico.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHistorialClinico.ForeColor = SystemColors.ActiveCaptionText;
            btnHistorialClinico.Image = Properties.Resources.folder_open_solid;
            btnHistorialClinico.ImageAlign = ContentAlignment.MiddleLeft;
            btnHistorialClinico.Location = new Point(0, 364);
            btnHistorialClinico.Margin = new Padding(2);
            btnHistorialClinico.Name = "btnHistorialClinico";
            btnHistorialClinico.Padding = new Padding(6, 0, 0, 0);
            btnHistorialClinico.Size = new Size(200, 50);
            btnHistorialClinico.TabIndex = 4;
            btnHistorialClinico.Text = "            Historial clinico";
            btnHistorialClinico.TextAlign = ContentAlignment.MiddleLeft;
            btnHistorialClinico.UseVisualStyleBackColor = false;
            btnHistorialClinico.Click += btnHistorialClinico_Click;
            // 
            // btnTratamientos
            // 
            btnTratamientos.BackColor = SystemColors.ControlLight;
            btnTratamientos.FlatStyle = FlatStyle.Flat;
            btnTratamientos.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTratamientos.ForeColor = SystemColors.ActiveCaptionText;
            btnTratamientos.Image = Properties.Resources.pills_solid;
            btnTratamientos.ImageAlign = ContentAlignment.MiddleLeft;
            btnTratamientos.Location = new Point(0, 310);
            btnTratamientos.Margin = new Padding(2);
            btnTratamientos.Name = "btnTratamientos";
            btnTratamientos.Padding = new Padding(6, 0, 0, 0);
            btnTratamientos.Size = new Size(200, 50);
            btnTratamientos.TabIndex = 4;
            btnTratamientos.Text = "            Tratamientos";
            btnTratamientos.TextAlign = ContentAlignment.MiddleLeft;
            btnTratamientos.UseVisualStyleBackColor = false;
            btnTratamientos.Click += btnTratamientos_Click;
            // 
            // btnDiagnosticos
            // 
            btnDiagnosticos.BackColor = SystemColors.ControlLight;
            btnDiagnosticos.FlatStyle = FlatStyle.Flat;
            btnDiagnosticos.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDiagnosticos.ForeColor = SystemColors.ActiveCaptionText;
            btnDiagnosticos.Image = Properties.Resources.clipboard_list_solid;
            btnDiagnosticos.ImageAlign = ContentAlignment.MiddleLeft;
            btnDiagnosticos.Location = new Point(0, 255);
            btnDiagnosticos.Margin = new Padding(2);
            btnDiagnosticos.Name = "btnDiagnosticos";
            btnDiagnosticos.Padding = new Padding(6, 0, 0, 0);
            btnDiagnosticos.Size = new Size(200, 50);
            btnDiagnosticos.TabIndex = 4;
            btnDiagnosticos.Text = "            Diagnosticos";
            btnDiagnosticos.TextAlign = ContentAlignment.MiddleLeft;
            btnDiagnosticos.UseVisualStyleBackColor = false;
            btnDiagnosticos.Click += btnDiagnosticos_Click;
            // 
            // btnConsultas
            // 
            btnConsultas.BackColor = SystemColors.ControlLight;
            btnConsultas.FlatStyle = FlatStyle.Flat;
            btnConsultas.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConsultas.ForeColor = SystemColors.ActiveCaptionText;
            btnConsultas.Image = Properties.Resources.calendar_days_solid;
            btnConsultas.ImageAlign = ContentAlignment.MiddleLeft;
            btnConsultas.Location = new Point(0, 201);
            btnConsultas.Margin = new Padding(2);
            btnConsultas.Name = "btnConsultas";
            btnConsultas.Padding = new Padding(6, 0, 0, 0);
            btnConsultas.Size = new Size(200, 50);
            btnConsultas.TabIndex = 4;
            btnConsultas.Text = "            Consultas";
            btnConsultas.TextAlign = ContentAlignment.MiddleLeft;
            btnConsultas.UseVisualStyleBackColor = false;
            btnConsultas.Click += btnConsultas_Click;
            // 
            // btnPacientes
            // 
            btnPacientes.BackColor = SystemColors.ControlLight;
            btnPacientes.FlatStyle = FlatStyle.Flat;
            btnPacientes.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPacientes.ForeColor = SystemColors.ActiveCaptionText;
            btnPacientes.Image = Properties.Resources.users_solid;
            btnPacientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnPacientes.Location = new Point(0, 146);
            btnPacientes.Margin = new Padding(2);
            btnPacientes.Name = "btnPacientes";
            btnPacientes.Padding = new Padding(6, 0, 0, 0);
            btnPacientes.Size = new Size(200, 50);
            btnPacientes.TabIndex = 4;
            btnPacientes.Text = "            Pacientes";
            btnPacientes.TextAlign = ContentAlignment.MiddleLeft;
            btnPacientes.UseVisualStyleBackColor = false;
            btnPacientes.Click += btnPacientes_Click;
            // 
            // panelInicio
            // 
            panelInicio.Controls.Add(panel4);
            panelInicio.Controls.Add(panel3);
            panelInicio.Controls.Add(lblTitle);
            panelInicio.Dock = DockStyle.Fill;
            panelInicio.Location = new Point(200, 0);
            panelInicio.Margin = new Padding(2, 3, 2, 3);
            panelInicio.Name = "panelInicio";
            panelInicio.Size = new Size(841, 599);
            panelInicio.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.Controls.Add(panel6);
            panel4.Location = new Point(0, 431);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(841, 167);
            panel4.TabIndex = 11;
            // 
            // panel6
            // 
            panel6.Controls.Add(pictureBox3);
            panel6.Dock = DockStyle.Right;
            panel6.Location = new Point(373, 0);
            panel6.Margin = new Padding(2, 3, 2, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(468, 167);
            panel6.TabIndex = 13;
            // 
            // pictureBox3
            // 
            pictureBox3.Dock = DockStyle.Right;
            pictureBox3.Image = Properties.Resources.ezquina2;
            pictureBox3.Location = new Point(170, 0);
            pictureBox3.Margin = new Padding(2, 3, 2, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(298, 167);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(panel5);
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(841, 167);
            panel3.TabIndex = 10;
            // 
            // panel5
            // 
            panel5.Controls.Add(pictureBox2);
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(0, 0);
            panel5.Margin = new Padding(2, 3, 2, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(393, 167);
            panel5.TabIndex = 12;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Left;
            pictureBox2.Image = Properties.Resources.ezquina1;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Margin = new Padding(2, 3, 2, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(295, 167);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(238, 241);
            lblTitle.Margin = new Padding(2, 0, 2, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(458, 110);
            lblTitle.TabIndex = 9;
            lblTitle.Text = "     ¡Bienvenido!\r\nGestion Cinta Rosa\r\n";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(194, 194, 194);
            ClientSize = new Size(1041, 599);
            Controls.Add(panelInicio);
            Controls.Add(panel1);
            IsMdiContainer = true;
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Gestion Ginecologica";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelInicio.ResumeLayout(false);
            panelInicio.PerformLayout();
            panel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button btnPacientes;
        private Button btnHistorialClinico;
        private Button btnTratamientos;
        private Button btnDiagnosticos;
        private Button btnConsultas;
        private Button btnFacturacion;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button btnExit;
        private Label lblLogo;
        private Panel panelInicio;
        private Label lblTitle;
        private Panel panel3;
        private Panel panel4;
        private Panel panel6;
        private PictureBox pictureBox3;
        private Panel panel5;
        private PictureBox pictureBox2;
        private Button btnExportar;
    }
}
