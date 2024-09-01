namespace Ejercicio23_Lab2
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
            hScrollBar1 = new HScrollBar();
            vScrollBar1 = new VScrollBar();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // hScrollBar1
            // 
            hScrollBar1.Location = new Point(46, 101);
            hScrollBar1.Name = "hScrollBar1";
            hScrollBar1.Size = new Size(180, 20);
            hScrollBar1.TabIndex = 0;
            hScrollBar1.Scroll += hScrollBar1_Scroll;
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(360, 101);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(20, 180);
            vScrollBar1.TabIndex = 1;
            vScrollBar1.Scroll += vScrollBar1_Scroll;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(97, 52);
            label1.Name = "label1";
            label1.Padding = new Padding(30, 10, 30, 10);
            label1.Size = new Size(62, 37);
            label1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Location = new Point(272, 166);
            label2.Name = "label2";
            label2.Padding = new Padding(30, 10, 30, 10);
            label2.Size = new Size(62, 37);
            label2.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 319);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(vScrollBar1);
            Controls.Add(hScrollBar1);
            Name = "Form1";
            Text = "Uso de scrollBar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private HScrollBar hScrollBar1;
        private VScrollBar vScrollBar1;
        private Label label1;
        private Label label2;
    }
}
