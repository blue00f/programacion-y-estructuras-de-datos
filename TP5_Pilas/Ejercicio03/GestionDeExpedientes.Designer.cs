namespace Ejercicio03
{
    partial class frmGestionDeExpedientes
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            txtNumExpediente = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtCaratula = new TextBox();
            label4 = new Label();
            btnCargarExpediente = new Button();
            gridExpedientes = new DataGridView();
            Fecha = new DataGridViewTextBoxColumn();
            numExpediente = new DataGridViewTextBoxColumn();
            Caratula = new DataGridViewTextBoxColumn();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)gridExpedientes).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(31, 71);
            dateTimePicker1.MaxDate = new DateTime(2999, 12, 31, 0, 0, 0, 0);
            dateTimePicker1.MinDate = new DateTime(1900, 2, 1, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(230, 23);
            dateTimePicker1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 53);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 2;
            label1.Text = "Fecha";
            // 
            // txtNumExpediente
            // 
            txtNumExpediente.Location = new Point(31, 130);
            txtNumExpediente.Name = "txtNumExpediente";
            txtNumExpediente.Size = new Size(230, 23);
            txtNumExpediente.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 112);
            label2.Name = "label2";
            label2.Size = new Size(128, 15);
            label2.TabIndex = 4;
            label2.Text = "Número de expediente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 171);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 6;
            label3.Text = "Carátula";
            // 
            // txtCaratula
            // 
            txtCaratula.Location = new Point(31, 189);
            txtCaratula.Name = "txtCaratula";
            txtCaratula.Size = new Size(230, 23);
            txtCaratula.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label4.Location = new Point(67, 19);
            label4.Name = "label4";
            label4.Size = new Size(149, 20);
            label4.TabIndex = 7;
            label4.Text = "DATOS EXPEDIENTE";
            // 
            // btnCargarExpediente
            // 
            btnCargarExpediente.Location = new Point(67, 243);
            btnCargarExpediente.Name = "btnCargarExpediente";
            btnCargarExpediente.Size = new Size(149, 33);
            btnCargarExpediente.TabIndex = 11;
            btnCargarExpediente.Text = "Cargar expediente";
            btnCargarExpediente.UseVisualStyleBackColor = true;
            btnCargarExpediente.Click += btnCargarExpediente_Click;
            // 
            // gridExpedientes
            // 
            gridExpedientes.AllowUserToAddRows = false;
            gridExpedientes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridExpedientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            gridExpedientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridExpedientes.Columns.AddRange(new DataGridViewColumn[] { Fecha, numExpediente, Caratula });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            gridExpedientes.DefaultCellStyle = dataGridViewCellStyle5;
            gridExpedientes.Location = new Point(309, 53);
            gridExpedientes.Name = "gridExpedientes";
            gridExpedientes.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            gridExpedientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridExpedientes.RowsDefaultCellStyle = dataGridViewCellStyle7;
            gridExpedientes.Size = new Size(429, 244);
            gridExpedientes.TabIndex = 12;
            // 
            // Fecha
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Fecha.DefaultCellStyle = dataGridViewCellStyle2;
            Fecha.HeaderText = "Fecha";
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            Fecha.SortMode = DataGridViewColumnSortMode.NotSortable;
            Fecha.Width = 120;
            // 
            // numExpediente
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            numExpediente.DefaultCellStyle = dataGridViewCellStyle3;
            numExpediente.HeaderText = "Número";
            numExpediente.Name = "numExpediente";
            numExpediente.ReadOnly = true;
            numExpediente.SortMode = DataGridViewColumnSortMode.NotSortable;
            numExpediente.Width = 90;
            // 
            // Caratula
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Caratula.DefaultCellStyle = dataGridViewCellStyle4;
            Caratula.HeaderText = "Carátula";
            Caratula.Name = "Caratula";
            Caratula.ReadOnly = true;
            Caratula.SortMode = DataGridViewColumnSortMode.NotSortable;
            Caratula.Width = 120;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label6.Location = new Point(309, 19);
            label6.Name = "label6";
            label6.Size = new Size(429, 20);
            label6.TabIndex = 13;
            label6.Text = "LISTA DE EXPEDIENTES ORDENADO POR FECHA Y NÚMERO";
            // 
            // frmGestionDeExpedientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(788, 336);
            Controls.Add(label6);
            Controls.Add(gridExpedientes);
            Controls.Add(btnCargarExpediente);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtCaratula);
            Controls.Add(label2);
            Controls.Add(txtNumExpediente);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Name = "frmGestionDeExpedientes";
            Text = "Apilamiento de expedientes";
            Load += frmGestionDeExpedientes_Load;
            ((System.ComponentModel.ISupportInitialize)gridExpedientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private TextBox txtNumExpediente;
        private Label label2;
        private Label label3;
        private TextBox txtCaratula;
        private Label label4;
        private Button btnCargarExpediente;
        private DataGridView gridExpedientes;
        private Label label6;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn numExpediente;
        private DataGridViewTextBoxColumn Caratula;
    }
}
