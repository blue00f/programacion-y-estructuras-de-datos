namespace AltaAlumnos
{
    partial class frmAltaAlumnos
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
            idAlumno = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            apellido = new DataGridViewTextBoxColumn();
            fechaNacimiento = new DataGridViewTextBoxColumn();
            especialidad = new DataGridViewTextBoxColumn();
            anio = new DataGridViewTextBoxColumn();
            division = new DataGridViewTextBoxColumn();
            estado = new DataGridViewTextBoxColumn();
            label1 = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dateFechaNacimiento = new DateTimePicker();
            cbxEspecialidad = new ComboBox();
            cbxAnio = new ComboBox();
            cbxDivision = new ComboBox();
            btnAgregar = new Button();
            ((System.ComponentModel.ISupportInitialize)grillaAlumnos).BeginInit();
            SuspendLayout();
            // 
            // grillaAlumnos
            // 
            grillaAlumnos.AllowUserToAddRows = false;
            grillaAlumnos.AllowUserToDeleteRows = false;
            grillaAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaAlumnos.Columns.AddRange(new DataGridViewColumn[] { idAlumno, nombre, apellido, fechaNacimiento, especialidad, anio, division, estado });
            grillaAlumnos.Location = new Point(430, 15);
            grillaAlumnos.Name = "grillaAlumnos";
            grillaAlumnos.ReadOnly = true;
            grillaAlumnos.Size = new Size(779, 398);
            grillaAlumnos.TabIndex = 0;
            // 
            // idAlumno
            // 
            idAlumno.HeaderText = "ID";
            idAlumno.Name = "idAlumno";
            idAlumno.ReadOnly = true;
            idAlumno.Width = 30;
            // 
            // nombre
            // 
            nombre.HeaderText = "Nombre";
            nombre.Name = "nombre";
            nombre.ReadOnly = true;
            // 
            // apellido
            // 
            apellido.HeaderText = "Apellido";
            apellido.Name = "apellido";
            apellido.ReadOnly = true;
            // 
            // fechaNacimiento
            // 
            fechaNacimiento.HeaderText = "Fecha de nacimiento";
            fechaNacimiento.Name = "fechaNacimiento";
            fechaNacimiento.ReadOnly = true;
            // 
            // especialidad
            // 
            especialidad.HeaderText = "Especialidad";
            especialidad.Name = "especialidad";
            especialidad.ReadOnly = true;
            // 
            // anio
            // 
            anio.HeaderText = "Año";
            anio.Name = "anio";
            anio.ReadOnly = true;
            // 
            // division
            // 
            division.HeaderText = "División";
            division.Name = "division";
            division.ReadOnly = true;
            // 
            // estado
            // 
            estado.HeaderText = "Estado";
            estado.Name = "estado";
            estado.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 49);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(175, 46);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(200, 23);
            txtNombre.TabIndex = 2;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(175, 99);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(200, 23);
            txtApellido.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 102);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 3;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 155);
            label3.Name = "label3";
            label3.Size = new Size(117, 15);
            label3.TabIndex = 5;
            label3.Text = "Fecha de nacimiento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 208);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 6;
            label4.Text = "Especialidad";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(50, 261);
            label5.Name = "label5";
            label5.Size = new Size(29, 15);
            label5.TabIndex = 7;
            label5.Text = "Año";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(50, 317);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 8;
            label6.Text = "División";
            // 
            // dateFechaNacimiento
            // 
            dateFechaNacimiento.Location = new Point(175, 149);
            dateFechaNacimiento.Name = "dateFechaNacimiento";
            dateFechaNacimiento.Size = new Size(200, 23);
            dateFechaNacimiento.TabIndex = 9;
            // 
            // cbxEspecialidad
            // 
            cbxEspecialidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxEspecialidad.FormattingEnabled = true;
            cbxEspecialidad.Items.AddRange(new object[] { "Ciclo básico", "Computación", "Administración de empresas" });
            cbxEspecialidad.Location = new Point(175, 205);
            cbxEspecialidad.Name = "cbxEspecialidad";
            cbxEspecialidad.Size = new Size(200, 23);
            cbxEspecialidad.TabIndex = 10;
            // 
            // cbxAnio
            // 
            cbxAnio.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxAnio.FormattingEnabled = true;
            cbxAnio.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6" });
            cbxAnio.Location = new Point(175, 258);
            cbxAnio.Name = "cbxAnio";
            cbxAnio.Size = new Size(200, 23);
            cbxAnio.TabIndex = 11;
            // 
            // cbxDivision
            // 
            cbxDivision.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxDivision.FormattingEnabled = true;
            cbxDivision.Items.AddRange(new object[] { "1", "2", "3", "4" });
            cbxDivision.Location = new Point(175, 314);
            cbxDivision.Name = "cbxDivision";
            cbxDivision.Size = new Size(200, 23);
            cbxDivision.TabIndex = 12;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(175, 365);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(125, 48);
            btnAgregar.TabIndex = 13;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // frmAltaAlumnos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1267, 450);
            Controls.Add(btnAgregar);
            Controls.Add(cbxDivision);
            Controls.Add(cbxAnio);
            Controls.Add(cbxEspecialidad);
            Controls.Add(dateFechaNacimiento);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtApellido);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(grillaAlumnos);
            Name = "frmAltaAlumnos";
            Text = "Alta alumnos";
            ((System.ComponentModel.ISupportInitialize)grillaAlumnos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grillaAlumnos;
        private Label label1;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DateTimePicker dateFechaNacimiento;
        private ComboBox cbxEspecialidad;
        private ComboBox cbxAnio;
        private ComboBox cbxDivision;
        private Button btnAgregar;
        private DataGridViewTextBoxColumn idAlumno;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn apellido;
        private DataGridViewTextBoxColumn fechaNacimiento;
        private DataGridViewTextBoxColumn especialidad;
        private DataGridViewTextBoxColumn anio;
        private DataGridViewTextBoxColumn division;
        private DataGridViewTextBoxColumn estado;
    }
}
