namespace Ejercicio14_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hScrollBar1.Value = 30;
            vScrollBar1.Value = 50;
            label1.Text = $"El Scroll Horizontal representa {this.hScrollBar1.Value.ToString()}";
            label2.Text = $"El Scroll Vertical representa {this.vScrollBar1.Value.ToString()}";
            progressBar1.Value = hScrollBar1.Value;
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            label1.Text = $"El Scroll Horizontal representa {hScrollBar1.Value.ToString()}";
            progressBar1.Value = hScrollBar1.Value;
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            label2.Text = $"El Scroll Vertical representa {vScrollBar1.Value.ToString()}";
        }
        private void label1_Click(object sender, EventArgs e)
        {
            // La diferencia entre este método Show y el de label2_Click son las opciones de Si/No en el cuadro de dialogo
            // que aparece al momento de hacer click en el label y el icono de informacion "¡" que aparece en el lado
            // izquierdo del cuadro de dialogo
            MessageBox.Show($"El desplazamiento es de {this.hScrollBar1.Value.ToString()}", "Informacion");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"El desplazamiento es de {this.vScrollBar1.Value.ToString()}", "Informacion", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
        }
    }
}
