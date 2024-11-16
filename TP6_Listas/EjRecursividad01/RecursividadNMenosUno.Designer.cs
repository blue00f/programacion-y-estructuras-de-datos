namespace EjRecursividad01
{
    partial class frmRecursividadNMenosUno
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
            lstNumeros = new ListBox();
            txtNumero = new TextBox();
            label1 = new Label();
            btnIngresar = new Button();
            SuspendLayout();
            // 
            // lstNumeros
            // 
            lstNumeros.FormattingEnabled = true;
            lstNumeros.ItemHeight = 15;
            lstNumeros.Location = new Point(250, 45);
            lstNumeros.Name = "lstNumeros";
            lstNumeros.Size = new Size(167, 199);
            lstNumeros.TabIndex = 0;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(43, 63);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(132, 23);
            txtNumero.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 45);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 2;
            label1.Text = "Número";
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(43, 101);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(132, 23);
            btnIngresar.TabIndex = 3;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // frmRecursividadNMenosUno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 261);
            Controls.Add(btnIngresar);
            Controls.Add(label1);
            Controls.Add(txtNumero);
            Controls.Add(lstNumeros);
            Name = "frmRecursividadNMenosUno";
            Text = "Recursividad de N menos uno";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstNumeros;
        private TextBox txtNumero;
        private Label label1;
        private Button btnIngresar;
    }
}
