namespace CapaPresentación.SecondWindows.Tratamientos
{
    partial class FAgregarTratamiento
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
            btnSeleccionar = new Button();
            btnCancelar = new Button();
            btnGuardar = new Button();
            txtDescripcion = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtTratamiento = new TextBox();
            label1 = new Label();
            txtID = new TextBox();
            label5 = new Label();
            dateInicio = new DateTimePicker();
            dateFin = new DateTimePicker();
            SuspendLayout();
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.Location = new Point(286, 93);
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.Size = new Size(110, 52);
            btnSeleccionar.TabIndex = 8;
            btnSeleccionar.Text = "Seleccionar Paciente";
            btnSeleccionar.UseVisualStyleBackColor = true;
            btnSeleccionar.Click += btnSeleccionar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(314, 285);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(82, 22);
            btnCancelar.TabIndex = 17;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(129, 285);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(82, 22);
            btnGuardar.TabIndex = 16;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(129, 165);
            txtDescripcion.Margin = new Padding(3, 2, 3, 2);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.ScrollBars = ScrollBars.Vertical;
            txtDescripcion.Size = new Size(268, 104);
            txtDescripcion.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 165);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 14;
            label4.Text = "Descripcion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 92);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 15;
            label3.Text = "Fecha inicio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 60);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 12;
            label2.Text = "Tratamiento";
            // 
            // txtTratamiento
            // 
            txtTratamiento.Location = new Point(139, 52);
            txtTratamiento.Margin = new Padding(3, 2, 3, 2);
            txtTratamiento.Name = "txtTratamiento";
            txtTratamiento.Size = new Size(110, 23);
            txtTratamiento.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 27);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 9;
            label1.Text = "ID Paciente";
            // 
            // txtID
            // 
            txtID.Location = new Point(139, 19);
            txtID.Margin = new Padding(3, 2, 3, 2);
            txtID.Name = "txtID";
            txtID.Size = new Size(110, 23);
            txtID.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(78, 130);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 15;
            label5.Text = "Fecha fin";
            // 
            // dateInicio
            // 
            dateInicio.Location = new Point(139, 86);
            dateInicio.Name = "dateInicio";
            dateInicio.Size = new Size(110, 23);
            dateInicio.TabIndex = 18;
            // 
            // dateFin
            // 
            dateFin.Location = new Point(139, 124);
            dateFin.Name = "dateFin";
            dateFin.Size = new Size(110, 23);
            dateFin.TabIndex = 18;
            // 
            // FAgregarTratamiento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 329);
            Controls.Add(dateFin);
            Controls.Add(dateInicio);
            Controls.Add(btnSeleccionar);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(txtDescripcion);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtTratamiento);
            Controls.Add(label1);
            Controls.Add(txtID);
            Name = "FAgregarTratamiento";
            Text = "Agregar Tratamiento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSeleccionar;
        private Button btnCancelar;
        private Button btnGuardar;
        private TextBox txtDescripcion;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtTratamiento;
        private Label label1;
        private TextBox txtID;
        private Label label5;
        private DateTimePicker dateInicio;
        private DateTimePicker dateFin;
    }
}