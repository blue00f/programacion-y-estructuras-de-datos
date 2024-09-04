namespace Ejercicio13
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
            pictureBox1 = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            btnColocarImagen = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.walle;
            pictureBox1.Location = new Point(331, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(638, 490);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnColocarImagen
            // 
            btnColocarImagen.Location = new Point(78, 247);
            btnColocarImagen.Name = "btnColocarImagen";
            btnColocarImagen.Size = new Size(143, 54);
            btnColocarImagen.TabIndex = 1;
            btnColocarImagen.Text = "Adjuntar imagen";
            btnColocarImagen.UseVisualStyleBackColor = true;
            btnColocarImagen.Click += btnColocarImagen_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(994, 553);
            Controls.Add(btnColocarImagen);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Imagenes de robots famosos";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private OpenFileDialog openFileDialog1;
        private Button btnColocarImagen;
    }
}
