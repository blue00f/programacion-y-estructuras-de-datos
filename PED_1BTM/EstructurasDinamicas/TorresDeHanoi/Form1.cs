using Microsoft.VisualBasic;

namespace TorresDeHanoi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Pila p1, p2, p3, pa;
        int c,q;

        private void Form1_Load(object sender, EventArgs e)
        {
            button7.Enabled=false;
            GenerarDiscos();
        }
        private void GenerarDiscos()
        {

            try
            {
                listBox1.Items.Clear();
                listBox2.Items.Clear();
                listBox3.Items.Clear();
                label1.Text="0 Seg";
                label2.Text="Movimientos: 0";
                p1=new Pila(); p2=new Pila(); p3=new Pila(); pa=new Pila();
                var discos = Interaction.InputBox("Ingrese la cantidad de discos: ");
                if (!Information.IsNumeric(discos)) throw new Exception("El valor debe ser numérico !!!");
                //Invertimos el for para que nos de los valores en el orden que hay que apilarlos
                for (int x = Convert.ToInt32(discos); x>0; x--) { p1.Apilar(x.ToString()); }
                Mostrar(listBox1, p1);
                c=0; q=0;         
                timer1.Start();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }


        }
        private void Mostrar(ListBox pL, Pila pP)
        {
            pL.Items.Clear();
            MostrarEnListBox(pL, pP);
            RestaurarPO(pP);
        }
        private void MostrarEnListBox(ListBox pL, Pila pP)
        {
            Nodo aux = pP.Desapilar();
            if (aux!=null)
            {
                pL.Items.Add(aux.Id);
                pa.Apilar(aux.Id);
                MostrarEnListBox(pL, pP);
            }

        }
        private void RestaurarPO(Pila pP)
        {
            Nodo aux = pa.Desapilar();
            if (aux!=null) { pP.Apilar(aux.Id); RestaurarPO(pP); }
        }
        private bool Ganador()
        {
            return p1.Ver()==null && p2.Ver()==null ? true : false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Pase(p1, p2, listBox1, listBox2);
            ContarMovimientos();
        }

        private void ContarMovimientos()
        {
            q++; label2.Text=$"Movimientos: {q}";
        }

        private void Pase(Pila pPO, Pila pPD, ListBox pLO, ListBox pLD)
        {
            if (pPO.Ver!=null)
            {
                if (pPD.Ver()==null || Convert.ToInt32(pPO.Ver().Id) < Convert.ToInt32(pPD.Ver().Id))
                    pPD.Apilar(pPO.Desapilar().Id);
                Mostrar(pLO, pPO);
                Mostrar(pLD, pPD);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
          
            Pase(p1, p3, listBox1, listBox3);   
            ContarMovimientos();
            if (Ganador()) { timer1.Stop(); MessageBox.Show("Ganaste"); button7.Enabled=true; }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Pase(p2, p1, listBox2, listBox1); ContarMovimientos();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Pase(p2, p3, listBox2, listBox3); 
            ContarMovimientos();
            if (Ganador()) { timer1.Stop(); MessageBox.Show("Ganaste"); button7.Enabled=true; }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Pase(p3, p1, listBox3, listBox1);
            ContarMovimientos();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Pase(p3, p2, listBox3, listBox2);
            ContarMovimientos();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            GenerarDiscos(); button7.Enabled=false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            c++;
            label1.Text=$"{c} Seg";
        }
    }
}
