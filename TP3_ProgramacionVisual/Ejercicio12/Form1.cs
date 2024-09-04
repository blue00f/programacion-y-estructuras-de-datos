namespace Ejercicio12
{
    public partial class frmPersonalizarForm : Form
    {
        public frmPersonalizarForm()
        {
            InitializeComponent();
        }

        private void btnCambiarColorForm_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog1.Color; 
            }
        }
    }
}
