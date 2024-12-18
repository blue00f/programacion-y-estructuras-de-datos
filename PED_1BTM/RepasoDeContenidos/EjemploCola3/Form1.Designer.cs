namespace EjemploCola2
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
            grillaCoches = new DataGridView();
            modelo = new DataGridViewTextBoxColumn();
            tipoMotor = new DataGridViewTextBoxColumn();
            txtModelo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            cbxTipoDeMotor = new ComboBox();
            btnEncolar = new Button();
            btnDesencolar = new Button();
            ((System.ComponentModel.ISupportInitialize)grillaCoches).BeginInit();
            SuspendLayout();
            // 
            // grillaCoches
            // 
            grillaCoches.AllowUserToAddRows = false;
            grillaCoches.AllowUserToDeleteRows = false;
            grillaCoches.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaCoches.Columns.AddRange(new DataGridViewColumn[] { modelo, tipoMotor });
            grillaCoches.Location = new Point(216, 63);
            grillaCoches.Name = "grillaCoches";
            grillaCoches.ReadOnly = true;
            grillaCoches.RowHeadersVisible = false;
            grillaCoches.Size = new Size(292, 244);
            grillaCoches.TabIndex = 0;
            // 
            // modelo
            // 
            modelo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            modelo.HeaderText = "Modelo";
            modelo.Name = "modelo";
            modelo.ReadOnly = true;
            // 
            // tipoMotor
            // 
            tipoMotor.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tipoMotor.HeaderText = "Tipo de motor";
            tipoMotor.Name = "tipoMotor";
            tipoMotor.ReadOnly = true;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(42, 81);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(121, 23);
            txtModelo.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 63);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 2;
            label1.Text = "Modelo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 163);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 3;
            label2.Text = "Tipo de motor";
            // 
            // cbxTipoDeMotor
            // 
            cbxTipoDeMotor.FormattingEnabled = true;
            cbxTipoDeMotor.Location = new Point(42, 181);
            cbxTipoDeMotor.Name = "cbxTipoDeMotor";
            cbxTipoDeMotor.Size = new Size(121, 23);
            cbxTipoDeMotor.TabIndex = 4;
            // 
            // btnEncolar
            // 
            btnEncolar.Location = new Point(42, 244);
            btnEncolar.Name = "btnEncolar";
            btnEncolar.Size = new Size(75, 23);
            btnEncolar.TabIndex = 5;
            btnEncolar.Text = "Encolar";
            btnEncolar.UseVisualStyleBackColor = true;
            btnEncolar.Click += btnEncolar_Click;
            // 
            // btnDesencolar
            // 
            btnDesencolar.Location = new Point(42, 284);
            btnDesencolar.Name = "btnDesencolar";
            btnDesencolar.Size = new Size(75, 23);
            btnDesencolar.TabIndex = 6;
            btnDesencolar.Text = "Desencolar";
            btnDesencolar.UseVisualStyleBackColor = true;
            btnDesencolar.Click += btnDesencolar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 395);
            Controls.Add(btnDesencolar);
            Controls.Add(btnEncolar);
            Controls.Add(cbxTipoDeMotor);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtModelo);
            Controls.Add(grillaCoches);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)grillaCoches).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grillaCoches;
        private DataGridViewTextBoxColumn modelo;
        private DataGridViewTextBoxColumn tipoMotor;
        private TextBox txtModelo;
        private Label label1;
        private Label label2;
        private ComboBox cbxTipoDeMotor;
        private Button btnEncolar;
        private Button btnDesencolar;
    }
}
