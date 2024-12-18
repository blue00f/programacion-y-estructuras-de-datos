using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowNewFolderButton=true;
            folderBrowserDialog1.ShowDialog();
            textBox1.Text=folderBrowserDialog1.SelectedPath;

        }

        private void button2_Click(object sender, EventArgs e)
        {
        
            
            openFileDialog1.ShowDialog();

            textBox2.Text=openFileDialog1.FileName;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter="Excel|*.xlsx|Word|*.docx|Todos|*.*";
            saveFileDialog1.ShowDialog();
            textBox3.Text=saveFileDialog1.FileName;
        }
    }
}
