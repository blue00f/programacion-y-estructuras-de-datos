namespace Ejercicio21_Lab2
{
    partial class frmCronometro
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
            components = new System.ComponentModel.Container();
            btnComenzar = new Button();
            btnParar = new Button();
            btnIniciar = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            SuspendLayout();
            // 
            // btnComenzar
            // 
            btnComenzar.Location = new Point(21, 183);
            btnComenzar.Name = "btnComenzar";
            btnComenzar.Size = new Size(75, 30);
            btnComenzar.TabIndex = 0;
            btnComenzar.Text = "Comenzar";
            btnComenzar.UseVisualStyleBackColor = true;
            btnComenzar.Click += btnComenzar_Click;
            // 
            // btnParar
            // 
            btnParar.Location = new Point(130, 183);
            btnParar.Name = "btnParar";
            btnParar.Size = new Size(75, 30);
            btnParar.TabIndex = 1;
            btnParar.Text = "Parar";
            btnParar.UseVisualStyleBackColor = true;
            btnParar.Click += btnParar_Click;
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(237, 183);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(75, 30);
            btnIniciar.TabIndex = 2;
            btnIniciar.Text = "Inicializar";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 40F, FontStyle.Bold);
            label1.Location = new Point(50, 63);
            label1.Name = "label1";
            label1.Size = new Size(246, 72);
            label1.TabIndex = 3;
            label1.Text = "00:00:00";
            // 
            // frmCronometro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 256);
            Controls.Add(label1);
            Controls.Add(btnIniciar);
            Controls.Add(btnParar);
            Controls.Add(btnComenzar);
            Name = "frmCronometro";
            Text = "Cronómetro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnComenzar;
        private Button btnParar;
        private Button btnIniciar;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
    }
}
