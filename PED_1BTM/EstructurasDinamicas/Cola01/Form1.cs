using Microsoft.VisualBasic;

namespace Cola01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Cola colaOriginal;
        Cola colaAuxiliar;
        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            colaOriginal=new Cola();
            colaAuxiliar=new Cola();


        }
        private void Mostrar()
        {
            listBox1.Items.Clear();
            if (colaOriginal.Ver()!=null)
            {
                MostrarIdRecursiva(colaOriginal.Desencolar());
                RearmarColaOriginalRecursiva(colaAuxiliar.Desencolar());
            }
        }
        private void RearmarColaOriginalRecursiva(Nodo pNodo)
        {
            if (pNodo!=null)
            {
                colaOriginal.Encolar(pNodo.Id);
                RearmarColaOriginalRecursiva(colaAuxiliar.Desencolar());
            }
        }
        private void MostrarIdRecursiva(Nodo? pNodo)
        {
            if (pNodo!=null)
            {
                listBox1.Items.Add(pNodo.Id);
                colaAuxiliar.Encolar(pNodo.Id);
                MostrarIdRecursiva(colaOriginal.Desencolar());
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            colaOriginal.Encolar(Interaction.InputBox("Id: "));
            Mostrar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (colaOriginal.Ver()==null) throw new Exception("No hay nodos para desencolar !!!");
                Nodo n = colaOriginal.Desencolar();
                Mostrar();
                MessageBox.Show($"Se desencoló en Nodo cuyo Id es: {n.Id}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(colaOriginal.Ver()==null ? "No hay nodos para ver !!!" : $"El nodo que está para ser desencolado es: {colaOriginal.Ver().Id}");
        }
    }
}
