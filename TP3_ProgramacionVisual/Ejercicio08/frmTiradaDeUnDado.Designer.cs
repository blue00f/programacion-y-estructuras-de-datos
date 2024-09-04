namespace Ejercicio08
{
    partial class frmTiradaDeUnDado
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
            btnTirarDado = new Button();
            txtValorDado = new TextBox();
            SuspendLayout();
            // 
            // btnTirarDado
            // 
            btnTirarDado.BackColor = Color.FromArgb(255, 128, 128);
            btnTirarDado.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnTirarDado.ForeColor = Color.White;
            btnTirarDado.Location = new Point(12, 81);
            btnTirarDado.Name = "btnTirarDado";
            btnTirarDado.Size = new Size(188, 67);
            btnTirarDado.TabIndex = 0;
            btnTirarDado.Text = "Tirar 1 dado";
            btnTirarDado.UseVisualStyleBackColor = false;
            btnTirarDado.Click += btnTirarDado_Click;
            // 
            // txtValorDado
            // 
            txtValorDado.Font = new Font("Segoe UI", 14F);
            txtValorDado.Location = new Point(217, 99);
            txtValorDado.Name = "txtValorDado";
            txtValorDado.Size = new Size(141, 32);
            txtValorDado.TabIndex = 1;
            // 
            // frmTiradaDeUnDado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 209);
            Controls.Add(txtValorDado);
            Controls.Add(btnTirarDado);
            Name = "frmTiradaDeUnDado";
            Text = "Tirada de un dado";
            Load += frmTiradaDeUnDado_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTirarDado;
        private TextBox txtValorDado;
    }
}
