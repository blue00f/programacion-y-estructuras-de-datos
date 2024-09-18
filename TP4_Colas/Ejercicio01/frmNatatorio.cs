using Ejercicio01;
using Microsoft.VisualBasic;
using System.Drawing;
using System.Windows.Forms;

namespace Ejercicio01
{
    public partial class frmNatatorio : Form
    {
        public frmNatatorio()
        {
            InitializeComponent();
        }
        Cola colaOriginal, colaAuxiliar, colaF, colaFA, colaM, colaMA;
        private void Form1_Load(object sender, EventArgs e)
        {
            lstClientes.Items.Clear();
            colaOriginal = new Cola();
            colaAuxiliar = new Cola();
            colaF = new Cola();
            colaFA = new Cola();
            colaM = new Cola();
            colaMA = new Cola();
        }
        private void Mostrar(Cola colaO, Cola colaA, ListBox pList)
        {
            pList.Items.Clear();
            if (colaO.Ver() != null)
            {
                MostrarNombreRecursiva(colaO.Desencolar(), colaO, colaA, pList);
                RearmarColaOriginalRecursiva(colaA.Desencolar(), colaO, colaA);
            }
        }
        private void RearmarColaOriginalRecursiva(Persona pPersona, Cola colaO, Cola colaA)
        {
            if (pPersona != null)
            {
                colaO.Encolar(pPersona.Nombre, pPersona.SexoPersona);
                RearmarColaOriginalRecursiva(colaA.Desencolar(), colaO, colaA);
            }
        }
        private void MostrarNombreRecursiva(Persona? pPersona, Cola colaO, Cola colaA, ListBox pList)
        {
            if (pPersona != null)
            {
                pList.Items.Add($"{pPersona.Nombre} {pPersona.SexoPersona}");
                colaA.Encolar(pPersona.Nombre, pPersona.SexoPersona);
                MostrarNombreRecursiva(colaO.Desencolar(), colaO, colaA, pList);
            }

        }

        private void btnEncolar_Click(object sender, EventArgs e)
        {
            colaOriginal.Encolar(
                Interaction.InputBox("Nombre: "),
                MessageBox.Show("¿Es masculino?", "", MessageBoxButtons.YesNo) == DialogResult.Yes ? Persona.Sexo.Masculino : Persona.Sexo.Femenino
            );
            Mostrar(colaOriginal, colaAuxiliar, lstClientes);
        }

        private void btnDesencolar_Click(object sender, EventArgs e)
        {
            try
            {
                if (colaOriginal.Ver() == null) throw new Exception("No hay personas para desencolar !!!");
                Persona n = colaOriginal.Desencolar();
                if (n.SexoPersona == Persona.Sexo.Masculino)
                {
                    colaM.Encolar(n.Nombre, n.SexoPersona);
                    Mostrar(colaM, colaMA, lstHombres);
                }
                else
                {
                    colaF.Encolar(n.Nombre, n.SexoPersona);
                    Mostrar(colaF, colaFA, lstMujeres);
                }
                Mostrar(colaOriginal, colaAuxiliar, lstClientes);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            MessageBox.Show(colaOriginal.Ver() == null ? "No hay personas para ver !!!" : $"La persona que está para ser desencolada es: {colaOriginal.Ver().Nombre}");
        }
    }
}
