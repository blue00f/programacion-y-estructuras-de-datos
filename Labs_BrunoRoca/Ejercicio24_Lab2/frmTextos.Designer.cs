namespace Ejercicio24_Lab2
{
    partial class frmTextos
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
            btnMensaje1 = new Button();
            btnMensaje2 = new Button();
            btnMensaje3 = new Button();
            SuspendLayout();
            // 
            // btnMensaje1
            // 
            btnMensaje1.Location = new Point(78, 57);
            btnMensaje1.Name = "btnMensaje1";
            btnMensaje1.Size = new Size(90, 30);
            btnMensaje1.TabIndex = 0;
            btnMensaje1.Text = "Mensaje 1";
            btnMensaje1.UseVisualStyleBackColor = true;
            btnMensaje1.Click += btnMensaje1_Click;
            // 
            // btnMensaje2
            // 
            btnMensaje2.Location = new Point(78, 124);
            btnMensaje2.Name = "btnMensaje2";
            btnMensaje2.Size = new Size(90, 30);
            btnMensaje2.TabIndex = 1;
            btnMensaje2.Text = "Mensaje 2";
            btnMensaje2.UseVisualStyleBackColor = true;
            btnMensaje2.Click += btnMensaje2_Click;
            // 
            // btnMensaje3
            // 
            btnMensaje3.Location = new Point(78, 181);
            btnMensaje3.Name = "btnMensaje3";
            btnMensaje3.Size = new Size(90, 30);
            btnMensaje3.TabIndex = 2;
            btnMensaje3.Text = "Mensaje 3";
            btnMensaje3.UseVisualStyleBackColor = true;
            btnMensaje3.Click += btnMensaje3_Click;
            // 
            // frmTextos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(250, 273);
            Controls.Add(btnMensaje3);
            Controls.Add(btnMensaje2);
            Controls.Add(btnMensaje1);
            Name = "frmTextos";
            Text = "Uso de textos";
            ResumeLayout(false);
        }

        #endregion

        private Button btnMensaje1;
        private Button btnMensaje2;
        private Button btnMensaje3;
    }
}
