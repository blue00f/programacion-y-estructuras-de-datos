using Microsoft.VisualBasic;

namespace Ejercicio03
{
    public partial class frmSumaDeNumeros : Form
    {
        public frmSumaDeNumeros()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            int n, i, suma=0;

            // Validar que se ingrese una cantidad de numeros
            if(txtCantidadNumeros.Text.Length == 0)
            {
                MessageBox.Show("Cantidad de numeros a ingresar está vacio", "ERROR");
            }
            else
            {
                n = int.Parse(txtCantidadNumeros.Text);
                int[] numeros = new int[n];


                // Guardar los numeros en el vector numeros[i]
                for (i = 0; i < numeros.Length; i++)
                {
                    numeros[i] = int.Parse(Interaction.InputBox($"Ingresa el numero {i + 1}", "Ingreso de numeros"));
                }

                // Mostrar los numeros ingresados en txtNumerosIngresados
                txtNumerosIngresados.Text = string.Join(", ", numeros);

                // Calcular la suma de los elementos
                for (i = 0; i < numeros.Length; i++)
                {
                    suma = suma + numeros[i];
                }

                lblResultado.Text = suma.ToString();
            }
        }
    }
}
