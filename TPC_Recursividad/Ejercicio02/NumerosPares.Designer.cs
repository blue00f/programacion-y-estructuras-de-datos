namespace Ejercicio02
{
    partial class frmMostrarPares
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
            txtResultado = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnEjecutar
            // 
            btnEjecutar.Location = new Point(37, 115);
            btnEjecutar.Name = "btnEjecutar";
            btnEjecutar.Size = new Size(110, 39);
            btnEjecutar.TabIndex = 0;
            btnEjecutar.Text = "Ejecutar";
            btnEjecutar.UseVisualStyleBackColor = true;
            btnEjecutar.Click += btnEjecutar_Click;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(37, 54);
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(548, 23);
            txtResultado.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 36);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 2;
            label1.Text = "Números pares";
            // 
            // frmMostrarPares
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 220);
            Controls.Add(label1);
            Controls.Add(txtResultado);
            Controls.Add(btnEjecutar);
            Name = "frmMostrarPares";
            Text = "Mostrar números pares";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEjecutar;
        private TextBox txtResultado;
        private Label label1;
    }
}
