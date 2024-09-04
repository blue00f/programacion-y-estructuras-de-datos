namespace Ejercicio10
{
    public partial class frmConversorTemperatura : Form
    {
        public frmConversorTemperatura()
        {
            InitializeComponent();
        }

        private double ConvertirTemperaturas(double cantidad, string escalaInicial, string escalaFinal)
        {
            double celsius = 0;
            double resultado = 0;

            if (escalaInicial == "Celsius") celsius = cantidad;
            else if (escalaInicial == "Fahrenheit") celsius = (cantidad - 32) * 5 / 9;
            else if (escalaInicial == "Kelvin") celsius = cantidad - 273.15;
            else if (escalaInicial == "Rankine") celsius = (cantidad - 491.67) * 5 / 9;

            if (escalaFinal == "Celsius") resultado = celsius;
            else if (escalaFinal == "Fahrenheit") resultado = celsius * 9 / 5 + 32;
            else if (escalaFinal == "Kelvin") resultado = celsius + 273.15;
            else if (escalaFinal == "Rankine") resultado = celsius * 9 / 5 + 491.67;

            return resultado;
        }

        private void frmConversorTemperatura_Load(object sender, EventArgs e)
        {
            cbxEscalaInicial.SelectedIndex = 0;
            cbxEscalaFinal.SelectedIndex = 1;
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            string escalaInicial = cbxEscalaInicial.Text;
            string escalaFinal = cbxEscalaFinal.Text;
            double cantidad;
            if (!double.TryParse(txtCantidad.Text, out cantidad) || txtCantidad.Text.Length == 0)
            {
                MessageBox.Show("La cantidad no es valida", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double cantidadConvertida = ConvertirTemperaturas(cantidad, escalaInicial, escalaFinal);
                gridTemperaturas.Rows.Add(escalaInicial, escalaFinal, cantidad.ToString("0.00"), cantidadConvertida.ToString("0.00"));
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            gridTemperaturas.Rows.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
