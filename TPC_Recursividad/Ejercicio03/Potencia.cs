namespace Ejercicio03
{
    public partial class frmPotencia : Form
    {
        public frmPotencia()
        {
            InitializeComponent();
        }

        private double Potencia(double pBase, double pExpo)
        {
            double res = 0;
            if (pExpo == 0)
            {
                res = 1;
            }
            else
            {
                res = pBase * Potencia(pBase, pExpo - 1);
            }
            return res;
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBase.Text.Length == 0) throw new Exception("La base está vacía");
                if (txtExpo.Text.Length == 0) throw new Exception("El exponente está vacío");

                double numBase, numExpo;

                numBase = Convert.ToDouble(txtBase.Text);
                numExpo = Convert.ToDouble(txtExpo.Text);

                if (numExpo < 0) throw new Exception("El programa no contempla exponentes negativos");

                txtRes.Text = Potencia(numBase, numExpo).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
