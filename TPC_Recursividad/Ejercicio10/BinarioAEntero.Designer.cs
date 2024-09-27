namespace Ejercicio10
{
    partial class frmBinarioAEntero
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
            label2 = new Label();
            txtBinario = new TextBox();
            label1 = new Label();
            txtEntero = new TextBox();
            btnConvertir = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(219, 44);
            label2.Name = "label2";
            label2.Size = new Size(113, 15);
            label2.TabIndex = 9;
            label2.Text = "Conversión a entero";
            // 
            // txtBinario
            // 
            txtBinario.Location = new Point(43, 71);
            txtBinario.Name = "txtBinario";
            txtBinario.Size = new Size(147, 23);
            txtBinario.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 44);
            label1.Name = "label1";
            label1.Size = new Size(147, 15);
            label1.TabIndex = 7;
            label1.Text = "Ingresa un número binario";
            // 
            // txtEntero
            // 
            txtEntero.Location = new Point(219, 71);
            txtEntero.Name = "txtEntero";
            txtEntero.ReadOnly = true;
            txtEntero.Size = new Size(147, 23);
            txtEntero.TabIndex = 6;
            // 
            // btnConvertir
            // 
            btnConvertir.Location = new Point(43, 122);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(144, 39);
            btnConvertir.TabIndex = 5;
            btnConvertir.Text = "Convertir a binario";
            btnConvertir.UseVisualStyleBackColor = true;
            btnConvertir.Click += btnConvertir_Click;
            // 
            // frmBinarioAEntero
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 212);
            Controls.Add(label2);
            Controls.Add(txtBinario);
            Controls.Add(label1);
            Controls.Add(txtEntero);
            Controls.Add(btnConvertir);
            Name = "frmBinarioAEntero";
            Text = "Conversión de binario a entero";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox txtBinario;
        private Label label1;
        private TextBox txtEntero;
        private Button btnConvertir;
    }
}
