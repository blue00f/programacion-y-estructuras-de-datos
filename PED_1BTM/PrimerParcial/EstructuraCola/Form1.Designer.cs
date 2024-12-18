namespace EstructuraCola
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
            btnEncolar = new Button();
            btnDesencolar = new Button();
            btnVer = new Button();
            lstNodos = new ListBox();
            SuspendLayout();
            // 
            // btnEncolar
            // 
            btnEncolar.Location = new Point(105, 35);
            btnEncolar.Name = "btnEncolar";
            btnEncolar.Size = new Size(191, 63);
            btnEncolar.TabIndex = 0;
            btnEncolar.Text = "Encolar";
            btnEncolar.UseVisualStyleBackColor = true;
            btnEncolar.Click += btnEncolar_Click;
            // 
            // btnDesencolar
            // 
            btnDesencolar.Location = new Point(105, 104);
            btnDesencolar.Name = "btnDesencolar";
            btnDesencolar.Size = new Size(191, 63);
            btnDesencolar.TabIndex = 1;
            btnDesencolar.Text = "Desencolar";
            btnDesencolar.UseVisualStyleBackColor = true;
            btnDesencolar.Click += btnDesencolar_Click;
            // 
            // btnVer
            // 
            btnVer.Location = new Point(105, 173);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(191, 63);
            btnVer.TabIndex = 2;
            btnVer.Text = "Ver";
            btnVer.UseVisualStyleBackColor = true;
            btnVer.Click += btnVer_Click;
            // 
            // lstNodos
            // 
            lstNodos.FormattingEnabled = true;
            lstNodos.ItemHeight = 25;
            lstNodos.Location = new Point(354, 35);
            lstNodos.Name = "lstNodos";
            lstNodos.Size = new Size(189, 204);
            lstNodos.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 319);
            Controls.Add(lstNodos);
            Controls.Add(btnVer);
            Controls.Add(btnDesencolar);
            Controls.Add(btnEncolar);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnEncolar;
        private Button btnDesencolar;
        private Button btnVer;
        private ListBox lstNodos;
    }
}
