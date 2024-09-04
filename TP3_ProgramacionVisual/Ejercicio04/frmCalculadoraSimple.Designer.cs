namespace Ejercicio04
{
    partial class frmCalculadoraSimple
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
            btnRestar = new Button();
            btnMultiplicar = new Button();
            btnDividir = new Button();
            btnPotencia = new Button();
            btnRaizCuadrada = new Button();
            label1 = new Label();
            label2 = new Label();
            txtNum1 = new TextBox();
            txtNum2 = new TextBox();
            txtResultado = new TextBox();
            label3 = new Label();
            txtPotenciaNum1 = new TextBox();
            txtPotenciaNum2 = new TextBox();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label6 = new Label();
            txtRaizNum1 = new TextBox();
            txtRaizNum2 = new TextBox();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // btnSumar
            // 
            btnSumar.Location = new Point(288, 218);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(102, 23);
            btnSumar.TabIndex = 0;
            btnSumar.Text = "Sumar";
            btnSumar.UseVisualStyleBackColor = true;
            btnSumar.Click += btnSumar_Click;
            // 
            // btnRestar
            // 
            btnRestar.Location = new Point(406, 218);
            btnRestar.Name = "btnRestar";
            btnRestar.Size = new Size(102, 23);
            btnRestar.TabIndex = 1;
            btnRestar.Text = "Restar";
            btnRestar.UseVisualStyleBackColor = true;
            btnRestar.Click += btnRestar_Click;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.Location = new Point(288, 271);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(102, 23);
            btnMultiplicar.TabIndex = 2;
            btnMultiplicar.Text = "Multiplicar";
            btnMultiplicar.UseVisualStyleBackColor = true;
            btnMultiplicar.Click += btnMultiplicar_Click;
            // 
            // btnDividir
            // 
            btnDividir.Location = new Point(406, 271);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(102, 23);
            btnDividir.TabIndex = 3;
            btnDividir.Text = "Dividir";
            btnDividir.UseVisualStyleBackColor = true;
            btnDividir.Click += btnDividir_Click;
            // 
            // btnPotencia
            // 
            btnPotencia.Location = new Point(288, 322);
            btnPotencia.Name = "btnPotencia";
            btnPotencia.Size = new Size(102, 23);
            btnPotencia.TabIndex = 4;
            btnPotencia.Text = "Potencia";
            btnPotencia.UseVisualStyleBackColor = true;
            btnPotencia.Click += btnPotencia_Click;
            // 
            // btnRaizCuadrada
            // 
            btnRaizCuadrada.Location = new Point(406, 322);
            btnRaizCuadrada.Name = "btnRaizCuadrada";
            btnRaizCuadrada.Size = new Size(102, 23);
            btnRaizCuadrada.TabIndex = 5;
            btnRaizCuadrada.Text = "Raíz cuadrada";
            btnRaizCuadrada.UseVisualStyleBackColor = true;
            btnRaizCuadrada.Click += btnRaizCuadrada_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 50);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 6;
            label1.Text = "Número 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 106);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 7;
            label2.Text = "Número 2";
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(112, 50);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(100, 23);
            txtNum1.TabIndex = 8;
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(112, 106);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(100, 23);
            txtNum2.TabIndex = 9;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(112, 162);
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(191, 23);
            txtResultado.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 165);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 11;
            label3.Text = "Resultado";
            // 
            // txtPotenciaNum1
            // 
            txtPotenciaNum1.Location = new Point(341, 50);
            txtPotenciaNum1.Name = "txtPotenciaNum1";
            txtPotenciaNum1.ReadOnly = true;
            txtPotenciaNum1.Size = new Size(100, 23);
            txtPotenciaNum1.TabIndex = 12;
            // 
            // txtPotenciaNum2
            // 
            txtPotenciaNum2.Location = new Point(341, 106);
            txtPotenciaNum2.Name = "txtPotenciaNum2";
            txtPotenciaNum2.ReadOnly = true;
            txtPotenciaNum2.Size = new Size(100, 23);
            txtPotenciaNum2.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(460, 109);
            label7.Name = "label7";
            label7.Size = new Size(80, 15);
            label7.TabIndex = 14;
            label7.Text = "Raíz cuadrada";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(265, 109);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 15;
            label5.Text = "Potencia";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(265, 53);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 16;
            label4.Text = "Potencia";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(460, 53);
            label6.Name = "label6";
            label6.Size = new Size(80, 15);
            label6.TabIndex = 17;
            label6.Text = "Raíz cuadrada";
            // 
            // txtRaizNum1
            // 
            txtRaizNum1.Location = new Point(560, 50);
            txtRaizNum1.Name = "txtRaizNum1";
            txtRaizNum1.ReadOnly = true;
            txtRaizNum1.Size = new Size(229, 23);
            txtRaizNum1.TabIndex = 18;
            // 
            // txtRaizNum2
            // 
            txtRaizNum2.Location = new Point(560, 106);
            txtRaizNum2.Name = "txtRaizNum2";
            txtRaizNum2.ReadOnly = true;
            txtRaizNum2.Size = new Size(229, 23);
            txtRaizNum2.TabIndex = 19;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(288, 368);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(220, 23);
            btnSalir.TabIndex = 20;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // frmCalculadoraSimple
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(821, 412);
            Controls.Add(btnSalir);
            Controls.Add(txtRaizNum2);
            Controls.Add(txtRaizNum1);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label7);
            Controls.Add(txtPotenciaNum2);
            Controls.Add(txtPotenciaNum1);
            Controls.Add(label3);
            Controls.Add(txtResultado);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRaizCuadrada);
            Controls.Add(btnPotencia);
            Controls.Add(btnDividir);
            Controls.Add(btnMultiplicar);
            Controls.Add(btnRestar);
            Controls.Add(btnSumar);
            Name = "frmCalculadoraSimple";
            Text = "Calculadora simple";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSumar;
        private Button btnRestar;
        private Button btnMultiplicar;
        private Button btnDividir;
        private Button btnPotencia;
        private Button btnRaizCuadrada;
        private Label label1;
        private Label label2;
        private TextBox txtNum1;
        private TextBox txtNum2;
        private TextBox txtResultado;
        private Label label3;
        private TextBox txtPotenciaNum1;
        private TextBox txtPotenciaNum2;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label6;
        private TextBox txtRaizNum1;
        private TextBox txtRaizNum2;
        private Button btnSalir;
    }
}
