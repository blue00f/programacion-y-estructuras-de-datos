namespace EjRecursividad02
{
    partial class frmFactorial
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
            label1 = new Label();
            txtNumero = new TextBox();
            btnCalcular = new Button();
            txtResultado = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 69);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Número";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(41, 87);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(122, 23);
            txtNumero.TabIndex = 1;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(41, 128);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(122, 23);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "Calcular factorial";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(232, 87);
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(100, 23);
            txtResultado.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(232, 69);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 4;
            label2.Text = "Resultado";
            // 
            // frmFactorial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 224);
            Controls.Add(label2);
            Controls.Add(txtResultado);
            Controls.Add(btnCalcular);
            Controls.Add(txtNumero);
            Controls.Add(label1);
            Name = "frmFactorial";
            Text = "Factorial de un número";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumero;
        private Button btnCalcular;
        private TextBox txtResultado;
        private Label label2;
    }
}
