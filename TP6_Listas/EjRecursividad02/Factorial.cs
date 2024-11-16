using System.CodeDom;

namespace EjRecursividad02
{
    public partial class frmFactorial : Form
    {
        public frmFactorial()
        {
            InitializeComponent();
        }

        private int Factorial(int pNumero)
        {
            int numero = pNumero;
            if (numero == 1)
            {
                numero = 1;
            }
            else
            {
                numero = numero * Factorial(numero - 1);
            }
            return numero;
        }

        public void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNumero.Text.Length == 0) throw new Exception("El campo número está vacio");
                if (!int.TryParse(txtNumero.Text, out int numero)) throw new Exception("El campo número debe recibir un valor numérico");
                int resultado = Factorial(numero);
                txtResultado.Text = resultado.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
