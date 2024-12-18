using Microsoft.VisualBasic;

namespace Cola01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Cola colaOriginal,colaAuxiliar,colaF,colaFA,colaM,colaMA;

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            colaOriginal=new Cola();
            colaAuxiliar=new Cola();
            colaF=new Cola();
            colaFA=new Cola();
            colaM=new Cola();
            colaMA=new Cola();


        }
        private void Mostrar(Cola colaO,Cola colaA,ListBox pList)
        {
            pList.Items.Clear();
            if (colaO.Ver()!=null)
            {
                MostrarNombreRecursiva(colaO.Desencolar(), colaO, colaA, pList);
                RearmarColaOriginalRecursiva(colaA.Desencolar(), colaO, colaA);
            }
        }
        private void RearmarColaOriginalRecursiva(Persona pPersona, Cola colaO, Cola colaA)
        {
            if (pPersona!=null)
            {
                colaO.Encolar(pPersona.Nombre, pPersona.SexoPersona);
                RearmarColaOriginalRecursiva(colaA.Desencolar(),colaO,colaA);
            }
        }
        private void MostrarNombreRecursiva(Persona? pPersona, Cola colaO, Cola colaA,ListBox pList)
        {
            if (pPersona!=null)
            {
                pList.Items.Add($"{pPersona.Nombre}  {pPersona.SexoPersona}");
                colaA.Encolar(pPersona.Nombre, pPersona.SexoPersona);
                MostrarNombreRecursiva(colaO.Desencolar(),colaO,colaA,pList);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            colaOriginal.Encolar(Interaction.InputBox("Nombre: "),
                    MessageBox.Show("Es masculino: ", "", MessageBoxButtons.YesNo)==DialogResult.Yes ? Persona.Sexo.Masculino : Persona.Sexo.Femenino);
            Mostrar(colaOriginal,colaAuxiliar,listBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (colaOriginal.Ver()==null) throw new Exception("No hay Personas para desencolar !!!");
                Persona n = colaOriginal.Desencolar();
                if (n.SexoPersona==Persona.Sexo.Masculino)
                {
                    colaM.Encolar(n.Nombre, n.SexoPersona);
                    Mostrar(colaM,colaMA,listBox3);
                }
                else
                {
                    colaF.Encolar(n.Nombre, n.SexoPersona);
                    Mostrar(colaF, colaFA, listBox2);
                }
                Mostrar(colaOriginal, colaAuxiliar, listBox1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       
    }
}
