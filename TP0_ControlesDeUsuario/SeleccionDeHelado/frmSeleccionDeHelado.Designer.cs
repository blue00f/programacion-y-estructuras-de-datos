namespace Ejemplo03
{
    partial class frmSeleccionDeHelado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            radTipo1 = new RadioButton();
            radTipo2 = new RadioButton();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            radTamanio2 = new RadioButton();
            radTamanio1 = new RadioButton();
            chkSabor1 = new CheckBox();
            chkSabor2 = new CheckBox();
            chkSabor3 = new CheckBox();
            pictureBox1 = new PictureBox();
            numCantidad = new NumericUpDown();
            lblCantidadAElegir = new Label();
            lblPedidoFinal = new Label();
            lblExtras = new Label();
            lblCantidad = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCantidad).BeginInit();
            SuspendLayout();
            // 
            // radTipo1
            // 
            radTipo1.AutoSize = true;
            radTipo1.Checked = true;
            radTipo1.Location = new Point(18, 31);
            radTipo1.Name = "radTipo1";
            radTipo1.Size = new Size(84, 19);
            radTipo1.TabIndex = 0;
            radTipo1.TabStop = true;
            radTipo1.Text = "Cucurucho";
            radTipo1.UseVisualStyleBackColor = true;
            radTipo1.CheckedChanged += MostrarLeyenda;
            // 
            // radTipo2
            // 
            radTipo2.AutoSize = true;
            radTipo2.Location = new Point(18, 56);
            radTipo2.Name = "radTipo2";
            radTipo2.Size = new Size(49, 19);
            radTipo2.TabIndex = 1;
            radTipo2.Text = "Vaso";
            radTipo2.UseVisualStyleBackColor = true;
            radTipo2.CheckedChanged += MostrarLeyenda;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radTipo2);
            groupBox1.Controls.Add(radTipo1);
            groupBox1.Location = new Point(63, 108);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tipo";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radTamanio2);
            groupBox2.Controls.Add(radTamanio1);
            groupBox2.Location = new Point(301, 108);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 100);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tamaño";
            // 
            // radTamanio2
            // 
            radTamanio2.AutoSize = true;
            radTamanio2.Checked = true;
            radTamanio2.Location = new Point(33, 58);
            radTamanio2.Name = "radTamanio2";
            radTamanio2.Size = new Size(56, 19);
            radTamanio2.TabIndex = 1;
            radTamanio2.TabStop = true;
            radTamanio2.Text = "Chico";
            radTamanio2.UseVisualStyleBackColor = true;
            radTamanio2.CheckedChanged += MostrarLeyenda;
            // 
            // radTamanio1
            // 
            radTamanio1.AutoSize = true;
            radTamanio1.Location = new Point(33, 33);
            radTamanio1.Name = "radTamanio1";
            radTamanio1.Size = new Size(63, 19);
            radTamanio1.TabIndex = 0;
            radTamanio1.Text = "Grande";
            radTamanio1.UseVisualStyleBackColor = true;
            radTamanio1.CheckedChanged += MostrarLeyenda;
            // 
            // chkSabor1
            // 
            chkSabor1.AutoSize = true;
            chkSabor1.Location = new Point(236, 261);
            chkSabor1.Name = "chkSabor1";
            chkSabor1.Size = new Size(153, 19);
            chkSabor1.TabIndex = 4;
            chkSabor1.Text = "Baño extra de chocolate";
            chkSabor1.UseVisualStyleBackColor = true;
            chkSabor1.CheckedChanged += MostrarLeyenda;
            // 
            // chkSabor2
            // 
            chkSabor2.AutoSize = true;
            chkSabor2.Location = new Point(236, 286);
            chkSabor2.Name = "chkSabor2";
            chkSabor2.Size = new Size(138, 19);
            chkSabor2.TabIndex = 5;
            chkSabor2.Text = "Chispas de chocolate";
            chkSabor2.UseVisualStyleBackColor = true;
            chkSabor2.CheckedChanged += MostrarLeyenda;
            // 
            // chkSabor3
            // 
            chkSabor3.AutoSize = true;
            chkSabor3.Location = new Point(236, 311);
            chkSabor3.Name = "chkSabor3";
            chkSabor3.Size = new Size(177, 19);
            chkSabor3.TabIndex = 6;
            chkSabor3.Text = "Baño extra de dulce de leche";
            chkSabor3.UseVisualStyleBackColor = true;
            chkSabor3.CheckedChanged += MostrarLeyenda;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = SeleccionDeHelado.Properties.Resources.heladeria;
            pictureBox1.Location = new Point(777, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(208, 226);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // numCantidad
            // 
            numCantidad.Location = new Point(63, 289);
            numCantidad.Name = "numCantidad";
            numCantidad.Size = new Size(120, 23);
            numCantidad.TabIndex = 8;
            numCantidad.ValueChanged += MostrarLeyenda;
            // 
            // lblCantidadAElegir
            // 
            lblCantidadAElegir.AutoSize = true;
            lblCantidadAElegir.Location = new Point(63, 265);
            lblCantidadAElegir.Name = "lblCantidadAElegir";
            lblCantidadAElegir.Size = new Size(55, 15);
            lblCantidadAElegir.TabIndex = 9;
            lblCantidadAElegir.Text = "Cantidad";
            // 
            // lblPedidoFinal
            // 
            lblPedidoFinal.AutoSize = true;
            lblPedidoFinal.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic);
            lblPedidoFinal.Location = new Point(12, 334);
            lblPedidoFinal.Name = "lblPedidoFinal";
            lblPedidoFinal.Size = new Size(99, 25);
            lblPedidoFinal.TabIndex = 10;
            lblPedidoFinal.Text = "Selección:";
            // 
            // lblExtras
            // 
            lblExtras.AutoSize = true;
            lblExtras.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic);
            lblExtras.Location = new Point(12, 374);
            lblExtras.Name = "lblExtras";
            lblExtras.Size = new Size(71, 25);
            lblExtras.TabIndex = 11;
            lblExtras.Text = "Extras:";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic);
            lblCantidad.Location = new Point(12, 418);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(102, 25);
            lblCantidad.TabIndex = 12;
            lblCantidad.Text = "Cantidad: ";
            // 
            // frmSeleccionDeHelado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(985, 486);
            Controls.Add(lblCantidad);
            Controls.Add(lblExtras);
            Controls.Add(lblPedidoFinal);
            Controls.Add(lblCantidadAElegir);
            Controls.Add(numCantidad);
            Controls.Add(pictureBox1);
            Controls.Add(chkSabor3);
            Controls.Add(chkSabor2);
            Controls.Add(chkSabor1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmSeleccionDeHelado";
            Text = "Selección de helado";
            Load += frmSeleccionDeHelado_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radTipo1;
        private RadioButton radTipo2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private RadioButton radTamanio2;
        private RadioButton radTamanio1;
        private CheckBox chkSabor1;
        private CheckBox chkSabor2;
        private CheckBox chkSabor3;
        private PictureBox pictureBox1;
        private NumericUpDown numCantidad;
        private Label lblCantidadAElegir;
        private Label lblPedidoFinal;
        private Label lblExtras;
        private Label lblCantidad;
    }
}