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
            panelFacturacion = new Panel();
            panelClose = new Panel();
            pictureBox1 = new PictureBox();
            panelFacturacion.SuspendLayout();
            panelClose.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelFacturacion
            // 
            panelFacturacion.Controls.Add(panelClose);
            panelFacturacion.Dock = DockStyle.Fill;
            panelFacturacion.Location = new Point(0, 0);
            panelFacturacion.Margin = new Padding(3, 4, 3, 4);
            panelFacturacion.Name = "panelFacturacion";
            panelFacturacion.Size = new Size(914, 600);
            panelFacturacion.TabIndex = 0;
            // 
            // panelClose
            // 
            panelClose.Controls.Add(pictureBox1);
            panelClose.Dock = DockStyle.Top;
            panelClose.Location = new Point(0, 0);
            panelClose.Margin = new Padding(3, 4, 3, 4);
            panelClose.Name = "panelClose";
            panelClose.Size = new Size(914, 52);
            panelClose.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Dock = DockStyle.Right;
            pictureBox1.Image = Properties.Resources.circle_xmark_solid1;
            pictureBox1.Location = new Point(876, 0);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(38, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // FFacturacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(panelFacturacion);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FFacturacion";
            Text = "FFacturacion";
            panelFacturacion.ResumeLayout(false);
            panelClose.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelFacturacion;
        private Panel panelClose;
        private PictureBox pictureBox1;
    }
}