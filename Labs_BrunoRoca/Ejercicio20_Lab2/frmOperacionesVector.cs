namespace Ejercicio20_Lab2
{
    public partial class frmOperacionesVector : Form
    {
        string dato;
        int[] vector;
        int i;
        public frmOperacionesVector()
        {
            AllocConsole();
            InitializeComponent();
        }
        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        private static extern bool AllocConsole();

        private void btnCargar_Click(object sender, EventArgs e)
        {
            lst1.Items.Clear();
            vector = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese un valor: ");
                dato = Console.ReadLine();
                vector[i] = Int32.Parse(dato);
            }
            Console.WriteLine("Los datos del vector fueron impresos");

            for (int i = 0; i < 10; i++)
            {
                lst1.Items.Add($"En la posición: {i} el valor es: {vector[i]}");
            }
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            lst1.Items.Clear();
            Array.Sort(vector); // Esta instrucción ordena el vector
            for (i = 0; i < 10; i++)
            {
                lst1.Items.Add($"El valor es: {vector[i]} en la posicion: {i}");
            }
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            int[] vectorDestino = new int[20];
            Array.Copy(vector, 0, vectorDestino, 0, 10); // (vector, indiceVector, vectorDestino, indiceVectorDestino, longitudVector)
            for (i = 0; i < 10; i++)
            {
                lst1.Items.Add($"{vectorDestino[i]} en la posicion {i}");
            }
        }

        private void btnBusqBinaria_Click(object sender, EventArgs e)
        {
            int posicion;
            posicion = Array.BinarySearch(vector, 9); // Se pasa como parametro el vector y el elemento a buscar
            lst1.Items.Add($"En la posicion {posicion} se encuentra el numero 9");
        }

        private void btnLimites_Click(object sender, EventArgs e)
        {
            int superior;
            int inferior;
            lst1.Items.Clear();
            superior = vector.GetUpperBound(0); // Obtiene el indice del ultimo elemento de la dimension especificada en la matriz
            inferior = vector.GetLowerBound(0); // Obtiene el indice del primer elemento de la dimension especificada en la matriz
            lst1.Items.Add($"El limite inferior es {inferior} y el limite superior es {superior}");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
