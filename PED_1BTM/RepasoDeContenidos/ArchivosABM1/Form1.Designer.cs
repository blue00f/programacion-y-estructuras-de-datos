namespace ArchivosABM1
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
            btnAgregar = new Button();
            btnBorrar = new Button();
            btnModificar = new Button();
            lblLegajo = new Label();
            txtLegajo = new TextBox();
            groupBox1 = new GroupBox();
            txtVenta = new TextBox();
            lblVenta = new Label();
            btnSalir = new Button();
            grillaVendedores = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grillaVendedores).BeginInit();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(33, 272);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 20;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(114, 272);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(75, 23);
            btnBorrar.TabIndex = 21;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(33, 301);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 22;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // lblLegajo
            // 
            lblLegajo.AutoSize = true;
            lblLegajo.Location = new Point(33, 41);
            lblLegajo.Name = "lblLegajo";
            lblLegajo.Size = new Size(42, 15);
            lblLegajo.TabIndex = 4;
            lblLegajo.Text = "Legajo";
            // 
            // txtLegajo
            // 
            txtLegajo.Location = new Point(104, 38);
            txtLegajo.Name = "txtLegajo";
            txtLegajo.Size = new Size(100, 23);
            txtLegajo.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtVenta);
            groupBox1.Controls.Add(lblVenta);
            groupBox1.Controls.Add(btnSalir);
            groupBox1.Controls.Add(lblLegajo);
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(btnBorrar);
            groupBox1.Controls.Add(txtLegajo);
            groupBox1.Controls.Add(btnModificar);
            groupBox1.Location = new Point(32, 44);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(229, 367);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Registro vendedores";
            // 
            // txtVenta
            // 
            txtVenta.Location = new Point(104, 104);
            txtVenta.Name = "txtVenta";
            txtVenta.Size = new Size(100, 23);
            txtVenta.TabIndex = 10;
            // 
            // lblVenta
            // 
            lblVenta.AutoSize = true;
            lblVenta.Location = new Point(33, 104);
            lblVenta.Name = "lblVenta";
            lblVenta.Size = new Size(36, 15);
            lblVenta.TabIndex = 11;
            lblVenta.Text = "Venta";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(114, 301);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 23;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // grillaVendedores
            // 
            grillaVendedores.AllowUserToAddRows = false;
            grillaVendedores.AllowUserToDeleteRows = false;
            grillaVendedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaVendedores.Location = new Point(317, 52);
            grillaVendedores.Name = "grillaVendedores";
            grillaVendedores.ReadOnly = true;
            grillaVendedores.Size = new Size(451, 359);
            grillaVendedores.TabIndex = 11;
            grillaVendedores.CellDoubleClick += grillaVendedores_CellDoubleClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grillaVendedores);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grillaVendedores).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnAgregar;
        private Button btnBorrar;
        private Button btnModificar;
        private Label lblLegajo;
        private TextBox txtLegajo;
        private GroupBox groupBox1;
        private Button btnSalir;
        private TextBox txtVenta;
        private Label lblVenta;
        private DataGridView grillaVendedores;
    }
}
