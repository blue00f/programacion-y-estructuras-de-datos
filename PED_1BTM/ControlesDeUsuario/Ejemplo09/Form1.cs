namespace Ejemplo09
{
    public partial class Form1 : Form
    {
        Form2 f2 = null;
        Form3 f3 = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            f2 = new Form2();
            f3 = new Form3();
            f2.Form2Bis(this, f3);
            f3.Form3Bis(this, f2);
            f2.Hide();
            f3.Hide();
        }

        private void verFormulario1(object sender, EventArgs e)
        {
            this.Show();
            f2.Hide();
            f3.Hide();


        }

        private void verFormulario2(object sender, EventArgs e)
        {
            this.Hide();
            f2.Show();
            f3.Hide();
        }

        private void verFormulario3(object sender, EventArgs e)
        {
            this.Hide();
            f2.Hide();
            f3.Show();
        }
    }
}
