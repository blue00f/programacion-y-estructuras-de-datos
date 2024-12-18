namespace Ejemplo07
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
            menuStrip1 = new MenuStrip();
            fORMULARIO2ToolStripMenuItem = new ToolStripMenuItem();
            abroirFormulario2ToolStripMenuItem = new ToolStripMenuItem();
            cerrarFormulario2ToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fORMULARIO2ToolStripMenuItem, acercaDeToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fORMULARIO2ToolStripMenuItem
            // 
            fORMULARIO2ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { abroirFormulario2ToolStripMenuItem, cerrarFormulario2ToolStripMenuItem });
            fORMULARIO2ToolStripMenuItem.Name = "fORMULARIO2ToolStripMenuItem";
            fORMULARIO2ToolStripMenuItem.Size = new Size(102, 20);
            fORMULARIO2ToolStripMenuItem.Text = "FORMULARIO 2";
            // 
            // abroirFormulario2ToolStripMenuItem
            // 
            abroirFormulario2ToolStripMenuItem.Name = "abroirFormulario2ToolStripMenuItem";
            abroirFormulario2ToolStripMenuItem.Size = new Size(180, 22);
            abroirFormulario2ToolStripMenuItem.Text = "Abrir Formulario 2";
            abroirFormulario2ToolStripMenuItem.Click += abroirFormulario2ToolStripMenuItem_Click;
            // 
            // cerrarFormulario2ToolStripMenuItem
            // 
            cerrarFormulario2ToolStripMenuItem.Name = "cerrarFormulario2ToolStripMenuItem";
            cerrarFormulario2ToolStripMenuItem.Size = new Size(180, 22);
            cerrarFormulario2ToolStripMenuItem.Text = "Cerrar Formulario 2";
            cerrarFormulario2ToolStripMenuItem.Click += cerrarFormulario2ToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(41, 20);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // acercaDeToolStripMenuItem
            // 
            acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            acercaDeToolStripMenuItem.Size = new Size(80, 20);
            acercaDeToolStripMenuItem.Text = "Acerca de...";
            acercaDeToolStripMenuItem.Click += acercaDeToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fORMULARIO2ToolStripMenuItem;
        private ToolStripMenuItem abroirFormulario2ToolStripMenuItem;
        private ToolStripMenuItem cerrarFormulario2ToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
    }
}
