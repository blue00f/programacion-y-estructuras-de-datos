namespace Ejercicio25_Lab2
{
    partial class frmMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            statusStrip = new StatusStrip();
            toolStripStatusLabel = new ToolStripStatusLabel();
            toolTip = new ToolTip(components);
            menuStrip1 = new MenuStrip();
            menúToolStripMenuItem = new ToolStripMenuItem();
            formatoDeNumerosToolStripMenuItem = new ToolStripMenuItem();
            formatoDeFechasToolStripMenuItem = new ToolStripMenuItem();
            manejoDeStringsToolStripMenuItem = new ToolStripMenuItem();
            statusStrip.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel });
            statusStrip.Location = new Point(0, 548);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(1, 0, 16, 0);
            statusStrip.Size = new Size(847, 22);
            statusStrip.TabIndex = 2;
            statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(42, 17);
            toolStripStatusLabel.Text = "Estado";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menúToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(847, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // menúToolStripMenuItem
            // 
            menúToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { formatoDeNumerosToolStripMenuItem, formatoDeFechasToolStripMenuItem, manejoDeStringsToolStripMenuItem });
            menúToolStripMenuItem.Name = "menúToolStripMenuItem";
            menúToolStripMenuItem.Size = new Size(209, 20);
            menúToolStripMenuItem.Text = "Formato y manejo de tipos de datos";
            // 
            // formatoDeNumerosToolStripMenuItem
            // 
            formatoDeNumerosToolStripMenuItem.Name = "formatoDeNumerosToolStripMenuItem";
            formatoDeNumerosToolStripMenuItem.Size = new Size(185, 22);
            formatoDeNumerosToolStripMenuItem.Text = "Formato de números";
            formatoDeNumerosToolStripMenuItem.Click += formatoDeNumerosToolStripMenuItem_Click;
            // 
            // formatoDeFechasToolStripMenuItem
            // 
            formatoDeFechasToolStripMenuItem.Name = "formatoDeFechasToolStripMenuItem";
            formatoDeFechasToolStripMenuItem.Size = new Size(185, 22);
            formatoDeFechasToolStripMenuItem.Text = "Formato de fechas";
            formatoDeFechasToolStripMenuItem.Click += formatoDeFechasToolStripMenuItem_Click;
            // 
            // manejoDeStringsToolStripMenuItem
            // 
            manejoDeStringsToolStripMenuItem.Name = "manejoDeStringsToolStripMenuItem";
            manejoDeStringsToolStripMenuItem.Size = new Size(185, 22);
            manejoDeStringsToolStripMenuItem.Text = "Manejo de strings";
            manejoDeStringsToolStripMenuItem.Click += manejoDeStringsToolStripMenuItem_Click;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 570);
            Controls.Add(statusStrip);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmMenu";
            Text = "Laboratorio 2 - Parte B";
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menúToolStripMenuItem;
        private ToolStripMenuItem formatoDeNumerosToolStripMenuItem;
        private ToolStripMenuItem formatoDeFechasToolStripMenuItem;
        private ToolStripMenuItem manejoDeStringsToolStripMenuItem;
    }
}



