namespace ArchivosABM
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
            grillaHerramientas = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtHerramienta = new TextBox();
            txtStock = new TextBox();
            cbxTipoDeHerramienta = new ComboBox();
            label4 = new Label();
            txtIdVendedor = new TextBox();
            btnAgregar = new Button();
            btnBorrar = new Button();
            btnModificar = new Button();
            ((System.ComponentModel.ISupportInitialize)grillaHerramientas).BeginInit();
            SuspendLayout();
            // 
            // grillaHerramientas
            // 
            grillaHerramientas.AllowUserToAddRows = false;
            grillaHerramientas.AllowUserToDeleteRows = false;
            grillaHerramientas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaHerramientas.Location = new Point(227, 42);
            grillaHerramientas.Name = "grillaHerramientas";
            grillaHerramientas.ReadOnly = true;
            grillaHerramientas.RowHeadersVisible = false;
            grillaHerramientas.Size = new Size(546, 357);
            grillaHerramientas.TabIndex = 0;
            grillaHerramientas.CellDoubleClick += grillaHerramientas_CellDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 42);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 1;
            label1.Text = "Herramienta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 102);
            label2.Name = "label2";
            label2.Size = new Size(113, 15);
            label2.TabIndex = 2;
            label2.Text = "Tipo de herramienta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 172);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 3;
            label3.Text = "Stock";
            // 
            // txtHerramienta
            // 
            txtHerramienta.Location = new Point(34, 60);
            txtHerramienta.Name = "txtHerramienta";
            txtHerramienta.Size = new Size(137, 23);
            txtHerramienta.TabIndex = 4;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(34, 184);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(137, 23);
            txtStock.TabIndex = 6;
            // 
            // cbxTipoDeHerramienta
            // 
            cbxTipoDeHerramienta.FormattingEnabled = true;
            cbxTipoDeHerramienta.Location = new Point(34, 120);
            cbxTipoDeHerramienta.Name = "cbxTipoDeHerramienta";
            cbxTipoDeHerramienta.Size = new Size(137, 23);
            cbxTipoDeHerramienta.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 227);
            label4.Name = "label4";
            label4.Size = new Size(115, 15);
            label4.TabIndex = 8;
            label4.Text = "Código de vendedor";
            // 
            // txtIdVendedor
            // 
            txtIdVendedor.Location = new Point(34, 245);
            txtIdVendedor.Name = "txtIdVendedor";
            txtIdVendedor.Size = new Size(137, 23);
            txtIdVendedor.TabIndex = 9;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(34, 287);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(137, 34);
            btnAgregar.TabIndex = 10;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(34, 327);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(137, 34);
            btnBorrar.TabIndex = 11;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(34, 365);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(137, 34);
            btnModificar.TabIndex = 12;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(813, 450);
            Controls.Add(btnModificar);
            Controls.Add(btnBorrar);
            Controls.Add(btnAgregar);
            Controls.Add(txtIdVendedor);
            Controls.Add(label4);
            Controls.Add(cbxTipoDeHerramienta);
            Controls.Add(txtStock);
            Controls.Add(txtHerramienta);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(grillaHerramientas);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)grillaHerramientas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grillaHerramientas;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtHerramienta;
        private TextBox txtStock;
        private ComboBox cbxTipoDeHerramienta;
        private Label label4;
        private TextBox txtIdVendedor;
        private Button btnAgregar;
        private Button btnBorrar;
        private Button btnModificar;
    }
}
