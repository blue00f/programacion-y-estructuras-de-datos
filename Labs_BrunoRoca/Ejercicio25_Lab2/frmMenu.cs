using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio25_Lab2
{
    public partial class frmMenu : Form
    {

        public frmMenu()
        {
            InitializeComponent();
        }

        private void formatoDeNumerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFormatoNumeros ofrmFormatoNumeros = new frmFormatoNumeros();
            ofrmFormatoNumeros.MdiParent = this;
            ofrmFormatoNumeros.Show();
        }

        private void formatoDeFechasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFormatoFechas ofrmFormatoFechas = new frmFormatoFechas();
            ofrmFormatoFechas.MdiParent = this;
            ofrmFormatoFechas.Show();
        }

        private void manejoDeStringsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManejoStrings ofrmManejoStrings = new frmManejoStrings();
            ofrmManejoStrings.MdiParent = this;
            ofrmManejoStrings.Show();
        }
    }
}
