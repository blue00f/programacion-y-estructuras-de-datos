namespace Ejercicio20_Lab2
{
    partial class frmOperacionesVector
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
            btnCargar = new Button();
            btnOrdenar = new Button();
            btnCopiar = new Button();
            btnLimites = new Button();
            btnBusqBinaria = new Button();
            btnSalir = new Button();
            lst1 = new ListBox();
            SuspendLayout();
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(198, 57);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(98, 23);
            btnCargar.TabIndex = 0;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // btnOrdenar
            // 
            btnOrdenar.Location = new Point(263, 224);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(98, 23);
            btnOrdenar.TabIndex = 1;
            btnOrdenar.Text = "Ordenar";
            btnOrdenar.UseVisualStyleBackColor = true;
            btnOrdenar.Click += btnOrdenar_Click;
            // 
            // btnCopiar
            // 
            btnCopiar.Location = new Point(140, 224);
            btnCopiar.Name = "btnCopiar";
            btnCopiar.Size = new Size(98, 23);
            btnCopiar.TabIndex = 2;
            btnCopiar.Text = "Copiar";
            btnCopiar.UseVisualStyleBackColor = true;
            btnCopiar.Click += btnCopiar_Click;
            // 
            // btnLimites
            // 
            btnLimites.Location = new Point(140, 264);
            btnLimites.Name = "btnLimites";
            btnLimites.Size = new Size(98, 23);
            btnLimites.TabIndex = 3;
            btnLimites.Text = "Limites";
            btnLimites.UseVisualStyleBackColor = true;
            btnLimites.Click += btnLimites_Click;
            // 
            // btnBusqBinaria
            // 
            btnBusqBinaria.Location = new Point(263, 264);
            btnBusqBinaria.Name = "btnBusqBinaria";
            btnBusqBinaria.Size = new Size(98, 23);
            btnBusqBinaria.TabIndex = 4;
            btnBusqBinaria.Text = "Busq Binaria";
            btnBusqBinaria.UseVisualStyleBackColor = true;
            btnBusqBinaria.Click += btnBusqBinaria_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(198, 309);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(98, 23);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // lst1
            // 
            lst1.FormattingEnabled = true;
            lst1.ItemHeight = 15;
            lst1.Location = new Point(48, 98);
            lst1.Name = "lst1";
            lst1.Size = new Size(373, 109);
            lst1.TabIndex = 6;
            // 
            // frmOperacionesVector
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(481, 386);
            Controls.Add(lst1);
            Controls.Add(btnSalir);
            Controls.Add(btnBusqBinaria);
            Controls.Add(btnLimites);
            Controls.Add(btnCopiar);
            Controls.Add(btnOrdenar);
            Controls.Add(btnCargar);
            Name = "frmOperacionesVector";
            Text = "Operaciones con Vectores";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCargar;
        private Button btnOrdenar;
        private Button btnCopiar;
        private Button btnLimites;
        private Button btnBusqBinaria;
        private Button btnSalir;
        private ListBox lst1;
    }
}
