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
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panelFacturacion.SuspendLayout();
            panelClose.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelFacturacion
            // 
            panelFacturacion.Controls.Add(panelClose);
            panelFacturacion.Dock = DockStyle.Fill;
            panelFacturacion.Location = new Point(0, 0);
            panelFacturacion.Name = "panelFacturacion";
            panelFacturacion.Size = new Size(800, 450);
            panelFacturacion.TabIndex = 0;
            // 
            // panelClose
            // 
            panelClose.Controls.Add(pictureBox2);
            panelClose.Controls.Add(pictureBox1);
            panelClose.Dock = DockStyle.Top;
            panelClose.Location = new Point(0, 0);
            panelClose.Name = "panelClose";
            panelClose.Size = new Size(800, 39);
            panelClose.TabIndex = 10;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Image = Properties.Resources.circle_xmark_solid1;
            pictureBox2.Location = new Point(1364, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(33, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Right;
            pictureBox1.Image = Properties.Resources.circle_xmark_solid1;
            pictureBox1.Location = new Point(767, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(33, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // FFacturacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelFacturacion);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FFacturacion";
            Text = "FFacturacion";
            panelFacturacion.ResumeLayout(false);
            panelClose.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelFacturacion;
        private PictureBox pictureBox1;
        private Panel panelClose;
        private PictureBox pictureBox2;
    }
}