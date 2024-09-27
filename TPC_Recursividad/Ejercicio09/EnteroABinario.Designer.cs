namespace Ejercicio09
{
    partial class frmEnteroABinario
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
            btnConvertir = new Button();
            txtBinario = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtEntero = new TextBox();
            SuspendLayout();
            // 
            // btnConvertir
            // 
            btnConvertir.Location = new Point(48, 130);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(144, 39);
            btnConvertir.TabIndex = 0;
            btnConvertir.Text = "Convertir a binario";
            btnConvertir.UseVisualStyleBackColor = true;
            btnConvertir.Click += btnConvertir_Click;
            // 
            // txtBinario
            // 
            txtBinario.Location = new Point(224, 79);
            txtBinario.Name = "txtBinario";
            txtBinario.Size = new Size(147, 23);
            txtBinario.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 52);
            label1.Name = "label1";
            label1.Size = new Size(144, 15);
            label1.TabIndex = 2;
            label1.Text = "Ingresa un número entero";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(224, 52);
            label2.Name = "label2";
            label2.Size = new Size(116, 15);
            label2.TabIndex = 4;
            label2.Text = "Conversión a binario";
            // 
            // txtEntero
            // 
            txtEntero.Location = new Point(48, 79);
            txtEntero.Name = "txtEntero";
            txtEntero.Size = new Size(147, 23);
            txtEntero.TabIndex = 3;
            // 
            // frmEnteroABinario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 211);
            Controls.Add(label2);
            Controls.Add(txtEntero);
            Controls.Add(label1);
            Controls.Add(txtBinario);
            Controls.Add(btnConvertir);
            Name = "frmEnteroABinario";
            Text = "Conversión de entero a binario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConvertir;
        private TextBox txtBinario;
        private Label label1;
        private Label label2;
        private TextBox txtEntero;
    }
}
