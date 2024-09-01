namespace Ejercicio24_Lab2
{
    public partial class frmTextos : Form
    {
        public frmTextos()
        {
            InitializeComponent();
        }

        private void btnMensaje1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta es la primer advertencia de que la aplicacion PODRÍA fallar", "Aviso de que puedo fallar", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
        }

        private void btnMensaje2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tengo la leve sospecha de que puedo tener un bug escondido", "Advertencia, estoy apunto de fallar", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
        }

        private void btnMensaje3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lastimosamente tengo 482 bugs detectados...", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
