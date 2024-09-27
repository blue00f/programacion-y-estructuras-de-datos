using System.CodeDom;

namespace Ejercicio04
{
    public partial class frmSucesionFibonacci : Form
    {
        public frmSucesionFibonacci()
        {
            InitializeComponent();
        }

        private void Fibonacci(double pNumero, List<double> pSerieFibo)
        {
            double res;
            int i;
            for (i = 0; i <= pNumero; i++)
            {
                res = FibonacciRecursiva(i);
                pSerieFibo.Add(res);
            }
        }

        private double FibonacciRecursiva(double pNumero)
        {
            double res = 0;
            if (pNumero == 0 || pNumero == 1)
            {
                res = 1;
            }
            else
            {
                res = FibonacciRecursiva(pNumero - 1) + FibonacciRecursiva(pNumero - 2);
            }
            return res;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCantidadDeSucesiones.Text.Length == 0) throw new Exception("La cantidad de sucesiones no puede ser vacía");
                double cantSucesiones = Convert.ToDouble(txtCantidadDeSucesiones.Text);
                if (cantSucesiones < 0) throw new Exception("La cantidad de sucesiones no puede ser negativa");

                List<double> serieFibo = new List<double>();

                Fibonacci(cantSucesiones-2, serieFibo);
                txtSucesionFibo.Text = $"0, {string.Join(", ", serieFibo)}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
