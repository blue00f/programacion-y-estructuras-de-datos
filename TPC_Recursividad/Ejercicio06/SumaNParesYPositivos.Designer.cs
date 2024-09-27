namespace Ejercicio06
{
    partial class frmSumaNParesYPositivos
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
            txtNumero = new TextBox();
            label1 = new Label();
            txtSuma = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnSumar
            // 
            btnSumar.Location = new Point(146, 152);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(100, 23);
            btnSumar.TabIndex = 0;
            btnSumar.Text = "Sumar";
            btnSumar.UseVisualStyleBackColor = true;
            btnSumar.Click += btnSumar_Click;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(74, 77);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 47);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 2;
            label1.Text = "Número";
            // 
            // txtSuma
            // 
            txtSuma.Location = new Point(223, 77);
            txtSuma.Name = "txtSuma";
            txtSuma.ReadOnly = true;
            txtSuma.Size = new Size(100, 23);
            txtSuma.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(223, 47);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 4;
            label2.Text = "Suma";
            // 
            // frmSumaNParesYPositivos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 224);
            Controls.Add(label2);
            Controls.Add(txtSuma);
            Controls.Add(label1);
            Controls.Add(txtNumero);
            Controls.Add(btnSumar);
            Name = "frmSumaNParesYPositivos";
            Text = "Sumar a partir de N, números positivos y pares";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSumar;
        private TextBox txtNumero;
        private Label label1;
        private TextBox txtSuma;
        private Label label2;
    }
}
