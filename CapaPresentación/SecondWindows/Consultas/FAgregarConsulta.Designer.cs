namespace CapaPresentación.SecondWindows.Consultas
{
    partial class FAgregarConsulta
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
            txtDNI = new TextBox();
            label1 = new Label();
            txtFecha = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtMotivo = new TextBox();
            label4 = new Label();
            txtObservaciones = new TextBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            btnSeleccionar = new Button();
            SuspendLayout();
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(141, 50);
            txtDNI.Margin = new Padding(3, 2, 3, 2);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(110, 23);
            txtDNI.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 53);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 1;
            label1.Text = "ID Paciente";
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(141, 83);
            txtFecha.Margin = new Padding(3, 2, 3, 2);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(110, 23);
            txtFecha.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(94, 88);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 3;
            label2.Text = "Fecha";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(87, 120);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 4;
            label3.Text = "Motivo";
            // 
            // txtMotivo
            // 
            txtMotivo.Location = new Point(141, 115);
            txtMotivo.Margin = new Padding(3, 2, 3, 2);
            txtMotivo.Name = "txtMotivo";
            txtMotivo.Size = new Size(110, 23);
            txtMotivo.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 153);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 4;
            label4.Text = "Observaciones";
            // 
            // txtObservaciones
            // 
            txtObservaciones.Location = new Point(141, 148);
            txtObservaciones.Margin = new Padding(3, 2, 3, 2);
            txtObservaciones.Multiline = true;
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.ScrollBars = ScrollBars.Vertical;
            txtObservaciones.Size = new Size(268, 104);
            txtObservaciones.TabIndex = 4;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(141, 268);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(82, 22);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(326, 268);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(82, 22);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.Location = new Point(289, 69);
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.Size = new Size(110, 52);
            btnSeleccionar.TabIndex = 1;
            btnSeleccionar.Text = "Seleccionar Paciente";
            btnSeleccionar.UseVisualStyleBackColor = true;
            btnSeleccionar.Click += btnSeleccionar_Click;
            // 
            // FAgregarConsulta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 316);
            Controls.Add(btnSeleccionar);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(txtObservaciones);
            Controls.Add(txtMotivo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtFecha);
            Controls.Add(label1);
            Controls.Add(txtDNI);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FAgregarConsulta";
            Text = "Agregar Consulta";
            Load += FAgregarConsulta_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDNI;
        private Label label1;
        private TextBox txtFecha;
        private Label label2;
        private Label label3;
        private TextBox txtMotivo;
        private Label label4;
        private TextBox txtObservaciones;
        private Button btnGuardar;
        private Button btnCancelar;
        private Button btnSeleccionar;
    }
}