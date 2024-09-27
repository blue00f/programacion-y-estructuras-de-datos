namespace Ejercicio11
{
    public partial class frmPalindromo : Form
    {
        public frmPalindromo()
        {
            InitializeComponent();
        }

        private bool EsPalindromo(string pPalabra)
        {
            bool esPalindromo = false;
            if (pPalabra.Length <= 1)
            {
                esPalindromo = true;
            }
            else
            {
                if (pPalabra.Substring(0, 1) == pPalabra.Substring(pPalabra.Length - 1, 1))
                {
                    esPalindromo = EsPalindromo(pPalabra.Substring(1, pPalabra.Length - 2));
                }
                else
                {
                    esPalindromo = false;
                }
            }
            return esPalindromo;
        }

        private void btnVerificarPalabra_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPalabra.Text.Length == 0) throw new Exception("La palabra está vacía");

                // El replace sirve para detectar si una FRASE es palíndroma
                string palabra = txtPalabra.Text.ToLower().Replace(" ", "");
                bool esPalindromo = EsPalindromo(palabra);

                if (esPalindromo) MessageBox.Show("Es palíndromo");
                else MessageBox.Show("No es palíndromo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
