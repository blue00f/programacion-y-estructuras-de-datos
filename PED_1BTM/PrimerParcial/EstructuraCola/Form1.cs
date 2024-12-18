using Microsoft.VisualBasic;

namespace EstructuraCola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Cola co, ca;
        private void Form1_Load(object sender, EventArgs e)
        {
            co = new Cola();
            ca = new Cola();
        }
        private void Mostrar()
        {
            lstNodos.Items.Clear();
            MostrarEnListBox();
            RestaurarCO();
        }
        private void MostrarEnListBox()
        {
            Nodo aux = co.Desencolar();
            if (aux != null)
            {
                lstNodos.Items.Add(aux.Id);
                ca.Encolar(aux.Id);
                MostrarEnListBox();
            }
        }
        private void RestaurarCO()
        {
            Nodo aux = ca.Desencolar();
            if (aux != null) { co.Encolar(aux.Id); RestaurarCO(); }
        }
        private void btnEncolar_Click(object sender, EventArgs e)
        {
            try
            {
                var t = Interaction.InputBox("Id: ");
                if (!Information.IsNumeric(t) || Convert.ToInt16(t) % 2 != 0 || Convert.ToInt16(t) == 0) throw new Exception("Debe ingresar un número par !!!");
                co.Encolar(t);
                Mostrar();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void btnDesencolar_Click(object sender, EventArgs e)
        {
            Nodo aux = co.Desencolar();
            Mostrar();
            MessageBox.Show(aux == null ? "No hay Nodos !!!" : aux.Id);
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            Nodo aux = co.Ver();
            MessageBox.Show(aux == null ? "No hay Nodos !!!" : aux.Id);
        }
    }
}
