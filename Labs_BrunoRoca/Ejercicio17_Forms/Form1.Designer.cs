namespace Ejercicio17_Forms
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
            btnEjecutar = new Button();
            btnSalir = new Button();
            chk1 = new CheckBox();
            chk2 = new CheckBox();
            lbl1 = new Label();
            lbl2 = new Label();
            lbl3 = new Label();
            SuspendLayout();
            // 
            // btnEjecutar
            // 
            btnEjecutar.Location = new Point(31, 234);
            btnEjecutar.Name = "btnEjecutar";
            btnEjecutar.Size = new Size(75, 23);
            btnEjecutar.TabIndex = 0;
            btnEjecutar.Text = "Ejecutar";
            btnEjecutar.UseVisualStyleBackColor = true;
            btnEjecutar.Click += btnEjecutar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(142, 234);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // chk1
            // 
            chk1.AutoSize = true;
            chk1.Location = new Point(31, 188);
            chk1.Name = "chk1";
            chk1.Size = new Size(89, 19);
            chk1.TabIndex = 2;
            chk1.Text = "1ra elección";
            chk1.UseVisualStyleBackColor = true;
            // 
            // chk2
            // 
            chk2.AutoSize = true;
            chk2.Location = new Point(142, 188);
            chk2.Name = "chk2";
            chk2.Size = new Size(92, 19);
            chk2.TabIndex = 3;
            chk2.Text = "2da elección";
            chk2.UseVisualStyleBackColor = true;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.BackColor = Color.Red;
            lbl1.Font = new Font("Segoe UI", 12F);
            lbl1.Location = new Point(64, 91);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(130, 21);
            lbl1.TabIndex = 4;
            lbl1.Text = "--------------------";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.BackColor = Color.Red;
            lbl2.Font = new Font("Segoe UI", 12F);
            lbl2.Location = new Point(64, 112);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(130, 21);
            lbl2.TabIndex = 5;
            lbl2.Text = "--------------------";
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.BackColor = Color.Red;
            lbl3.Font = new Font("Segoe UI", 12F);
            lbl3.Location = new Point(64, 133);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(130, 21);
            lbl3.TabIndex = 6;
            lbl3.Text = "--------------------";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(290, 318);
            Controls.Add(lbl3);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Controls.Add(chk2);
            Controls.Add(chk1);
            Controls.Add(btnSalir);
            Controls.Add(btnEjecutar);
            Name = "Form1";
            Text = "Manejo de checkbox";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEjecutar;
        private Button btnSalir;
        private CheckBox chk1;
        private CheckBox chk2;
        private Label lbl1;
        private Label lbl2;
        private Label lbl3;
    }
}
