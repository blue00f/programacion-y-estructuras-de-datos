namespace Ejercicio25_Lab2
{
    public partial class frmFormatoNumeros : Form
    {
        public frmFormatoNumeros()
        {
            InitializeComponent();
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            if (txtIngreso.Text.Length == 0)
            {
                MessageBox.Show("Ingrese un numero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double auxiliar;
                double auxiliar1;
                double auxiliar2;
                auxiliar = double.Parse(txtIngreso.Text);
                textBox2.Text = string.Format("{0:c}", auxiliar);
                auxiliar1 = (auxiliar / 100);
                textBox3.Text = string.Format("{0:N}", auxiliar);
                textBox4.Text = string.Format("{0:N4}", auxiliar);
                textBox5.Text = string.Format("{0:D8}", Convert.ToInt32(auxiliar));
                textBox6.Text = string.Format("{0:f3}", auxiliar);
                textBox7.Text = string.Format("{0:E3}", auxiliar);
                textBox8.Text = string.Format("{0:p}", auxiliar);
                textBox9.Text = string.Format("El valor es {0:c}", auxiliar);
                auxiliar2 = (auxiliar + 10);
                textBox10.Text = string.Format("{0:c}  {1:c}", auxiliar, auxiliar2);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
