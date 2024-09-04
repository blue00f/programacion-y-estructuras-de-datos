namespace Ejercicio05
{
    partial class frmNumerosPrimos
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
            lstNumerosPrimos = new ListBox();
            label1 = new Label();
            txtNumMin = new TextBox();
            label2 = new Label();
            txtNumMax = new TextBox();
            label3 = new Label();
            btnCalcularNumerosPrimos = new Button();
            SuspendLayout();
            // 
            // lstNumerosPrimos
            // 
            lstNumerosPrimos.FormattingEnabled = true;
            lstNumerosPrimos.ItemHeight = 15;
            lstNumerosPrimos.Location = new Point(51, 201);
            lstNumerosPrimos.Name = "lstNumerosPrimos";
            lstNumerosPrimos.Size = new Size(316, 94);
            lstNumerosPrimos.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 47);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 0;
            label1.Text = "Número mínimo";
            // 
            // txtNumMin
            // 
            txtNumMin.Location = new Point(165, 44);
            txtNumMin.Name = "txtNumMin";
            txtNumMin.Size = new Size(100, 23);
            txtNumMin.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 93);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 2;
            label2.Text = "Número máximo";
            // 
            // txtNumMax
            // 
            txtNumMax.Location = new Point(165, 90);
            txtNumMax.Name = "txtNumMax";
            txtNumMax.Size = new Size(100, 23);
            txtNumMax.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 174);
            label3.Name = "label3";
            label3.Size = new Size(212, 15);
            label3.TabIndex = 5;
            label3.Text = "Números primos que están en el rango";
            // 
            // btnCalcularNumerosPrimos
            // 
            btnCalcularNumerosPrimos.Location = new Point(51, 301);
            btnCalcularNumerosPrimos.Name = "btnCalcularNumerosPrimos";
            btnCalcularNumerosPrimos.Size = new Size(316, 37);
            btnCalcularNumerosPrimos.TabIndex = 6;
            btnCalcularNumerosPrimos.Text = "Ejecutar";
            btnCalcularNumerosPrimos.UseVisualStyleBackColor = true;
            btnCalcularNumerosPrimos.Click += btnCalcularNumerosPrimos_Click;
            // 
            // frmNumerosPrimos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 425);
            Controls.Add(btnCalcularNumerosPrimos);
            Controls.Add(label3);
            Controls.Add(lstNumerosPrimos);
            Controls.Add(txtNumMax);
            Controls.Add(label2);
            Controls.Add(txtNumMin);
            Controls.Add(label1);
            Name = "frmNumerosPrimos";
            Text = "Números primos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumMin;
        private Label label2;
        private TextBox txtNumMax;
        private ListBox lstNumerosPrimos;
        private Label label3;
        private Button btnCalcularNumerosPrimos;
    }
}
