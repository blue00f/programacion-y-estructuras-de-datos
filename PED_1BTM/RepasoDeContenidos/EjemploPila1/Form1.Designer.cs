namespace EjemploPila1
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
            dateFechaNaci = new DateTimePicker();
            label1 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            gridClientes = new DataGridView();
            nombre = new DataGridViewTextBoxColumn();
            fechaNacimiento = new DataGridViewTextBoxColumn();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnApilar = new Button();
            btnDesapilar = new Button();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)gridClientes).BeginInit();
            SuspendLayout();
            // 
            // dateFechaNaci
            // 
            dateFechaNaci.Location = new Point(67, 141);
            dateFechaNaci.MinDate = new DateTime(1850, 1, 1, 0, 0, 0, 0);
            dateFechaNaci.Name = "dateFechaNaci";
            dateFechaNaci.Size = new Size(224, 23);
            dateFechaNaci.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 123);
            label1.Name = "label1";
            label1.Size = new Size(117, 15);
            label1.TabIndex = 1;
            label1.Text = "Fecha de nacimiento";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(67, 82);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(224, 23);
            txtNombre.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 64);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 3;
            label2.Text = "Nombre";
            // 
            // gridClientes
            // 
            gridClientes.AllowUserToAddRows = false;
            gridClientes.AllowUserToDeleteRows = false;
            gridClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridClientes.Columns.AddRange(new DataGridViewColumn[] { nombre, fechaNacimiento });
            gridClientes.Location = new Point(406, 64);
            gridClientes.Name = "gridClientes";
            gridClientes.ReadOnly = true;
            gridClientes.Size = new Size(350, 268);
            gridClientes.TabIndex = 4;
            // 
            // nombre
            // 
            nombre.HeaderText = "Nombre";
            nombre.Name = "nombre";
            nombre.ReadOnly = true;
            // 
            // fechaNacimiento
            // 
            fechaNacimiento.HeaderText = "Fecha de nacimiento";
            fechaNacimiento.Name = "fechaNacimiento";
            fechaNacimiento.ReadOnly = true;
            // 
            // btnApilar
            // 
            btnApilar.Location = new Point(67, 201);
            btnApilar.Name = "btnApilar";
            btnApilar.Size = new Size(75, 23);
            btnApilar.TabIndex = 5;
            btnApilar.Text = "Apilar";
            btnApilar.UseVisualStyleBackColor = true;
            btnApilar.Click += btnApilar_Click;
            // 
            // btnDesapilar
            // 
            btnDesapilar.Location = new Point(67, 244);
            btnDesapilar.Name = "btnDesapilar";
            btnDesapilar.Size = new Size(75, 23);
            btnDesapilar.TabIndex = 6;
            btnDesapilar.Text = "Desapilar";
            btnDesapilar.UseVisualStyleBackColor = true;
            btnDesapilar.Click += btnDesapilar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(67, 291);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(825, 402);
            Controls.Add(btnSalir);
            Controls.Add(btnDesapilar);
            Controls.Add(btnApilar);
            Controls.Add(gridClientes);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(dateFechaNaci);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)gridClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateFechaNaci;
        private Label label1;
        private TextBox txtNombre;
        private Label label2;
        private DataGridView gridClientes;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn fechaNacimiento;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnApilar;
        private Button btnDesapilar;
        private Button btnSalir;
    }
}
