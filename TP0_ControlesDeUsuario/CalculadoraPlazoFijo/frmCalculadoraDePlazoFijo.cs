/* Controles utilizados:
 * -textBox
 * -label
 * -monthCalendar
 * -linkLabel
 */

namespace Ejemplo02
{
    public partial class frmCalculadoraDePlazoFijo : Form
    {
        public frmCalculadoraDePlazoFijo()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            monthCalendar1.MinDate = DateTime.Now;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            txtDias.Text = (monthCalendar1.SelectionEnd - DateTime.Now.Date).Days.ToString();
        }

        private void txtCapital_TextChanged(object sender, EventArgs e)
        {
            txtInteres.Text = string.Format("$ {0:0.00}", (Convert.ToDecimal(txtCapital.Text)* Convert.ToDecimal(txtTasa.Text)*Convert.ToDecimal(txtDias.Text) / 36500));
            txtTotal.Text = string.Format("$ {0:0.00}", (Convert.ToDecimal(txtCapital.Text) + Convert.ToDecimal(txtInteres.Text.Replace("$ ", ""))));
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = "https://www.bcra.gob.ar/BCRAyVos/Plazos_fijos_online.asp",
                UseShellExecute = true
            });
        }

    }
}
