namespace Ejercicio07
{
    partial class frmApareoDeListas
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
            btnInsertarLista1 = new Button();
            lstLista1 = new ListBox();
            lstLista2 = new ListBox();
            btnInsertarLista2 = new Button();
            lstListaApareada = new ListBox();
            btnAparear = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnInsertarLista1
            // 
            btnInsertarLista1.Location = new Point(50, 185);
            btnInsertarLista1.Name = "btnInsertarLista1";
            btnInsertarLista1.Size = new Size(120, 36);
            btnInsertarLista1.TabIndex = 0;
            btnInsertarLista1.Text = "Insertar en lista 1";
            btnInsertarLista1.UseVisualStyleBackColor = true;
            btnInsertarLista1.Click += btnInsertarLista1_Click;
            // 
            // lstLista1
            // 
            lstLista1.FormattingEnabled = true;
            lstLista1.ItemHeight = 15;
            lstLista1.Location = new Point(50, 68);
            lstLista1.Name = "lstLista1";
            lstLista1.Size = new Size(120, 94);
            lstLista1.TabIndex = 1;
            // 
            // lstLista2
            // 
            lstLista2.FormattingEnabled = true;
            lstLista2.ItemHeight = 15;
            lstLista2.Location = new Point(226, 68);
            lstLista2.Name = "lstLista2";
            lstLista2.Size = new Size(120, 94);
            lstLista2.TabIndex = 2;
            // 
            // btnInsertarLista2
            // 
            btnInsertarLista2.Location = new Point(226, 185);
            btnInsertarLista2.Name = "btnInsertarLista2";
            btnInsertarLista2.Size = new Size(120, 36);
            btnInsertarLista2.TabIndex = 3;
            btnInsertarLista2.Text = "Insertar en lista 2";
            btnInsertarLista2.UseVisualStyleBackColor = true;
            btnInsertarLista2.Click += btnInsertarLista2_Click;
            // 
            // lstListaApareada
            // 
            lstListaApareada.FormattingEnabled = true;
            lstListaApareada.ItemHeight = 15;
            lstListaApareada.Location = new Point(399, 68);
            lstListaApareada.Name = "lstListaApareada";
            lstListaApareada.Size = new Size(120, 94);
            lstListaApareada.TabIndex = 4;
            // 
            // btnAparear
            // 
            btnAparear.Location = new Point(399, 185);
            btnAparear.Name = "btnAparear";
            btnAparear.Size = new Size(120, 36);
            btnAparear.TabIndex = 5;
            btnAparear.Text = "Aparear lista 1 y 2";
            btnAparear.UseVisualStyleBackColor = true;
            btnAparear.Click += btnAparear_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 36);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 6;
            label1.Text = "Lista 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(226, 36);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 7;
            label2.Text = "Lista 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(399, 36);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 8;
            label3.Text = "Lista apareada";
            // 
            // frmApareoDeListas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 272);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAparear);
            Controls.Add(lstListaApareada);
            Controls.Add(btnInsertarLista2);
            Controls.Add(lstLista2);
            Controls.Add(lstLista1);
            Controls.Add(btnInsertarLista1);
            Name = "frmApareoDeListas";
            Text = "Apareo de listas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInsertarLista1;
        private ListBox lstLista1;
        private ListBox lstLista2;
        private Button btnInsertarLista2;
        private ListBox lstListaApareada;
        private Button btnAparear;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
