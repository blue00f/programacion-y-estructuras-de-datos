namespace Ejercicio05
{
    partial class Hospital
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
            label8 = new Label();
            label7 = new Label();
            grillaPacientes = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            apellido = new DataGridViewTextBoxColumn();
            direccion = new DataGridViewTextBoxColumn();
            telefono = new DataGridViewTextBoxColumn();
            label6 = new Label();
            groupBox1 = new GroupBox();
            btnSalir = new Button();
            btnModificar = new Button();
            label5 = new Label();
            btnBorrar = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnAgregar = new Button();
            txtTelefono = new TextBox();
            label1 = new Label();
            txtId = new TextBox();
            txtDireccion = new TextBox();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            ((System.ComponentModel.ISupportInitialize)grillaPacientes).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label8.Location = new Point(40, 43);
            label8.Name = "label8";
            label8.Size = new Size(175, 25);
            label8.TabIndex = 16;
            label8.Text = "Datos del paciente";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(362, 444);
            label7.Name = "label7";
            label7.Size = new Size(307, 15);
            label7.TabIndex = 15;
            label7.Text = "Nota: hacer doble click en la fila para modificar sus datos";
            // 
            // grillaPacientes
            // 
            grillaPacientes.AllowUserToAddRows = false;
            grillaPacientes.AllowUserToDeleteRows = false;
            grillaPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaPacientes.Columns.AddRange(new DataGridViewColumn[] { id, nombre, apellido, direccion, telefono });
            grillaPacientes.Location = new Point(362, 86);
            grillaPacientes.Name = "grillaPacientes";
            grillaPacientes.ReadOnly = true;
            grillaPacientes.RowHeadersVisible = false;
            grillaPacientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grillaPacientes.Size = new Size(555, 355);
            grillaPacientes.TabIndex = 14;
            grillaPacientes.CellDoubleClick += grillaPacientes_CellDoubleClick;
            // 
            // id
            // 
            id.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            id.HeaderText = "Código";
            id.Name = "id";
            id.ReadOnly = true;
            id.Width = 71;
            // 
            // nombre
            // 
            nombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            nombre.HeaderText = "Nombre";
            nombre.Name = "nombre";
            nombre.ReadOnly = true;
            nombre.Width = 76;
            // 
            // apellido
            // 
            apellido.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            apellido.HeaderText = "Apellido";
            apellido.Name = "apellido";
            apellido.ReadOnly = true;
            apellido.Width = 76;
            // 
            // direccion
            // 
            direccion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            direccion.HeaderText = "Dirección";
            direccion.Name = "direccion";
            direccion.ReadOnly = true;
            // 
            // telefono
            // 
            telefono.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            telefono.HeaderText = "Teléfono";
            telefono.Name = "telefono";
            telefono.ReadOnly = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(362, 43);
            label6.Name = "label6";
            label6.Size = new Size(174, 25);
            label6.TabIndex = 13;
            label6.Text = "Grilla de pacientes";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSalir);
            groupBox1.Controls.Add(btnModificar);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(btnBorrar);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(txtTelefono);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(txtDireccion);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(txtApellido);
            groupBox1.Location = new Point(40, 81);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(284, 391);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Registro paciente";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(135, 314);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(116, 46);
            btnSalir.TabIndex = 11;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(17, 314);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(116, 46);
            btnModificar.TabIndex = 10;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 219);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 4;
            label5.Text = "Teléfono";
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(135, 262);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(116, 46);
            btnBorrar.TabIndex = 9;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 175);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 4;
            label4.Text = "Dirección";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 135);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 4;
            label3.Text = "Apellido";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 93);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 4;
            label2.Text = "Nombre";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(17, 262);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(116, 46);
            btnAgregar.TabIndex = 8;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(99, 216);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(152, 23);
            txtTelefono.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 51);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 3;
            label1.Text = "Código";
            // 
            // txtId
            // 
            txtId.Location = new Point(99, 48);
            txtId.Name = "txtId";
            txtId.Size = new Size(152, 23);
            txtId.TabIndex = 3;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(99, 175);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(152, 23);
            txtDireccion.TabIndex = 6;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(99, 90);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(152, 23);
            txtNombre.TabIndex = 4;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(99, 132);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(152, 23);
            txtApellido.TabIndex = 5;
            // 
            // Hospital
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 500);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(grillaPacientes);
            Controls.Add(label6);
            Controls.Add(groupBox1);
            Name = "Hospital";
            Text = "ABM de Pacientes usando Lista Doblemente Enlazada";
            Load += Hospital_Load;
            ((System.ComponentModel.ISupportInitialize)grillaPacientes).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private Label label7;
        private DataGridView grillaPacientes;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn apellido;
        private DataGridViewTextBoxColumn direccion;
        private DataGridViewTextBoxColumn telefono;
        private Label label6;
        private GroupBox groupBox1;
        private Button btnModificar;
        private Label label5;
        private Button btnBorrar;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnAgregar;
        private TextBox txtTelefono;
        private Label label1;
        private TextBox txtId;
        private TextBox txtDireccion;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private Button btnSalir;
    }
}
