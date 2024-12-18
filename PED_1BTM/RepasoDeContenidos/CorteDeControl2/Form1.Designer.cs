namespace CorteDeControl2
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
            grillaVendedores = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNombre = new TextBox();
            txtProducto = new TextBox();
            txtFactura = new TextBox();
            btnAgregar = new Button();
            btnBorrar = new Button();
            btnModificar = new Button();
            groupBox1 = new GroupBox();
            radDesc = new RadioButton();
            radAsc = new RadioButton();
            grillaValores = new DataGridView();
            nombre = new DataGridViewTextBoxColumn();
            producto = new DataGridViewTextBoxColumn();
            factura = new DataGridViewTextBoxColumn();
            subtotalProducto = new DataGridViewTextBoxColumn();
            subtotalVendedor = new DataGridViewTextBoxColumn();
            totalGeneral = new DataGridViewTextBoxColumn();
            btnCorteDeControl = new Button();
            ((System.ComponentModel.ISupportInitialize)grillaVendedores).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grillaValores).BeginInit();
            SuspendLayout();
            // 
            // grillaVendedores
            // 
            grillaVendedores.AllowUserToAddRows = false;
            grillaVendedores.AllowUserToDeleteRows = false;
            grillaVendedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaVendedores.Location = new Point(150, 149);
            grillaVendedores.Name = "grillaVendedores";
            grillaVendedores.ReadOnly = true;
            grillaVendedores.RowHeadersVisible = false;
            grillaVendedores.Size = new Size(487, 376);
            grillaVendedores.TabIndex = 0;
            grillaVendedores.CellDoubleClick += grillaVendedores_CellDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 149);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 221);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 2;
            label2.Text = "Producto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 298);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 3;
            label3.Text = "Factura";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(24, 167);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 4;
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(24, 239);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(100, 23);
            txtProducto.TabIndex = 5;
            // 
            // txtFactura
            // 
            txtFactura.Location = new Point(24, 316);
            txtFactura.Name = "txtFactura";
            txtFactura.Size = new Size(100, 23);
            txtFactura.TabIndex = 6;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(24, 361);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(100, 23);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(25, 401);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(100, 23);
            btnBorrar.TabIndex = 8;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(25, 441);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(100, 23);
            btnModificar.TabIndex = 9;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radDesc);
            groupBox1.Controls.Add(radAsc);
            groupBox1.Location = new Point(150, 36);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(487, 89);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ordenamiento por vendedor y producto";
            // 
            // radDesc
            // 
            radDesc.AutoSize = true;
            radDesc.Location = new Point(19, 57);
            radDesc.Name = "radDesc";
            radDesc.Size = new Size(93, 19);
            radDesc.TabIndex = 1;
            radDesc.TabStop = true;
            radDesc.Text = "Descendente";
            radDesc.UseVisualStyleBackColor = true;
            radDesc.CheckedChanged += radDesc_CheckedChanged;
            // 
            // radAsc
            // 
            radAsc.AutoSize = true;
            radAsc.Location = new Point(19, 32);
            radAsc.Name = "radAsc";
            radAsc.Size = new Size(87, 19);
            radAsc.TabIndex = 0;
            radAsc.TabStop = true;
            radAsc.Text = "Ascendente";
            radAsc.UseVisualStyleBackColor = true;
            radAsc.CheckedChanged += radAsc_CheckedChanged;
            // 
            // grillaValores
            // 
            grillaValores.AllowUserToAddRows = false;
            grillaValores.AllowUserToDeleteRows = false;
            grillaValores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaValores.Columns.AddRange(new DataGridViewColumn[] { nombre, producto, factura, subtotalProducto, subtotalVendedor, totalGeneral });
            grillaValores.Location = new Point(694, 149);
            grillaValores.Name = "grillaValores";
            grillaValores.ReadOnly = true;
            grillaValores.RowHeadersVisible = false;
            grillaValores.Size = new Size(630, 376);
            grillaValores.TabIndex = 11;
            // 
            // nombre
            // 
            nombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nombre.HeaderText = "Nombre";
            nombre.Name = "nombre";
            nombre.ReadOnly = true;
            // 
            // producto
            // 
            producto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            producto.HeaderText = "Producto";
            producto.Name = "producto";
            producto.ReadOnly = true;
            // 
            // factura
            // 
            factura.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            factura.HeaderText = "Factura";
            factura.Name = "factura";
            factura.ReadOnly = true;
            // 
            // subtotalProducto
            // 
            subtotalProducto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            subtotalProducto.HeaderText = "Subtotal producto";
            subtotalProducto.Name = "subtotalProducto";
            subtotalProducto.ReadOnly = true;
            // 
            // subtotalVendedor
            // 
            subtotalVendedor.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            subtotalVendedor.HeaderText = "Subtotal vendedor";
            subtotalVendedor.Name = "subtotalVendedor";
            subtotalVendedor.ReadOnly = true;
            // 
            // totalGeneral
            // 
            totalGeneral.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            totalGeneral.HeaderText = "Total general";
            totalGeneral.Name = "totalGeneral";
            totalGeneral.ReadOnly = true;
            // 
            // btnCorteDeControl
            // 
            btnCorteDeControl.Location = new Point(694, 93);
            btnCorteDeControl.Name = "btnCorteDeControl";
            btnCorteDeControl.Size = new Size(134, 32);
            btnCorteDeControl.TabIndex = 12;
            btnCorteDeControl.Text = "Corte de control";
            btnCorteDeControl.UseVisualStyleBackColor = true;
            btnCorteDeControl.Click += btnCorteDeControl_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1336, 569);
            Controls.Add(btnCorteDeControl);
            Controls.Add(grillaValores);
            Controls.Add(groupBox1);
            Controls.Add(btnModificar);
            Controls.Add(btnBorrar);
            Controls.Add(btnAgregar);
            Controls.Add(txtFactura);
            Controls.Add(txtProducto);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(grillaVendedores);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)grillaVendedores).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grillaValores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grillaVendedores;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNombre;
        private TextBox txtProducto;
        private TextBox txtFactura;
        private Button btnAgregar;
        private Button btnBorrar;
        private Button btnModificar;
        private GroupBox groupBox1;
        private RadioButton radDesc;
        private RadioButton radAsc;
        private DataGridView grillaValores;
        private Button btnCorteDeControl;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn producto;
        private DataGridViewTextBoxColumn factura;
        private DataGridViewTextBoxColumn subtotalProducto;
        private DataGridViewTextBoxColumn subtotalVendedor;
        private DataGridViewTextBoxColumn totalGeneral;
    }
}
