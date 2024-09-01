namespace Ejercicio22_Lab2
{
    partial class frmBarraProgreso
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
            btnComenzar = new Button();
            progressBar1 = new ProgressBar();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // btnComenzar
            // 
            btnComenzar.Location = new Point(122, 54);
            btnComenzar.Name = "btnComenzar";
            btnComenzar.Size = new Size(75, 23);
            btnComenzar.TabIndex = 0;
            btnComenzar.Text = "Comenzar";
            btnComenzar.UseVisualStyleBackColor = true;
            btnComenzar.Click += btnComenzar_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(33, 195);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(245, 23);
            progressBar1.TabIndex = 1;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(122, 254);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // frmBarraProgreso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(308, 326);
            Controls.Add(btnSalir);
            Controls.Add(progressBar1);
            Controls.Add(btnComenzar);
            Name = "frmBarraProgreso";
            Text = "Barra de progreso";
            ResumeLayout(false);
        }

        #endregion

        private Button btnComenzar;
        private ProgressBar progressBar1;
        private Button btnSalir;
    }
}