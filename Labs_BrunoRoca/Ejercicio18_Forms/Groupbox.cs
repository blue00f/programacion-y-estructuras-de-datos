namespace Ejercicio18_Forms
{
    public partial class frmGroupbox : Form
    {
        public frmGroupbox()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (opt1.Checked == true)
            {
                lst1.Items.Add(textBox1.Text);
                opt1.Checked = false;
            }
            if (opt2.Checked == true)
            {
                lst1.Items.Add(textBox2.Text);
                opt2.Checked = false;
            }
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lst1.Items.Clear();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
