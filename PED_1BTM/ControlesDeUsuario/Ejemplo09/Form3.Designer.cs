namespace Ejemplo09
{
    partial class Form3
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
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            verToolStripMenuItem = new ToolStripMenuItem();
            verFormulario2ToolStripMenuItem = new ToolStripMenuItem();
            verFormulario3ToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 60F);
            label1.Location = new Point(356, 172);
            label1.Name = "label1";
            label1.Size = new Size(88, 106);
            label1.TabIndex = 1;
            label1.Text = "3";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { verToolStripMenuItem, verFormulario2ToolStripMenuItem, verFormulario3ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 29);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // verToolStripMenuItem
            // 
            verToolStripMenuItem.Font = new Font("Segoe UI", 12F);
            verToolStripMenuItem.Name = "verToolStripMenuItem";
            verToolStripMenuItem.Size = new Size(139, 25);
            verToolStripMenuItem.Text = "Ver Formulario 1";
            verToolStripMenuItem.Click += verFormulario1;
            // 
            // verFormulario2ToolStripMenuItem
            // 
            verFormulario2ToolStripMenuItem.Font = new Font("Segoe UI", 12F);
            verFormulario2ToolStripMenuItem.Name = "verFormulario2ToolStripMenuItem";
            verFormulario2ToolStripMenuItem.Size = new Size(139, 25);
            verFormulario2ToolStripMenuItem.Text = "Ver Formulario 2";
            verFormulario2ToolStripMenuItem.Click += verFormulario2;
            // 
            // verFormulario3ToolStripMenuItem
            // 
            verFormulario3ToolStripMenuItem.Font = new Font("Segoe UI", 12F);
            verFormulario3ToolStripMenuItem.Name = "verFormulario3ToolStripMenuItem";
            verFormulario3ToolStripMenuItem.Size = new Size(139, 25);
            verFormulario3ToolStripMenuItem.Text = "Ver Formulario 3";
            verFormulario3ToolStripMenuItem.Click += verFormulario3;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form3";
            Text = "Formulario 1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem verToolStripMenuItem;
        private ToolStripMenuItem verFormulario2ToolStripMenuItem;
        private ToolStripMenuItem verFormulario3ToolStripMenuItem;
    }
}