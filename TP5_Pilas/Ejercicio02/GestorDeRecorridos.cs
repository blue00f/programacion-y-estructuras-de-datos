using Microsoft.VisualBasic;

namespace Ejercicio02
{
    public partial class frmGestorDeRecorridos : Form
    {
        public frmGestorDeRecorridos()
        {
            InitializeComponent();
        }

        Pila viajeIda, viajeVuelta, viajeAuxiliar;

        private void frmGestorDeRecorridos_Load(object sender, EventArgs e)
        {
            viajeIda = new Pila();
            viajeVuelta = new Pila();
            viajeAuxiliar = new Pila();
        }

        private void Mostrar(ListBox pLstViajes, Pila pPilaOriginal, Pila pPilaAuxiliar)
        {
            pLstViajes.Items.Clear();
            MostrarEnListBox(pLstViajes, pPilaOriginal, pPilaAuxiliar);
            RestaurarPilaOriginal(pPilaOriginal, pPilaAuxiliar);
        }
        private void MostrarEnListBox(ListBox pLstViajes, Pila pPilaOriginal, Pila pPilaAuxiliar)
        {
            Nodo aux = pPilaOriginal.Desapilar();
            if (aux != null)
            {
                pLstViajes.Items.Add($"Pueblo: {aux.Nombre}");
                pPilaAuxiliar.Apilar(aux.Nombre);
                MostrarEnListBox(pLstViajes, pPilaOriginal, pPilaAuxiliar);
            }

        }
        private void RestaurarPilaOriginal(Pila pPilaOriginal, Pila pPilaAuxiliar)
        {
            Nodo aux = pPilaAuxiliar.Desapilar();
            if (aux != null)
            {
                pPilaOriginal.Apilar(aux.Nombre);
                RestaurarPilaOriginal(pPilaOriginal, pPilaAuxiliar);
            }
        }

        private void DesapilarPueblos(Pila pPilaIda, Pila pPilaVuelta)
        {
            DesapilarPueblosRecursiva(pPilaIda, pPilaVuelta);
            RestaurarPilaOriginal(pPilaVuelta, pPilaIda);
        }

        private void DesapilarPueblosRecursiva(Pila pPilaIda, Pila pPilaVuelta)
        {
            Nodo puebloEliminado = pPilaIda.Desapilar();
            if (puebloEliminado != null)
            {
                pPilaVuelta.Apilar(puebloEliminado.Nombre);
                DesapilarPueblosRecursiva(pPilaIda, pPilaVuelta);
            }
        }

        private void btnIngresarIda_Click(object sender, EventArgs e)
        {
            try
            {
                string nombrePueblo = Interaction.InputBox("Ingrese el nombre del pueblo", "Apilando pueblos de ida");
                if (nombrePueblo.Length == 0) throw new Exception("El nombre del pueblo no puede estar vacío!");
                viajeIda.Apilar(nombrePueblo);
                Mostrar(lstViajesIda, viajeIda, viajeAuxiliar);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIngresarVuelta_Click(object sender, EventArgs e)
        {
            DesapilarPueblos(viajeIda, viajeVuelta);
            Mostrar(lstViajesVuelta, viajeVuelta, viajeAuxiliar);
        }
    }
}
