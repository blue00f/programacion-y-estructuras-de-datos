using System.Configuration;
using System.Text.RegularExpressions;

namespace Ejercicio10
{
    public partial class frmBinarioAEntero : Form
    {
        public frmBinarioAEntero()
        {
            InitializeComponent();
        }

        private int ConvertirBinarioAEntero(string pBinario, int pBase)
        {
            int valor = 0;
            if (pBinario.Length == 0)
            {
                valor = 0;
            }
            else
            {
                int digito = Convert.ToInt32(pBinario[0].ToString());
                int exponente = pBinario.Length - 1;
                valor = digito * Convert.ToInt32(Math.Pow(pBase, exponente));
                valor += ConvertirBinarioAEntero(pBinario.Substring(1), pBase);
            }
            return valor;
        }


        private void btnConvertir_Click(object sender, EventArgs e)
        {
            try
            {
                // Uso de expresión regular para que solo se reciba unos y ceros
                string formatoBinario = "^[01]+$";
                Regex regex = new Regex(formatoBinario);

                // Permite escribir los bits agrupados de a 4
                string cadenaBinario = txtBinario.Text.Replace(" ", "");
                
                if (cadenaBinario.Length <= 0 && cadenaBinario.Length >= 32) throw new Exception("El binario solo puede ser entre 1 y 32 bits");
                if (!regex.IsMatch(cadenaBinario)) throw new Exception("El formato del binario es incorrecto, solo se aceptan 1s y 0s");
                txtEntero.Text = ConvertirBinarioAEntero(cadenaBinario, 2).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
