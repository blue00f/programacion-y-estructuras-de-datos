namespace Ejercicio04
{
    public partial class frmCalculadoraSimple : Form
    {
        public frmCalculadoraSimple()
        {
            InitializeComponent();
        }
        #region
        private static bool ValidarNumeroVacio(string cadena)
        {
            if(cadena.Length == 0)
            {
                return false;
            }
            return true;
        }
        private static void MensajeDeError()
        {
            MessageBox.Show("No deje los campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private static double RealizarOperacion(double pNum1, double pNum2, string pOperador)
        {
            if(pOperador == "+")
            {
                return pNum1 + pNum2;
            }
            else if(pOperador == "-")
            {
                return pNum1 - pNum2;
            }
            else if(pOperador == "*")
            {
                return pNum1 * pNum2;
            }
            else if(pOperador == "/")
            {
                if (pNum2 == 0)
                {
                    throw new Exception("No se puede dividir por cero");
                }
                else
                {
                    return pNum1 / pNum2;
                }
            }
            else
            {
                throw new Exception("Operador no valido");
            }
        } 

        #endregion
        private void btnSumar_Click(object sender, EventArgs e)
        {
            if(!ValidarNumeroVacio(txtNum1.Text) || !ValidarNumeroVacio(txtNum2.Text))
            {
                MensajeDeError();
            }
            else
            {

                txtResultado.Text = RealizarOperacion(double.Parse(txtNum1.Text), double.Parse(txtNum2.Text), "+").ToString();
            }
        }

        private void btnRestar_Click(object obj, EventArgs e)
        {
            if (!ValidarNumeroVacio(txtNum1.Text) || !ValidarNumeroVacio(txtNum2.Text))
            {
                MensajeDeError();
            }
            else
            {
                txtResultado.Text = RealizarOperacion(double.Parse(txtNum1.Text), double.Parse(txtNum2.Text), "-").ToString();
            }
        }

        private void btnMultiplicar_Click(object obj, EventArgs e)
        {
            if (!ValidarNumeroVacio(txtNum1.Text) || !ValidarNumeroVacio(txtNum2.Text))
            {
                MensajeDeError();
            }
            else
            {
                txtResultado.Text = RealizarOperacion(double.Parse(txtNum1.Text), double.Parse(txtNum2.Text), "*").ToString();

            }
        }

        private void btnDividir_Click(object obj, EventArgs e)
        {
            if (!ValidarNumeroVacio(txtNum1.Text) || !ValidarNumeroVacio(txtNum2.Text))
            {
                MensajeDeError();
            }
            else
            {
                try
                {
                    txtResultado.Text = RealizarOperacion(double.Parse(txtNum1.Text), double.Parse(txtNum2.Text), "/").ToString("0.00");
                }
                catch (Exception ex)
                {
                    txtResultado.Text = ex.Message;
                }

            }

        }
        private void btnPotencia_Click(object sender, EventArgs e)
        {
            if (!ValidarNumeroVacio(txtNum1.Text) || !ValidarNumeroVacio(txtNum2.Text))
            {
                MensajeDeError();
            }
            else
            {
                double potenciaNum1, potenciaNum2;
                potenciaNum1 = double.Parse(txtNum1.Text) * double.Parse(txtNum1.Text);
                potenciaNum2 = double.Parse(txtNum2.Text) * double.Parse(txtNum2.Text);
                txtPotenciaNum1.Text = potenciaNum1.ToString();
                txtPotenciaNum2.Text = potenciaNum2.ToString();
            }
            
        }

        private void btnRaizCuadrada_Click(object sender, EventArgs e)
        {
            if (!ValidarNumeroVacio(txtNum1.Text) || !ValidarNumeroVacio(txtNum2.Text))
            {
                MensajeDeError();
            }
            else
            {
                double raizCuadradaNum1, raizCuadradaNum2;
                if (double.Parse(txtNum1.Text) < 0)
                {
                    txtRaizNum1.Text = "No existen raíces de números negativos";
                }
                else
                {
                    raizCuadradaNum1 = Math.Sqrt(double.Parse(txtNum1.Text));
                    txtRaizNum1.Text = raizCuadradaNum1.ToString("0.00");
                }

                if (double.Parse(txtNum2.Text) < 0)
                {
                    txtRaizNum2.Text = "No existen raíces de números negativos";
                }
                else
                {
                    raizCuadradaNum2 = Math.Sqrt(double.Parse(txtNum2.Text));
                    txtRaizNum2.Text = raizCuadradaNum2.ToString("0.00");
                }
            }
            
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
