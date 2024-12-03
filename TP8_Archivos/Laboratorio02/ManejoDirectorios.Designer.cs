namespace Laboratorio02
{
    partial class ManejoDirectorios
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
            lstContenido = new ListBox();
            lstUnidades = new ListBox();
            txtRuta = new TextBox();
            btnContenido = new Button();
            btnSalir = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            btnSeleccionarCarpeta = new Button();
            SuspendLayout();
            // 
            // lstContenido
            // 
            lstContenido.FormattingEnabled = true;
            lstContenido.ItemHeight = 15;
            lstContenido.Location = new Point(29, 90);
            lstContenido.Name = "lstContenido";
            lstContenido.Size = new Size(372, 319);
            lstContenido.TabIndex = 0;
            // 
            // lstUnidades
            // 
            lstUnidades.FormattingEnabled = true;
            lstUnidades.ItemHeight = 15;
            lstUnidades.Location = new Point(531, 50);
            lstUnidades.Name = "lstUnidades";
            lstUnidades.Size = new Size(118, 139);
            lstUnidades.TabIndex = 1;
            // 
            // txtRuta
            // 
            txtRuta.Location = new Point(29, 50);
            txtRuta.Name = "txtRuta";
            txtRuta.Size = new Size(372, 23);
            txtRuta.TabIndex = 2;
            // 
            // btnContenido
            // 
            btnContenido.Location = new Point(428, 50);
            btnContenido.Name = "btnContenido";
            btnContenido.Size = new Size(75, 23);
            btnContenido.TabIndex = 3;
            btnContenido.Text = "Contenido";
            btnContenido.UseVisualStyleBackColor = true;
            btnContenido.Click += btnContenido_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(531, 209);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(118, 23);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnSeleccionarCarpeta
            // 
            btnSeleccionarCarpeta.Location = new Point(29, 21);
            btnSeleccionarCarpeta.Name = "btnSeleccionarCarpeta";
            btnSeleccionarCarpeta.Size = new Size(169, 23);
            btnSeleccionarCarpeta.TabIndex = 5;
            btnSeleccionarCarpeta.Text = "Seleccionar carpeta";
            btnSeleccionarCarpeta.UseVisualStyleBackColor = true;
            btnSeleccionarCarpeta.Click += btnSeleccionarCarpeta_Click;
            // 
            // ManejoDirectorios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(674, 450);
            Controls.Add(btnSeleccionarCarpeta);
            Controls.Add(btnSalir);
            Controls.Add(btnContenido);
            Controls.Add(txtRuta);
            Controls.Add(lstUnidades);
            Controls.Add(lstContenido);
            Name = "ManejoDirectorios";
            Text = "Manejo de directorios";
            Load += ManejoDirectorios_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstContenido;
        private ListBox lstUnidades;
        private TextBox txtRuta;
        private Button btnContenido;
        private Button btnSalir;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button btnSeleccionarCarpeta;
    }
}
