using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Ejercicio01
{
    partial class frmNatatorio
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
            lstClientes = new ListBox();
            btnEncolar = new Button();
            btnDesencolar = new Button();
            btnVer = new Button();
            lstMujeres = new ListBox();
            lstHombres = new ListBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // lstClientes
            // 
            lstClientes.FormattingEnabled = true;
            lstClientes.ItemHeight = 15;
            lstClientes.Location = new Point(206, 233);
            lstClientes.Margin = new Padding(2);
            lstClientes.Name = "lstClientes";
            lstClientes.Size = new Size(182, 124);
            lstClientes.TabIndex = 0;
            // 
            // btnEncolar
            // 
            btnEncolar.Location = new Point(63, 253);
            btnEncolar.Margin = new Padding(2);
            btnEncolar.Name = "btnEncolar";
            btnEncolar.Size = new Size(124, 28);
            btnEncolar.TabIndex = 1;
            btnEncolar.Text = "Encolar";
            btnEncolar.UseVisualStyleBackColor = true;
            btnEncolar.Click += btnEncolar_Click;
            // 
            // btnDesencolar
            // 
            btnDesencolar.Location = new Point(241, 190);
            btnDesencolar.Margin = new Padding(2);
            btnDesencolar.Name = "btnDesencolar";
            btnDesencolar.Size = new Size(124, 28);
            btnDesencolar.TabIndex = 2;
            btnDesencolar.Text = "Desencolar";
            btnDesencolar.UseVisualStyleBackColor = true;
            btnDesencolar.Click += btnDesencolar_Click;
            // 
            // btnVer
            // 
            btnVer.Location = new Point(63, 300);
            btnVer.Margin = new Padding(2);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(124, 28);
            btnVer.TabIndex = 3;
            btnVer.Text = "Ver";
            btnVer.UseVisualStyleBackColor = true;
            btnVer.Click += btnVer_Click;
            // 
            // lstMujeres
            // 
            lstMujeres.FormattingEnabled = true;
            lstMujeres.ItemHeight = 15;
            lstMujeres.Location = new Point(50, 34);
            lstMujeres.Margin = new Padding(2);
            lstMujeres.Name = "lstMujeres";
            lstMujeres.Size = new Size(182, 124);
            lstMujeres.TabIndex = 4;
            // 
            // lstHombres
            // 
            lstHombres.FormattingEnabled = true;
            lstHombres.ItemHeight = 15;
            lstHombres.Location = new Point(372, 34);
            lstHombres.Margin = new Padding(2);
            lstHombres.Name = "lstHombres";
            lstHombres.Size = new Size(182, 124);
            lstHombres.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 9);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 6;
            label1.Text = "Cola mujeres";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(372, 9);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 7;
            label2.Text = "Cola hombres";
            // 
            // frmNatatorio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(590, 408);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstHombres);
            Controls.Add(lstMujeres);
            Controls.Add(btnVer);
            Controls.Add(btnDesencolar);
            Controls.Add(btnEncolar);
            Controls.Add(lstClientes);
            Name = "frmNatatorio";
            Text = "Sistema de natatorio";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstClientes;
        private Button btnEncolar;
        private Button btnDesencolar;
        private Button btnVer;
        private ListBox lstMujeres;
        private ListBox lstHombres;
        private Label label1;
        private Label label2;
    }
}
