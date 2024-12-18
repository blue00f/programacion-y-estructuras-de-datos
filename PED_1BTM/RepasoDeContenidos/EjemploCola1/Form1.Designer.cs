namespace EjemploCola1
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
            gridClientes = new DataGridView();
            nombre = new DataGridViewTextBoxColumn();
            apellido = new DataGridViewTextBoxColumn();
            edad = new DataGridViewTextBoxColumn();
            btnEncolar = new Button();
            btnDesencolar = new Button();
            btnVer = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNombre = new TextBox();
            txtApe = new TextBox();
            txtEdad = new TextBox();
            ((System.ComponentModel.ISupportInitialize)gridClientes).BeginInit();
            SuspendLayout();
            // 
            // gridClientes
            // 
            gridClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridClientes.Columns.AddRange(new DataGridViewColumn[] { nombre, apellido, edad });
            gridClientes.Location = new Point(238, 41);
            gridClientes.Name = "gridClientes";
            gridClientes.Size = new Size(437, 259);
            gridClientes.TabIndex = 0;
            // 
            // nombre
            // 
            nombre.HeaderText = "Nombre";
            nombre.Name = "nombre";
            // 
            // apellido
            // 
            apellido.HeaderText = "Apellido";
            apellido.Name = "apellido";
            // 
            // edad
            // 
            edad.HeaderText = "Edad";
            edad.Name = "edad";
            // 
            // btnEncolar
            // 
            btnEncolar.Location = new Point(66, 315);
            btnEncolar.Name = "btnEncolar";
            btnEncolar.Size = new Size(75, 23);
            btnEncolar.TabIndex = 1;
            btnEncolar.Text = "Encolar";
            btnEncolar.UseVisualStyleBackColor = true;
            btnEncolar.Click += btnApilar_Click;
            // 
            // btnDesencolar
            // 
            btnDesencolar.Location = new Point(238, 315);
            btnDesencolar.Name = "btnDesencolar";
            btnDesencolar.Size = new Size(75, 23);
            btnDesencolar.TabIndex = 2;
            btnDesencolar.Text = "Desencolar";
            btnDesencolar.UseVisualStyleBackColor = true;
            btnDesencolar.Click += btnDesapilar_Click;
            // 
            // btnVer
            // 
            btnVer.Location = new Point(328, 315);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(75, 23);
            btnVer.TabIndex = 3;
            btnVer.Text = "Ver";
            btnVer.UseVisualStyleBackColor = true;
            btnVer.Click += btnVer_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 41);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 4;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 95);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 5;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(66, 152);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 6;
            label3.Text = "Edad";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(66, 59);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 7;
            // 
            // txtApe
            // 
            txtApe.Location = new Point(66, 113);
            txtApe.Name = "txtApe";
            txtApe.Size = new Size(100, 23);
            txtApe.TabIndex = 8;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(66, 170);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(100, 23);
            txtEdad.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(740, 395);
            Controls.Add(txtEdad);
            Controls.Add(txtApe);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnVer);
            Controls.Add(btnDesencolar);
            Controls.Add(btnEncolar);
            Controls.Add(gridClientes);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)gridClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridClientes;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn apellido;
        private DataGridViewTextBoxColumn edad;
        private Button btnEncolar;
        private Button btnDesencolar;
        private Button btnVer;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNombre;
        private TextBox txtApe;
        private TextBox txtEdad;
    }
}
