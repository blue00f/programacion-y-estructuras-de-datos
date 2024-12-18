namespace Ejemplo02
{
    public partial class Form1 : Form
    {
        private Random rnd;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text= rnd.Next(1, 7).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rnd=new Random();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int d1 = rnd.Next(1, 7);
            int d2 = rnd.Next(1, 7);
            textBox3.Text= d1.ToString();
            textBox4.Text= d2.ToString();
            textBox2.Text = (d1+d2).ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            button2_Click(null, null);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
