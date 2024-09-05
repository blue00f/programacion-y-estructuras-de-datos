namespace Ejemplo02
{
    partial class frmCalculadoraDePlazoFijo
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtCapital = new TextBox();
            txtTasa = new TextBox();
            txtDias = new TextBox();
            txtInteres = new TextBox();
            txtTotal = new TextBox();
            monthCalendar1 = new MonthCalendar();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(45, 56);
            label1.Name = "label1";
            label1.Size = new Size(79, 30);
            label1.TabIndex = 0;
            label1.Text = "Capital";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(45, 123);
            label2.Name = "label2";
            label2.Size = new Size(54, 30);
            label2.TabIndex = 1;
            label2.Text = "Tasa";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(45, 199);
            label3.Name = "label3";
            label3.Size = new Size(53, 30);
            label3.TabIndex = 3;
            label3.Text = "Días";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F);
            label4.Location = new Point(45, 261);
            label4.Name = "label4";
            label4.Size = new Size(79, 30);
            label4.TabIndex = 2;
            label4.Text = "Interés";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F);
            label5.Location = new Point(45, 320);
            label5.Name = "label5";
            label5.Size = new Size(59, 30);
            label5.TabIndex = 5;
            label5.Text = "Total";
            // 
            // txtCapital
            // 
            txtCapital.Font = new Font("Segoe UI", 16F);
            txtCapital.Location = new Point(146, 53);
            txtCapital.Name = "txtCapital";
            txtCapital.Size = new Size(150, 36);
            txtCapital.TabIndex = 6;
            txtCapital.Text = "0";
            txtCapital.TextAlign = HorizontalAlignment.Right;
            txtCapital.TextChanged += txtCapital_TextChanged;
            // 
            // txtTasa
            // 
            txtTasa.Font = new Font("Segoe UI", 16F);
            txtTasa.Location = new Point(146, 123);
            txtTasa.Name = "txtTasa";
            txtTasa.Size = new Size(150, 36);
            txtTasa.TabIndex = 7;
            txtTasa.Text = "0";
            txtTasa.TextAlign = HorizontalAlignment.Right;
            txtTasa.TextChanged += txtCapital_TextChanged;
            // 
            // txtDias
            // 
            txtDias.Font = new Font("Segoe UI", 16F);
            txtDias.Location = new Point(146, 196);
            txtDias.Name = "txtDias";
            txtDias.ReadOnly = true;
            txtDias.Size = new Size(150, 36);
            txtDias.TabIndex = 8;
            txtDias.Text = "0";
            txtDias.TextAlign = HorizontalAlignment.Right;
            txtDias.TextChanged += txtCapital_TextChanged;
            // 
            // txtInteres
            // 
            txtInteres.Font = new Font("Segoe UI", 16F);
            txtInteres.Location = new Point(146, 258);
            txtInteres.Name = "txtInteres";
            txtInteres.ReadOnly = true;
            txtInteres.Size = new Size(150, 36);
            txtInteres.TabIndex = 9;
            txtInteres.Text = "0";
            txtInteres.TextAlign = HorizontalAlignment.Right;
            // 
            // txtTotal
            // 
            txtTotal.Font = new Font("Segoe UI", 16F);
            txtTotal.Location = new Point(146, 317);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(150, 36);
            txtTotal.TabIndex = 10;
            txtTotal.Text = "0";
            txtTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // monthCalendar1
            // 
            monthCalendar1.CalendarDimensions = new Size(2, 2);
            monthCalendar1.Location = new Point(331, 53);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(45, 395);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(309, 15);
            linkLabel1.TabIndex = 11;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Información sobre el valor de la tasa en diferentes bancos";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // frmCalculadoraDePlazoFijo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(892, 450);
            Controls.Add(linkLabel1);
            Controls.Add(monthCalendar1);
            Controls.Add(txtTotal);
            Controls.Add(txtInteres);
            Controls.Add(txtDias);
            Controls.Add(txtTasa);
            Controls.Add(txtCapital);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmCalculadoraDePlazoFijo";
            Text = "Calculadora de plazo fijo";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtCapital;
        private TextBox txtTasa;
        private TextBox txtDias;
        private TextBox txtInteres;
        private TextBox txtTotal;
        private MonthCalendar monthCalendar1;
        private LinkLabel linkLabel1;
    }
}
