namespace Ejercicio10
{
    partial class frmConversorTemperatura
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
            gridTemperaturas = new DataGridView();
            escalaInicial = new DataGridViewTextBoxColumn();
            escalaFinal = new DataGridViewTextBoxColumn();
            cantidadATransformar = new DataGridViewTextBoxColumn();
            cantidadTransformada = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            txtCantidad = new TextBox();
            label3 = new Label();
            cbxEscalaInicial = new ComboBox();
            cbxEscalaFinal = new ComboBox();
            btnConvertir = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)gridTemperaturas).BeginInit();
            SuspendLayout();
            // 
            // gridTemperaturas
            // 
            gridTemperaturas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridTemperaturas.Columns.AddRange(new DataGridViewColumn[] { escalaInicial, escalaFinal, cantidadATransformar, cantidadTransformada });
            gridTemperaturas.Location = new Point(312, 31);
            gridTemperaturas.Name = "gridTemperaturas";
            gridTemperaturas.Size = new Size(468, 240);
            gridTemperaturas.TabIndex = 0;
            // 
            // escalaInicial
            // 
            escalaInicial.HeaderText = "Escala inicial";
            escalaInicial.Name = "escalaInicial";
            // 
            // escalaFinal
            // 
            escalaFinal.HeaderText = "Escala final";
            escalaFinal.Name = "escalaFinal";
            // 
            // cantidadATransformar
            // 
            cantidadATransformar.HeaderText = "Cantidad a transformar";
            cantidadATransformar.Name = "cantidadATransformar";
            // 
            // cantidadTransformada
            // 
            cantidadTransformada.HeaderText = "Cantidad transformada";
            cantidadTransformada.Name = "cantidadTransformada";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 53);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 1;
            label1.Text = "Escala inicial";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 112);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 3;
            label2.Text = "Escala final";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(119, 168);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(157, 23);
            txtCantidad.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 171);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 5;
            label3.Text = "Cantidad";
            // 
            // cbxEscalaInicial
            // 
            cbxEscalaInicial.FormattingEnabled = true;
            cbxEscalaInicial.Items.AddRange(new object[] { "Celsius", "Fahrenheit", "Kelvin", "Rankine" });
            cbxEscalaInicial.Location = new Point(119, 53);
            cbxEscalaInicial.Name = "cbxEscalaInicial";
            cbxEscalaInicial.Size = new Size(157, 23);
            cbxEscalaInicial.TabIndex = 7;
            // 
            // cbxEscalaFinal
            // 
            cbxEscalaFinal.FormattingEnabled = true;
            cbxEscalaFinal.Items.AddRange(new object[] { "Celsius", "Fahrenheit", "Kelvin", "Rankine" });
            cbxEscalaFinal.Location = new Point(119, 112);
            cbxEscalaFinal.Name = "cbxEscalaFinal";
            cbxEscalaFinal.Size = new Size(157, 23);
            cbxEscalaFinal.TabIndex = 8;
            // 
            // btnConvertir
            // 
            btnConvertir.Location = new Point(40, 214);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(160, 23);
            btnConvertir.TabIndex = 9;
            btnConvertir.Text = "Convertir temperatura";
            btnConvertir.UseVisualStyleBackColor = true;
            btnConvertir.Click += btnConvertir_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(40, 248);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(160, 23);
            btnLimpiar.TabIndex = 10;
            btnLimpiar.Text = "Limpiar grilla";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(216, 214);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(60, 57);
            btnSalir.TabIndex = 11;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // frmConversorTemperatura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(811, 318);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnConvertir);
            Controls.Add(cbxEscalaFinal);
            Controls.Add(cbxEscalaInicial);
            Controls.Add(txtCantidad);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(gridTemperaturas);
            Name = "frmConversorTemperatura";
            Text = "Conversor de temperaturas";
            Load += frmConversorTemperatura_Load;
            ((System.ComponentModel.ISupportInitialize)gridTemperaturas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridTemperaturas;
        private Label label1;
        private Label label2;
        private TextBox txtCantidad;
        private Label label3;
        private ComboBox cbxEscalaInicial;
        private ComboBox cbxEscalaFinal;
        private DataGridViewTextBoxColumn escalaInicial;
        private DataGridViewTextBoxColumn escalaFinal;
        private DataGridViewTextBoxColumn cantidadATransformar;
        private DataGridViewTextBoxColumn cantidadTransformada;
        private Button btnConvertir;
        private Button btnLimpiar;
        private Button btnSalir;
    }
}
