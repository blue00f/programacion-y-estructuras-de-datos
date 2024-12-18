using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Arbol1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Declaro los Nodos
        Nodo a; Nodo b; Nodo c; Nodo d; Nodo e; Nodo f; Nodo g;Nodo h;
        private void Form1_Load(object sender, EventArgs ex)
        {
            // Instancio los Nodos
            a = new Nodo("A");
            b = new Nodo("B");
            c = new Nodo("C");
            d = new Nodo("D");
            e = new Nodo("E");
            f = new Nodo("F");
            g = new Nodo("G");
            h = new Nodo("H");

            // Se arma el árbol
            a.Izq = b;
            a.Der = c;
            b.Der = d;
            c.Izq = e;
            c.Der = f;
            f.Izq = g;
            f.Der = h;
            
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            // Agrega nodos a mano al Treeview2
            if (treeView2.Nodes.Count == 0) { treeView2.Nodes.Add("A"); treeView2.SelectedNode = treeView2.Nodes[0]; }
            else
            {
                try
                {
                    TreeNode tn = treeView2.SelectedNode;
                    if (tn.Nodes.Count < 2) { tn.Nodes.Add(Interaction.InputBox("¿Texto?: ")); }
                    treeView2.ExpandAll();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }           
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            Preorder(a);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            Inorder(a);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
           Posorder(a);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
            List<Nodo> L = new List<Nodo>() { a };
            Anchura(L);
            
        }
        private void button6_Click(object sender, EventArgs e)
        {
            textBox5.Clear();
            treeView3.Nodes.Clear();
            List<Nodo> L = new List<Nodo>(){a};
            // Llena la caja de texto 5 con el recorrido en anchura que contempla los nulls
            AnchuraConNull(L);
            // Construye el arbol en memoria leyendo la informción de la caja de texto 5
            var r = StringToTree(textBox5.Text);
            // Se carga en el treeView3 el árbol construido  en memoria leyendo la informción de la caja de texto 5
            CargaTreeView2(treeView3, r);
        }
        private void Preorder(Nodo pNodo) 
        {
            if (pNodo != null)
            {
                textBox1.Text += pNodo.texto + " "; //ABDCEF
                Preorder(pNodo.Izq);
                Preorder(pNodo.Der);
            }
        }
        private void Inorder(Nodo pNodo)
        {
            if (pNodo != null)
            {
                Inorder(pNodo.Izq);
                textBox2.Text += pNodo.texto + " ";    
                Inorder(pNodo.Der);
            }
        }
        private void Posorder(Nodo pNodo)
        {
            if (pNodo != null)
            {
                Posorder(pNodo.Izq);          
                Posorder(pNodo.Der);
                textBox3.Text += pNodo.texto + " ";
            }
        }

        private void Anchura(List<Nodo> pLnodo)//
        {
            if (pLnodo.Count>0)
            {
                List<Nodo> LT = new List<Nodo>();
                foreach (Nodo N in pLnodo) //
                {
                    textBox4.Text += N.texto + " "; //ABCDEF
                    if (N.Izq != null) { LT.Add(N.Izq); }
                    if (N.Der!=null)  { LT.Add(N.Der); }
                }
                Anchura(LT);//
            }
        }
        private void AnchuraConNull(List<Nodo> pLnodo)//@@@@@@@@
        {
            
            if (pLnodo.FindAll(x => x.texto !="@").Count() > 0)
            {
                List<Nodo> LT = new List<Nodo>();
                foreach (Nodo N in pLnodo)//
                {
                    textBox5.Text += N.texto; //ABC@DEF
                    // Se evalúa si el Nodo N es distinto de null a su izquierda
                    // en caso afirmativo se agrega a LT lo que posee el nodo N a su izquierda
                    // en caso negativo se agrega a LT un nuevo nodo cuyo texto es "@"        
                    LT.Add(N.Izq != null ? N.Izq : new Nodo("@"));
                    // Se evalúa si el Nodo N es distinto de null a su derecha
                    // en caso afirmativo se agrega a LT lo que posee el nodo N a su derecha
                    // en caso negativo se agrega a LT un nuevo nodo cuyo texto es "@"
                    LT.Add(N.Der != null ? N.Der : new Nodo("@"));
                }
                AnchuraConNull(LT);//@@@@@@@@
            }
        }

                                            //TREEVIEW3    Node: A
        private void CargaTreeView2(TreeView pTreeView, Nodo pRaiz)
        {
            // Se verifica de el nodo recibido como nodo raíz sea distinto de null y que no posea un "@" en su texto
            if(pRaiz!=null && pRaiz.texto!="@")
            {
                // Se crea un nodo raiz en el treeView con el texto del nodo del arbol de memoria
                pTreeView.Nodes.Add(pRaiz.texto);
                // Se llama a la función recursiva que carga el TreeView y se pasaÑ
                // a. Una Lista con el/los nodos del TreeView al que hay que cargarle nodos
                // b. Una lista con los nodos del arbol de memoria que hay que usar para cargar el TreeView
                CargaTreeView2Recursivo(new List<TreeNode> { pTreeView.Nodes[0] }, new List<Nodo> { pRaiz.Izq, pRaiz.Der });
                pTreeView.ExpandAll();
            }
        }
                                                //                             //
        private void CargaTreeView2Recursivo(List<TreeNode> pListaTreeView, List<Nodo> pListaArbol)
        {
            if(pListaArbol.FindAll(x=>x.texto!="@").Count>0)
            {
                // Crea una lista auxiliar para los nodos del treeView donde se cargarán los nodos a los que hay que agregarle TreeNode
                List<TreeNode> _auxListaTreeView = new List<TreeNode>();
                // Crea una lista auxiliar para los nodos del árbol en memoria donde se cargarán los nodos que se deben cargar al TreeNode
                List<Nodo> _auxListaArbol = new List<Nodo>();
                // Se recorre cada nodo del TreeView a los que hay que cargarle más nodos
                foreach(TreeNode nt in pListaTreeView) //B
                {
                    // Se itera dos veces para pues a cada nodo nt se le carga a la izquierda y la derecha
                    for(int x=0; x<2;x++)
                    {
                        // Se agrega el nodo al TreeView
                        nt.Nodes.Add(pListaArbol[0].texto == "@" ? "null": pListaArbol[0].texto);
                        // Se actualiza la lista de nodos del arbol con lo que contiene a la izquierda y a la derecha el 
                        // Nodo que se cargo en el treeView.
                        _auxListaArbol.Add(pListaArbol.First().Izq != null ? pListaArbol.First().Izq : new Nodo("@"));
                        _auxListaArbol.Add(pListaArbol.First().Der != null ? pListaArbol.First().Der : new Nodo("@"));
                        // Se remueve el nodo de la lista de nodos del árbol que ya se agregó al treeView
                        pListaArbol.RemoveAt(0);
                        // Se agrega a la lista de nodos treeView el nodo al cual hay que colgarle más nodos
                        _auxListaTreeView.Add(nt.Nodes[nt.Nodes.Count-1]);
                    }
                }
                // Se hace el llamado recursivo
                //                                             
                CargaTreeView2Recursivo(_auxListaTreeView, _auxListaArbol);
            }
        }

                                           // 0123456
        Nodo StringToTree(string pString)  // ABC@DEF
        {
            
            // Se construye el nodo raíz tomando el primer caracter (A) de pString 
            var raiz = new Nodo(pString.Substring(0, 1));
            // Se llama a la función recursiva y se pasa:
            // a. La lista de nodos con el nodo raiz.
            // b. el string de caracteres sin la letra A ya que se utilizó para el primer nodo
            StringToTreeRecursivo( new List<Nodo> { raiz }, pString.Substring(1));
            return raiz;
        }
                                            // @DEF            
        void StringToTreeRecursivo(List<Nodo> pLista, string pString)  
        {
            // Si la cadena pString está vacía se saltea en caso recursivo y termina
            // Si la cadena pString tiene contenido se ingresa al caso general o recursivo
            if(pString.Length>0)
            {
                // Se crea una lista de nodos auxiliar
                List<Nodo> auxLista = new List<Nodo>();
                // Para cada nodo de la lista se le agrega lo que corresponde a la izquierda y a derecha
                foreach(Nodo n in pLista)// 
                {
                   // Se evalúa que posee la cadena pString en la primera posición y crea un nodo con ese caracter.
                   n.Izq = new Nodo(pString.Substring(0,1));
                   // Se evalúa que posee la cadena pString en la segunda posición y crea un nodo con ese caracter.
                   n.Der = new Nodo(pString.Substring(1,1));
                   // Se agregan los nodos creados en la lista auxiliar
                   auxLista.AddRange(new Nodo[] {n.Izq,n.Der});// @DEF
                   // Se recortan los dos primeros caracteres de pString
                   pString = pString.Substring(2);// 
                }
                // Se llama a la función recursivamente sumandole 1 a pPosición.
                StringToTreeRecursivo(auxLista,pString);
            }
        }

    }
 
}
