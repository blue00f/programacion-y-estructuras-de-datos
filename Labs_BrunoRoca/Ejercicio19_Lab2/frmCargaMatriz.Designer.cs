namespace Ejercicio19_Lab2
{
    partial class frmCargaMatriz
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
            btnCargar = new Button();
            btnSalir = new Button();
            lst1 = new ListBox();
            SuspendLayout();
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(42, 38);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(221, 23);
            btnCargar.TabIndex = 0;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(42, 289);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(221, 23);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // lst1
            // 
            lst1.FormattingEnabled = true;
            lst1.ItemHeight = 15;
            lst1.Location = new Point(42, 102);
            lst1.Name = "lst1";
            lst1.Size = new Size(221, 154);
            lst1.TabIndex = 2;
            // 
            // frmCargaMatriz
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(319, 386);
            Controls.Add(lst1);
            Controls.Add(btnSalir);
            Controls.Add(btnCargar);
            Name = "frmCargaMatriz";
            Text = "Carga Matrices";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCargar;
        private Button btnSalir;
        private ListBox lst1;
    }
}