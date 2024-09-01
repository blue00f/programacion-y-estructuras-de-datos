namespace Ejercicio26_Lab2
{
    partial class frmMenu
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
            menuStrip1 = new MenuStrip();
            formularioDeFechasToolStripMenuItem = new ToolStripMenuItem();
            formatoDeFechasMedianteDateTimePickerToolStripMenuItem = new ToolStripMenuItem();
            diferenciaEntreDosFechasToolStripMenuItem = new ToolStripMenuItem();
            sumaYRestaDeDiasAUnaFechaToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { formularioDeFechasToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(699, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // formularioDeFechasToolStripMenuItem
            // 
            formularioDeFechasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { formatoDeFechasMedianteDateTimePickerToolStripMenuItem, diferenciaEntreDosFechasToolStripMenuItem, sumaYRestaDeDiasAUnaFechaToolStripMenuItem });
            formularioDeFechasToolStripMenuItem.Name = "formularioDeFechasToolStripMenuItem";
            formularioDeFechasToolStripMenuItem.Size = new Size(259, 20);
            formularioDeFechasToolStripMenuItem.Text = "Operaciones de fecha usando dateTimePicker";
            // 
            // formatoDeFechasMedianteDateTimePickerToolStripMenuItem
            // 
            formatoDeFechasMedianteDateTimePickerToolStripMenuItem.Name = "formatoDeFechasMedianteDateTimePickerToolStripMenuItem";
            formatoDeFechasMedianteDateTimePickerToolStripMenuItem.Size = new Size(245, 22);
            formatoDeFechasMedianteDateTimePickerToolStripMenuItem.Text = "Formato de fechas";
            formatoDeFechasMedianteDateTimePickerToolStripMenuItem.Click += formatoDeFechasMedianteDateTimePickerToolStripMenuItem_Click;
            // 
            // diferenciaEntreDosFechasToolStripMenuItem
            // 
            diferenciaEntreDosFechasToolStripMenuItem.Name = "diferenciaEntreDosFechasToolStripMenuItem";
            diferenciaEntreDosFechasToolStripMenuItem.Size = new Size(245, 22);
            diferenciaEntreDosFechasToolStripMenuItem.Text = "Diferencia entre dos fechas";
            diferenciaEntreDosFechasToolStripMenuItem.Click += diferenciaEntreDosFechasToolStripMenuItem_Click;
            // 
            // sumaYRestaDeDiasAUnaFechaToolStripMenuItem
            // 
            sumaYRestaDeDiasAUnaFechaToolStripMenuItem.Name = "sumaYRestaDeDiasAUnaFechaToolStripMenuItem";
            sumaYRestaDeDiasAUnaFechaToolStripMenuItem.Size = new Size(245, 22);
            sumaYRestaDeDiasAUnaFechaToolStripMenuItem.Text = "Suma y resta de dias a una fecha";
            sumaYRestaDeDiasAUnaFechaToolStripMenuItem.Click += sumaYRestaDeDiasAUnaFechaToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(41, 20);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.windows_wallpaper;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(699, 357);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmMenu";
            Text = "Laboratorio 2 - Parte C";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem formularioDeFechasToolStripMenuItem;
        private ToolStripMenuItem formatoDeFechasMedianteDateTimePickerToolStripMenuItem;
        private ToolStripMenuItem diferenciaEntreDosFechasToolStripMenuItem;
        private ToolStripMenuItem sumaYRestaDeDiasAUnaFechaToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
    }
}