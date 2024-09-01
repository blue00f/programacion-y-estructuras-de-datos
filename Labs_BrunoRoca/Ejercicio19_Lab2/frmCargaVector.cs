using System.Numerics;

namespace Ejercicio19_Lab2
{
    public partial class frmCargaVector : Form
    {
        public frmCargaVector() // Constructor
        {
            AllocConsole();
            InitializeComponent();
        }
        // Agregar estas dos líneas para habilitar la consola
        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        private static extern bool AllocConsole();

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            string dato;
            int[] vector; // Declaracion del vector
            vector = new int[10]; // Inicializacion del vector
            int i;

            // Carga del vector
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese un valor: ");
                dato = Console.ReadLine();
                vector[i] = Int32.Parse(dato);
            }
            Console.WriteLine("Los datos del vector fueron impresos");

            // Recorrido del vector para cargar los datos en el listBox
            for (i = 0; i < 10; i++)
            {
                lst1.Items.Add($"En la posicion {i} el valor es {vector[i]}");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
