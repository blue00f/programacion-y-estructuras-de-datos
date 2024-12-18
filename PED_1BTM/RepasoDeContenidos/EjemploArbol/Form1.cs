using Microsoft.VisualBasic;

namespace EjemploArbol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(tvNodos.Nodes.Count == 0)
            {
                tvNodos.Nodes.Add("A");
                tvNodos.SelectedNode = tvNodos.Nodes[0];
            }
            else
            {
                TreeNode tn = tvNodos.SelectedNode;
                if(tn.Nodes.Count < 2)
                {
                    tn.Nodes.Add(Interaction.InputBox("Ingrese el nombre del nodo"));
                }
                tvNodos.ExpandAll();
            }
        }

        private Nodo ConvertirTreeViewANodo(TreeNode pNodo)
        {
            Nodo n = null;
            if(pNodo != null)
            {
                n = new Nodo(pNodo.Text);
                if(pNodo.Nodes.Count > 0)
                {
                    n.Izq = ConvertirTreeViewANodo(pNodo.Nodes[0]);
                }
                if(pNodo.Nodes.Count > 1)
                {
                    n.Der = ConvertirTreeViewANodo(pNodo.Nodes[1]);
                }
            }
            return n;
        }

        private void btnPreorden_Click(object sender, EventArgs e)
        {
            try
            {
                txtPreorden.Clear();
                if (tvNodos.Nodes.Count == 0) throw new Exception("No hay nodos");
                Nodo raiz = ConvertirTreeViewANodo(tvNodos.Nodes[0]);
                Preorden(raiz);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnInorden_Click(object sender, EventArgs e)
        {
            try
            {
                txtInorden.Clear();
                if (tvNodos.Nodes.Count == 0) throw new Exception("No hay nodos");
                Nodo raiz = ConvertirTreeViewANodo(tvNodos.Nodes[0]);
                Inorden(raiz);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnPosorden_Click(object sender, EventArgs e)
        {
            try
            {
                txtPosorden.Clear();
                if (tvNodos.Nodes.Count == 0) throw new Exception("No hay nodos");
                Nodo raiz = ConvertirTreeViewANodo(tvNodos.Nodes[0]);
                Posorden(raiz);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void btnAnchura_Click(object sender, EventArgs e)
        {
            try
            {
                txtAnchura.Clear();
                if (tvNodos.Nodes.Count == 0) throw new Exception("No hay nodos");
                Nodo raiz = ConvertirTreeViewANodo(tvNodos.Nodes[0]);
                List<Nodo> lista = new List<Nodo>() { raiz };
                Anchura(lista);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Preorden(Nodo? raiz)
        {
            if(raiz != null)
            {
                txtPreorden.Text += $"{raiz.Nombre} ";
                Preorden(raiz.Izq);
                Preorden(raiz.Der);
            }
        }
        private void Inorden(Nodo? raiz)
        {
            if (raiz != null)
            {
                Inorden(raiz.Izq);
                txtInorden.Text += $"{raiz.Nombre} ";
                Inorden(raiz.Der);
            }
        }
        private void Posorden(Nodo? raiz)
        {
            if (raiz != null)
            {
                Posorden(raiz.Izq);
                Posorden(raiz.Der);
                txtPosorden.Text += $"{raiz.Nombre} ";
            }
        }

        private void Anchura(List<Nodo> pLista)
        {
            if (pLista.Count > 0)
            {
                List<Nodo> LT = new List<Nodo>();
                foreach(Nodo n in pLista)
                {
                    txtAnchura.Text += $"{n.Nombre} ";
                    if (n.Izq != null) LT.Add (n.Izq);
                    if (n.Der != null) LT.Add (n.Der);
                }
                Anchura(LT);
            }
        }
    }
}
