namespace Ejercicio12
{
    public partial class frmDobleRecursividad : Form
    {
        public frmDobleRecursividad()
        {
            InitializeComponent();
        }

        List<int> resParciales = new List<int>();

        /*
         * 
         * EXPLICACI�N DE LA FUNCI�N RECURSIVA
         * En la funci�n recursiva si ingreso un n�mero menor a 101, se ejecuta el caso recursivo hasta finalmente retornar 91.
         * Cuando es mayor o igual a 101, la funci�n solo ejecuta el caso base y retorna el valor disminuido en 10. Por ejemplo, si ingreso un 120 recibo un 110.
         * 
        */

        private int f(int x)
        {
            if (x > 100)
            {
                return x - 10;
            }
            else
            {
                resParciales.Add(x);
                return (f(f(x + 11)));
            }
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNumero.Text.Length == 0) throw new Exception("El n�mero est� vac�o");
                int numero = Convert.ToInt32(txtNumero.Text);
                resParciales.Clear();

                txtResFinal.Text = f(numero).ToString();
                txtResultados.Text = string.Join(", ", resParciales);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
