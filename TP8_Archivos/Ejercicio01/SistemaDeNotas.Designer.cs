namespace Ejercicio01
{
    partial class SistemaDeNotas
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
            grillaNotas = new DataGridView();
            lblAlumnos = new Label();
            lblNotas = new Label();
            lblDni = new Label();
            lblNombre = new Label();
            lblApellido = new Label();
            txtDni = new TextBox();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            btnGuardarAlumno = new Button();
            gbxAlumno = new GroupBox();
            groupBox1 = new GroupBox();
            cbxDni = new ComboBox();
            dtpFecha = new DateTimePicker();
            btnGuardarNota = new Button();
            lblDniPorNota = new Label();
            lblNota = new Label();
            txtNota = new TextBox();
            lblFecha = new Label();
            btnModificarAlumno = new Button();
            btnBorrarAlumno = new Button();
            btnBorrarNota = new Button();
            btnModificarNota = new Button();
            ((System.ComponentModel.ISupportInitialize)grillaAlumnos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grillaNotas).BeginInit();
            gbxAlumno.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // grillaAlumnos
            // 
            grillaAlumnos.AllowUserToAddRows = false;
            grillaAlumnos.AllowUserToDeleteRows = false;
            grillaAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaAlumnos.Location = new Point(47, 62);
            grillaAlumnos.Name = "grillaAlumnos";
            grillaAlumnos.ReadOnly = true;
            grillaAlumnos.RowHeadersVisible = false;
            grillaAlumnos.Size = new Size(310, 186);
            grillaAlumnos.TabIndex = 0;
            grillaAlumnos.CellDoubleClick += grillaAlumnos_CellDoubleClick;
            // 
            // grillaNotas
            // 
            grillaNotas.AllowUserToAddRows = false;
            grillaNotas.AllowUserToDeleteRows = false;
            grillaNotas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaNotas.Location = new Point(47, 312);
            grillaNotas.Name = "grillaNotas";
            grillaNotas.ReadOnly = true;
            grillaNotas.RowHeadersVisible = false;
            grillaNotas.Size = new Size(310, 186);
            grillaNotas.TabIndex = 1;
            grillaNotas.CellDoubleClick += grillaNotas_CellDoubleClick;
            // 
            // lblAlumnos
            // 
            lblAlumnos.AutoSize = true;
            lblAlumnos.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblAlumnos.Location = new Point(47, 34);
            lblAlumnos.Name = "lblAlumnos";
            lblAlumnos.Size = new Size(91, 25);
            lblAlumnos.TabIndex = 2;
            lblAlumnos.Text = "Alumnos";
            // 
            // lblNotas
            // 
            lblNotas.AutoSize = true;
            lblNotas.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblNotas.Location = new Point(47, 284);
            lblNotas.Name = "lblNotas";
            lblNotas.Size = new Size(64, 25);
            lblNotas.TabIndex = 3;
            lblNotas.Text = "Notas";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(17, 29);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(27, 15);
            lblDni.TabIndex = 4;
            lblDni.Text = "DNI";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(17, 70);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 5;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(17, 111);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 6;
            lblApellido.Text = "Apellido";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(113, 26);
            txtDni.MaxLength = 8;
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(154, 23);
            txtDni.TabIndex = 7;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(113, 67);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(154, 23);
            txtNombre.TabIndex = 8;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(113, 108);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(154, 23);
            txtApellido.TabIndex = 9;
            // 
            // btnGuardarAlumno
            // 
            btnGuardarAlumno.Location = new Point(75, 148);
            btnGuardarAlumno.Name = "btnGuardarAlumno";
            btnGuardarAlumno.Size = new Size(102, 28);
            btnGuardarAlumno.TabIndex = 10;
            btnGuardarAlumno.Text = "Guardar";
            btnGuardarAlumno.UseVisualStyleBackColor = true;
            btnGuardarAlumno.Click += btnGuardarAlumno_Click;
            // 
            // gbxAlumno
            // 
            gbxAlumno.Controls.Add(btnGuardarAlumno);
            gbxAlumno.Controls.Add(lblDni);
            gbxAlumno.Controls.Add(txtApellido);
            gbxAlumno.Controls.Add(lblNombre);
            gbxAlumno.Controls.Add(txtNombre);
            gbxAlumno.Controls.Add(lblApellido);
            gbxAlumno.Controls.Add(txtDni);
            gbxAlumno.Location = new Point(413, 62);
            gbxAlumno.Name = "gbxAlumno";
            gbxAlumno.Size = new Size(299, 186);
            gbxAlumno.TabIndex = 11;
            gbxAlumno.TabStop = false;
            gbxAlumno.Text = "Registro alumno";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbxDni);
            groupBox1.Controls.Add(dtpFecha);
            groupBox1.Controls.Add(btnGuardarNota);
            groupBox1.Controls.Add(lblDniPorNota);
            groupBox1.Controls.Add(lblNota);
            groupBox1.Controls.Add(txtNota);
            groupBox1.Controls.Add(lblFecha);
            groupBox1.Location = new Point(413, 312);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(299, 186);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Registro notas";
            // 
            // cbxDni
            // 
            cbxDni.FormattingEnabled = true;
            cbxDni.Location = new Point(113, 26);
            cbxDni.Name = "cbxDni";
            cbxDni.Size = new Size(154, 23);
            cbxDni.TabIndex = 16;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(113, 105);
            dtpFecha.MaxDate = new DateTime(2200, 1, 1, 0, 0, 0, 0);
            dtpFecha.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(154, 23);
            dtpFecha.TabIndex = 11;
            // 
            // btnGuardarNota
            // 
            btnGuardarNota.Location = new Point(75, 149);
            btnGuardarNota.Name = "btnGuardarNota";
            btnGuardarNota.Size = new Size(102, 27);
            btnGuardarNota.TabIndex = 10;
            btnGuardarNota.Text = "Guardar";
            btnGuardarNota.UseVisualStyleBackColor = true;
            btnGuardarNota.Click += btnGuardarNota_Click;
            // 
            // lblDniPorNota
            // 
            lblDniPorNota.AutoSize = true;
            lblDniPorNota.Location = new Point(17, 29);
            lblDniPorNota.Name = "lblDniPorNota";
            lblDniPorNota.Size = new Size(27, 15);
            lblDniPorNota.TabIndex = 4;
            lblDniPorNota.Text = "DNI";
            // 
            // lblNota
            // 
            lblNota.AutoSize = true;
            lblNota.Location = new Point(17, 70);
            lblNota.Name = "lblNota";
            lblNota.Size = new Size(33, 15);
            lblNota.TabIndex = 5;
            lblNota.Text = "Nota";
            // 
            // txtNota
            // 
            txtNota.Location = new Point(113, 67);
            txtNota.Name = "txtNota";
            txtNota.Size = new Size(154, 23);
            txtNota.TabIndex = 8;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(17, 111);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(38, 15);
            lblFecha.TabIndex = 6;
            lblFecha.Text = "Fecha";
            // 
            // btnModificarAlumno
            // 
            btnModificarAlumno.Location = new Point(108, 254);
            btnModificarAlumno.Name = "btnModificarAlumno";
            btnModificarAlumno.Size = new Size(75, 23);
            btnModificarAlumno.TabIndex = 11;
            btnModificarAlumno.Text = "Modificar";
            btnModificarAlumno.UseVisualStyleBackColor = true;
            btnModificarAlumno.Click += btnModificarAlumno_Click;
            // 
            // btnBorrarAlumno
            // 
            btnBorrarAlumno.Location = new Point(216, 254);
            btnBorrarAlumno.Name = "btnBorrarAlumno";
            btnBorrarAlumno.Size = new Size(75, 23);
            btnBorrarAlumno.TabIndex = 13;
            btnBorrarAlumno.Text = "Borrar";
            btnBorrarAlumno.UseVisualStyleBackColor = true;
            btnBorrarAlumno.Click += btnBorrarAlumno_Click;
            // 
            // btnBorrarNota
            // 
            btnBorrarNota.Location = new Point(216, 504);
            btnBorrarNota.Name = "btnBorrarNota";
            btnBorrarNota.Size = new Size(75, 23);
            btnBorrarNota.TabIndex = 15;
            btnBorrarNota.Text = "Borrar";
            btnBorrarNota.UseVisualStyleBackColor = true;
            btnBorrarNota.Click += btnBorrarNota_Click;
            // 
            // btnModificarNota
            // 
            btnModificarNota.Location = new Point(108, 504);
            btnModificarNota.Name = "btnModificarNota";
            btnModificarNota.Size = new Size(75, 23);
            btnModificarNota.TabIndex = 14;
            btnModificarNota.Text = "Modificar";
            btnModificarNota.UseVisualStyleBackColor = true;
            btnModificarNota.Click += btnModificarNota_Click;
            // 
            // SistemaDeNotas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 550);
            Controls.Add(btnBorrarNota);
            Controls.Add(btnModificarNota);
            Controls.Add(btnBorrarAlumno);
            Controls.Add(btnModificarAlumno);
            Controls.Add(groupBox1);
            Controls.Add(gbxAlumno);
            Controls.Add(lblNotas);
            Controls.Add(lblAlumnos);
            Controls.Add(grillaNotas);
            Controls.Add(grillaAlumnos);
            Name = "SistemaDeNotas";
            Text = "ABM de Alumno y Notas";
            Load += SistemaDeNotas_Load;
            ((System.ComponentModel.ISupportInitialize)grillaAlumnos).EndInit();
            ((System.ComponentModel.ISupportInitialize)grillaNotas).EndInit();
            gbxAlumno.ResumeLayout(false);
            gbxAlumno.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grillaAlumnos;
        private DataGridView grillaNotas;
        private Label lblAlumnos;
        private Label lblNotas;
        private Label lblDni;
        private Label lblNombre;
        private Label lblApellido;
        private TextBox txtDni;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private Button btnGuardarAlumno;
        private GroupBox gbxAlumno;
        private GroupBox groupBox1;
        private DateTimePicker dtpFecha;
        private Button btnGuardarNota;
        private Label lblDniPorNota;
        private Label lblNota;
        private TextBox txtNota;
        private Label lblFecha;
        private Button btnModificarAlumno;
        private Button btnBorrarAlumno;
        private Button btnBorrarNota;
        private Button btnModificarNota;
        private ComboBox cbxDni;
    }
}
