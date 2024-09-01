namespace Ejercicio26_Lab2
{
    public partial class frmDatePicker : Form
    {
        public frmDatePicker()
        {
            InitializeComponent();
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            DateTime Fecha = this.dateTimePicker1.Value;
            textBox1.Text = Convert.ToString(Fecha);

            // Fecha corta
            textBox2.Text = string.Format("{0:d}", Fecha);

            // Fecha larga + tiempo
            textBox3.Text = string.Format("{0:D}", Fecha);

            // Fecha larga + tiempo corto
            textBox4.Text = string.Format("{0:f}", Fecha);

            // Fecha corta + tiempo corto
            textBox5.Text = string.Format("{0:g}", Fecha);

            // Fecha corta + tiempo largo
            textBox6.Text = string.Format("{0:G}", Fecha);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
