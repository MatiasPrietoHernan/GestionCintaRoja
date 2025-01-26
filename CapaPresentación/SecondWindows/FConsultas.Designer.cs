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
            dataGridView1 = new DataGridView();
            lblTituloPacientes = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(44, 52);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(577, 314);
            dataGridView1.TabIndex = 1;
            // 
            // lblTituloPacientes
            // 
            lblTituloPacientes.AutoSize = true;
            lblTituloPacientes.Font = new Font("Roboto", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloPacientes.Location = new Point(44, 24);
            lblTituloPacientes.Name = "lblTituloPacientes";
            lblTituloPacientes.Size = new Size(183, 25);
            lblTituloPacientes.TabIndex = 2;
            lblTituloPacientes.Text = "Lista de pacientes";
            // 
            // FConsultas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTituloPacientes);
            Controls.Add(dataGridView1);
            Name = "FConsultas";
            Text = "FConsultas";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label lblTituloPacientes;
    }
}