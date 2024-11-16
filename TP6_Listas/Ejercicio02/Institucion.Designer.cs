namespace Ejercicio02
{
    partial class Institucion
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
            grillaAlumnos = new DataGridView();
            nombre = new DataGridViewTextBoxColumn();
            apellido = new DataGridViewTextBoxColumn();
            dni = new DataGridViewTextBoxColumn();
            fechaNacimiento = new DataGridViewTextBoxColumn();
            direccion = new DataGridViewTextBoxColumn();
            telefono = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDni = new TextBox();
            txtDireccion = new TextBox();
            txtTelefono = new TextBox();
            dtpFechaNacimiento = new DateTimePicker();
            btnAgregar = new Button();
            btnAgregarArribaDelSeleccionado = new Button();
            btnAgregarAbajoDelSeleccionado = new Button();
            btnModificar = new Button();
            btnBorrar = new Button();
            groupBox1 = new GroupBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)grillaAlumnos).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // grillaAlumnos
            // 
            grillaAlumnos.AllowUserToAddRows = false;
            grillaAlumnos.AllowUserToDeleteRows = false;
            grillaAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaAlumnos.Columns.AddRange(new DataGridViewColumn[] { nombre, apellido, dni, fechaNacimiento, direccion, telefono });
            grillaAlumnos.Location = new Point(431, 73);
            grillaAlumnos.Name = "grillaAlumnos";
            grillaAlumnos.ReadOnly = true;
            grillaAlumnos.RowHeadersVisible = false;
            grillaAlumnos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grillaAlumnos.Size = new Size(635, 323);
            grillaAlumnos.TabIndex = 0;
            grillaAlumnos.CellDoubleClick += grillaAlumnos_CellDoubleClick;
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
            // dni
            // 
            dni.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dni.FillWeight = 70F;
            dni.HeaderText = "DNI";
            dni.Name = "dni";
            dni.ReadOnly = true;
            // 
            // fechaNacimiento
            // 
            fechaNacimiento.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            fechaNacimiento.FillWeight = 110F;
            fechaNacimiento.HeaderText = "Fecha de nacimiento";
            fechaNacimiento.Name = "fechaNacimiento";
            fechaNacimiento.ReadOnly = true;
            // 
            // direccion
            // 
            direccion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            direccion.FillWeight = 120F;
            direccion.HeaderText = "Dirección";
            direccion.Name = "direccion";
            direccion.ReadOnly = true;
            // 
            // telefono
            // 
            telefono.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            telefono.FillWeight = 120F;
            telefono.HeaderText = "Telefóno";
            telefono.Name = "telefono";
            telefono.ReadOnly = true;
            telefono.Width = 77;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 32);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 65);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 2;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 101);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 3;
            label3.Text = "DNI";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 137);
            label4.Name = "label4";
            label4.Size = new Size(117, 15);
            label4.TabIndex = 4;
            label4.Text = "Fecha de nacimiento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 175);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 5;
            label5.Text = "Dirección";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 213);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 6;
            label6.Text = "Teléfono";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(146, 29);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(215, 23);
            txtNombre.TabIndex = 3;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(146, 67);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(215, 23);
            txtApellido.TabIndex = 4;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(146, 103);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(215, 23);
            txtDni.TabIndex = 5;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(146, 172);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(215, 23);
            txtDireccion.TabIndex = 7;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(146, 210);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(215, 23);
            txtTelefono.TabIndex = 8;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(146, 137);
            dtpFechaNacimiento.MaxDate = new DateTime(2400, 12, 31, 0, 0, 0, 0);
            dtpFechaNacimiento.MinDate = new DateTime(1889, 12, 31, 0, 0, 0, 0);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(215, 23);
            dtpFechaNacimiento.TabIndex = 6;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(23, 273);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(103, 39);
            btnAgregar.TabIndex = 9;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnAgregarArribaDelSeleccionado
            // 
            btnAgregarArribaDelSeleccionado.Location = new Point(241, 273);
            btnAgregarArribaDelSeleccionado.Name = "btnAgregarArribaDelSeleccionado";
            btnAgregarArribaDelSeleccionado.Size = new Size(103, 39);
            btnAgregarArribaDelSeleccionado.TabIndex = 11;
            btnAgregarArribaDelSeleccionado.Text = "Agregar arriba";
            btnAgregarArribaDelSeleccionado.UseVisualStyleBackColor = true;
            btnAgregarArribaDelSeleccionado.Click += btnAgregarArribaDelSeleccionado_Click;
            // 
            // btnAgregarAbajoDelSeleccionado
            // 
            btnAgregarAbajoDelSeleccionado.Location = new Point(132, 273);
            btnAgregarAbajoDelSeleccionado.Name = "btnAgregarAbajoDelSeleccionado";
            btnAgregarAbajoDelSeleccionado.Size = new Size(103, 39);
            btnAgregarAbajoDelSeleccionado.TabIndex = 10;
            btnAgregarAbajoDelSeleccionado.Text = "Agregar abajo";
            btnAgregarAbajoDelSeleccionado.UseVisualStyleBackColor = true;
            btnAgregarAbajoDelSeleccionado.Click += btnAgregarAbajoDelSeleccionado_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(187, 318);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(103, 39);
            btnModificar.TabIndex = 13;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(78, 318);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(103, 39);
            btnBorrar.TabIndex = 12;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtpFechaNacimiento);
            groupBox1.Controls.Add(btnBorrar);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnModificar);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnAgregarAbajoDelSeleccionado);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnAgregarArribaDelSeleccionado);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtTelefono);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(txtDireccion);
            groupBox1.Controls.Add(txtApellido);
            groupBox1.Controls.Add(txtDni);
            groupBox1.Location = new Point(25, 73);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(379, 367);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Registro alumno";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label7.Location = new Point(431, 28);
            label7.Name = "label7";
            label7.Size = new Size(167, 25);
            label7.TabIndex = 20;
            label7.Text = "Grilla de alumnos";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label8.Location = new Point(25, 28);
            label8.Name = "label8";
            label8.Size = new Size(168, 25);
            label8.TabIndex = 21;
            label8.Text = "Datos del alumno";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(431, 403);
            label9.Name = "label9";
            label9.Size = new Size(307, 15);
            label9.TabIndex = 22;
            label9.Text = "Nota: hacer doble click en la fila para modificar sus datos";
            // 
            // Institucion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1110, 474);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(groupBox1);
            Controls.Add(grillaAlumnos);
            Name = "Institucion";
            Text = "ABM de Alumnos usando Lista Simplemente Enlazada";
            Load += Institucion_Load;
            ((System.ComponentModel.ISupportInitialize)grillaAlumnos).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grillaAlumnos;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn apellido;
        private DataGridViewTextBoxColumn dni;
        private DataGridViewTextBoxColumn fechaNacimiento;
        private DataGridViewTextBoxColumn direccion;
        private DataGridViewTextBoxColumn telefono;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDni;
        private TextBox txtDireccion;
        private TextBox txtTelefono;
        private DateTimePicker dtpFechaNacimiento;
        private Button btnAgregar;
        private Button btnAgregarArribaDelSeleccionado;
        private Button btnAgregarAbajoDelSeleccionado;
        private Button btnModificar;
        private Button btnBorrar;
        private GroupBox groupBox1;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}
