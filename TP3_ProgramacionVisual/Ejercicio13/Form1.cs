namespace Ejercicio13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnColocarImagen_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Imágenes|*.png;*.jpg;*.jpeg;";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Image imagen = Image.FromFile(openFileDialog1.FileName);
                pictureBox1.Image = imagen; 
            }
        }
    }
}
