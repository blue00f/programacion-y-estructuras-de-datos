namespace Ejercicio05
{
    public partial class frmSumaRango : Form
    {
        public frmSumaRango()
        {
            InitializeComponent();
        }

        private int SumarHasta(int pNum, int pDesde)
        {
            int res = 0;
            if (pNum == 0)
            {
                res = 0;
            }
            else
            {
                res = pDesde + SumarHasta(pNum - 1, pDesde + 1);
            }
            return res;
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtN.Text.Length == 0) throw new Exception("El campo n no puede estar vacío");
                if (txtDesde.Text.Length == 0) throw new Exception("El campo Desde no puede estar vacío");
                int n = Convert.ToInt16(txtN.Text);
                int desde = Convert.ToInt16(txtDesde.Text);
                txtResultado.Text = SumarHasta(n, desde).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
