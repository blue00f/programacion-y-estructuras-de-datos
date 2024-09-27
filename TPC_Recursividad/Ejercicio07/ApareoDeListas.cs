using Microsoft.VisualBasic;

namespace Ejercicio07
{
    public partial class frmApareoDeListas : Form
    {
        public frmApareoDeListas()
        {
            InitializeComponent();
        }
        List<string> lista1 = new List<string>();
        List<string> lista2 = new List<string>();

        private List<string> Aparear(List<string> unaLista, List<string> otra)
        {
            List<string> apareoDeListas = new List<string>();

            if (unaLista.Count == 0 || otra.Count == 0)
            {
                apareoDeListas.Add("");
            }
            else
            {
                string par = $"{unaLista[0]}{otra[0]}";
                apareoDeListas.Add(par);
                apareoDeListas.AddRange(Aparear(unaLista.GetRange(1, unaLista.Count - 1), otra.GetRange(1, otra.Count - 1)));
            }
            return apareoDeListas;
        }


        private void btnInsertarLista1_Click(object sender, EventArgs e)
        {
            try
            {
                string cadena = Interaction.InputBox("Ingresa una cadena");
                if (cadena.Length == 0) throw new Exception("La cadena no puede estar vacía");
                lista1.Add(cadena);
                lstLista1.Items.Add(cadena);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnInsertarLista2_Click(object sender, EventArgs e)
        {
            try
            {
                string cadena = Interaction.InputBox("Ingresa una cadena");
                if (cadena.Length == 0) throw new Exception("La cadena no puede estar vacía");
                lista2.Add(cadena);
                lstLista2.Items.Add(cadena);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnAparear_Click(object sender, EventArgs e)
        {
            lstListaApareada.Items.Clear();
            List<string> listaApareada = Aparear(lista1, lista2);

            foreach (string item in listaApareada)
            {
                lstListaApareada.Items.Add(item);
            }
        }
    }
}
