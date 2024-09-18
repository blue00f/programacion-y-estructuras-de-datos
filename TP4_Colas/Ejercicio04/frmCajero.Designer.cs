namespace Ejercicio04
{
    partial class frmCajero
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
            label1 = new Label();
            btnCerrar1 = new Button();
            btnAbrir1 = new Button();
            panel1 = new Panel();
            btnCobrar1 = new Button();
            txtMonto1 = new TextBox();
            label2 = new Label();
            label4 = new Label();
            lblCantClientes1 = new Label();
            lblEstado1 = new Label();
            panel2 = new Panel();
            btnCobrar2 = new Button();
            txtMonto2 = new TextBox();
            label3 = new Label();
            label5 = new Label();
            lblCantClientes2 = new Label();
            lblEstado2 = new Label();
            label8 = new Label();
            btnAbrir2 = new Button();
            btnCerrar2 = new Button();
            panel3 = new Panel();
            btnCobrar3 = new Button();
            txtMonto3 = new TextBox();
            label9 = new Label();
            label10 = new Label();
            lblCantClientes3 = new Label();
            lblEstado3 = new Label();
            label13 = new Label();
            btnAbrir3 = new Button();
            btnCerrar3 = new Button();
            btnEncolar = new Button();
            btnFinalizar = new Button();
            label6 = new Label();
            lblTotalCaja1 = new Label();
            lblTotalCaja2 = new Label();
            lblTotalCaja3 = new Label();
            label7 = new Label();
            label11 = new Label();
            label12 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 24F);
            label1.Location = new Point(15, 11);
            label1.Name = "label1";
            label1.Padding = new Padding(10);
            label1.Size = new Size(128, 67);
            label1.TabIndex = 0;
            label1.Text = "Caja 1";
            // 
            // btnCerrar1
            // 
            btnCerrar1.Enabled = false;
            btnCerrar1.Location = new Point(158, 11);
            btnCerrar1.Name = "btnCerrar1";
            btnCerrar1.Size = new Size(86, 23);
            btnCerrar1.TabIndex = 3;
            btnCerrar1.Text = "Cerrar";
            btnCerrar1.UseVisualStyleBackColor = true;
            btnCerrar1.Click += btnCerrar1_Click;
            // 
            // btnAbrir1
            // 
            btnAbrir1.Location = new Point(158, 40);
            btnAbrir1.Name = "btnAbrir1";
            btnAbrir1.Size = new Size(86, 23);
            btnAbrir1.TabIndex = 4;
            btnAbrir1.Text = "Abrir";
            btnAbrir1.UseVisualStyleBackColor = true;
            btnAbrir1.Click += btnAbrir1_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnCobrar1);
            panel1.Controls.Add(txtMonto1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(lblCantClientes1);
            panel1.Controls.Add(lblEstado1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnAbrir1);
            panel1.Controls.Add(btnCerrar1);
            panel1.Location = new Point(51, 48);
            panel1.Name = "panel1";
            panel1.Size = new Size(258, 261);
            panel1.TabIndex = 5;
            // 
            // btnCobrar1
            // 
            btnCobrar1.Enabled = false;
            btnCobrar1.Location = new Point(158, 191);
            btnCobrar1.Name = "btnCobrar1";
            btnCobrar1.Size = new Size(86, 23);
            btnCobrar1.TabIndex = 6;
            btnCobrar1.Text = "Cobrar";
            btnCobrar1.UseVisualStyleBackColor = true;
            btnCobrar1.Click += btnCobrar1_Click;
            // 
            // txtMonto1
            // 
            txtMonto1.Location = new Point(32, 192);
            txtMonto1.Name = "txtMonto1";
            txtMonto1.Size = new Size(100, 23);
            txtMonto1.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 195);
            label2.Name = "label2";
            label2.Size = new Size(13, 15);
            label2.TabIndex = 8;
            label2.Text = "$";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 161);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 6;
            label4.Text = "¿Cobrando?";
            // 
            // lblCantClientes1
            // 
            lblCantClientes1.AutoSize = true;
            lblCantClientes1.Location = new Point(15, 135);
            lblCantClientes1.Name = "lblCantClientes1";
            lblCantClientes1.Size = new Size(96, 15);
            lblCantClientes1.TabIndex = 7;
            lblCantClientes1.Text = "Clientes en cola: ";
            // 
            // lblEstado1
            // 
            lblEstado1.AutoSize = true;
            lblEstado1.Location = new Point(54, 88);
            lblEstado1.Name = "lblEstado1";
            lblEstado1.Size = new Size(48, 15);
            lblEstado1.TabIndex = 6;
            lblEstado1.Text = "Cerrada";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnCobrar2);
            panel2.Controls.Add(txtMonto2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(lblCantClientes2);
            panel2.Controls.Add(lblEstado2);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(btnAbrir2);
            panel2.Controls.Add(btnCerrar2);
            panel2.Location = new Point(325, 48);
            panel2.Name = "panel2";
            panel2.Size = new Size(258, 261);
            panel2.TabIndex = 9;
            // 
            // btnCobrar2
            // 
            btnCobrar2.Location = new Point(159, 192);
            btnCobrar2.Name = "btnCobrar2";
            btnCobrar2.Size = new Size(86, 23);
            btnCobrar2.TabIndex = 6;
            btnCobrar2.Text = "Cobrar";
            btnCobrar2.UseVisualStyleBackColor = true;
            btnCobrar2.Click += btnCobrar2_Click;
            // 
            // txtMonto2
            // 
            txtMonto2.Location = new Point(32, 192);
            txtMonto2.Name = "txtMonto2";
            txtMonto2.Size = new Size(100, 23);
            txtMonto2.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 195);
            label3.Name = "label3";
            label3.Size = new Size(13, 15);
            label3.TabIndex = 8;
            label3.Text = "$";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 161);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 6;
            label5.Text = "¿Cobrando?";
            // 
            // lblCantClientes2
            // 
            lblCantClientes2.AutoSize = true;
            lblCantClientes2.Location = new Point(15, 135);
            lblCantClientes2.Name = "lblCantClientes2";
            lblCantClientes2.Size = new Size(96, 15);
            lblCantClientes2.TabIndex = 7;
            lblCantClientes2.Text = "Clientes en cola: ";
            // 
            // lblEstado2
            // 
            lblEstado2.AutoSize = true;
            lblEstado2.Location = new Point(54, 88);
            lblEstado2.Name = "lblEstado2";
            lblEstado2.Size = new Size(45, 15);
            lblEstado2.TabIndex = 6;
            lblEstado2.Text = "Abierta";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BorderStyle = BorderStyle.FixedSingle;
            label8.Font = new Font("Segoe UI", 24F);
            label8.Location = new Point(15, 11);
            label8.Name = "label8";
            label8.Padding = new Padding(10);
            label8.Size = new Size(128, 67);
            label8.TabIndex = 0;
            label8.Text = "Caja 2";
            // 
            // btnAbrir2
            // 
            btnAbrir2.Enabled = false;
            btnAbrir2.Location = new Point(159, 40);
            btnAbrir2.Name = "btnAbrir2";
            btnAbrir2.Size = new Size(86, 23);
            btnAbrir2.TabIndex = 4;
            btnAbrir2.Text = "Abrir";
            btnAbrir2.UseVisualStyleBackColor = true;
            btnAbrir2.Click += btnAbrir2_Click;
            // 
            // btnCerrar2
            // 
            btnCerrar2.Location = new Point(159, 11);
            btnCerrar2.Name = "btnCerrar2";
            btnCerrar2.Size = new Size(86, 23);
            btnCerrar2.TabIndex = 3;
            btnCerrar2.Text = "Cerrar";
            btnCerrar2.UseVisualStyleBackColor = true;
            btnCerrar2.Click += btnCerrar2_Click;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(btnCobrar3);
            panel3.Controls.Add(txtMonto3);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(lblCantClientes3);
            panel3.Controls.Add(lblEstado3);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(btnAbrir3);
            panel3.Controls.Add(btnCerrar3);
            panel3.Location = new Point(599, 48);
            panel3.Name = "panel3";
            panel3.Size = new Size(258, 261);
            panel3.TabIndex = 10;
            // 
            // btnCobrar3
            // 
            btnCobrar3.Location = new Point(158, 191);
            btnCobrar3.Name = "btnCobrar3";
            btnCobrar3.Size = new Size(86, 23);
            btnCobrar3.TabIndex = 6;
            btnCobrar3.Text = "Cobrar";
            btnCobrar3.UseVisualStyleBackColor = true;
            btnCobrar3.Click += btnCobrar3_Click;
            // 
            // txtMonto3
            // 
            txtMonto3.Location = new Point(32, 192);
            txtMonto3.Name = "txtMonto3";
            txtMonto3.Size = new Size(100, 23);
            txtMonto3.TabIndex = 6;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(13, 195);
            label9.Name = "label9";
            label9.Size = new Size(13, 15);
            label9.TabIndex = 8;
            label9.Text = "$";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(15, 161);
            label10.Name = "label10";
            label10.Size = new Size(70, 15);
            label10.TabIndex = 6;
            label10.Text = "¿Cobrando?";
            // 
            // lblCantClientes3
            // 
            lblCantClientes3.AutoSize = true;
            lblCantClientes3.Location = new Point(15, 135);
            lblCantClientes3.Name = "lblCantClientes3";
            lblCantClientes3.Size = new Size(96, 15);
            lblCantClientes3.TabIndex = 7;
            lblCantClientes3.Text = "Clientes en cola: ";
            // 
            // lblEstado3
            // 
            lblEstado3.AutoSize = true;
            lblEstado3.Location = new Point(54, 88);
            lblEstado3.Name = "lblEstado3";
            lblEstado3.Size = new Size(45, 15);
            lblEstado3.TabIndex = 6;
            lblEstado3.Text = "Abierta";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BorderStyle = BorderStyle.FixedSingle;
            label13.Font = new Font("Segoe UI", 24F);
            label13.Location = new Point(15, 11);
            label13.Name = "label13";
            label13.Padding = new Padding(10);
            label13.Size = new Size(128, 67);
            label13.TabIndex = 0;
            label13.Text = "Caja 3";
            // 
            // btnAbrir3
            // 
            btnAbrir3.Enabled = false;
            btnAbrir3.Location = new Point(158, 40);
            btnAbrir3.Name = "btnAbrir3";
            btnAbrir3.Size = new Size(86, 23);
            btnAbrir3.TabIndex = 4;
            btnAbrir3.Text = "Abrir";
            btnAbrir3.UseVisualStyleBackColor = true;
            btnAbrir3.Click += btnAbrir3_Click;
            // 
            // btnCerrar3
            // 
            btnCerrar3.Location = new Point(158, 11);
            btnCerrar3.Name = "btnCerrar3";
            btnCerrar3.Size = new Size(86, 23);
            btnCerrar3.TabIndex = 3;
            btnCerrar3.Text = "Cerrar";
            btnCerrar3.UseVisualStyleBackColor = true;
            btnCerrar3.Click += btnCerrar3_Click;
            // 
            // btnEncolar
            // 
            btnEncolar.Location = new Point(312, 345);
            btnEncolar.Name = "btnEncolar";
            btnEncolar.Size = new Size(130, 60);
            btnEncolar.TabIndex = 11;
            btnEncolar.Text = "Ingresar nuevo Cliente a línea de Cajas";
            btnEncolar.UseVisualStyleBackColor = true;
            btnEncolar.Click += btnEncolar_Click;
            // 
            // btnFinalizar
            // 
            btnFinalizar.Location = new Point(470, 345);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(130, 60);
            btnFinalizar.TabIndex = 12;
            btnFinalizar.Text = "Finalizar Jornada";
            btnFinalizar.UseVisualStyleBackColor = true;
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(687, 336);
            label6.Name = "label6";
            label6.Size = new Size(121, 15);
            label6.TabIndex = 13;
            label6.Text = "Importe total por caja";
            // 
            // lblTotalCaja1
            // 
            lblTotalCaja1.AutoSize = true;
            lblTotalCaja1.Location = new Point(739, 362);
            lblTotalCaja1.Name = "lblTotalCaja1";
            lblTotalCaja1.Size = new Size(0, 15);
            lblTotalCaja1.TabIndex = 14;
            // 
            // lblTotalCaja2
            // 
            lblTotalCaja2.AutoSize = true;
            lblTotalCaja2.Location = new Point(739, 388);
            lblTotalCaja2.Name = "lblTotalCaja2";
            lblTotalCaja2.Size = new Size(0, 15);
            lblTotalCaja2.TabIndex = 15;
            // 
            // lblTotalCaja3
            // 
            lblTotalCaja3.AutoSize = true;
            lblTotalCaja3.Location = new Point(739, 414);
            lblTotalCaja3.Name = "lblTotalCaja3";
            lblTotalCaja3.Size = new Size(0, 15);
            lblTotalCaja3.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(687, 362);
            label7.Name = "label7";
            label7.Size = new Size(45, 15);
            label7.TabIndex = 17;
            label7.Text = "Caja 1: ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(687, 388);
            label11.Name = "label11";
            label11.Size = new Size(45, 15);
            label11.TabIndex = 18;
            label11.Text = "Caja 2: ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(687, 414);
            label12.Name = "label12";
            label12.Size = new Size(45, 15);
            label12.TabIndex = 19;
            label12.Text = "Caja 3: ";
            // 
            // frmCajero
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 451);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label7);
            Controls.Add(lblTotalCaja3);
            Controls.Add(lblTotalCaja2);
            Controls.Add(lblTotalCaja1);
            Controls.Add(label6);
            Controls.Add(btnFinalizar);
            Controls.Add(btnEncolar);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmCajero";
            Text = "Sistema de cajero";
            Load += frmCajero_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCerrar1;
        private Button btnAbrir1;
        private Panel panel1;
        private Label lblEstado1;
        private Label label4;
        private Label lblCantClientes1;
        private Button btnCobrar1;
        private TextBox txtMonto1;
        private Label label2;
        private Panel panel2;
        private Button btnCobrar2;
        private TextBox txtMonto2;
        private Label label3;
        private Label label5;
        private Label lblCantClientes2;
        private Label lblEstado2;
        private Label label8;
        private Button btnAbrir2;
        private Button btnCerrar2;
        private Panel panel3;
        private Button btnCobrar3;
        private TextBox txtMonto3;
        private Label label9;
        private Label label10;
        private Label lblCantClientes3;
        private Label lblEstado3;
        private Label label13;
        private Button btnAbrir3;
        private Button btnCerrar3;
        private Button btnEncolar;
        private Button btnFinalizar;
        private Label label6;
        private Label lblTotalCaja1;
        private Label lblTotalCaja2;
        private Label lblTotalCaja3;
        private Label label7;
        private Label label11;
        private Label label12;
    }
}
