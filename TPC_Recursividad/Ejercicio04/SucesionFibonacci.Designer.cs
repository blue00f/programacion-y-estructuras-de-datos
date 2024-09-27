namespace Ejercicio04
{
    partial class frmSucesionFibonacci
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
            btnCalcular = new Button();
            txtCantidadDeSucesiones = new TextBox();
            label1 = new Label();
            txtSucesionFibo = new TextBox();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(41, 113);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(100, 38);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtCantidadDeSucesiones
            // 
            txtCantidadDeSucesiones.Location = new Point(41, 73);
            txtCantidadDeSucesiones.Name = "txtCantidadDeSucesiones";
            txtCantidadDeSucesiones.Size = new Size(100, 23);
            txtCantidadDeSucesiones.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 46);
            label1.Name = "label1";
            label1.Size = new Size(238, 15);
            label1.TabIndex = 2;
            label1.Text = "Cantidad de sucesiones Fibonacci a mostrar";
            // 
            // txtSucesionFibo
            // 
            txtSucesionFibo.Location = new Point(23, 217);
            txtSucesionFibo.Name = "txtSucesionFibo";
            txtSucesionFibo.ReadOnly = true;
            txtSucesionFibo.Size = new Size(420, 23);
            txtSucesionFibo.TabIndex = 3;
            // 
            // frmSucesionFibonacci
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 298);
            Controls.Add(txtSucesionFibo);
            Controls.Add(label1);
            Controls.Add(txtCantidadDeSucesiones);
            Controls.Add(btnCalcular);
            Name = "frmSucesionFibonacci";
            Text = "Mostrar una sucesión Fibonacci en base a un número";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private TextBox txtCantidadDeSucesiones;
        private Label label1;
        private TextBox txtSucesionFibo;
    }
}
