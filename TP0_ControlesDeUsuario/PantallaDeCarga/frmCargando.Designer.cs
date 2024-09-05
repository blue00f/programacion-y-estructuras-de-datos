namespace Ejemplo05
{
    partial class frmCargando
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            progressBar1 = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 215);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(517, 23);
            progressBar1.TabIndex = 0;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            label1.Location = new Point(146, 90);
            label1.Name = "label1";
            label1.Size = new Size(235, 51);
            label1.TabIndex = 1;
            label1.Text = "Cargando ...";
            // 
            // frmCargando
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(541, 250);
            Controls.Add(label1);
            Controls.Add(progressBar1);
            Cursor = Cursors.AppStarting;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmCargando";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cargando aplicación";
            TopMost = true;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
    }
}
