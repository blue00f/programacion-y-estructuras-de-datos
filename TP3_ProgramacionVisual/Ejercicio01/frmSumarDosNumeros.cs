namespace Ejercicio01
{
    public partial class frmSumarDosNumeros : Form
    {
        public frmSumarDosNumeros()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            int num1, num2;
            if(txtNum1.Text.Length == 0 || txtNum2.Text.Length == 0)
            {
                MessageBox.Show("No debe dejar el campo vacio", "ERROR");
            }
            else if (!int.TryParse(txtNum1.Text, out num1) || !int.TryParse(txtNum2.Text, out num2))
            {
                MessageBox.Show("No se debe ingresar letras", "ERROR");
            }
            else
            {
                int suma = num1 + num2;
                lblResultado.Text = suma.ToString();
            }
        }
    }
}
