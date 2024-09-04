namespace Ejercicio06
{
    public partial class frmSucesionFibonacci : Form
    {
        public frmSucesionFibonacci()
        {
            InitializeComponent();
        }

        private int[] CalcularSucesionFibonacci(int cantidad)
        {
            int[] numerosFib = new int[cantidad];
            if (cantidad >= 1) numerosFib[0] = 1;
            if (cantidad >= 2) numerosFib[1] = 1;

            for(int i = 2; i < cantidad; i++)
            {
                numerosFib[i] = numerosFib[i - 1] + numerosFib[i - 2];
            }
            return numerosFib;
        }

        private void MostrarNumeros(int[] numeros)
        {
            lstNumerosFib.Items.Clear();
            foreach(int numero in numeros)
            {
                lstNumerosFib.Items.Add(numero);
            }
        }

        private void btnCalcularNumerosFib_Click(object sender, EventArgs e)
        {
            int cantidadNumeros;
            if (!int.TryParse(txtCantidadNumeros.Text, out cantidadNumeros) || cantidadNumeros <= 0)
            {
                MessageBox.Show("El número ingresado es incorrecto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int[] numerosFib = CalcularSucesionFibonacci(cantidadNumeros);
                MostrarNumeros(numerosFib);
            }
        }
    }
}
