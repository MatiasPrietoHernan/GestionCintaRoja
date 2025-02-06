namespace CapaPresentación.SecondWindows.Exportacion
{
    partial class FExportar
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
            comboBox1 = new ComboBox();
            label1 = new Label();
            btnExcel = new Button();
            btnPdf = new Button();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(57, 67);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(57, 28);
            label1.Name = "label1";
            label1.Size = new Size(147, 25);
            label1.TabIndex = 1;
            label1.Text = "Tabla a Exportar";
            // 
            // btnExcel
            // 
            btnExcel.Location = new Point(33, 126);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(81, 45);
            btnExcel.TabIndex = 2;
            btnExcel.Text = "Exportar a Excel";
            btnExcel.UseVisualStyleBackColor = true;
            btnExcel.Click += btnExcel_Click;
            // 
            // btnPdf
            // 
            btnPdf.Location = new Point(164, 126);
            btnPdf.Name = "btnPdf";
            btnPdf.Size = new Size(81, 45);
            btnPdf.TabIndex = 2;
            btnPdf.Text = "Exportar a PDF";
            btnPdf.UseVisualStyleBackColor = true;
            btnPdf.Click += btnPdf_Click;
            // 
            // FExportar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(299, 267);
            Controls.Add(btnPdf);
            Controls.Add(btnExcel);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Name = "FExportar";
            Text = "FExportar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private Button btnExcel;
        private Button btnPdf;
    }
}