namespace Ejemplo09
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
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            verFormulario1ToolStripMenuItem = new ToolStripMenuItem();
            verToolStripMenuItem = new ToolStripMenuItem();
            verFOrmulario3ToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 60F);
            label1.Location = new Point(336, 147);
            label1.Name = "label1";
            label1.Size = new Size(88, 106);
            label1.TabIndex = 0;
            label1.Text = "1";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { verFormulario1ToolStripMenuItem, verToolStripMenuItem, verFOrmulario3ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 29);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // verFormulario1ToolStripMenuItem
            // 
            verFormulario1ToolStripMenuItem.Font = new Font("Segoe UI", 12F);
            verFormulario1ToolStripMenuItem.Name = "verFormulario1ToolStripMenuItem";
            verFormulario1ToolStripMenuItem.Size = new Size(139, 25);
            verFormulario1ToolStripMenuItem.Text = "Ver Formulario 1";
            verFormulario1ToolStripMenuItem.Click += verFormulario1;
            // 
            // verToolStripMenuItem
            // 
            verToolStripMenuItem.Font = new Font("Segoe UI", 12F);
            verToolStripMenuItem.Name = "verToolStripMenuItem";
            verToolStripMenuItem.Size = new Size(139, 25);
            verToolStripMenuItem.Text = "Ver Formulario 2";
            verToolStripMenuItem.Click += verFormulario2;
            // 
            // verFOrmulario3ToolStripMenuItem
            // 
            verFOrmulario3ToolStripMenuItem.Font = new Font("Segoe UI", 12F);
            verFOrmulario3ToolStripMenuItem.Name = "verFOrmulario3ToolStripMenuItem";
            verFOrmulario3ToolStripMenuItem.Size = new Size(139, 25);
            verFOrmulario3ToolStripMenuItem.Text = "Ver Formulario 3";
            verFOrmulario3ToolStripMenuItem.Click += verFormulario3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem verFormulario1ToolStripMenuItem;
        private ToolStripMenuItem verToolStripMenuItem;
        private ToolStripMenuItem verFOrmulario3ToolStripMenuItem;
    }
}
