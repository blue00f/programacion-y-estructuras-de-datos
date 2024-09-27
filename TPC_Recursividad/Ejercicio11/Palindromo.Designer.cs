namespace Ejercicio11
{
    partial class frmPalindromo
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
            txtPalabra = new TextBox();
            label1 = new Label();
            btnVerificarPalabra = new Button();
            SuspendLayout();
            // 
            // txtPalabra
            // 
            txtPalabra.Location = new Point(106, 80);
            txtPalabra.Name = "txtPalabra";
            txtPalabra.Size = new Size(136, 23);
            txtPalabra.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(106, 48);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 1;
            label1.Text = "Ingresar texto";
            // 
            // btnVerificarPalabra
            // 
            btnVerificarPalabra.Location = new Point(106, 121);
            btnVerificarPalabra.Name = "btnVerificarPalabra";
            btnVerificarPalabra.Size = new Size(136, 29);
            btnVerificarPalabra.TabIndex = 2;
            btnVerificarPalabra.Text = "¿Es palíndromo?";
            btnVerificarPalabra.UseVisualStyleBackColor = true;
            btnVerificarPalabra.Click += btnVerificarPalabra_Click;
            // 
            // frmPalindromo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(365, 187);
            Controls.Add(btnVerificarPalabra);
            Controls.Add(label1);
            Controls.Add(txtPalabra);
            Name = "frmPalindromo";
            Text = "Verificar si una palabra es palíndroma";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPalabra;
        private Label label1;
        private Button btnVerificarPalabra;
    }
}
