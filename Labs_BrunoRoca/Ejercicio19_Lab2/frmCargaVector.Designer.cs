namespace Ejercicio19_Lab2
{
    partial class frmCargaVector
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
            btnEjecutar = new Button();
            btnSalir = new Button();
            lst1 = new ListBox();
            SuspendLayout();
            // 
            // btnEjecutar
            // 
            btnEjecutar.Location = new Point(42, 38);
            btnEjecutar.Name = "btnEjecutar";
            btnEjecutar.Size = new Size(221, 23);
            btnEjecutar.TabIndex = 0;
            btnEjecutar.Text = "Cargar";
            btnEjecutar.UseVisualStyleBackColor = true;
            btnEjecutar.Click += btnEjecutar_Click;
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
            // frmCargaVector
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(319, 386);
            Controls.Add(lst1);
            Controls.Add(btnSalir);
            Controls.Add(btnEjecutar);
            Name = "frmCargaVector";
            Text = "Carga Vectores";
            ResumeLayout(false);
        }

        #endregion

        private Button btnEjecutar;
        private Button btnSalir;
        private ListBox lst1;
    }
}
