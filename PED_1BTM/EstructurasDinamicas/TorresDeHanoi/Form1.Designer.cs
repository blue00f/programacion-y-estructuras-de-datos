namespace TorresDeHanoi
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
            components = new System.ComponentModel.Container();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            listBox3 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 20F);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 37;
            listBox1.Location = new Point(55, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(214, 300);
            listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            listBox2.Font = new Font("Segoe UI", 20F);
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 37;
            listBox2.Location = new Point(306, 12);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(214, 300);
            listBox2.TabIndex = 1;
            // 
            // listBox3
            // 
            listBox3.Font = new Font("Segoe UI", 20F);
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 37;
            listBox3.Location = new Point(562, 12);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(214, 300);
            listBox3.TabIndex = 2;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F);
            button1.Location = new Point(55, 318);
            button1.Name = "button1";
            button1.Size = new Size(96, 34);
            button1.TabIndex = 3;
            button1.Text = "Pila 2";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14F);
            button2.Location = new Point(173, 318);
            button2.Name = "button2";
            button2.Size = new Size(96, 34);
            button2.TabIndex = 4;
            button2.Text = "Pila 3";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 14F);
            button3.Location = new Point(306, 318);
            button3.Name = "button3";
            button3.Size = new Size(96, 34);
            button3.TabIndex = 5;
            button3.Text = "Pila 1";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 14F);
            button4.Location = new Point(424, 318);
            button4.Name = "button4";
            button4.Size = new Size(96, 34);
            button4.TabIndex = 6;
            button4.Text = "Pila 3";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 14F);
            button5.Location = new Point(562, 318);
            button5.Name = "button5";
            button5.Size = new Size(96, 34);
            button5.TabIndex = 7;
            button5.Text = "Pila 1";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 14F);
            button6.Location = new Point(680, 318);
            button6.Name = "button6";
            button6.Size = new Size(96, 34);
            button6.TabIndex = 8;
            button6.Text = "Pila 2";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 14F);
            button7.Location = new Point(55, 374);
            button7.Name = "button7";
            button7.Size = new Size(214, 34);
            button7.TabIndex = 9;
            button7.Text = "Comenzar";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(306, 374);
            label1.Name = "label1";
            label1.Size = new Size(83, 37);
            label1.TabIndex = 10;
            label1.Text = "0 Seg";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(562, 374);
            label2.Name = "label2";
            label2.Size = new Size(200, 37);
            label2.TabIndex = 11;
            label2.Text = "Movimientos: 0";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox3);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private ListBox listBox2;
        private ListBox listBox3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private Label label2;
    }
}
