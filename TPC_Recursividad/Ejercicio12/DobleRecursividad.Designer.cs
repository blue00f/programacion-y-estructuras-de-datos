namespace Ejercicio12
{
    partial class frmDobleRecursividad
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
            txtResultados = new TextBox();
            label1 = new Label();
            txtNumero = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtResFinal = new TextBox();
            SuspendLayout();
            // 
            // btnEjecutar
            // 
            btnEjecutar.Location = new Point(30, 310);
            btnEjecutar.Name = "btnEjecutar";
            btnEjecutar.Size = new Size(107, 23);
            btnEjecutar.TabIndex = 0;
            btnEjecutar.Text = "Ejecutar";
            btnEjecutar.UseVisualStyleBackColor = true;
            btnEjecutar.Click += btnEjecutar_Click;
            // 
            // txtResultados
            // 
            txtResultados.Font = new Font("Segoe UI", 9F);
            txtResultados.Location = new Point(30, 59);
            txtResultados.Multiline = true;
            txtResultados.Name = "txtResultados";
            txtResultados.ReadOnly = true;
            txtResultados.Size = new Size(969, 178);
            txtResultados.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 41);
            label1.Name = "label1";
            label1.Size = new Size(208, 15);
            label1.TabIndex = 2;
            label1.Text = "Resultados parciales de la recursividad";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(30, 281);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(107, 23);
            txtNumero.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 263);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 4;
            label2.Text = "Ingrese un número";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(162, 263);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 6;
            label3.Text = "Resultado final";
            // 
            // txtResFinal
            // 
            txtResFinal.Location = new Point(162, 281);
            txtResFinal.Name = "txtResFinal";
            txtResFinal.ReadOnly = true;
            txtResFinal.Size = new Size(107, 23);
            txtResFinal.TabIndex = 5;
            // 
            // frmDobleRecursividad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1048, 376);
            Controls.Add(label3);
            Controls.Add(txtResFinal);
            Controls.Add(label2);
            Controls.Add(txtNumero);
            Controls.Add(label1);
            Controls.Add(txtResultados);
            Controls.Add(btnEjecutar);
            Name = "frmDobleRecursividad";
            Text = "Doble recursividad";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEjecutar;
        private TextBox txtResultados;
        private Label label1;
        private TextBox txtNumero;
        private Label label2;
        private Label label3;
        private TextBox txtResFinal;
    }
}
