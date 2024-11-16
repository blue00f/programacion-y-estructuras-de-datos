namespace Ejercicio07
{
    partial class UsoDeSwap
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
            lblNota = new Label();
            grillaNumeros = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            lblGrillaTitulo = new Label();
            groupBox1 = new GroupBox();
            btnIntercambiar = new Button();
            btnIntercambiarIzquierda = new Button();
            btnIntercambiarDerecha = new Button();
            btnModificar = new Button();
            btnBorrar = new Button();
            btnAgregar = new Button();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblIngresoTitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)grillaNumeros).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblNota
            // 
            lblNota.AutoSize = true;
            lblNota.Location = new Point(374, 403);
            lblNota.Name = "lblNota";
            lblNota.Size = new Size(312, 15);
            lblNota.TabIndex = 15;
            lblNota.Text = "Nota: hacer doble click en la fila para modificar el número";
            // 
            // grillaNumeros
            // 
            grillaNumeros.AllowUserToAddRows = false;
            grillaNumeros.AllowUserToDeleteRows = false;
            grillaNumeros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaNumeros.Columns.AddRange(new DataGridViewColumn[] { id, nombre });
            grillaNumeros.Location = new Point(374, 77);
            grillaNumeros.Name = "grillaNumeros";
            grillaNumeros.ReadOnly = true;
            grillaNumeros.RowHeadersVisible = false;
            grillaNumeros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grillaNumeros.Size = new Size(312, 307);
            grillaNumeros.TabIndex = 14;
            grillaNumeros.CellDoubleClick += grillaPacientes_CellDoubleClick;
            grillaNumeros.SelectionChanged += grillaNumeros_SelectionChanged;
            // 
            // id
            // 
            id.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            id.HeaderText = "ID";
            id.Name = "id";
            id.ReadOnly = true;
            id.Width = 43;
            // 
            // nombre
            // 
            nombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nombre.HeaderText = "Nombre";
            nombre.Name = "nombre";
            nombre.ReadOnly = true;
            // 
            // lblGrillaTitulo
            // 
            lblGrillaTitulo.AutoSize = true;
            lblGrillaTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGrillaTitulo.Location = new Point(374, 34);
            lblGrillaTitulo.Name = "lblGrillaTitulo";
            lblGrillaTitulo.Size = new Size(170, 25);
            lblGrillaTitulo.TabIndex = 13;
            lblGrillaTitulo.Text = "Grilla de nombres";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnIntercambiar);
            groupBox1.Controls.Add(btnIntercambiarIzquierda);
            groupBox1.Controls.Add(btnIntercambiarDerecha);
            groupBox1.Controls.Add(btnModificar);
            groupBox1.Controls.Add(btnBorrar);
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(lblNombre);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Location = new Point(44, 77);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(284, 341);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Registro de nombres";
            // 
            // btnIntercambiar
            // 
            btnIntercambiar.Location = new Point(139, 181);
            btnIntercambiar.Name = "btnIntercambiar";
            btnIntercambiar.Size = new Size(116, 46);
            btnIntercambiar.TabIndex = 12;
            btnIntercambiar.Text = "Intercambiar";
            btnIntercambiar.UseVisualStyleBackColor = true;
            btnIntercambiar.Click += btnIntercambiar_Click;
            // 
            // btnIntercambiarIzquierda
            // 
            btnIntercambiarIzquierda.Location = new Point(139, 233);
            btnIntercambiarIzquierda.Name = "btnIntercambiarIzquierda";
            btnIntercambiarIzquierda.Size = new Size(116, 46);
            btnIntercambiarIzquierda.TabIndex = 14;
            btnIntercambiarIzquierda.Text = "Intercambiar izquierda";
            btnIntercambiarIzquierda.UseVisualStyleBackColor = true;
            btnIntercambiarIzquierda.Click += btnIntercambiarIzquierda_Click;
            // 
            // btnIntercambiarDerecha
            // 
            btnIntercambiarDerecha.Location = new Point(17, 233);
            btnIntercambiarDerecha.Name = "btnIntercambiarDerecha";
            btnIntercambiarDerecha.Size = new Size(116, 46);
            btnIntercambiarDerecha.TabIndex = 13;
            btnIntercambiarDerecha.Text = "Intercambiar derecha";
            btnIntercambiarDerecha.UseVisualStyleBackColor = true;
            btnIntercambiarDerecha.Click += btnIntercambiarDerecha_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(17, 181);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(116, 46);
            btnModificar.TabIndex = 11;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(139, 129);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(116, 46);
            btnBorrar.TabIndex = 10;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(17, 129);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(116, 46);
            btnAgregar.TabIndex = 8;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(21, 67);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(103, 64);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(152, 23);
            txtNombre.TabIndex = 3;
            // 
            // lblIngresoTitulo
            // 
            lblIngresoTitulo.AutoSize = true;
            lblIngresoTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIngresoTitulo.Location = new Point(44, 34);
            lblIngresoTitulo.Name = "lblIngresoTitulo";
            lblIngresoTitulo.Size = new Size(191, 25);
            lblIngresoTitulo.TabIndex = 16;
            lblIngresoTitulo.Text = "Ingreso de nombres";
            // 
            // UsoDeSwap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(735, 447);
            Controls.Add(lblIngresoTitulo);
            Controls.Add(lblNota);
            Controls.Add(grillaNumeros);
            Controls.Add(lblGrillaTitulo);
            Controls.Add(groupBox1);
            Name = "UsoDeSwap";
            Text = "Implementación de las funciones de intercambio o swap";
            Load += UsoDeSwap_Load;
            ((System.ComponentModel.ISupportInitialize)grillaNumeros).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNota;
        private DataGridView grillaNumeros;
        private Label lblGrillaTitulo;
        private GroupBox groupBox1;
        private Button btnModificar;
        private Button btnBorrar;
        private Label lblIngresoTitulo;
        private Button btnAgregar;
        private Label lblNombre;
        private TextBox txtNombre;
        private Button btnIntercambiar;
        private Button btnIntercambiarIzquierda;
        private Button btnIntercambiarDerecha;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn nombre;
    }
}
