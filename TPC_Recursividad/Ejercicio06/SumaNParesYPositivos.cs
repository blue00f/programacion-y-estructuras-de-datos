namespace Ejercicio06
{
    public partial class frmSumaNParesYPositivos : Form
    {
        public frmSumaNParesYPositivos()
        {
            InitializeComponent();
        }

        private int SumarPares(int pNum)
        {
            int suma = 0;
            if (pNum == 2)
            {
                suma = 2;
            }
            else
            {
                suma = pNum + SumarPares(pNum - 2);
            }
            return suma;
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNumero.Text.Length == 0) throw new Exception("El número no puede estar vacío");
                int numero = Convert.ToInt16(txtNumero.Text);

                // Valido el número para que sea par y positivo antes de pasarlo como parámetro a la función recursiva
                if (numero % 2 != 0) throw new Exception("El número debe ser par");
                if (numero <= 0) throw new Exception("El número no puede ser negativo o cero");

                txtSuma.Text = SumarPares(numero).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
