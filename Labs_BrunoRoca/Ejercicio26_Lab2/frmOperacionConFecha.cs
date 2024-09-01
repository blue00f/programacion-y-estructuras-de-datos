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
    public partial class frmOperacionConFecha : Form
    {
        public frmOperacionConFecha()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            if (txtDias.Text.Length == 0)
            {
                MessageBox.Show("Inserte la cantidad de dias", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DateTime fecha1 = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day);
                txtResultado.Text = (fecha1.AddDays(Convert.ToInt32(txtDias.Text)).ToString("dd/MM/yyyy")).ToString();
            }
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            if (txtDias.Text.Length == 0)
            {
                MessageBox.Show("Inserte la cantidad de dias", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DateTime fecha1 = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day);
                txtResultado.Text = (fecha1.AddDays(-1 * Convert.ToInt32(txtDias.Text)).ToString("dd/MM/yyyy")).ToString();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
