using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio19_Lab2
{
    public partial class frmCargaMatriz : Form
    {
        public frmCargaMatriz()
        {
            AllocConsole();
            InitializeComponent();
        }
        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        private static extern bool AllocConsole();

        private void btnCargar_Click(object sender, EventArgs e)
        {
            string dato;
            int[,] matriz; // Declaracion de la matriz
            matriz = new int[3, 4];
            int i, j; // Inicializacion de la matriz

            // Recorrido y carga la matriz
            for (i = 0; i < 3; i++) // Recorrido de filas
            {
                for (j = 0; j < 4; j++) // Recorrido de columnas
                {
                    Console.WriteLine("Ingrese un valor: ");
                    dato = Console.ReadLine();
                    matriz[i, j] = Int32.Parse(dato);
                }
            }
            Console.WriteLine("Los datos de la matriz fueron impresos");

            // Recorrido y carga de datos al listBox
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    int ver = matriz[i, j];
                    lst1.Items.Add($"En la fila: {i} columna: {j} el valor es {matriz[i, j]}");
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
