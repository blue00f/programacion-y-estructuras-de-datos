namespace Ejemplo06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            monthCalendar1.MinDate=DateTime.Now;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBox3.Text=(monthCalendar1.SelectionEnd - DateTime.Now.Date).Days.ToString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox4.Text=string.Format("$ {0:0.00}", (Convert.ToDecimal(textBox1.Text) * Convert.ToDecimal(textBox2.Text) * Convert.ToDecimal(textBox3.Text) /36500));
            textBox5.Text=string.Format("$ {0:0.00}",(Convert.ToDecimal(textBox1.Text)+ Convert.ToDecimal(textBox4.Text.Replace("$ ",""))));
        }
    }
}
