namespace Ejercicio06
{
    partial class Cine
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
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label8 = new Label();
            label9 = new Label();
            label6 = new Label();
            groupBox1 = new GroupBox();
            btnSalir = new Button();
            label7 = new Label();
            txtApellido = new TextBox();
            txtTotalRecaudado = new TextBox();
            label1 = new Label();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNombre = new TextBox();
            btnBorrar = new Button();
            btnAgregar = new Button();
            btnModificar = new Button();
            label5 = new Label();
            grillaClientes = new DataGridView();
            nombre = new DataGridViewTextBoxColumn();
            apellido = new DataGridViewTextBoxColumn();
            edad = new DataGridViewTextBoxColumn();
            monto = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grillaClientes).BeginInit();
            SuspendLayout();
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label12.Location = new Point(385, 395);
            label12.Name = "label12";
            label12.Size = new Size(314, 15);
            label12.TabIndex = 36;
            label12.Text = "EXPLICACIÓN DEL VALOR DEL MONTO SEGÚN LA EDAD";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(385, 425);
            label11.Name = "label11";
            label11.Size = new Size(353, 15);
            label11.TabIndex = 35;
            label11.Text = "Se aplica un descuento del 50% si el cliente tiene entre 5 y 13 años";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(385, 440);
            label10.Name = "label10";
            label10.Size = new Size(359, 15);
            label10.TabIndex = 34;
            label10.Text = "Se aplica un descuento del 75% si el cliente tiene entre 50 y 60 años";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(385, 410);
            label8.Name = "label8";
            label8.Size = new Size(235, 15);
            label8.TabIndex = 33;
            label8.Text = "Cada entrada tiene un precio base de $3000";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(385, 371);
            label9.Name = "label9";
            label9.Size = new Size(307, 15);
            label9.TabIndex = 32;
            label9.Text = "Nota: hacer doble click en la fila para modificar sus datos";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label6.Location = new Point(47, 38);
            label6.Name = "label6";
            label6.Size = new Size(158, 25);
            label6.TabIndex = 31;
            label6.Text = "Datos del cliente";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSalir);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtApellido);
            groupBox1.Controls.Add(txtTotalRecaudado);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(btnBorrar);
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(btnModificar);
            groupBox1.Location = new Point(47, 76);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(309, 340);
            groupBox1.TabIndex = 30;
            groupBox1.TabStop = false;
            groupBox1.Text = "Registro clientes";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(169, 241);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(104, 34);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 300);
            label7.Name = "label7";
            label7.Size = new Size(91, 15);
            label7.TabIndex = 11;
            label7.Text = "Total recaudado";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(90, 84);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(183, 23);
            txtApellido.TabIndex = 4;
            // 
            // txtTotalRecaudado
            // 
            txtTotalRecaudado.Location = new Point(120, 297);
            txtTotalRecaudado.Name = "txtTotalRecaudado";
            txtTotalRecaudado.ReadOnly = true;
            txtTotalRecaudado.Size = new Size(153, 23);
            txtTotalRecaudado.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 44);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 158);
            label4.Name = "label4";
            label4.Size = new Size(202, 15);
            label4.TabIndex = 10;
            label4.Text = "El monto se calcula en base a la edad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 87);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 2;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 134);
            label3.Name = "label3";
            label3.Size = new Size(250, 15);
            label3.TabIndex = 9;
            label3.Text = "La edad se obtiene aleatoriamente entre 5 y 60";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(90, 44);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(183, 23);
            txtNombre.TabIndex = 3;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(169, 195);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(104, 34);
            btnBorrar.TabIndex = 6;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(40, 195);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(104, 34);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(40, 241);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(104, 34);
            btnModificar.TabIndex = 7;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label5.Location = new Point(385, 38);
            label5.Name = "label5";
            label5.Size = new Size(157, 25);
            label5.TabIndex = 29;
            label5.Text = "Grilla de clientes";
            // 
            // grillaClientes
            // 
            grillaClientes.AllowUserToAddRows = false;
            grillaClientes.AllowUserToDeleteRows = false;
            grillaClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaClientes.Columns.AddRange(new DataGridViewColumn[] { nombre, apellido, edad, monto });
            grillaClientes.Location = new Point(385, 76);
            grillaClientes.Name = "grillaClientes";
            grillaClientes.ReadOnly = true;
            grillaClientes.RowHeadersVisible = false;
            grillaClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grillaClientes.Size = new Size(436, 292);
            grillaClientes.TabIndex = 28;
            grillaClientes.CellDoubleClick += grillaClientes_CellDoubleClick;
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
            edad.HeaderText = "Edad";
            edad.Name = "edad";
            edad.ReadOnly = true;
            edad.Width = 58;
            // 
            // monto
            // 
            monto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            monto.HeaderText = "Monto";
            monto.Name = "monto";
            monto.ReadOnly = true;
            // 
            // Cine
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(868, 493);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label6);
            Controls.Add(groupBox1);
            Controls.Add(label5);
            Controls.Add(grillaClientes);
            Name = "Cine";
            Text = "Aplicación de Cine usando Lista Doblemente Enlazada";
            Load += Cine_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grillaClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label12;
        private Label label11;
        private Label label10;
        private Label label8;
        private Label label9;
        private Label label6;
        private GroupBox groupBox1;
        private Label label7;
        private TextBox txtApellido;
        private TextBox txtTotalRecaudado;
        private Label label1;
        private Label label4;
        private Label label2;
        private Label label3;
        private TextBox txtNombre;
        private Button btnBorrar;
        private Button btnAgregar;
        private Button btnModificar;
        private Label label5;
        private DataGridView grillaClientes;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn apellido;
        private DataGridViewTextBoxColumn edad;
        private DataGridViewTextBoxColumn monto;
        private Button btnSalir;
    }
}
