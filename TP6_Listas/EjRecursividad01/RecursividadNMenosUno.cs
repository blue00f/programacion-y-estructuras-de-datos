namespace EjRecursividad01
{
    public partial class frmRecursividadNMenosUno : Form
    {
        public frmRecursividadNMenosUno()
        {
            InitializeComponent();
        }
        private int ImprimirValorMenosUno(int pNumero)
        {
            int numero = pNumero;
            if (numero <= 0)
            {
                numero = 0;
            }
            else
            {
                lstNumeros.Items.Add(numero);
                numero = ImprimirValorMenosUno(numero - 1);
            }
            return numero;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                lstNumeros.Items.Clear();
                if (txtNumero.Text.Length == 0) throw new Exception("El campo número no puede estar vacío");
                if (!int.TryParse(txtNumero.Text, out int numero)) throw new Exception("El campo número solo acepta valores numéricos");
                ImprimirValorMenosUno(numero);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
