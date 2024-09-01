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
    public partial class frmDiferenciaEntreFechas : Form
    {
        public frmDiferenciaEntreFechas()
        {
            InitializeComponent();
        }

        private void btnDiferencia_Click(object sender, EventArgs e)
        {
            DateTime fecha1 = this.dateTimePicker1.Value;
            DateTime fecha2 = this.dateTimePicker2.Value;
            textBox1.Text = (fecha1.Subtract(fecha2).Days).ToString();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
