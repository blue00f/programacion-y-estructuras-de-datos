namespace Ejercicio16_Forms
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            opt1 = new RadioButton();
            opt2 = new RadioButton();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            btnMostrar = new Button();
            btnSalir = new Button();
            lst1 = new ListBox();
            btnLimpiar = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 37);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 0;
            label1.Text = "1er valor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 89);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 1;
            label2.Text = "2do valor";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(124, 34);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(124, 86);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 3;
            // 
            // opt1
            // 
            opt1.AutoSize = true;
            opt1.Location = new Point(6, 22);
            opt1.Name = "opt1";
            opt1.Size = new Size(70, 19);
            opt1.TabIndex = 4;
            opt1.TabStop = true;
            opt1.Text = "1er valor";
            opt1.UseVisualStyleBackColor = true;
            // 
            // opt2
            // 
            opt2.AutoSize = true;
            opt2.Location = new Point(6, 22);
            opt2.Name = "opt2";
            opt2.Size = new Size(74, 19);
            opt2.TabIndex = 5;
            opt2.TabStop = true;
            opt2.Text = "2do valor";
            opt2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(opt1);
            groupBox1.Location = new Point(62, 139);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(162, 56);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "primera selección";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(opt2);
            groupBox2.Location = new Point(62, 201);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(162, 56);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "segunda selección";
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(62, 272);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(75, 23);
            btnMostrar.TabIndex = 7;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(149, 272);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // lst1
            // 
            lst1.FormattingEnabled = true;
            lst1.ItemHeight = 15;
            lst1.Location = new Point(62, 314);
            lst1.Name = "lst1";
            lst1.Size = new Size(162, 79);
            lst1.TabIndex = 9;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(62, 399);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(162, 23);
            btnLimpiar.TabIndex = 10;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(294, 450);
            Controls.Add(btnLimpiar);
            Controls.Add(lst1);
            Controls.Add(btnSalir);
            Controls.Add(btnMostrar);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Manejo de groupbox";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private RadioButton opt1;
        private RadioButton opt2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnMostrar;
        private Button btnSalir;
        private ListBox lst1;
        private Button btnLimpiar;
    }
}
