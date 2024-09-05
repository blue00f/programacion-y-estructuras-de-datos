namespace Ejemplo01
{
    partial class frmBlocDeNotas
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
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            ediciónToolStripMenuItem = new ToolStripMenuItem();
            adelanteToolStripMenuItem = new ToolStripMenuItem();
            atrásToolStripMenuItem = new ToolStripMenuItem();
            copiarToolStripMenuItem = new ToolStripMenuItem();
            pegarToolStripMenuItem = new ToolStripMenuItem();
            cortarToolStripMenuItem = new ToolStripMenuItem();
            seleccionarTodoToolStripMenuItem = new ToolStripMenuItem();
            borrarTodoToolStripMenuItem = new ToolStripMenuItem();
            formatoToolStripMenuItem = new ToolStripMenuItem();
            estiloDeFuenteToolStripMenuItem = new ToolStripMenuItem();
            colorDeFuenteToolStripMenuItem = new ToolStripMenuItem();
            colorDeFondoToolStripMenuItem = new ToolStripMenuItem();
            richTextBox1 = new RichTextBox();
            fontDialog1 = new FontDialog();
            colorDialog1 = new ColorDialog();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, ediciónToolStripMenuItem, formatoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(60, 20);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(96, 22);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // ediciónToolStripMenuItem
            // 
            ediciónToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { adelanteToolStripMenuItem, atrásToolStripMenuItem, copiarToolStripMenuItem, pegarToolStripMenuItem, cortarToolStripMenuItem, seleccionarTodoToolStripMenuItem, borrarTodoToolStripMenuItem });
            ediciónToolStripMenuItem.Name = "ediciónToolStripMenuItem";
            ediciónToolStripMenuItem.Size = new Size(58, 20);
            ediciónToolStripMenuItem.Text = "Edición";
            // 
            // adelanteToolStripMenuItem
            // 
            adelanteToolStripMenuItem.Name = "adelanteToolStripMenuItem";
            adelanteToolStripMenuItem.Size = new Size(162, 22);
            adelanteToolStripMenuItem.Text = "Adelante";
            adelanteToolStripMenuItem.Click += adelanteToolStripMenuItem_Click;
            // 
            // atrásToolStripMenuItem
            // 
            atrásToolStripMenuItem.Name = "atrásToolStripMenuItem";
            atrásToolStripMenuItem.Size = new Size(162, 22);
            atrásToolStripMenuItem.Text = "Atrás";
            atrásToolStripMenuItem.Click += atrásToolStripMenuItem_Click;
            // 
            // copiarToolStripMenuItem
            // 
            copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            copiarToolStripMenuItem.Size = new Size(162, 22);
            copiarToolStripMenuItem.Text = "Copiar";
            copiarToolStripMenuItem.Click += copiarToolStripMenuItem_Click;
            // 
            // pegarToolStripMenuItem
            // 
            pegarToolStripMenuItem.Name = "pegarToolStripMenuItem";
            pegarToolStripMenuItem.Size = new Size(162, 22);
            pegarToolStripMenuItem.Text = "Pegar";
            pegarToolStripMenuItem.Click += pegarToolStripMenuItem_Click;
            // 
            // cortarToolStripMenuItem
            // 
            cortarToolStripMenuItem.Name = "cortarToolStripMenuItem";
            cortarToolStripMenuItem.Size = new Size(162, 22);
            cortarToolStripMenuItem.Text = "Cortar";
            cortarToolStripMenuItem.Click += cortarToolStripMenuItem_Click;
            // 
            // seleccionarTodoToolStripMenuItem
            // 
            seleccionarTodoToolStripMenuItem.Name = "seleccionarTodoToolStripMenuItem";
            seleccionarTodoToolStripMenuItem.Size = new Size(162, 22);
            seleccionarTodoToolStripMenuItem.Text = "Seleccionar todo";
            seleccionarTodoToolStripMenuItem.Click += seleccionarTodoToolStripMenuItem_Click;
            // 
            // borrarTodoToolStripMenuItem
            // 
            borrarTodoToolStripMenuItem.Name = "borrarTodoToolStripMenuItem";
            borrarTodoToolStripMenuItem.Size = new Size(162, 22);
            borrarTodoToolStripMenuItem.Text = "Borrar todo";
            borrarTodoToolStripMenuItem.Click += borrarTodoToolStripMenuItem_Click;
            // 
            // formatoToolStripMenuItem
            // 
            formatoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { estiloDeFuenteToolStripMenuItem, colorDeFuenteToolStripMenuItem, colorDeFondoToolStripMenuItem });
            formatoToolStripMenuItem.Name = "formatoToolStripMenuItem";
            formatoToolStripMenuItem.Size = new Size(64, 20);
            formatoToolStripMenuItem.Text = "Formato";
            // 
            // estiloDeFuenteToolStripMenuItem
            // 
            estiloDeFuenteToolStripMenuItem.Name = "estiloDeFuenteToolStripMenuItem";
            estiloDeFuenteToolStripMenuItem.Size = new Size(180, 22);
            estiloDeFuenteToolStripMenuItem.Text = "Estilo de fuente";
            estiloDeFuenteToolStripMenuItem.Click += estiloDeFuenteToolStripMenuItem_Click;
            // 
            // colorDeFuenteToolStripMenuItem
            // 
            colorDeFuenteToolStripMenuItem.Name = "colorDeFuenteToolStripMenuItem";
            colorDeFuenteToolStripMenuItem.Size = new Size(180, 22);
            colorDeFuenteToolStripMenuItem.Text = "Color de fuente";
            colorDeFuenteToolStripMenuItem.Click += colorDeFuenteToolStripMenuItem_Click;
            // 
            // colorDeFondoToolStripMenuItem
            // 
            colorDeFondoToolStripMenuItem.Name = "colorDeFondoToolStripMenuItem";
            colorDeFondoToolStripMenuItem.Size = new Size(180, 22);
            colorDeFondoToolStripMenuItem.Text = "Color de fondo";
            colorDeFondoToolStripMenuItem.Click += colorDeFondoToolStripMenuItem_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox1.Location = new Point(0, 27);
            richTextBox1.Margin = new Padding(6);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(800, 423);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Bloc de notas";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem ediciónToolStripMenuItem;
        private ToolStripMenuItem formatoToolStripMenuItem;
        private ToolStripMenuItem adelanteToolStripMenuItem;
        private ToolStripMenuItem atrásToolStripMenuItem;
        private ToolStripMenuItem copiarToolStripMenuItem;
        private ToolStripMenuItem pegarToolStripMenuItem;
        private ToolStripMenuItem cortarToolStripMenuItem;
        private ToolStripMenuItem seleccionarTodoToolStripMenuItem;
        private ToolStripMenuItem borrarTodoToolStripMenuItem;
        private ToolStripMenuItem estiloDeFuenteToolStripMenuItem;
        private ToolStripMenuItem colorDeFuenteToolStripMenuItem;
        private ToolStripMenuItem colorDeFondoToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private RichTextBox richTextBox1;
        private FontDialog fontDialog1;
        private ColorDialog colorDialog1;
    }
}
