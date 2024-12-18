namespace Ejemplo05
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
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label1 = new Label();
            groupBox1 = new GroupBox();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Font = new Font("Segoe UI", 14F);
            radioButton1.Location = new Point(75, 60);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(122, 29);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Cucurucho";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.Click += Leyenda;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 14F);
            radioButton2.Location = new Point(75, 114);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(70, 29);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Vaso";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.Click += Leyenda;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(75, 258);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton4);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Location = new Point(203, 32);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 124);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "TAMAÑO";
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Font = new Font("Segoe UI", 14F);
            radioButton4.Location = new Point(40, 82);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(78, 29);
            radioButton4.TabIndex = 6;
            radioButton4.Text = "Chico";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.Click += Leyenda;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Checked = true;
            radioButton3.Font = new Font("Segoe UI", 14F);
            radioButton3.Location = new Point(40, 28);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(92, 29);
            radioButton3.TabIndex = 5;
            radioButton3.TabStop = true;
            radioButton3.Text = "Grande";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.Click += Leyenda;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 14F);
            checkBox1.Location = new Point(450, 61);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(131, 29);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Tramontana";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.Click += Leyenda;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Segoe UI", 14F);
            checkBox2.Location = new Point(450, 96);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(176, 29);
            checkBox2.TabIndex = 8;
            checkBox2.Text = "Menta Granizada";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.Click += Leyenda;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("Segoe UI", 14F);
            checkBox3.Location = new Point(450, 131);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(116, 29);
            checkBox3.TabIndex = 9;
            checkBox3.Text = "Chocolate";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.Click += Leyenda;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label1;
        private GroupBox groupBox1;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
    }
}
