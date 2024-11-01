using Microsoft.VisualBasic;
using System.CodeDom;

namespace Ejercicio01
{
    public partial class frmArboles : Form
    {
        public frmArboles()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (tvArbol.Nodes.Count == 0)
            {
                tvArbol.Nodes.Add("A"); tvArbol.SelectedNode = tvArbol.Nodes[0];
            }
            else
            {
                try
                {
                    TreeNode tn = tvArbol.SelectedNode;
                    if (tn.Nodes.Count < 2) { tn.Nodes.Add(Interaction.InputBox("Ingresa el valor del nodo")); }
                    tvArbol.ExpandAll();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private Nodo ConvertirTreeViewAArbol(TreeNode pTreeNode)
        {
            Nodo nodo = null;
            if (pTreeNode != null)
            {
                nodo = new Nodo(pTreeNode.Text);

                if (pTreeNode.Nodes.Count > 0)
                {
                    nodo.Izq = ConvertirTreeViewAArbol(pTreeNode.Nodes[0]);
                }
                if (pTreeNode.Nodes.Count > 1)
                {
                    nodo.Der = ConvertirTreeViewAArbol(pTreeNode.Nodes[1]);
                }
            }
            return nodo;
        }

        private void btnPreorden_Click(object sender, EventArgs e)
        {
            txtPreorden.Clear();
            try
            {
                if (tvArbol.Nodes.Count == 0) throw new Exception("No hay un nodo raíz!");
                Nodo raiz = ConvertirTreeViewAArbol(tvArbol.Nodes[0]);
                PreordenRecursiva(raiz);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnInorden_Click(object sender, EventArgs e)
        {
            txtInorden.Clear();
            try
            {
                if (tvArbol.Nodes.Count == 0) throw new Exception("No hay un nodo raíz!");
                Nodo raiz = ConvertirTreeViewAArbol(tvArbol.Nodes[0]);
                InordenRecursiva(raiz);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPostorden_Click(object sender, EventArgs e)
        {
            txtPostorden.Clear();
            try
            {
                if (tvArbol.Nodes.Count == 0) throw new Exception("No hay un nodo raíz!");
                Nodo raiz = ConvertirTreeViewAArbol(tvArbol.Nodes[0]);
                PostordenRecursiva(raiz);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PreordenRecursiva(Nodo pNodo)
        {
            if (pNodo != null)
            {
                txtPreorden.Text += pNodo.texto + " ";
                PreordenRecursiva(pNodo.Izq);
                PreordenRecursiva(pNodo.Der);
            }
        }
        private void InordenRecursiva(Nodo pNodo)
        {
            if (pNodo != null)
            {
                InordenRecursiva(pNodo.Izq);
                txtInorden.Text += pNodo.texto + " ";
                InordenRecursiva(pNodo.Der);
            }
        }
        private void PostordenRecursiva(Nodo pNodo)
        {
            if (pNodo != null)
            {
                PostordenRecursiva(pNodo.Izq);
                PostordenRecursiva(pNodo.Der);
                txtPostorden.Text += pNodo.texto + " ";
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
