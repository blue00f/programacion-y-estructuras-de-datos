using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Ejercicio01
{
    partial class frmContenedores
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
            lstContenedores = new ListBox();
            lstContenedoresActualizado = new ListBox();
            label1 = new Label();
            btnApilar = new Button();
            btnDesapilarPorId = new Button();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // lstContenedores
            // 
            lstContenedores.FormattingEnabled = true;
            lstContenedores.ItemHeight = 25;
            lstContenedores.Location = new Point(64, 111);
            lstContenedores.Margin = new Padding(5);
            lstContenedores.Name = "lstContenedores";
            lstContenedores.Size = new Size(205, 229);
            lstContenedores.TabIndex = 0;
            // 
            // lstContenedoresActualizado
            // 
            lstContenedoresActualizado.FormattingEnabled = true;
            lstContenedoresActualizado.ItemHeight = 25;
            lstContenedoresActualizado.Location = new Point(321, 111);
            lstContenedoresActualizado.Margin = new Padding(5);
            lstContenedoresActualizado.Name = "lstContenedoresActualizado";
            lstContenedoresActualizado.Size = new Size(205, 229);
            lstContenedoresActualizado.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 71);
            label1.Name = "label1";
            label1.Size = new Size(113, 25);
            label1.TabIndex = 2;
            label1.Text = "Pila original";
            // 
            // btnApilar
            // 
            btnApilar.Location = new Point(192, 347);
            btnApilar.Name = "btnApilar";
            btnApilar.Size = new Size(204, 40);
            btnApilar.TabIndex = 3;
            btnApilar.Text = "Apilar";
            btnApilar.UseVisualStyleBackColor = true;
            btnApilar.Click += btnApilar_Click;
            // 
            // btnDesapilarPorId
            // 
            btnDesapilarPorId.Location = new Point(192, 392);
            btnDesapilarPorId.Name = "btnDesapilarPorId";
            btnDesapilarPorId.Size = new Size(204, 40);
            btnDesapilarPorId.TabIndex = 4;
            btnDesapilarPorId.Text = "Desapilar por ID";
            btnDesapilarPorId.UseVisualStyleBackColor = true;
            btnDesapilarPorId.Click += btnDesapilarPorId_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(321, 71);
            label2.Name = "label2";
            label2.Size = new Size(144, 25);
            label2.TabIndex = 5;
            label2.Text = "Pila actualizada";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 14F, FontStyle.Bold);
            label3.Location = new Point(207, 18);
            label3.Name = "label3";
            label3.Size = new Size(160, 25);
            label3.TabIndex = 6;
            label3.Text = "CONTENEDORES";
            // 
            // frmContenedores
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(581, 487);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnDesapilarPorId);
            Controls.Add(btnApilar);
            Controls.Add(label1);
            Controls.Add(lstContenedoresActualizado);
            Controls.Add(lstContenedores);
            Font = new System.Drawing.Font("Segoe UI", 14F);
            Margin = new Padding(5);
            Name = "frmContenedores";
            Text = "Manejo de contenedores";
            Load += frmContenedores_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstContenedores;
        private ListBox lstContenedoresActualizado;
        private Label label1;
        private Button btnApilar;
        private Button btnDesapilarPorId;
        private Label label2;
        private Label label3;
    }
}
