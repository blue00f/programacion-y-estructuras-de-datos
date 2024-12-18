using Microsoft.VisualBasic;

namespace Ejemplo04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = 0;
            comboBox1.SelectedIndex=0;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox1.SelectedItem!=null)
            {         
                label1.Text = listBox1.SelectedItem.ToString();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(Interaction.InputBox("Ingrese una Comida: "));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
            label1.Text="";
        }
    }
}
