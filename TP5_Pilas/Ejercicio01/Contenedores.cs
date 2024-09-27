using Microsoft.VisualBasic;
using System.CodeDom;

namespace Ejercicio01
{
    public partial class frmContenedores : Form
    {
        public frmContenedores()
        {
            InitializeComponent();
        }

        Pila contenedorOriginal, contenedorAuxiliar;

        private void frmContenedores_Load(object sender, EventArgs e)
        {
            contenedorOriginal = new Pila();
            contenedorAuxiliar = new Pila();
        }

        private void Mostrar(ListBox pLstContenedores)
        {
            pLstContenedores.Items.Clear();
            MostrarEnListBox(pLstContenedores);
            RestaurarPilaOriginal();
        }
        private void MostrarEnListBox(ListBox pLstContenedores)
        {
            Nodo aux = contenedorOriginal.Desapilar();
            if (aux != null)
            {
                pLstContenedores.Items.Add($"ID: {aux.Id}");
                contenedorAuxiliar.Apilar(aux.Id);
                MostrarEnListBox(pLstContenedores);
            }

        }
        private void RestaurarPilaOriginal()
        {
            Nodo aux = contenedorAuxiliar.Desapilar();
            if (aux != null)
            {
                contenedorOriginal.Apilar(aux.Id);
                RestaurarPilaOriginal();
            }
        }

        private void DesapilarPorId(string pId)
        {
            // Desapilar contenedorOriginal hasta encontrar el ID del contenedor y guardar los desapilados en el auxiliar
            // Apilar el contenedorOriginal sin ese contenedor reutilizando el método RestaurarPilaOriginal()
            DesapilarPorIdRecursiva(pId);
            RestaurarPilaOriginal();
        }

        private void DesapilarPorIdRecursiva(string pId)
        {
            Nodo contenedorEliminado = contenedorOriginal.Desapilar();
            if (contenedorEliminado == null) throw new Exception("El ID ingresado no pertenece a ningún contenedor");

            if (contenedorEliminado.Id != pId)
            {
                contenedorAuxiliar.Apilar(contenedorEliminado.Id);
                DesapilarPorIdRecursiva(pId);
            }
        }

        private void btnApilar_Click(object sender, EventArgs e)
        {
            try
            {
                string contenedorId = Interaction.InputBox("Ingrese el ID del contenedor", "Apilamiento de un contenedor");
                if (contenedorId.Length == 0) throw new Exception("El ID del contenedor no puede estar vacío!");
                contenedorOriginal.Apilar(contenedorId);
                Mostrar(lstContenedores);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDesapilarPorId_Click(object sender, EventArgs e)
        {
            try
            {
                if (contenedorOriginal.Ver() == null) throw new Exception("No hay contenedores para desapilar!");

                string contenedorId = Interaction.InputBox("Ingrese el ID del contenedor a eliminar", "Desapilamiento de un contenedor");
                if (contenedorId.Length == 0) throw new Exception("El ID del contenedor no puede estar vacío!");
                DesapilarPorId(contenedorId);
                Mostrar(lstContenedoresActualizado);
                Mostrar(lstContenedores);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
