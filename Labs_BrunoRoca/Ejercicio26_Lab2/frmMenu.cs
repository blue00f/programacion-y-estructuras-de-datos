using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio26_Lab2
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void formatoDeFechasMedianteDateTimePickerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatePicker ofrmDatePicker = new frmDatePicker();
            ofrmDatePicker.Show();
        }

        private void diferenciaEntreDosFechasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDiferenciaEntreFechas frmDifFechas = new frmDiferenciaEntreFechas();
            frmDifFechas.Show();
        }

        private void sumaYRestaDeDiasAUnaFechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOperacionConFecha frmOpFechas = new frmOperacionConFecha();
            frmOpFechas.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
