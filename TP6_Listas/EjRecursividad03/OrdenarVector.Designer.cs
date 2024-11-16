namespace EjRecursividad03
{
    partial class frmOrdenarVector
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
            lstVector = new ListBox();
            label1 = new Label();
            label2 = new Label();
            lstVectorOrdenado = new ListBox();
            btnOrdenar = new Button();
            SuspendLayout();
            // 
            // lstVector
            // 
            lstVector.ColumnWidth = 50;
            lstVector.FormattingEnabled = true;
            lstVector.ItemHeight = 15;
            lstVector.Items.AddRange(new object[] { "6", "2", "7", "12", "5", "1", "2" });
            lstVector.Location = new Point(41, 81);
            lstVector.MultiColumn = true;
            lstVector.Name = "lstVector";
            lstVector.Size = new Size(316, 19);
            lstVector.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 63);
            label1.Name = "label1";
            label1.Size = new Size(112, 15);
            label1.TabIndex = 1;
            label1.Text = "Vector desordenado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 207);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 3;
            label2.Text = "Vector ordenado";
            // 
            // lstVectorOrdenado
            // 
            lstVectorOrdenado.ColumnWidth = 50;
            lstVectorOrdenado.FormattingEnabled = true;
            lstVectorOrdenado.ItemHeight = 15;
            lstVectorOrdenado.Location = new Point(41, 225);
            lstVectorOrdenado.MultiColumn = true;
            lstVectorOrdenado.Name = "lstVectorOrdenado";
            lstVectorOrdenado.Size = new Size(316, 19);
            lstVectorOrdenado.TabIndex = 2;
            // 
            // btnOrdenar
            // 
            btnOrdenar.Location = new Point(41, 135);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(132, 42);
            btnOrdenar.TabIndex = 4;
            btnOrdenar.Text = "Ordenar vector";
            btnOrdenar.UseVisualStyleBackColor = true;
            btnOrdenar.Click += this.btnOrdenar_Click;
            // 
            // frmOrdenarVector
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(435, 309);
            Controls.Add(btnOrdenar);
            Controls.Add(label2);
            Controls.Add(lstVectorOrdenado);
            Controls.Add(label1);
            Controls.Add(lstVector);
            Name = "frmOrdenarVector";
            Text = "Ordenamiento de un vector usando recursividad";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstVector;
        private Label label1;
        private Label label2;
        private ListBox lstVectorOrdenado;
        private Button btnOrdenar;
    }
}
