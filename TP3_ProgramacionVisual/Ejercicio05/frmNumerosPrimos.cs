namespace Ejercicio05
{
    public partial class frmNumerosPrimos : Form
    {
        public frmNumerosPrimos()
        {
            InitializeComponent();
        }

        private static bool EsPrimo(int numero)
        {
            int i;
            if (numero < 2) return false;

            // El calculo del numero primo se puede determinar dividiendolo por numeros menores o iguales
            // que su raiz cuadrada, de esa forma se reducen las iteraciones
            for (i = 2; i <= Math.Sqrt(numero); i++)
            {
                if ((numero % i) == 0) return false;
            }
            return true;
        }

        private void btnCalcularNumerosPrimos_Click(object sender, EventArgs e)
        {
            int numeroMinimo = int.Parse(txtNumMin.Text);
            int numeroMaximo = int.Parse(txtNumMax.Text);
            int longitudVector = numeroMaximo-numeroMinimo;

            if(numeroMaximo < numeroMinimo)
            {
                MessageBox.Show("El valor máximo no puede ser menor que el valor mínimo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Para incluir al numero maximo debo incrementar en uno a la longitudVector
                // y asi incluyo a todos los elementos que estan entre el minimo y el maximo
                int[] vector = new int[longitudVector + 1];
                int i;

                for (i = 0; i <= longitudVector; i++)
                {
                    vector[i] = numeroMinimo + i;
                }

                lstNumerosPrimos.Items.Clear();
                foreach (int numero in vector)
                {
                    if (EsPrimo(numero)) lstNumerosPrimos.Items.Add(numero);
                }
            }
        }
    }
}
