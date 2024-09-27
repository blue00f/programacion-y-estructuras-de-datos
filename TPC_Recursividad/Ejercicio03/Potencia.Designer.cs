namespace Ejercicio03
{
    partial class frmPotencia
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
            txtBase = new TextBox();
            txtExpo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtRes = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnEjecutar
            // 
            btnEjecutar.Location = new Point(43, 217);
            btnEjecutar.Name = "btnEjecutar";
            btnEjecutar.Size = new Size(100, 47);
            btnEjecutar.TabIndex = 0;
            btnEjecutar.Text = "Ejecutar operación";
            btnEjecutar.UseVisualStyleBackColor = true;
            btnEjecutar.Click += btnEjecutar_Click;
            // 
            // txtBase
            // 
            txtBase.Location = new Point(43, 55);
            txtBase.Name = "txtBase";
            txtBase.Size = new Size(100, 23);
            txtBase.TabIndex = 1;
            // 
            // txtExpo
            // 
            txtExpo.Location = new Point(43, 159);
            txtExpo.Name = "txtExpo";
            txtExpo.Size = new Size(100, 23);
            txtExpo.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 37);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 3;
            label1.Text = "Base";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 141);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 4;
            label2.Text = "Exponente";
            // 
            // txtRes
            // 
            txtRes.Location = new Point(197, 109);
            txtRes.Name = "txtRes";
            txtRes.ReadOnly = true;
            txtRes.Size = new Size(100, 23);
            txtRes.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(197, 91);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 6;
            label3.Text = "Resultado";
            // 
            // frmPotencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(336, 308);
            Controls.Add(label3);
            Controls.Add(txtRes);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtExpo);
            Controls.Add(txtBase);
            Controls.Add(btnEjecutar);
            Name = "frmPotencia";
            Text = "Calculadora de potencias";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEjecutar;
        private TextBox txtBase;
        private TextBox txtExpo;
        private Label label1;
        private Label label2;
        private TextBox txtRes;
        private Label label3;
    }
}
