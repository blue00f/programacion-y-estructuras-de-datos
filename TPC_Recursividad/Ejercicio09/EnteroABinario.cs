namespace Ejercicio09
{
    public partial class frmEnteroABinario : Form
    {
        public frmEnteroABinario()
        {
            InitializeComponent();
        }

        private string ConvertirEnteroABinario(int pEntero)
        {
            string cadenaBinaria;
            if (pEntero == 0)
            {
                cadenaBinaria = "0";
            }
            else if (pEntero == 1)
            {
                cadenaBinaria = "1";
            }
            else
            {
                cadenaBinaria = ConvertirEnteroABinario(pEntero / 2) + (pEntero % 2).ToString();
            }

            return cadenaBinaria;
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEntero.Text.Length == 0) throw new Exception("El entero no puede estar vacío");
                int entero = Convert.ToInt32(txtEntero.Text);
                txtBinario.Text = ConvertirEnteroABinario(entero);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
