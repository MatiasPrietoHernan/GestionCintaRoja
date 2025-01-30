namespace CapaPresentación.SecondWindows.GlobalWidows
{
    partial class GlobalPacientes
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
            listView1 = new ListView();
            txtBuscador = new TextBox();
            btnBuscar = new Button();
            btnActualizar = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Location = new Point(32, 23);
            listView1.Name = "listView1";
            listView1.Size = new Size(531, 325);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.DoubleClick += listView1_DoubleClick;
            // 
            // txtBuscador
            // 
            txtBuscador.Location = new Point(594, 49);
            txtBuscador.Name = "txtBuscador";
            txtBuscador.Size = new Size(118, 23);
            txtBuscador.TabIndex = 1;
            txtBuscador.KeyDown += txtBuscador_KeyDown;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(660, 78);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(70, 28);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(583, 78);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(70, 28);
            btnActualizar.TabIndex = 3;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // GlobalPacientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(736, 392);
            Controls.Add(btnActualizar);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscador);
            Controls.Add(listView1);
            Name = "GlobalPacientes";
            Text = "GlobalPacientes";
            Load += GlobalPacientes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private TextBox txtBuscador;
        private Button btnBuscar;
        private Button btnActualizar;
    }
}