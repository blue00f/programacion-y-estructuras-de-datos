namespace Ejercicio06
{
    partial class frmSucesionFibonacci
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
            txtCantidadNumeros = new TextBox();
            btnCalcularNumerosFib = new Button();
            lstNumerosFib = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 65);
            label1.Name = "label1";
            label1.Size = new Size(228, 15);
            label1.TabIndex = 0;
            label1.Text = "Cantidad de números Fibonacci a mostrar";
            // 
            // txtCantidadNumeros
            // 
            txtCantidadNumeros.Location = new Point(247, 62);
            txtCantidadNumeros.Name = "txtCantidadNumeros";
            txtCantidadNumeros.Size = new Size(118, 23);
            txtCantidadNumeros.TabIndex = 1;
            // 
            // btnCalcularNumerosFib
            // 
            btnCalcularNumerosFib.Location = new Point(46, 257);
            btnCalcularNumerosFib.Name = "btnCalcularNumerosFib";
            btnCalcularNumerosFib.Size = new Size(310, 41);
            btnCalcularNumerosFib.TabIndex = 2;
            btnCalcularNumerosFib.Text = "Calcular";
            btnCalcularNumerosFib.UseVisualStyleBackColor = true;
            btnCalcularNumerosFib.Click += btnCalcularNumerosFib_Click;
            // 
            // lstNumerosFib
            // 
            lstNumerosFib.FormattingEnabled = true;
            lstNumerosFib.ItemHeight = 15;
            lstNumerosFib.Location = new Point(46, 125);
            lstNumerosFib.MultiColumn = true;
            lstNumerosFib.Name = "lstNumerosFib";
            lstNumerosFib.Size = new Size(310, 94);
            lstNumerosFib.TabIndex = 3;
            // 
            // frmSucesionFibonacci
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 396);
            Controls.Add(lstNumerosFib);
            Controls.Add(btnCalcularNumerosFib);
            Controls.Add(txtCantidadNumeros);
            Controls.Add(label1);
            Name = "frmSucesionFibonacci";
            Text = "Sucesión de Fibonacci";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCantidadNumeros;
        private Button btnCalcularNumerosFib;
        private ListBox lstNumerosFib;
    }
}
