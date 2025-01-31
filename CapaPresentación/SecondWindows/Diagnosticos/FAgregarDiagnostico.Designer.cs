namespace CapaPresentación.SecondWindows.Diagnosticos
{
    partial class FAgregarDiagnostico
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
            label2 = new Label();
            txtFecha = new TextBox();
            label1 = new Label();
            txtID = new TextBox();
            SuspendLayout();
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.Location = new Point(264, 45);
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.Size = new Size(110, 52);
            btnSeleccionar.TabIndex = 1;
            btnSeleccionar.Text = "Seleccionar Paciente";
            btnSeleccionar.UseVisualStyleBackColor = true;
            btnSeleccionar.Click += btnSeleccionar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(301, 231);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(82, 22);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(116, 231);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(82, 22);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(116, 111);
            txtDescripcion.Margin = new Padding(3, 2, 3, 2);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.ScrollBars = ScrollBars.Vertical;
            txtDescripcion.Size = new Size(268, 104);
            txtDescripcion.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 111);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 12;
            label4.Text = "Descripcion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 82);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 11;
            label2.Text = "Fecha";
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(116, 74);
            txtFecha.Margin = new Padding(3, 2, 3, 2);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(110, 23);
            txtFecha.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 49);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 9;
            label1.Text = "ID Paciente";
            // 
            // txtID
            // 
            txtID.Location = new Point(116, 41);
            txtID.Margin = new Padding(3, 2, 3, 2);
            txtID.Name = "txtID";
            txtID.Size = new Size(110, 23);
            txtID.TabIndex = 0;
            // 
            // FAgregarDiagnostico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 354);
            Controls.Add(btnSeleccionar);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(txtDescripcion);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(txtFecha);
            Controls.Add(label1);
            Controls.Add(txtID);
            Name = "FAgregarDiagnostico";
            Text = "Agregar Diagnostico";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSeleccionar;
        private Button btnCancelar;
        private Button btnGuardar;
        private TextBox txtDescripcion;
        private Label label4;
        private Label label2;
        private TextBox txtFecha;
        private Label label1;
        private TextBox txtID;
    }
}