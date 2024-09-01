namespace Ejercicio15_Forms
{
    public partial class frmRadioButton : Form
    {
        public frmRadioButton()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Usamos this porque asi nos referimos a los controles que estan dentro de la clase frmRadioButton
            // para aquellos controles que estan por fuera de frmRadioButton no se coloca this
            this.txt1.Text = null;
            this.txt2.Text = null;
            this.txtRta.Text = null;
        }

        private void btnIf_Click(object sender, EventArgs e)
        {
            if (this.optResta.Checked)
            {
                this.txtRta.Text = (Int32.Parse(this.txt1.Text) - Int32.Parse(this.txt2.Text)).ToString();
            }
            if (this.optSuma.Checked)
            {
                this.txtRta.Text = (Int32.Parse(this.txt1.Text) + Int32.Parse(this.txt2.Text)).ToString();
            }
            if (this.optProd.Checked)
            {
                this.txtRta.Text = (Int32.Parse(this.txt1.Text) * Int32.Parse(this.txt2.Text)).ToString();
            }
            if (this.optCoc.Checked)
            {
                if (Int32.Parse(this.txt2.Text) != 0)
                {
                    this.txtRta.Text = (Decimal.Parse(this.txt1.Text) / Decimal.Parse(this.txt2.Text)).ToString("0.00");
                }
                else
                {
                    MessageBox.Show("No se puede dividir entre 0.", "ERROR");
                }
            }
        }
        private void btnSwitch_Click(object sender, EventArgs e)
        {
            bool mayor_cero = true;
            int opcion = 0;
            if (this.txt1.Text != null && this.txt2.Text != null)
            {
                if (Int32.Parse(this.txt2.Text) != 0)
                {
                    mayor_cero = true;
                }
                else
                {
                    mayor_cero = false;
                }
                if (this.optSuma.Checked) opcion = 1;
                if (this.optResta.Checked) opcion = 2;
                if (this.optProd.Checked) opcion = 3;
                if (this.optCoc.Checked)
                {
                    if (mayor_cero) opcion = 4;
                }

                switch (opcion)
                {
                    case 1:
                        this.txtRta.Text = (Int32.Parse(this.txt1.Text) + Int32.Parse(txt2.Text)).ToString();
                        break;
                    case 2:
                        this.txtRta.Text = (Int32.Parse(this.txt1.Text) - Int32.Parse(txt2.Text)).ToString();
                        break;
                    case 3:
                        this.txtRta.Text = (Int32.Parse(this.txt1.Text) * Int32.Parse(txt2.Text)).ToString();
                        break;
                    case 4:
                        this.txtRta.Text = (Decimal.Parse(this.txt1.Text) / Decimal.Parse(txt2.Text)).ToString("0.00");
                        break;
                    default:
                        string mensaje = "La operación no se puede realizar";
                        string titulo = "Importante";
                        MessageBoxButtons botones = MessageBoxButtons.YesNo;
                        DialogResult resultado;
                        resultado = MessageBox.Show(mensaje, titulo, botones);
                        if (resultado == System.Windows.Forms.DialogResult.Yes)
                        {
                            this.txt1.Text = null;
                            this.txt2.Text = null;
                            this.txtRta.Text = null;
                        }
                        break;
                }
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

