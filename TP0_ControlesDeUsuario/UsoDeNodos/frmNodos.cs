/* Controles utilizados:
 * -listBox
 * -treeView
 */


namespace Ejemplo04
{
    public partial class frmNodos : Form
    {
        public frmNodos()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Agregar hijos a los nodos principales
            int cantidadSubnodos = 20;
            for (int i = 0; i < cantidadSubnodos; i++)
            {
                treeView1.Nodes[0].Nodes.Add($"documento{i + 1}.pdf");
                treeView1.Nodes[1].Nodes.Add($"foto{i + 1}.png");
                treeView1.Nodes[2].Nodes.Add($"cancion{i + 1}.flac");
                treeView1.Nodes[3].Nodes.Add($"pelicula{i + 1}.mp4");
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            listBox1.Items.Clear();
            int cantidadDeSubnodos = e.Node.Nodes.Count;


            for (int i = 0; i < cantidadDeSubnodos; i++)
            {
                listBox1.Items.Add(e.Node.Nodes[i].Text);
            }

        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            listBox1.Items.Clear();

            // Si hago click en un nodo sin hijos, muestro su descripcion
            if(e.Node.Nodes.Count == 0)
            {
                listBox1.Items.Add($"Nombre del archivo {e.Node.Text}");
            }
        }
    }
}
