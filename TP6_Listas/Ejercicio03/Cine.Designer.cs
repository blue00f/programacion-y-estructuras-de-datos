namespace Ejercicio03
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
            grillaClientes = new DataGridView();
            nombre = new DataGridViewTextBoxColumn();
            apellido = new DataGridViewTextBoxColumn();
            edad = new DataGridViewTextBoxColumn();
            monto = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            btnAgregar = new Button();
            btnAgregarAbajo = new Button();
            btnModificar = new Button();
            btnBorrar = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            groupBox1 = new GroupBox();
            label7 = new Label();
            txtTotalRecaudado = new TextBox();
            label6 = new Label();
            label9 = new Label();
            label8 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            ((System.ComponentModel.ISupportInitialize)grillaClientes).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // grillaClientes
            // 
            grillaClientes.AllowUserToAddRows = false;
            grillaClientes.AllowUserToDeleteRows = false;
            grillaClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaClientes.Columns.AddRange(new DataGridViewColumn[] { nombre, apellido, edad, monto });
            grillaClientes.Location = new Point(388, 77);
            grillaClientes.Name = "grillaClientes";
            grillaClientes.ReadOnly = true;
            grillaClientes.RowHeadersVisible = false;
            grillaClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grillaClientes.Size = new Size(436, 292);
            grillaClientes.TabIndex = 0;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 44);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
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
            // txtNombre
            // 
            txtNombre.Location = new Point(90, 44);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(183, 23);
            txtNombre.TabIndex = 3;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(90, 84);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(183, 23);
            txtApellido.TabIndex = 4;
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
            // btnAgregarAbajo
            // 
            btnAgregarAbajo.Location = new Point(169, 195);
            btnAgregarAbajo.Name = "btnAgregarAbajo";
            btnAgregarAbajo.Size = new Size(104, 34);
            btnAgregarAbajo.TabIndex = 6;
            btnAgregarAbajo.Text = "Agregar abajo";
            btnAgregarAbajo.UseVisualStyleBackColor = true;
            btnAgregarAbajo.Click += btnAgregarAbajo_Click;
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
            // btnBorrar
            // 
            btnBorrar.Location = new Point(169, 241);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(104, 34);
            btnBorrar.TabIndex = 8;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 158);
            label4.Name = "label4";
            label4.Size = new Size(202, 15);
            label4.TabIndex = 10;
            label4.Text = "El monto se calcula en base a la edad";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label5.Location = new Point(388, 39);
            label5.Name = "label5";
            label5.Size = new Size(157, 25);
            label5.TabIndex = 11;
            label5.Text = "Grilla de clientes";
            // 
            // groupBox1
            // 
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
            groupBox1.Controls.Add(btnAgregarAbajo);
            groupBox1.Location = new Point(50, 77);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(309, 340);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Registro clientes";
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
            // txtTotalRecaudado
            // 
            txtTotalRecaudado.Location = new Point(120, 297);
            txtTotalRecaudado.Name = "txtTotalRecaudado";
            txtTotalRecaudado.ReadOnly = true;
            txtTotalRecaudado.Size = new Size(153, 23);
            txtTotalRecaudado.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label6.Location = new Point(50, 39);
            label6.Name = "label6";
            label6.Size = new Size(158, 25);
            label6.TabIndex = 13;
            label6.Text = "Datos del cliente";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(388, 372);
            label9.Name = "label9";
            label9.Size = new Size(307, 15);
            label9.TabIndex = 23;
            label9.Text = "Nota: hacer doble click en la fila para modificar sus datos";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(388, 411);
            label8.Name = "label8";
            label8.Size = new Size(235, 15);
            label8.TabIndex = 24;
            label8.Text = "Cada entrada tiene un precio base de $3000";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(388, 441);
            label10.Name = "label10";
            label10.Size = new Size(359, 15);
            label10.TabIndex = 25;
            label10.Text = "Se aplica un descuento del 75% si el cliente tiene entre 50 y 60 años";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(388, 426);
            label11.Name = "label11";
            label11.Size = new Size(353, 15);
            label11.TabIndex = 26;
            label11.Text = "Se aplica un descuento del 50% si el cliente tiene entre 5 y 13 años";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label12.Location = new Point(388, 396);
            label12.Name = "label12";
            label12.Size = new Size(314, 15);
            label12.TabIndex = 27;
            label12.Text = "EXPLICACIÓN DEL VALOR DEL MONTO SEGÚN LA EDAD";
            // 
            // Cine
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(874, 490);
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
            Text = "Aplicación de Cine usando Lista Simplemente Enlazada";
            Load += Cine_Load;
            ((System.ComponentModel.ISupportInitialize)grillaClientes).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grillaClientes;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn apellido;
        private DataGridViewTextBoxColumn edad;
        private DataGridViewTextBoxColumn monto;
        private Label label1;
        private Label label2;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private Button btnAgregar;
        private Button btnAgregarAbajo;
        private Button btnModificar;
        private Button btnBorrar;
        private Label label3;
        private Label label4;
        private Label label5;
        private GroupBox groupBox1;
        private Label label6;
        private Label label9;
        private Label label7;
        private TextBox txtTotalRecaudado;
        private Label label8;
        private Label label10;
        private Label label11;
        private Label label12;
    }
}
