namespace Ejercicio03
{
    partial class frmSumaDeNumeros
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
            btnSumar = new Button();
            label1 = new Label();
            txtCantidadNumeros = new TextBox();
            txtNumerosIngresados = new TextBox();
            label3 = new Label();
            label4 = new Label();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // btnSumar
            // 
            btnSumar.Location = new Point(241, 234);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(101, 32);
            btnSumar.TabIndex = 0;
            btnSumar.Text = "Sumar";
            btnSumar.UseVisualStyleBackColor = true;
            btnSumar.Click += btnSumar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 70);
            label1.Name = "label1";
            label1.Size = new Size(175, 15);
            label1.TabIndex = 2;
            label1.Text = "Cantidad de numeros a ingresar";
            // 
            // txtCantidadNumeros
            // 
            txtCantidadNumeros.Location = new Point(208, 67);
            txtCantidadNumeros.Name = "txtCantidadNumeros";
            txtCantidadNumeros.Size = new Size(177, 23);
            txtCantidadNumeros.TabIndex = 3;
            // 
            // txtNumerosIngresados
            // 
            txtNumerosIngresados.Location = new Point(208, 126);
            txtNumerosIngresados.Name = "txtNumerosIngresados";
            txtNumerosIngresados.ReadOnly = true;
            txtNumerosIngresados.Size = new Size(177, 23);
            txtNumerosIngresados.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 129);
            label3.Name = "label3";
            label3.Size = new Size(116, 15);
            label3.TabIndex = 6;
            label3.Text = "Números ingresados";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(68, 176);
            label4.Name = "label4";
            label4.Size = new Size(119, 15);
            label4.TabIndex = 7;
            label4.Text = "Resultado de la suma";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(252, 176);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 15);
            lblResultado.TabIndex = 8;
            // 
            // frmSumaDeNumeros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 296);
            Controls.Add(lblResultado);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtNumerosIngresados);
            Controls.Add(txtCantidadNumeros);
            Controls.Add(label1);
            Controls.Add(btnSumar);
            Name = "frmSumaDeNumeros";
            Text = "Suma de n numeros";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSumar;
        private Label label1;
        private TextBox txtCantidadNumeros;
        private TextBox txtNumerosIngresados;
        private Label label3;
        private Label label4;
        private Label lblResultado;
    }
}
