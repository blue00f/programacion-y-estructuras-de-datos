using Microsoft.VisualBasic;

namespace Ejemplo01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private double Factorial(double n)
        {
            double r = 0;
            if (n==0) r=1; //Caso Base
            else r= n * Factorial(n-1); //Caso recursivo
            return r;
        }
        private double Potencia(double pBase, double pExpo)
        {
            double r = 0;
            if (pExpo==0) r=1;
            else r=pBase * Potencia(pBase, pExpo-1);
            return r;
        }
        private double Fibonacci(double n)
        {
            double r=0;
            if (n==0 || n==1) r=1;
            else r= Fibonacci(n-1) + Fibonacci(n-2);
            return r;
        }
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                textBox1.Text =  Factorial(Convert.ToDouble(Interaction.InputBox("Número: "))).ToString();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text=Potencia(Convert.ToDouble(Interaction.InputBox("Base: ")), Convert.ToDouble(Interaction.InputBox("Exponente: "))).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text=Fibonacci(Convert.ToDouble(Interaction.InputBox("Ingrese n:"))).ToString();
        }
    }
}
