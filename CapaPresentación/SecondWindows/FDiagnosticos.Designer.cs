namespace CapaPresentación.SecondWindows
{
    partial class FDiagnosticos
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
            panelDiagnosticos = new Panel();
            panelClose = new Panel();
            pictureBox1 = new PictureBox();
            panelDiagnosticos.SuspendLayout();
            panelClose.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelDiagnosticos
            // 
            panelDiagnosticos.Controls.Add(panelClose);
            panelDiagnosticos.Dock = DockStyle.Fill;
            panelDiagnosticos.Location = new Point(0, 0);
            panelDiagnosticos.Margin = new Padding(3, 4, 3, 4);
            panelDiagnosticos.Name = "panelDiagnosticos";
            panelDiagnosticos.Size = new Size(914, 600);
            panelDiagnosticos.TabIndex = 0;
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
            // FDiagnosticos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(panelDiagnosticos);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FDiagnosticos";
            Text = "FDiagnosticos";
            panelDiagnosticos.ResumeLayout(false);
            panelClose.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelDiagnosticos;
        private Panel panelClose;
        private PictureBox pictureBox1;
    }
}