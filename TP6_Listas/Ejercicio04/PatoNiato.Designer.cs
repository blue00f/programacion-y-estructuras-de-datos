namespace Ejercicio04
{
    partial class PatoNiato
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
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            groupBox1 = new GroupBox();
            btnBorrar = new Button();
            label1 = new Label();
            btnModificar = new Button();
            label2 = new Label();
            btnAgregarAbajoDelSeleccionado = new Button();
            label3 = new Label();
            btnAgregar = new Button();
            label6 = new Label();
            txtEdad = new TextBox();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDni = new TextBox();
            grillaJugadores = new DataGridView();
            nombre = new DataGridViewTextBoxColumn();
            apellido = new DataGridViewTextBoxColumn();
            edad = new DataGridViewTextBoxColumn();
            dni = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grillaJugadores).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(428, 396);
            label9.Name = "label9";
            label9.Size = new Size(307, 15);
            label9.TabIndex = 27;
            label9.Text = "Nota: hacer doble click en la fila para modificar sus datos";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label8.Location = new Point(33, 21);
            label8.Name = "label8";
            label8.Size = new Size(214, 25);
            label8.TabIndex = 26;
            label8.Text = "Datos de los jugadores";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label7.Location = new Point(428, 21);
            label7.Name = "label7";
            label7.Size = new Size(180, 25);
            label7.TabIndex = 25;
            label7.Text = "Grilla de jugadores";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnBorrar);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnModificar);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnAgregarAbajoDelSeleccionado);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtEdad);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(txtApellido);
            groupBox1.Controls.Add(txtDni);
            groupBox1.Location = new Point(33, 66);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(342, 323);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            groupBox1.Text = "Registro jugador";
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(180, 257);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(103, 39);
            btnBorrar.TabIndex = 18;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 37);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(71, 257);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(103, 39);
            btnModificar.TabIndex = 17;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 75);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 2;
            label2.Text = "Apellido";
            // 
            // btnAgregarAbajoDelSeleccionado
            // 
            btnAgregarAbajoDelSeleccionado.Location = new Point(180, 212);
            btnAgregarAbajoDelSeleccionado.Name = "btnAgregarAbajoDelSeleccionado";
            btnAgregarAbajoDelSeleccionado.Size = new Size(103, 39);
            btnAgregarAbajoDelSeleccionado.TabIndex = 16;
            btnAgregarAbajoDelSeleccionado.Text = "Agregar abajo";
            btnAgregarAbajoDelSeleccionado.UseVisualStyleBackColor = true;
            btnAgregarAbajoDelSeleccionado.Click += btnAgregarAbajoDelSeleccionado_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 156);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 3;
            label3.Text = "DNI";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(71, 212);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(103, 39);
            btnAgregar.TabIndex = 14;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(39, 116);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 6;
            label6.Text = "Edad";
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(102, 113);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(215, 23);
            txtEdad.TabIndex = 9;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(102, 37);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(215, 23);
            txtNombre.TabIndex = 7;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(102, 75);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(215, 23);
            txtApellido.TabIndex = 8;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(102, 153);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(215, 23);
            txtDni.TabIndex = 10;
            // 
            // grillaJugadores
            // 
            grillaJugadores.AllowUserToAddRows = false;
            grillaJugadores.AllowUserToDeleteRows = false;
            grillaJugadores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaJugadores.Columns.AddRange(new DataGridViewColumn[] { nombre, apellido, edad, dni });
            grillaJugadores.Location = new Point(428, 66);
            grillaJugadores.Name = "grillaJugadores";
            grillaJugadores.ReadOnly = true;
            grillaJugadores.RowHeadersVisible = false;
            grillaJugadores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grillaJugadores.Size = new Size(465, 323);
            grillaJugadores.TabIndex = 23;
            grillaJugadores.CellDoubleClick += grillaJugadores_CellDoubleClick;
            // 
            // nombre
            // 
            nombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nombre.HeaderText = "Nombre";
            nombre.Name = "nombre";
            nombre.ReadOnly = true;
            // 
            // apellido
            // 
            apellido.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            apellido.HeaderText = "Apellido";
            apellido.Name = "apellido";
            apellido.ReadOnly = true;
            // 
            // edad
            // 
            edad.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            edad.FillWeight = 120F;
            edad.HeaderText = "Edad";
            edad.Name = "edad";
            edad.ReadOnly = true;
            edad.Width = 58;
            // 
            // dni
            // 
            dni.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dni.FillWeight = 70F;
            dni.HeaderText = "DNI";
            dni.Name = "dni";
            dni.ReadOnly = true;
            // 
            // PatoNiato
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 450);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(groupBox1);
            Controls.Add(grillaJugadores);
            Name = "PatoNiato";
            Text = "Pato Ñato usando Lista Circular Simple";
            Load += PatoNiato_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grillaJugadores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private Label label8;
        private Label label7;
        private GroupBox groupBox1;
        private Button btnBorrar;
        private Label label1;
        private Button btnModificar;
        private Label label2;
        private Button btnAgregarAbajoDelSeleccionado;
        private Label label3;
        private Button btnAgregar;
        private Label label6;
        private TextBox txtEdad;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDni;
        private DataGridView grillaJugadores;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn apellido;
        private DataGridViewTextBoxColumn edad;
        private DataGridViewTextBoxColumn dni;
    }
}
