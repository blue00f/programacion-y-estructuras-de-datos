/* Controles utilizados:
 * -progressBar
 */

namespace Ejemplo05
{
    public partial class frmCargando : Form
    {
        public frmCargando()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            progressBar1.Maximum = 100;


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 5;
            timer1.Start();
            progressBar1.Value++;
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                Close();
            }
        }
    }
}
