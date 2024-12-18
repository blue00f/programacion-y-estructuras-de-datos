using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo09
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
         
        }
        Form1 f1 = null;
        Form3 f3 = null;
        public void Form2Bis(Form1 pf1, Form3 pf3) 
        {
            f1=pf1;f3=pf3;
        }

        private void verFormulario1(object sender, EventArgs e)
        {
            f1.Show();
            this.Hide();
            f3.Hide();
        }

        private void verFormulario2(object sender, EventArgs e)
        {
            f1.Hide();
            this.Show();
            f3.Hide();
        }

        private void verFormulario3(object sender, EventArgs e)
        {
            f1.Hide();
            this.Hide();
            f3.Show();
        }
    }
}
