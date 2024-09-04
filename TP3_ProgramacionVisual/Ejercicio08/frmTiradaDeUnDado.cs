namespace Ejercicio08
{
    public partial class frmTiradaDeUnDado : Form
    {
        private Random rnd;
        public frmTiradaDeUnDado()
        {
            InitializeComponent();
        }

        private void frmTiradaDeUnDado_Load(object sender, EventArgs e)
        {
            rnd = new Random();
        }

        private void btnTirarDado_Click(object sender, EventArgs e)
        {
            txtValorDado.Text = rnd.Next(1, 7).ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
