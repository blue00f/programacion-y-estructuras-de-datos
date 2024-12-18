namespace EjemploArbol
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
            tvNodos = new TreeView();
            btnAgregar = new Button();
            btnPreorden = new Button();
            btnInorden = new Button();
            btnPosorden = new Button();
            txtPreorden = new TextBox();
            txtInorden = new TextBox();
            txtPosorden = new TextBox();
            txtAnchura = new TextBox();
            btnAnchura = new Button();
            SuspendLayout();
            // 
            // tvNodos
            // 
            tvNodos.Location = new Point(276, 40);
            tvNodos.Name = "tvNodos";
            tvNodos.Size = new Size(200, 329);
            tvNodos.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(92, 40);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(88, 42);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnPreorden
            // 
            btnPreorden.Location = new Point(31, 118);
            btnPreorden.Name = "btnPreorden";
            btnPreorden.Size = new Size(203, 23);
            btnPreorden.TabIndex = 2;
            btnPreorden.Text = "Preorden";
            btnPreorden.UseVisualStyleBackColor = true;
            btnPreorden.Click += btnPreorden_Click;
            // 
            // btnInorden
            // 
            btnInorden.Location = new Point(31, 186);
            btnInorden.Name = "btnInorden";
            btnInorden.Size = new Size(203, 23);
            btnInorden.TabIndex = 3;
            btnInorden.Text = "Inorden";
            btnInorden.UseVisualStyleBackColor = true;
            btnInorden.Click += btnInorden_Click;
            // 
            // btnPosorden
            // 
            btnPosorden.Location = new Point(31, 249);
            btnPosorden.Name = "btnPosorden";
            btnPosorden.Size = new Size(203, 23);
            btnPosorden.TabIndex = 4;
            btnPosorden.Text = "Posorden";
            btnPosorden.UseVisualStyleBackColor = true;
            btnPosorden.Click += btnPosorden_Click;
            // 
            // txtPreorden
            // 
            txtPreorden.Location = new Point(31, 147);
            txtPreorden.Name = "txtPreorden";
            txtPreorden.Size = new Size(203, 23);
            txtPreorden.TabIndex = 5;
            // 
            // txtInorden
            // 
            txtInorden.Location = new Point(31, 215);
            txtInorden.Name = "txtInorden";
            txtInorden.Size = new Size(203, 23);
            txtInorden.TabIndex = 6;
            // 
            // txtPosorden
            // 
            txtPosorden.Location = new Point(31, 278);
            txtPosorden.Name = "txtPosorden";
            txtPosorden.Size = new Size(203, 23);
            txtPosorden.TabIndex = 7;
            // 
            // txtAnchura
            // 
            txtAnchura.Location = new Point(31, 346);
            txtAnchura.Name = "txtAnchura";
            txtAnchura.Size = new Size(203, 23);
            txtAnchura.TabIndex = 9;
            // 
            // btnAnchura
            // 
            btnAnchura.Location = new Point(31, 317);
            btnAnchura.Name = "btnAnchura";
            btnAnchura.Size = new Size(203, 23);
            btnAnchura.TabIndex = 8;
            btnAnchura.Text = "Anchura";
            btnAnchura.UseVisualStyleBackColor = true;
            btnAnchura.Click += btnAnchura_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(525, 419);
            Controls.Add(txtAnchura);
            Controls.Add(btnAnchura);
            Controls.Add(txtPosorden);
            Controls.Add(txtInorden);
            Controls.Add(txtPreorden);
            Controls.Add(btnPosorden);
            Controls.Add(btnInorden);
            Controls.Add(btnPreorden);
            Controls.Add(btnAgregar);
            Controls.Add(tvNodos);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView tvNodos;
        private Button btnAgregar;
        private Button btnPreorden;
        private Button btnInorden;
        private Button btnPosorden;
        private TextBox txtPreorden;
        private TextBox txtInorden;
        private TextBox txtPosorden;
        private TextBox txtAnchura;
        private Button btnAnchura;
    }
}
