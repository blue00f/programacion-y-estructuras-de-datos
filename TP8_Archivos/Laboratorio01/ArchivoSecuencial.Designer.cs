namespace Laboratorio01
{
    partial class ArchivoSecuencial
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
            lblLegajo = new Label();
            lblNombre = new Label();
            lblCategoria = new Label();
            txtLegajo = new TextBox();
            txtNombre = new TextBox();
            txtCategoria = new TextBox();
            lstListado = new ListBox();
            btnAlta = new Button();
            btnBaja = new Button();
            btnModificar = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // lblLegajo
            // 
            lblLegajo.AutoSize = true;
            lblLegajo.Location = new Point(24, 33);
            lblLegajo.Name = "lblLegajo";
            lblLegajo.Size = new Size(42, 15);
            lblLegajo.TabIndex = 0;
            lblLegajo.Text = "Legajo";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(24, 68);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(24, 102);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(58, 15);
            lblCategoria.TabIndex = 2;
            lblCategoria.Text = "Categoría";
            // 
            // txtLegajo
            // 
            txtLegajo.Location = new Point(174, 30);
            txtLegajo.Name = "txtLegajo";
            txtLegajo.Size = new Size(211, 23);
            txtLegajo.TabIndex = 3;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(174, 68);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(211, 23);
            txtNombre.TabIndex = 4;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(174, 102);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(211, 23);
            txtCategoria.TabIndex = 5;
            // 
            // lstListado
            // 
            lstListado.FormattingEnabled = true;
            lstListado.ItemHeight = 15;
            lstListado.Location = new Point(24, 148);
            lstListado.Name = "lstListado";
            lstListado.Size = new Size(361, 109);
            lstListado.TabIndex = 6;
            lstListado.Click += lstListado_Click;
            // 
            // btnAlta
            // 
            btnAlta.Location = new Point(24, 291);
            btnAlta.Name = "btnAlta";
            btnAlta.Size = new Size(86, 23);
            btnAlta.TabIndex = 7;
            btnAlta.Text = "Alta";
            btnAlta.UseVisualStyleBackColor = true;
            btnAlta.Click += btnAlta_Click;
            // 
            // btnBaja
            // 
            btnBaja.Location = new Point(116, 291);
            btnBaja.Name = "btnBaja";
            btnBaja.Size = new Size(86, 23);
            btnBaja.TabIndex = 8;
            btnBaja.Text = "Baja";
            btnBaja.UseVisualStyleBackColor = true;
            btnBaja.Click += btnBaja_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(207, 291);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(86, 23);
            btnModificar.TabIndex = 9;
            btnModificar.Text = "Modificación";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(299, 291);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(86, 23);
            btnSalir.TabIndex = 10;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // ArchivoSecuencial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 358);
            Controls.Add(btnSalir);
            Controls.Add(btnModificar);
            Controls.Add(btnBaja);
            Controls.Add(btnAlta);
            Controls.Add(lstListado);
            Controls.Add(txtCategoria);
            Controls.Add(txtNombre);
            Controls.Add(txtLegajo);
            Controls.Add(lblCategoria);
            Controls.Add(lblNombre);
            Controls.Add(lblLegajo);
            Name = "ArchivoSecuencial";
            Text = "Archivo secuencial";
            Load += ArchivoSecuencial_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLegajo;
        private Label lblNombre;
        private Label lblCategoria;
        private TextBox txtLegajo;
        private TextBox txtNombre;
        private TextBox txtCategoria;
        private ListBox lstListado;
        private Button btnAlta;
        private Button btnBaja;
        private Button btnModificar;
        private Button btnSalir;
    }
}
