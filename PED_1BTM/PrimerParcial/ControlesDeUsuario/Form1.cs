namespace ControlesDeUsuario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(numericUpDown1.Value);
            if (listBox1.Items.Count == 5) MessageBox.Show("llegamos a 5 !!!");
        }
    }
}
