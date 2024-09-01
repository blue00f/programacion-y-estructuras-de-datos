namespace Ejercicio18_Forms
{
    partial class Menu
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
            laboratorio2ToolStripMenuItem = new ToolStripMenuItem();
            radioButtonToolStripMenuItem = new ToolStripMenuItem();
            checkBoxToolStripMenuItem = new ToolStripMenuItem();
            groupBoxToolStripMenuItem = new ToolStripMenuItem();
            statusStrip.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel });
            statusStrip.Location = new Point(0, 558);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(1, 0, 16, 0);
            statusStrip.Size = new Size(809, 22);
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
            menuStrip1.Items.AddRange(new ToolStripItem[] { laboratorio2ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(809, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // laboratorio2ToolStripMenuItem
            // 
            laboratorio2ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { radioButtonToolStripMenuItem, checkBoxToolStripMenuItem, groupBoxToolStripMenuItem });
            laboratorio2ToolStripMenuItem.Name = "laboratorio2ToolStripMenuItem";
            laboratorio2ToolStripMenuItem.Size = new Size(89, 20);
            laboratorio2ToolStripMenuItem.Text = "Laboratorio 2";
            // 
            // radioButtonToolStripMenuItem
            // 
            radioButtonToolStripMenuItem.Name = "radioButtonToolStripMenuItem";
            radioButtonToolStripMenuItem.Size = new Size(180, 22);
            radioButtonToolStripMenuItem.Text = "RadioButton";
            radioButtonToolStripMenuItem.Click += radioButtonToolStripMenuItem_Click;
            // 
            // checkBoxToolStripMenuItem
            // 
            checkBoxToolStripMenuItem.Name = "checkBoxToolStripMenuItem";
            checkBoxToolStripMenuItem.Size = new Size(180, 22);
            checkBoxToolStripMenuItem.Text = "CheckBox";
            checkBoxToolStripMenuItem.Click += checkBoxToolStripMenuItem_Click;
            // 
            // groupBoxToolStripMenuItem
            // 
            groupBoxToolStripMenuItem.Name = "groupBoxToolStripMenuItem";
            groupBoxToolStripMenuItem.Size = new Size(180, 22);
            groupBoxToolStripMenuItem.Text = "GroupBox";
            groupBoxToolStripMenuItem.Click += groupBoxToolStripMenuItem_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondoMenu;
            ClientSize = new Size(809, 580);
            Controls.Add(statusStrip);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Menu";
            Text = "Menú";
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
        private ToolStripMenuItem laboratorio2ToolStripMenuItem;
        private ToolStripMenuItem radioButtonToolStripMenuItem;
        private ToolStripMenuItem checkBoxToolStripMenuItem;
        private ToolStripMenuItem groupBoxToolStripMenuItem;
    }
}



