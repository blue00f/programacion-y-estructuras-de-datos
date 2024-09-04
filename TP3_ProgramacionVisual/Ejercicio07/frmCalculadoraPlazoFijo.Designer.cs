namespace Ejercicio07
{
    partial class frmPlazoFijo
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            txtMonto = new TextBox();
            txtTasa = new TextBox();
            label2 = new Label();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            btnAgregar = new Button();
            txtDias = new TextBox();
            monto = new DataGridViewTextBoxColumn();
            tasaAnual = new DataGridViewTextBoxColumn();
            diasImposicion = new DataGridViewTextBoxColumn();
            interesPlazoFijo = new DataGridViewTextBoxColumn();
            total = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { monto, tasaAnual, diasImposicion, interesPlazoFijo, total });
            dataGridView1.Location = new Point(350, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(696, 246);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 72);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 1;
            label1.Text = "Monto";
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(95, 69);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(114, 23);
            txtMonto.TabIndex = 2;
            // 
            // txtTasa
            // 
            txtTasa.Location = new Point(95, 117);
            txtTasa.Name = "txtTasa";
            txtTasa.Size = new Size(114, 23);
            txtTasa.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 120);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 3;
            label2.Text = "Tasa";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 163);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 5;
            label3.Text = "Días";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(215, 160);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(114, 23);
            dateTimePicker1.TabIndex = 6;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(39, 215);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtDias
            // 
            txtDias.Location = new Point(95, 160);
            txtDias.Name = "txtDias";
            txtDias.ReadOnly = true;
            txtDias.Size = new Size(114, 23);
            txtDias.TabIndex = 8;
            // 
            // monto
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            monto.DefaultCellStyle = dataGridViewCellStyle1;
            monto.HeaderText = "Monto";
            monto.Name = "monto";
            monto.ReadOnly = true;
            // 
            // tasaAnual
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tasaAnual.DefaultCellStyle = dataGridViewCellStyle2;
            tasaAnual.HeaderText = "Tasa Nominal Anual";
            tasaAnual.Name = "tasaAnual";
            tasaAnual.ReadOnly = true;
            tasaAnual.Width = 150;
            // 
            // diasImposicion
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            diasImposicion.DefaultCellStyle = dataGridViewCellStyle3;
            diasImposicion.HeaderText = "Días de imposición";
            diasImposicion.Name = "diasImposicion";
            diasImposicion.ReadOnly = true;
            diasImposicion.Width = 150;
            // 
            // interesPlazoFijo
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            interesPlazoFijo.DefaultCellStyle = dataGridViewCellStyle4;
            interesPlazoFijo.HeaderText = "Interés de plazo fijo";
            interesPlazoFijo.Name = "interesPlazoFijo";
            interesPlazoFijo.ReadOnly = true;
            interesPlazoFijo.Width = 150;
            // 
            // total
            // 
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            total.DefaultCellStyle = dataGridViewCellStyle5;
            total.HeaderText = "Total";
            total.Name = "total";
            total.ReadOnly = true;
            // 
            // frmPlazoFijo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1083, 292);
            Controls.Add(txtDias);
            Controls.Add(btnAgregar);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(txtTasa);
            Controls.Add(label2);
            Controls.Add(txtMonto);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "frmPlazoFijo";
            Text = "Calculadora de plazos fijos";
            Load += frmPlazoFijo_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox txtMonto;
        private TextBox txtTasa;
        private Label label2;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Button btnAgregar;
        private TextBox txtDias;
        private DataGridViewTextBoxColumn monto;
        private DataGridViewTextBoxColumn tasaAnual;
        private DataGridViewTextBoxColumn diasImposicion;
        private DataGridViewTextBoxColumn interesPlazoFijo;
        private DataGridViewTextBoxColumn total;
    }
}
