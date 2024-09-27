namespace Ejercicio05
{
    partial class frmSumaRango
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
            label1 = new Label();
            txtN = new TextBox();
            txtDesde = new TextBox();
            txtResultado = new TextBox();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnEjecutar
            // 
            btnEjecutar.Location = new Point(53, 221);
            btnEjecutar.Name = "btnEjecutar";
            btnEjecutar.Size = new Size(100, 23);
            btnEjecutar.TabIndex = 0;
            btnEjecutar.Text = "Ejecutar";
            btnEjecutar.UseVisualStyleBackColor = true;
            btnEjecutar.Click += btnEjecutar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 51);
            label1.Name = "label1";
            label1.Size = new Size(14, 15);
            label1.TabIndex = 1;
            label1.Text = "n";
            // 
            // txtN
            // 
            txtN.Location = new Point(53, 84);
            txtN.Name = "txtN";
            txtN.Size = new Size(100, 23);
            txtN.TabIndex = 2;
            // 
            // txtDesde
            // 
            txtDesde.Location = new Point(53, 165);
            txtDesde.Name = "txtDesde";
            txtDesde.Size = new Size(100, 23);
            txtDesde.TabIndex = 3;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(211, 125);
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(100, 23);
            txtResultado.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 132);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 5;
            label2.Text = "desde";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(211, 92);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 6;
            label3.Text = "resultado";
            // 
            // frmSumaRango
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(348, 289);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtResultado);
            Controls.Add(txtDesde);
            Controls.Add(txtN);
            Controls.Add(label1);
            Controls.Add(btnEjecutar);
            Name = "frmSumaRango";
            Text = "Suma de un rango";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEjecutar;
        private Label label1;
        private TextBox txtN;
        private TextBox txtDesde;
        private TextBox txtResultado;
        private Label label2;
        private Label label3;
    }
}
