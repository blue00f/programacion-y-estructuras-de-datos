namespace Ejercicio02
{
    partial class frmSumarDosNumerosInputBox
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
            components = new System.ComponentModel.Container();
            imageList1 = new ImageList(components);
            btnSumar = new Button();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // btnSumar
            // 
            btnSumar.Location = new Point(71, 57);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(158, 85);
            btnSumar.TabIndex = 0;
            btnSumar.Text = "Sumar dos numeros";
            btnSumar.UseVisualStyleBackColor = true;
            btnSumar.Click += btnSumar_Click;
            // 
            // frmSumarDosNumerosInputBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(317, 198);
            Controls.Add(btnSumar);
            Name = "frmSumarDosNumerosInputBox";
            Text = "Suma de dos números";
            ResumeLayout(false);
        }

        #endregion

        private ImageList imageList1;
        private Button btnSumar;
    }
}
