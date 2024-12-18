namespace Ejemplo08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void EjemploMessage(object sender, EventArgs e)
        {
            if (MessageBox.Show("Oprima el botón SI o NO", "Prueba del MessageBox", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                label1.Text="Oprimieron 'Sí'";
            }
            else { label1.Text="Oprimieron 'No'"; }
        }


    }
}
