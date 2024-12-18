namespace CorteDeControl1
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
            grillaCalculos = new DataGridView();
            vendedor = new DataGridViewTextBoxColumn();
            facturas = new DataGridViewTextBoxColumn();
            subtotalVend = new DataGridViewTextBoxColumn();
            totalVendedor = new DataGridViewTextBoxColumn();
            btnCorteControl = new Button();
            grillaVendedores = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            txtNombre = new TextBox();
            txtFactura = new TextBox();
            btnAgregar = new Button();
            btnBorrar = new Button();
            btnModificar = new Button();
            radAsc = new RadioButton();
            radDesc = new RadioButton();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)grillaCalculos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grillaVendedores).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // grillaCalculos
            // 
            grillaCalculos.AllowUserToAddRows = false;
            grillaCalculos.AllowUserToDeleteRows = false;
            grillaCalculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaCalculos.Columns.AddRange(new DataGridViewColumn[] { vendedor, facturas, subtotalVend, totalVendedor });
            grillaCalculos.Location = new Point(590, 42);
            grillaCalculos.Name = "grillaCalculos";
            grillaCalculos.ReadOnly = true;
            grillaCalculos.RowHeadersVisible = false;
            grillaCalculos.Size = new Size(411, 505);
            grillaCalculos.TabIndex = 0;
            // 
            // vendedor
            // 
            vendedor.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            vendedor.HeaderText = "Vendedor";
            vendedor.Name = "vendedor";
            vendedor.ReadOnly = true;
            // 
            // facturas
            // 
            facturas.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            facturas.HeaderText = "Facturas";
            facturas.Name = "facturas";
            facturas.ReadOnly = true;
            // 
            // subtotalVend
            // 
            subtotalVend.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            subtotalVend.HeaderText = "Subtotal Vendedor";
            subtotalVend.Name = "subtotalVend";
            subtotalVend.ReadOnly = true;
            // 
            // totalVendedor
            // 
            totalVendedor.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            totalVendedor.HeaderText = "Total General";
            totalVendedor.Name = "totalVendedor";
            totalVendedor.ReadOnly = true;
            // 
            // btnCorteControl
            // 
            btnCorteControl.Location = new Point(1023, 42);
            btnCorteControl.Name = "btnCorteControl";
            btnCorteControl.Size = new Size(120, 55);
            btnCorteControl.TabIndex = 1;
            btnCorteControl.Text = "Corte de control";
            btnCorteControl.UseVisualStyleBackColor = true;
            btnCorteControl.Click += btnCorteControl_Click;
            // 
            // grillaVendedores
            // 
            grillaVendedores.AllowUserToAddRows = false;
            grillaVendedores.AllowUserToDeleteRows = false;
            grillaVendedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaVendedores.Location = new Point(24, 65);
            grillaVendedores.Name = "grillaVendedores";
            grillaVendedores.ReadOnly = true;
            grillaVendedores.Size = new Size(341, 482);
            grillaVendedores.TabIndex = 2;
            grillaVendedores.CellDoubleClick += grillaVendedores_CellDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(384, 190);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 3;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(384, 250);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 4;
            label2.Text = "Factura";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(384, 208);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(110, 23);
            txtNombre.TabIndex = 5;
            // 
            // txtFactura
            // 
            txtFactura.Location = new Point(384, 268);
            txtFactura.Name = "txtFactura";
            txtFactura.Size = new Size(110, 23);
            txtFactura.TabIndex = 6;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(384, 323);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(110, 23);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(384, 352);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(110, 23);
            btnBorrar.TabIndex = 8;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(384, 381);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(110, 23);
            btnModificar.TabIndex = 9;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // radAsc
            // 
            radAsc.AutoSize = true;
            radAsc.Location = new Point(21, 31);
            radAsc.Name = "radAsc";
            radAsc.Size = new Size(87, 19);
            radAsc.TabIndex = 10;
            radAsc.TabStop = true;
            radAsc.Text = "Ascendente";
            radAsc.UseVisualStyleBackColor = true;
            radAsc.CheckedChanged += radAsc_CheckedChanged;
            // 
            // radDesc
            // 
            radDesc.AutoSize = true;
            radDesc.Location = new Point(21, 56);
            radDesc.Name = "radDesc";
            radDesc.Size = new Size(93, 19);
            radDesc.TabIndex = 11;
            radDesc.TabStop = true;
            radDesc.Text = "Descendente";
            radDesc.UseVisualStyleBackColor = true;
            radDesc.CheckedChanged += radDesc_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radAsc);
            groupBox1.Controls.Add(radDesc);
            groupBox1.Location = new Point(384, 65);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(172, 95);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ordenamiento por nombre";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1170, 575);
            Controls.Add(groupBox1);
            Controls.Add(btnModificar);
            Controls.Add(btnBorrar);
            Controls.Add(btnAgregar);
            Controls.Add(txtFactura);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(grillaVendedores);
            Controls.Add(btnCorteControl);
            Controls.Add(grillaCalculos);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)grillaCalculos).EndInit();
            ((System.ComponentModel.ISupportInitialize)grillaVendedores).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grillaCalculos;
        private DataGridViewTextBoxColumn vendedor;
        private DataGridViewTextBoxColumn facturas;
        private DataGridViewTextBoxColumn subtotalVend;
        private DataGridViewTextBoxColumn totalVendedor;
        private Button btnCorteControl;
        private DataGridView grillaVendedores;
        private Label label1;
        private Label label2;
        private TextBox txtNombre;
        private TextBox txtFactura;
        private Button btnAgregar;
        private Button btnBorrar;
        private Button btnModificar;
        private RadioButton radAsc;
        private RadioButton radDesc;
        private GroupBox groupBox1;
    }
}
