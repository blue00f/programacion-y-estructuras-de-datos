namespace Ejercicio12
{
    partial class frmPersonalizarForm
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
            colorDialog1 = new ColorDialog();
            btnCambiarColorForm = new Button();
            SuspendLayout();
            // 
            // btnCambiarColorForm
            // 
            btnCambiarColorForm.Location = new Point(107, 168);
            btnCambiarColorForm.Name = "btnCambiarColorForm";
            btnCambiarColorForm.Size = new Size(203, 59);
            btnCambiarColorForm.TabIndex = 0;
            btnCambiarColorForm.Text = "Cambiar color del formulario";
            btnCambiarColorForm.UseVisualStyleBackColor = true;
            btnCambiarColorForm.Click += btnCambiarColorForm_Click;
            // 
            // frmPersonalizarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 369);
            Controls.Add(btnCambiarColorForm);
            Name = "frmPersonalizarForm";
            Text = "Personalización del formulario";
            ResumeLayout(false);
        }

        #endregion

        private ColorDialog colorDialog1;
        private Button btnCambiarColorForm;
    }
}
