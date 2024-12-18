using Microsoft.VisualBasic;

namespace EstructuraPila
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Pila po, pa;
        private void Form1_Load(object sender, EventArgs e)
        {
            po= new Pila();
            pa=new Pila();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            po.Apilar(Interaction.InputBox("Id: "));
            Mostrar();
        }
        private void Mostrar()
        {
            listBox1.Items.Clear();
            MostrarEnListBox();
            RestaurarPO();
        }
        private void MostrarEnListBox()
        {
            Nodo aux = po.Desapilar();
            if (aux!=null)
            {
                listBox1.Items.Add(aux.Id);
                pa.Apilar(aux.Id);
                MostrarEnListBox();
            }

        }
        private void RestaurarPO()
        {
            Nodo aux = pa.Desapilar();
            if (aux!=null) { po.Apilar(aux.Id); RestaurarPO(); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Nodo aux = po.Desapilar();
            Mostrar();
            MessageBox.Show(aux==null ? "No hay Nodos !!!" : aux.Id);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Nodo aux = po.Ver();
            MessageBox.Show(aux==null ? "No hay Nodos !!!" : aux.Id);

        }
    }
}
