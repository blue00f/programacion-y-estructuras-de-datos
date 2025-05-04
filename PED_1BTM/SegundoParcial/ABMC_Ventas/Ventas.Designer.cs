namespace ABMC_Ventas
{
    partial class Ventas
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
            btnAgregar = new Button();
            btnBorrar = new Button();
            btnModificar = new Button();
            btnSalir = new Button();
            txtCodigo = new TextBox();
            txtVenta = new TextBox();
            lblCodigo = new Label();
            lblVenta = new Label();
            groupBox1 = new GroupBox();
            grillaVendedores = new DataGridView();
            lblTituloGrilla = new Label();
            lblNota = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grillaVendedores).BeginInit();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(55, 130);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(136, 130);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(75, 23);
            btnBorrar.TabIndex = 1;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(55, 169);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(136, 169);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(136, 30);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 4;
            // 
            // txtVenta
            // 
            txtVenta.Location = new Point(136, 72);
            txtVenta.Name = "txtVenta";
            txtVenta.Size = new Size(100, 23);
            txtVenta.TabIndex = 5;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(32, 30);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 6;
            lblCodigo.Text = "Código";
            // 
            // lblVenta
            // 
            lblVenta.AutoSize = true;
            lblVenta.Location = new Point(32, 72);
            lblVenta.Name = "lblVenta";
            lblVenta.Size = new Size(97, 15);
            lblVenta.TabIndex = 7;
            lblVenta.Text = "Importe de venta";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblCodigo);
            groupBox1.Controls.Add(lblVenta);
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(btnBorrar);
            groupBox1.Controls.Add(txtVenta);
            groupBox1.Controls.Add(btnModificar);
            groupBox1.Controls.Add(txtCodigo);
            groupBox1.Controls.Add(btnSalir);
            groupBox1.Location = new Point(43, 98);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(271, 234);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Registro vendedores";
            // 
            // grillaVendedores
            // 
            grillaVendedores.AllowUserToAddRows = false;
            grillaVendedores.AllowUserToDeleteRows = false;
            grillaVendedores.AllowUserToResizeColumns = false;
            grillaVendedores.AllowUserToResizeRows = false;
            grillaVendedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaVendedores.Location = new Point(365, 67);
            grillaVendedores.Name = "grillaVendedores";
            grillaVendedores.ReadOnly = true;
            grillaVendedores.RowHeadersVisible = false;
            grillaVendedores.Size = new Size(281, 288);
            grillaVendedores.TabIndex = 9;
            grillaVendedores.CellDoubleClick += grillaVendedores_CellDoubleClick;
            // 
            // lblTituloGrilla
            // 
            lblTituloGrilla.AutoSize = true;
            lblTituloGrilla.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloGrilla.Location = new Point(365, 39);
            lblTituloGrilla.Name = "lblTituloGrilla";
            lblTituloGrilla.Size = new Size(148, 25);
            lblTituloGrilla.TabIndex = 13;
            lblTituloGrilla.Text = "Grilla de ventas";
            // 
            // lblNota
            // 
            lblNota.AutoSize = true;
            lblNota.Location = new Point(365, 358);
            lblNota.Name = "lblNota";
            lblNota.Size = new Size(264, 15);
            lblNota.TabIndex = 14;
            lblNota.Text = "Hacer doble click en un registro para modificarlo";
            // 
            // Ventas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(701, 429);
            Controls.Add(lblNota);
            Controls.Add(lblTituloGrilla);
            Controls.Add(grillaVendedores);
            Controls.Add(groupBox1);
            Name = "Ventas";
            Text = "Sistema de ventas";
            Load += Ventas_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grillaVendedores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private Button btnBorrar;
        private Button btnModificar;
        private Button btnSalir;
        private TextBox txtCodigo;
        private TextBox txtVenta;
        private Label lblCodigo;
        private Label lblVenta;
        private GroupBox groupBox1;
        private DataGridView grillaVendedores;
        private Label lblTituloGrilla;
        private Label lblNota;
    }
}
