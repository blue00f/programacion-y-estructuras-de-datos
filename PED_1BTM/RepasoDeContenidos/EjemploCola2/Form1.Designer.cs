namespace EjemploCola
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
            grillaClientes = new DataGridView();
            nombre = new DataGridViewTextBoxColumn();
            monto = new DataGridViewTextBoxColumn();
            txtNombre = new TextBox();
            txtMonto = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnEncolar = new Button();
            btnDesencolar = new Button();
            ((System.ComponentModel.ISupportInitialize)grillaClientes).BeginInit();
            SuspendLayout();
            // 
            // grillaClientes
            // 
            grillaClientes.AllowUserToAddRows = false;
            grillaClientes.AllowUserToDeleteRows = false;
            grillaClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaClientes.Columns.AddRange(new DataGridViewColumn[] { nombre, monto });
            grillaClientes.Location = new Point(260, 65);
            grillaClientes.Name = "grillaClientes";
            grillaClientes.ReadOnly = true;
            grillaClientes.RowHeadersVisible = false;
            grillaClientes.Size = new Size(366, 276);
            grillaClientes.TabIndex = 0;
            // 
            // nombre
            // 
            nombre.HeaderText = "Nombre";
            nombre.Name = "nombre";
            nombre.ReadOnly = true;
            // 
            // monto
            // 
            monto.HeaderText = "Monto";
            monto.Name = "monto";
            monto.ReadOnly = true;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(35, 116);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(156, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(35, 180);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(156, 23);
            txtMonto.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 98);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 3;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 162);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 4;
            label2.Text = "Monto";
            // 
            // btnEncolar
            // 
            btnEncolar.Location = new Point(35, 240);
            btnEncolar.Name = "btnEncolar";
            btnEncolar.Size = new Size(75, 23);
            btnEncolar.TabIndex = 5;
            btnEncolar.Text = "Encolar";
            btnEncolar.UseVisualStyleBackColor = true;
            btnEncolar.Click += btnEncolar_Click;
            // 
            // btnDesencolar
            // 
            btnDesencolar.Location = new Point(116, 240);
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
            ClientSize = new Size(691, 420);
            Controls.Add(btnDesencolar);
            Controls.Add(btnEncolar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtMonto);
            Controls.Add(txtNombre);
            Controls.Add(grillaClientes);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)grillaClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grillaClientes;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn monto;
        private TextBox txtNombre;
        private TextBox txtMonto;
        private Label label1;
        private Label label2;
        private Button btnEncolar;
        private Button btnDesencolar;
    }
}
