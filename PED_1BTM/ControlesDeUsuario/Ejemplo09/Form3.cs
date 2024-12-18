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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        Form1 f1 = null;
        Form2 f2 = null;
        public void Form3Bis(Form1 pf1, Form2 pf2)
        {
            f1=pf1; f2=pf2;
        }

        private void verFormulario1(object sender, EventArgs e)
        {
            f1.Show();
            f2.Hide();
            this.Hide();


        }

        private void verFormulario2(object sender, EventArgs e)
        {
            f1.Hide();
            f2.Show();
            this.Hide();
        }

        private void verFormulario3(object sender, EventArgs e)
        {
            f1.Hide();
            f2.Hide();
            this.Show();
        }

    }
}
