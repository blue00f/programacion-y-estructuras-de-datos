using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio22_Lab2
{
    public partial class frmBarraProgreso : Form
    {
        public frmBarraProgreso()
        {
            InitializeComponent();
        }

        private void btnComenzar_Click(object sender, EventArgs e)
        {
            long contador;
            progressBar1.Value = 0; // Se inicializa el valor inicial del progressBar
            progressBar1.Maximum = 100; // Valor maximo para el progressBar
            while (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value++;
                // Bucle para simular el delay, esto es mejor hacerlo con hilos
                for (contador = 1; (contador <= 10000000); contador++) { }
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Alternativa al uso de "Close();"
            Application.Exit();
        }
    }
}
