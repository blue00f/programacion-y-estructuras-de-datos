namespace Ejercicio02
{
    partial class frmGestorDeRecorridos
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
            lstViajesIda = new ListBox();
            lstViajesVuelta = new ListBox();
            btnIngresarIda = new Button();
            btnIngresarVuelta = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // lstViajesIda
            // 
            lstViajesIda.FormattingEnabled = true;
            lstViajesIda.ItemHeight = 25;
            lstViajesIda.Location = new Point(78, 127);
            lstViajesIda.Margin = new Padding(5);
            lstViajesIda.Name = "lstViajesIda";
            lstViajesIda.Size = new Size(255, 304);
            lstViajesIda.TabIndex = 0;
            // 
            // lstViajesVuelta
            // 
            lstViajesVuelta.FormattingEnabled = true;
            lstViajesVuelta.ItemHeight = 25;
            lstViajesVuelta.Location = new Point(371, 127);
            lstViajesVuelta.Margin = new Padding(5);
            lstViajesVuelta.Name = "lstViajesVuelta";
            lstViajesVuelta.Size = new Size(255, 304);
            lstViajesVuelta.TabIndex = 1;
            // 
            // btnIngresarIda
            // 
            btnIngresarIda.Location = new Point(78, 455);
            btnIngresarIda.Name = "btnIngresarIda";
            btnIngresarIda.Size = new Size(255, 66);
            btnIngresarIda.TabIndex = 2;
            btnIngresarIda.Text = "Ingresar pueblos de ida";
            btnIngresarIda.UseVisualStyleBackColor = true;
            btnIngresarIda.Click += btnIngresarIda_Click;
            // 
            // btnIngresarVuelta
            // 
            btnIngresarVuelta.Location = new Point(371, 455);
            btnIngresarVuelta.Name = "btnIngresarVuelta";
            btnIngresarVuelta.Size = new Size(255, 66);
            btnIngresarVuelta.TabIndex = 3;
            btnIngresarVuelta.Text = "Obtener recorrido de vuelta";
            btnIngresarVuelta.UseVisualStyleBackColor = true;
            btnIngresarVuelta.Click += btnIngresarVuelta_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 97);
            label1.Name = "label1";
            label1.Size = new Size(150, 25);
            label1.TabIndex = 4;
            label1.Text = "Recorrido de ida";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(371, 97);
            label2.Name = "label2";
            label2.Size = new Size(175, 25);
            label2.TabIndex = 5;
            label2.Text = "Recorrido de vuelta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label3.Location = new Point(258, 39);
            label3.Name = "label3";
            label3.Size = new Size(195, 25);
            label3.TabIndex = 6;
            label3.Text = "Gestor de recorridos";
            // 
            // frmGestorDeRecorridos
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(705, 573);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnIngresarVuelta);
            Controls.Add(btnIngresarIda);
            Controls.Add(lstViajesVuelta);
            Controls.Add(lstViajesIda);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5);
            Name = "frmGestorDeRecorridos";
            Text = "Gestor de recorridos";
            Load += frmGestorDeRecorridos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstViajesIda;
        private ListBox lstViajesVuelta;
        private Button btnIngresarIda;
        private Button btnIngresarVuelta;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
