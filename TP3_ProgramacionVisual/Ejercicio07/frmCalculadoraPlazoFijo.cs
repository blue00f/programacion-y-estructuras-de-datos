namespace Ejercicio07
{
    public partial class frmPlazoFijo : Form
    {
        public frmPlazoFijo()
        {
            InitializeComponent();
        }

        private void frmPlazoFijo_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = DateTime.Now;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar monto para que sea un número y no sea negativo
                double monto;
                if (!double.TryParse(txtMonto.Text, out monto) || monto < 0) throw new Exception("El monto ingresado no es válido");

                // Validar para que la tasa sea un número y esté entre 0 y 100
                double tasa;
                if (!double.TryParse(txtTasa.Text, out tasa) || (tasa <= 0 || tasa >= 100)) throw new Exception("La tasa ingresada no es válida");

                // Calcular los dias que hay entre la fecha actual y la fecha seleccionada
                double dias = (dateTimePicker1.Value - DateTime.Now).Days;

                double interes = monto * tasa * dias / 36500;
                double total = monto + interes;
                dataGridView1.Rows.Add(monto, tasa, dias, interes, total);
                txtDias.Text = dias.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
