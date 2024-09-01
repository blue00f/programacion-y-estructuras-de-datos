namespace Ejercicio11_Forms
{
    partial class frmCalculadora
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
            txtOp1 = new TextBox();
            txtOp2 = new TextBox();
            txtRta = new TextBox();
            lblOp1 = new Label();
            lblOp2 = new Label();
            lblRta = new Label();
            btnSuma = new Button();
            btnResta = new Button();
            btnProd = new Button();
            btnCoc = new Button();
            btnSalir = new Button();
            btnLimpiar = new Button();
            SuspendLayout();
            // 
            // txtOp1
            // 
            txtOp1.Location = new Point(114, 32);
            txtOp1.Name = "txtOp1";
            txtOp1.Size = new Size(100, 23);
            txtOp1.TabIndex = 0;
            // 
            // txtOp2
            // 
            txtOp2.Location = new Point(114, 81);
            txtOp2.Name = "txtOp2";
            txtOp2.Size = new Size(100, 23);
            txtOp2.TabIndex = 1;
            // 
            // txtRta
            // 
            txtRta.Location = new Point(114, 126);
            txtRta.Name = "txtRta";
            txtRta.ReadOnly = true;
            txtRta.Size = new Size(100, 23);
            txtRta.TabIndex = 2;
            // 
            // lblOp1
            // 
            lblOp1.AutoSize = true;
            lblOp1.Location = new Point(28, 35);
            lblOp1.Name = "lblOp1";
            lblOp1.Size = new Size(76, 15);
            lblOp1.TabIndex = 3;
            lblOp1.Text = "1er Operador";
            // 
            // lblOp2
            // 
            lblOp2.AutoSize = true;
            lblOp2.Location = new Point(28, 84);
            lblOp2.Name = "lblOp2";
            lblOp2.Size = new Size(80, 15);
            lblOp2.TabIndex = 4;
            lblOp2.Text = "2do Operador";
            // 
            // lblRta
            // 
            lblRta.AutoSize = true;
            lblRta.Location = new Point(28, 129);
            lblRta.Name = "lblRta";
            lblRta.Size = new Size(59, 15);
            lblRta.TabIndex = 5;
            lblRta.Text = "Resultado";
            // 
            // btnSuma
            // 
            btnSuma.Location = new Point(267, 32);
            btnSuma.Name = "btnSuma";
            btnSuma.Size = new Size(75, 23);
            btnSuma.TabIndex = 6;
            btnSuma.Text = "Suma";
            btnSuma.UseVisualStyleBackColor = true;
            btnSuma.Click += btnSuma_Click;
            // 
            // btnResta
            // 
            btnResta.Location = new Point(267, 82);
            btnResta.Name = "btnResta";
            btnResta.Size = new Size(75, 23);
            btnResta.TabIndex = 7;
            btnResta.Text = "Resta";
            btnResta.UseVisualStyleBackColor = true;
            btnResta.Click += btnResta_Click;
            // 
            // btnProd
            // 
            btnProd.Location = new Point(267, 127);
            btnProd.Name = "btnProd";
            btnProd.Size = new Size(75, 23);
            btnProd.TabIndex = 8;
            btnProd.Text = "Producto";
            btnProd.UseVisualStyleBackColor = true;
            btnProd.Click += btnProd_Click;
            // 
            // btnCoc
            // 
            btnCoc.Location = new Point(267, 172);
            btnCoc.Name = "btnCoc";
            btnCoc.Size = new Size(75, 23);
            btnCoc.TabIndex = 9;
            btnCoc.Text = "Cociente";
            btnCoc.UseVisualStyleBackColor = true;
            btnCoc.Click += btnCoc_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(42, 172);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 10;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(139, 172);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 11;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // frmCalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 246);
            Controls.Add(btnLimpiar);
            Controls.Add(btnSalir);
            Controls.Add(btnCoc);
            Controls.Add(btnProd);
            Controls.Add(btnResta);
            Controls.Add(btnSuma);
            Controls.Add(lblRta);
            Controls.Add(lblOp2);
            Controls.Add(lblOp1);
            Controls.Add(txtRta);
            Controls.Add(txtOp2);
            Controls.Add(txtOp1);
            Name = "frmCalculadora";
            Text = "Calculadora simple";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtOp1;
        private TextBox txtOp2;
        private TextBox txtRta;
        private Label lblOp1;
        private Label lblOp2;
        private Label lblRta;
        private Button btnSuma;
        private Button btnResta;
        private Button btnProd;
        private Button btnCoc;
        private Button btnSalir;
        private Button btnLimpiar;
    }
}
