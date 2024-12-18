using Microsoft.VisualBasic;

namespace LSE01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lse=new ListaSE();
        }
        ListaSE lse;
        private void button1_Click(object sender, EventArgs e)
        {
            lse.AgregarAlPrincipio(new Expediente(Interaction.InputBox("Id: ")));
            Mostrar(lse);
        }
        private void Mostrar(ListaSE pLSE)
        {
            listBox1.Items.Clear();
            Expediente aux = pLSE.RetornaPrimero();
            while (aux!=null)
            {
                listBox1.Items.Add(aux.Id);
                aux=aux.Siguiente;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lse.AgregarAlFinal(new Expediente(Interaction.InputBox("Id: ")));
            Mostrar(lse);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(lse.Cantidad().ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {

            try
            {
                lse.AgregarPosicionN(new Expediente(Interaction.InputBox("Id: ")),Convert.ToInt32(Interaction.InputBox("Posición: ")));
                Mostrar(lse);

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void button5_Click(object sender, EventArgs e)
        {

            try
            {
                MessageBox.Show(lse.RetornaExpedientePosN(Convert.ToInt32(Interaction.InputBox("Posición: "))).Id);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }
    }
}
