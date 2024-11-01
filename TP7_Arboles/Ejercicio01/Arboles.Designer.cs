namespace Ejercicio01
{
    partial class frmArboles
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
            tvArbol = new TreeView();
            btnAgregar = new Button();
            btnPreorden = new Button();
            btnInorden = new Button();
            btnPostorden = new Button();
            txtPreorden = new TextBox();
            txtInorden = new TextBox();
            txtPostorden = new TextBox();
            label1 = new Label();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // tvArbol
            // 
            tvArbol.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tvArbol.Location = new Point(401, 84);
            tvArbol.Name = "tvArbol";
            tvArbol.Size = new Size(152, 198);
            tvArbol.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(401, 288);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(152, 33);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnPreorden
            // 
            btnPreorden.Location = new Point(34, 84);
            btnPreorden.Name = "btnPreorden";
            btnPreorden.Size = new Size(319, 23);
            btnPreorden.TabIndex = 2;
            btnPreorden.Text = "Recorrido Preorden";
            btnPreorden.UseVisualStyleBackColor = true;
            btnPreorden.Click += btnPreorden_Click;
            // 
            // btnInorden
            // 
            btnInorden.Location = new Point(33, 155);
            btnInorden.Name = "btnInorden";
            btnInorden.Size = new Size(319, 23);
            btnInorden.TabIndex = 3;
            btnInorden.Text = "Recorrido Inorden";
            btnInorden.UseVisualStyleBackColor = true;
            btnInorden.Click += btnInorden_Click;
            // 
            // btnPostorden
            // 
            btnPostorden.Location = new Point(33, 230);
            btnPostorden.Name = "btnPostorden";
            btnPostorden.Size = new Size(319, 23);
            btnPostorden.TabIndex = 4;
            btnPostorden.Text = "Recorrido Postorden";
            btnPostorden.UseVisualStyleBackColor = true;
            btnPostorden.Click += btnPostorden_Click;
            // 
            // txtPreorden
            // 
            txtPreorden.Location = new Point(35, 113);
            txtPreorden.Name = "txtPreorden";
            txtPreorden.ReadOnly = true;
            txtPreorden.Size = new Size(318, 23);
            txtPreorden.TabIndex = 5;
            // 
            // txtInorden
            // 
            txtInorden.Location = new Point(34, 184);
            txtInorden.Name = "txtInorden";
            txtInorden.ReadOnly = true;
            txtInorden.Size = new Size(318, 23);
            txtInorden.TabIndex = 6;
            // 
            // txtPostorden
            // 
            txtPostorden.Location = new Point(33, 259);
            txtPostorden.Name = "txtPostorden";
            txtPostorden.ReadOnly = true;
            txtPostorden.Size = new Size(318, 23);
            txtPostorden.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 27);
            label1.Name = "label1";
            label1.Size = new Size(269, 25);
            label1.TabIndex = 8;
            label1.Text = "Árboles binarios y recorridos";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(113, 290);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(152, 31);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // frmArboles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 347);
            Controls.Add(btnSalir);
            Controls.Add(label1);
            Controls.Add(txtPostorden);
            Controls.Add(txtInorden);
            Controls.Add(txtPreorden);
            Controls.Add(btnPostorden);
            Controls.Add(btnInorden);
            Controls.Add(btnPreorden);
            Controls.Add(btnAgregar);
            Controls.Add(tvArbol);
            Name = "frmArboles";
            Text = "Arboles binarios";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView tvArbol;
        private Button btnAgregar;
        private Button btnPreorden;
        private Button btnInorden;
        private Button btnPostorden;
        private TextBox txtPreorden;
        private TextBox txtInorden;
        private TextBox txtPostorden;
        private Label label1;
        private Button btnSalir;
    }
}
