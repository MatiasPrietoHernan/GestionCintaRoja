namespace CapaPresentación.SecondWindows
{
    partial class FTratamientos
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
            panelTratamientos = new Panel();
            panelClose = new Panel();
            pictureBox1 = new PictureBox();
            panelTratamientos.SuspendLayout();
            panelClose.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelTratamientos
            // 
            panelTratamientos.Controls.Add(panelClose);
            panelTratamientos.Dock = DockStyle.Fill;
            panelTratamientos.Location = new Point(0, 0);
            panelTratamientos.Name = "panelTratamientos";
            panelTratamientos.Size = new Size(800, 450);
            panelTratamientos.TabIndex = 0;
            // 
            // panelClose
            // 
            panelClose.Controls.Add(pictureBox1);
            panelClose.Dock = DockStyle.Top;
            panelClose.Location = new Point(0, 0);
            panelClose.Name = "panelClose";
            panelClose.Size = new Size(800, 39);
            panelClose.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Right;
            pictureBox1.Image = Properties.Resources.circle_xmark_solid1;
            pictureBox1.Location = new Point(767, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(33, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // FTratamientos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelTratamientos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FTratamientos";
            Text = "FTratamientos";
            panelTratamientos.ResumeLayout(false);
            panelClose.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTratamientos;
        private Panel panelClose;
        private PictureBox pictureBox1;
    }
}