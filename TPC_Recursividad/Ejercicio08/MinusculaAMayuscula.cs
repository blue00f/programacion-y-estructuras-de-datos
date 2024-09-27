using System.Reflection.Metadata.Ecma335;

namespace Ejercicio08
{
    public partial class frmConversionAMayus : Form
    {
        public frmConversionAMayus()
        {
            InitializeComponent();
        }

        private string Mayusculas(string unString)
        {
            string cadenaMayuscula;

            if (unString.Length == 0)
            {
                cadenaMayuscula = "";
            }
            else
            {
                char primerCaracter = unString[0];
                if (primerCaracter >= 'a' && primerCaracter <= 'z')
                {
                    primerCaracter = (char)(primerCaracter - 32); // Según ASCII, restando 32 obtengo la mayúscula de una letra
                }
                cadenaMayuscula = $"{primerCaracter}{Mayusculas(unString.Substring(1))}";
            }
            return cadenaMayuscula;
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCadena.Text.Length == 0) throw new Exception("La cadena no puede estar vacía");
                string cadena = txtCadena.Text;
                txtCadenaMayus.Text = string.Join("",Mayusculas(cadena));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
