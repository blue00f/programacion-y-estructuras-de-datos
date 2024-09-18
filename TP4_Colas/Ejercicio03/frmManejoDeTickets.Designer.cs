namespace Ejercicio03
{
    partial class frmManejoDeTickets
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
            lstColaInicial = new ListBox();
            btnEncolar = new Button();
            btnDesencolar = new Button();
            lstTienenTickets = new ListBox();
            lstNoTienenTickets = new ListBox();
            btnGenerarNuevaCola = new Button();
            lstColaFinal = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // lstColaInicial
            // 
            lstColaInicial.FormattingEnabled = true;
            lstColaInicial.ItemHeight = 15;
            lstColaInicial.Location = new Point(184, 74);
            lstColaInicial.Name = "lstColaInicial";
            lstColaInicial.Size = new Size(168, 139);
            lstColaInicial.TabIndex = 0;
            // 
            // btnEncolar
            // 
            btnEncolar.Location = new Point(65, 107);
            btnEncolar.Name = "btnEncolar";
            btnEncolar.Size = new Size(75, 23);
            btnEncolar.TabIndex = 1;
            btnEncolar.Text = "Encolar";
            btnEncolar.UseVisualStyleBackColor = true;
            btnEncolar.Click += btnEncolar_Click;
            // 
            // btnDesencolar
            // 
            btnDesencolar.Location = new Point(65, 145);
            btnDesencolar.Name = "btnDesencolar";
            btnDesencolar.Size = new Size(75, 23);
            btnDesencolar.TabIndex = 2;
            btnDesencolar.Text = "Desencolar";
            btnDesencolar.UseVisualStyleBackColor = true;
            btnDesencolar.Click += btnDesencolar_Click;
            // 
            // lstTienenTickets
            // 
            lstTienenTickets.FormattingEnabled = true;
            lstTienenTickets.ItemHeight = 15;
            lstTienenTickets.Location = new Point(400, 74);
            lstTienenTickets.Name = "lstTienenTickets";
            lstTienenTickets.Size = new Size(168, 139);
            lstTienenTickets.TabIndex = 3;
            // 
            // lstNoTienenTickets
            // 
            lstNoTienenTickets.FormattingEnabled = true;
            lstNoTienenTickets.ItemHeight = 15;
            lstNoTienenTickets.Location = new Point(593, 74);
            lstNoTienenTickets.Name = "lstNoTienenTickets";
            lstNoTienenTickets.Size = new Size(168, 139);
            lstNoTienenTickets.TabIndex = 4;
            // 
            // btnGenerarNuevaCola
            // 
            btnGenerarNuevaCola.Location = new Point(495, 244);
            btnGenerarNuevaCola.Name = "btnGenerarNuevaCola";
            btnGenerarNuevaCola.Size = new Size(169, 23);
            btnGenerarNuevaCola.TabIndex = 5;
            btnGenerarNuevaCola.Text = "Generar nueva cola";
            btnGenerarNuevaCola.UseVisualStyleBackColor = true;
            btnGenerarNuevaCola.Click += btnGenerarNuevaCola_Click;
            // 
            // lstColaFinal
            // 
            lstColaFinal.FormattingEnabled = true;
            lstColaFinal.ItemHeight = 15;
            lstColaFinal.Location = new Point(495, 289);
            lstColaFinal.Name = "lstColaFinal";
            lstColaFinal.Size = new Size(169, 139);
            lstColaFinal.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(400, 45);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 7;
            label1.Text = "Clientes con tickets";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(593, 45);
            label2.Name = "label2";
            label2.Size = new Size(104, 15);
            label2.TabIndex = 8;
            label2.Text = "Clientes sin tickets";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(184, 45);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 9;
            label3.Text = "Cola de clientes";
            // 
            // frmManejoDeTickets
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(887, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstColaFinal);
            Controls.Add(btnGenerarNuevaCola);
            Controls.Add(lstNoTienenTickets);
            Controls.Add(lstTienenTickets);
            Controls.Add(btnDesencolar);
            Controls.Add(btnEncolar);
            Controls.Add(lstColaInicial);
            Name = "frmManejoDeTickets";
            Text = "Manejo de tickets";
            Load += frmManejoDeTickets_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstColaInicial;
        private Button btnEncolar;
        private Button btnDesencolar;
        private ListBox lstTienenTickets;
        private ListBox lstNoTienenTickets;
        private Button btnGenerarNuevaCola;
        private ListBox lstColaFinal;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
