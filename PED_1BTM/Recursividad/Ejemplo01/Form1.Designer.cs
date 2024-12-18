namespace Ejemplo01
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
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button2 = new Button();
            label1 = new Label();
            textBox3 = new TextBox();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F);
            button1.Location = new Point(47, 85);
            button1.Name = "button1";
            button1.Size = new Size(141, 32);
            button1.TabIndex = 0;
            button1.Text = "Factorial";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14F);
            textBox1.Location = new Point(206, 85);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(523, 32);
            textBox1.TabIndex = 1;
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 14F);
            textBox2.Location = new Point(206, 143);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(523, 32);
            textBox2.TabIndex = 3;
            textBox2.TextAlign = HorizontalAlignment.Right;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14F);
            button2.Location = new Point(47, 143);
            button2.Name = "button2";
            button2.Size = new Size(141, 32);
            button2.TabIndex = 2;
            button2.Text = "Potencia";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(206, 205);
            label1.Name = "label1";
            label1.Size = new Size(297, 25);
            label1.TabIndex = 4;
            label1.Text = "0  1  1  2  3  5   8 13  21  34  55   89";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 14F);
            textBox3.Location = new Point(206, 233);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(523, 32);
            textBox3.TabIndex = 6;
            textBox3.TextAlign = HorizontalAlignment.Right;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 14F);
            button3.Location = new Point(47, 233);
            button3.Name = "button3";
            button3.Size = new Size(141, 32);
            button3.TabIndex = 5;
            button3.Text = "Fibonacci";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox3);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button2;
        private Label label1;
        private TextBox textBox3;
        private Button button3;
    }
}
