namespace Ejemplo01
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
            btnHola = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // btnHola
            // 
            btnHola.Location = new Point(155, 67);
            btnHola.Name = "btnHola";
            btnHola.Size = new Size(75, 23);
            btnHola.TabIndex = 0;
            btnHola.Text = "Cerrar";
            btnHola.UseVisualStyleBackColor = true;
            btnHola.Click += Pepito;
            // 
            // button2
            // 
            button2.Location = new Point(540, 69);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "Chau";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(btnHola);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            MouseMove += Form1_MouseMove;
            ResumeLayout(false);
        }

        #endregion

        private Button btnHola;
        private Button button2;
    }
}
