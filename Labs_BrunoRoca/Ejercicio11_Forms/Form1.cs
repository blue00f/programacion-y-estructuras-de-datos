namespace Ejercicio11_Forms
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            txtRta.Text = (Int32.Parse(txtOp1.Text) + Int32.Parse(txtOp2.Text)).ToString();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            txtRta.Text = Convert.ToString(Convert.ToInt32(txtOp1.Text) - Convert.ToInt32(txtOp2.Text));
        }

        private void btnProd_Click(object sender, EventArgs e)
        {
            txtRta.Text = (Int32.Parse(txtOp1.Text) * Int32.Parse(txtOp2.Text)).ToString();

        }

        private void btnCoc_Click(object sender, EventArgs e)
        {
            int num = Int32.Parse(txtOp1.Text);
            int den = Int32.Parse(txtOp2.Text);
            if (den != 0)
            {
                txtRta.Text = (Decimal.Parse(txtOp1.Text) / Decimal.Parse(txtOp2.Text)).ToString("0.00");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtOp1.Text = "";
            txtOp2.Text = "";
            txtRta.Text = "";
            this.txtOp1.Focus();
        }
    }
}
