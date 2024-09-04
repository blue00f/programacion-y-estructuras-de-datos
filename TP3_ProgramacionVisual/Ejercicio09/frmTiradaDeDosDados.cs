namespace Ejercicio09
{
    public partial class frmTiradaDeDosDados : Form
    {
        private Random rnd;
        int[] contadores = new int[6];
        double[] porcentajes = new double[6];
        int totalTiradas = 0;

        public frmTiradaDeDosDados()
        {
            InitializeComponent();
        }

        private void frmTiradaDeDosDados_Load(object sender, EventArgs e)
        {
            rnd = new Random();
        }

        private void btnTirarDados_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            int dado1 = rnd.Next(1, 7);
            int dado2 = rnd.Next(1, 7);
            txtValorDado1.Text = dado1.ToString();
            txtValorDado2.Text = dado2.ToString();

            contadores[dado1 - 1]++;
            contadores[dado2 - 1]++;

            totalTiradas += 2;

            // Calculo de los porcentajes de los dados
            for(int i = 0; i < contadores.Length; i++)
            {
                porcentajes[i] = (totalTiradas > 0) ? (contadores[i] / (double)totalTiradas) * 100 : 0;
            }

            dataGridView1.Rows.Add(
                contadores[0], contadores[1],
                contadores[2], contadores[3],
                contadores[4], contadores[5],
                porcentajes[0].ToString("0.00"), porcentajes[1].ToString("0.00"),
                porcentajes[2].ToString("0.00"), porcentajes[3].ToString("0.00"),
                porcentajes[4].ToString("0.00"), porcentajes[5].ToString("0.00")
            );

        }
    }
}
