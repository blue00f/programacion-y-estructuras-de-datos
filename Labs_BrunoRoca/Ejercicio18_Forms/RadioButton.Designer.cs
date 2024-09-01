namespace Ejercicio18_Forms
{
    partial class frmRadioButton
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
            btnLimpiar = new Button();
            btnIf = new Button();
            btnSwitch = new Button();
            btnSalir = new Button();
            lbl1 = new Label();
            lbl2 = new Label();
            lbl3 = new Label();
            txt1 = new TextBox();
            txt2 = new TextBox();
            txtRta = new TextBox();
            groupBox1 = new GroupBox();
            optCoc = new RadioButton();
            optProd = new RadioButton();
            optResta = new RadioButton();
            optSuma = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(117, 158);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(100, 23);
            btnLimpiar.TabIndex = 0;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnIf
            // 
            btnIf.Location = new Point(37, 322);
            btnIf.Name = "btnIf";
            btnIf.Size = new Size(75, 23);
            btnIf.TabIndex = 1;
            btnIf.Text = "Con IF";
            btnIf.UseVisualStyleBackColor = true;
            btnIf.Click += btnIf_Click;
            // 
            // btnSwitch
            // 
            btnSwitch.Location = new Point(144, 322);
            btnSwitch.Name = "btnSwitch";
            btnSwitch.Size = new Size(75, 23);
            btnSwitch.TabIndex = 2;
            btnSwitch.Text = "Con Switch";
            btnSwitch.UseVisualStyleBackColor = true;
            btnSwitch.Click += btnSwitch_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(144, 368);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(37, 34);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(74, 15);
            lbl1.TabIndex = 4;
            lbl1.Text = "1er operador";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(33, 75);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(78, 15);
            lbl2.TabIndex = 5;
            lbl2.Text = "2do operador";
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Location = new Point(52, 117);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(59, 15);
            lbl3.TabIndex = 6;
            lbl3.Text = "Resultado";
            // 
            // txt1
            // 
            txt1.Location = new Point(117, 31);
            txt1.Name = "txt1";
            txt1.Size = new Size(100, 23);
            txt1.TabIndex = 7;
            // 
            // txt2
            // 
            txt2.Location = new Point(117, 72);
            txt2.Name = "txt2";
            txt2.Size = new Size(100, 23);
            txt2.TabIndex = 8;
            // 
            // txtRta
            // 
            txtRta.Location = new Point(117, 114);
            txtRta.Name = "txtRta";
            txtRta.ReadOnly = true;
            txtRta.Size = new Size(100, 23);
            txtRta.TabIndex = 9;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(optCoc);
            groupBox1.Controls.Add(optProd);
            groupBox1.Controls.Add(optResta);
            groupBox1.Controls.Add(optSuma);
            groupBox1.Location = new Point(37, 197);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(182, 110);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Operaciones";
            // 
            // optCoc
            // 
            optCoc.AutoSize = true;
            optCoc.Location = new Point(18, 70);
            optCoc.Name = "optCoc";
            optCoc.Size = new Size(72, 19);
            optCoc.TabIndex = 3;
            optCoc.TabStop = true;
            optCoc.Text = "Cociente";
            optCoc.UseVisualStyleBackColor = true;
            // 
            // optProd
            // 
            optProd.AutoSize = true;
            optProd.Location = new Point(96, 70);
            optProd.Name = "optProd";
            optProd.Size = new Size(74, 19);
            optProd.TabIndex = 2;
            optProd.TabStop = true;
            optProd.Text = "Producto";
            optProd.UseVisualStyleBackColor = true;
            // 
            // optResta
            // 
            optResta.AutoSize = true;
            optResta.Location = new Point(96, 33);
            optResta.Name = "optResta";
            optResta.Size = new Size(53, 19);
            optResta.TabIndex = 1;
            optResta.TabStop = true;
            optResta.Text = "Resta";
            optResta.UseVisualStyleBackColor = true;
            // 
            // optSuma
            // 
            optSuma.AutoSize = true;
            optSuma.Location = new Point(18, 33);
            optSuma.Name = "optSuma";
            optSuma.Size = new Size(55, 19);
            optSuma.TabIndex = 0;
            optSuma.TabStop = true;
            optSuma.Text = "Suma";
            optSuma.UseVisualStyleBackColor = true;
            // 
            // frmRadioButton
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(342, 403);
            Controls.Add(groupBox1);
            Controls.Add(txtRta);
            Controls.Add(txt2);
            Controls.Add(txt1);
            Controls.Add(lbl3);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Controls.Add(btnSalir);
            Controls.Add(btnSwitch);
            Controls.Add(btnIf);
            Controls.Add(btnLimpiar);
            Name = "frmRadioButton";
            Text = "Calculadora con radiobutton";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLimpiar;
        private Button btnIf;
        private Button btnSwitch;
        private Button btnSalir;
        private Label lbl1;
        private Label lbl2;
        private Label lbl3;
        private TextBox txt1;
        private TextBox txt2;
        private TextBox txtRta;
        private GroupBox groupBox1;
        private RadioButton optSuma;
        private RadioButton optResta;
        private RadioButton optProd;
        private RadioButton optCoc;
    }
}
