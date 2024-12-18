namespace Ejemplo01
{
    public partial class Form1 : Form
    {
        private Random rnd;
        public Form1()
        {
            InitializeComponent();
        }

        private void Pepito(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Text=$"X: {e.X}  --  Y: {e.Y}";
            BackColor=Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rnd = new Random();
        }
    }
}
