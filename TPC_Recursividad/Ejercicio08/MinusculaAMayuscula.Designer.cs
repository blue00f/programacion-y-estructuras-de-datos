namespace Ejercicio08
{
    partial class frmConversionAMayus
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
            txtCadena = new TextBox();
            txtCadenaMayus = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnConvertir
            // 
            btnConvertir.Location = new Point(156, 129);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(184, 36);
            btnConvertir.TabIndex = 0;
            btnConvertir.Text = "Convertir a mayúsculas";
            btnConvertir.UseVisualStyleBackColor = true;
            btnConvertir.Click += btnConvertir_Click;
            // 
            // txtCadena
            // 
            txtCadena.Location = new Point(260, 64);
            txtCadena.Name = "txtCadena";
            txtCadena.Size = new Size(184, 23);
            txtCadena.TabIndex = 1;
            // 
            // txtCadenaMayus
            // 
            txtCadenaMayus.Location = new Point(48, 64);
            txtCadenaMayus.Name = "txtCadenaMayus";
            txtCadenaMayus.ReadOnly = true;
            txtCadenaMayus.Size = new Size(184, 23);
            txtCadenaMayus.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 34);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 3;
            label1.Text = "Ingresar texto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(260, 34);
            label2.Name = "label2";
            label2.Size = new Size(169, 15);
            label2.TabIndex = 4;
            label2.Text = "Texto convertido a mayúsculas";
            // 
            // frmConversionAMayus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(486, 198);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCadenaMayus);
            Controls.Add(txtCadena);
            Controls.Add(btnConvertir);
            Name = "frmConversionAMayus";
            Text = "Conversión de minúsculas a mayúsculas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConvertir;
        private TextBox txtCadena;
        private TextBox txtCadenaMayus;
        private Label label1;
        private Label label2;
    }
}
