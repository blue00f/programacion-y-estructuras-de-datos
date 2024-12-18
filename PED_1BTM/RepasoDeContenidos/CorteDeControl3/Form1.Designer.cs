namespace CorteDeControl3
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
            label4 = new Label();
            txtVendedor = new TextBox();
            txtProducto = new TextBox();
            txtCantidad = new TextBox();
            txtFactura = new TextBox();
            btnAgregar = new Button();
            btnBorrar = new Button();
            btnModificar = new Button();
            groupBox1 = new GroupBox();
            radDesc = new RadioButton();
            radAsc = new RadioButton();
            grillaTotales = new DataGridView();
            vendedor = new DataGridViewTextBoxColumn();
            producto = new DataGridViewTextBoxColumn();
            cantidad = new DataGridViewTextBoxColumn();
            factura = new DataGridViewTextBoxColumn();
            subtotalProducto = new DataGridViewTextBoxColumn();
            subtotalVendedor = new DataGridViewTextBoxColumn();
            total = new DataGridViewTextBoxColumn();
            btnCorte = new Button();
            ((System.ComponentModel.ISupportInitialize)grillaVendedores).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grillaTotales).BeginInit();
            SuspendLayout();
            // 
            // grillaVendedores
            // 
            grillaVendedores.AllowUserToAddRows = false;
            grillaVendedores.AllowUserToDeleteRows = false;
            grillaVendedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaVendedores.Location = new Point(300, 29);
            grillaVendedores.Name = "grillaVendedores";
            grillaVendedores.ReadOnly = true;
            grillaVendedores.Size = new Size(452, 327);
            grillaVendedores.TabIndex = 0;
            grillaVendedores.CellDoubleClick += grillaVendedores_CellDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 1;
            label1.Text = "Vendedor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 82);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 2;
            label2.Text = "Producto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 137);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 3;
            label3.Text = "Cantidad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 197);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 4;
            label4.Text = "Factura";
            // 
            // txtVendedor
            // 
            txtVendedor.Location = new Point(12, 46);
            txtVendedor.Name = "txtVendedor";
            txtVendedor.Size = new Size(115, 23);
            txtVendedor.TabIndex = 5;
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(12, 100);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(115, 23);
            txtProducto.TabIndex = 6;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(12, 155);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(115, 23);
            txtCantidad.TabIndex = 7;
            // 
            // txtFactura
            // 
            txtFactura.Location = new Point(12, 215);
            txtFactura.Name = "txtFactura";
            txtFactura.Size = new Size(115, 23);
            txtFactura.TabIndex = 8;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(12, 268);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(115, 23);
            btnAgregar.TabIndex = 9;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(12, 297);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(115, 23);
            btnBorrar.TabIndex = 10;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(12, 326);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(115, 23);
            btnModificar.TabIndex = 11;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radDesc);
            groupBox1.Controls.Add(radAsc);
            groupBox1.Location = new Point(148, 29);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(134, 94);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ordenamiento";
            // 
            // radDesc
            // 
            radDesc.AutoSize = true;
            radDesc.Location = new Point(17, 50);
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
            radAsc.Location = new Point(17, 24);
            radAsc.Name = "radAsc";
            radAsc.Size = new Size(87, 19);
            radAsc.TabIndex = 0;
            radAsc.TabStop = true;
            radAsc.Text = "Ascendente";
            radAsc.UseVisualStyleBackColor = true;
            radAsc.CheckedChanged += radAsc_CheckedChanged;
            // 
            // grillaTotales
            // 
            grillaTotales.AllowUserToAddRows = false;
            grillaTotales.AllowUserToDeleteRows = false;
            grillaTotales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaTotales.Columns.AddRange(new DataGridViewColumn[] { vendedor, producto, cantidad, factura, subtotalProducto, subtotalVendedor, total });
            grillaTotales.Location = new Point(796, 29);
            grillaTotales.Name = "grillaTotales";
            grillaTotales.ReadOnly = true;
            grillaTotales.RowHeadersVisible = false;
            grillaTotales.Size = new Size(541, 327);
            grillaTotales.TabIndex = 13;
            // 
            // vendedor
            // 
            vendedor.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            vendedor.HeaderText = "Vendedor";
            vendedor.Name = "vendedor";
            vendedor.ReadOnly = true;
            // 
            // producto
            // 
            producto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            producto.HeaderText = "Producto";
            producto.Name = "producto";
            producto.ReadOnly = true;
            // 
            // cantidad
            // 
            cantidad.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            cantidad.HeaderText = "Cantidad";
            cantidad.Name = "cantidad";
            cantidad.ReadOnly = true;
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
            subtotalProducto.HeaderText = "Subtotal Producto";
            subtotalProducto.Name = "subtotalProducto";
            subtotalProducto.ReadOnly = true;
            // 
            // subtotalVendedor
            // 
            subtotalVendedor.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            subtotalVendedor.HeaderText = "Subtotal Vendedor";
            subtotalVendedor.Name = "subtotalVendedor";
            subtotalVendedor.ReadOnly = true;
            // 
            // total
            // 
            total.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            total.HeaderText = "Total general";
            total.Name = "total";
            total.ReadOnly = true;
            // 
            // btnCorte
            // 
            btnCorte.Location = new Point(796, 372);
            btnCorte.Name = "btnCorte";
            btnCorte.Size = new Size(119, 23);
            btnCorte.TabIndex = 14;
            btnCorte.Text = "Corte de control";
            btnCorte.UseVisualStyleBackColor = true;
            btnCorte.Click += btnCorte_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1384, 450);
            Controls.Add(btnCorte);
            Controls.Add(grillaTotales);
            Controls.Add(groupBox1);
            Controls.Add(btnModificar);
            Controls.Add(btnBorrar);
            Controls.Add(btnAgregar);
            Controls.Add(txtFactura);
            Controls.Add(txtCantidad);
            Controls.Add(txtProducto);
            Controls.Add(txtVendedor);
            Controls.Add(label4);
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
            ((System.ComponentModel.ISupportInitialize)grillaTotales).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grillaVendedores;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtVendedor;
        private TextBox txtProducto;
        private TextBox txtCantidad;
        private TextBox txtFactura;
        private Button btnAgregar;
        private Button btnBorrar;
        private Button btnModificar;
        private GroupBox groupBox1;
        private RadioButton radDesc;
        private RadioButton radAsc;
        private DataGridView grillaTotales;
        private DataGridViewTextBoxColumn vendedor;
        private DataGridViewTextBoxColumn producto;
        private DataGridViewTextBoxColumn cantidad;
        private DataGridViewTextBoxColumn factura;
        private DataGridViewTextBoxColumn subtotalProducto;
        private DataGridViewTextBoxColumn subtotalVendedor;
        private DataGridViewTextBoxColumn total;
        private Button btnCorte;
    }
}
