namespace EjemploCola2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Cola coches, cochesAux;
        private void Form1_Load(object sender, EventArgs e)
        {
            coches = new Cola();
            cochesAux = new Cola();

            foreach(var motor in Enum.GetValues(typeof(Coche.Motor)))
            {
                cbxTipoDeMotor.Items.Add(motor);
            }
            cbxTipoDeMotor.SelectedIndex = 0;
        }

        private void Mostrar(Cola colaOrig, Cola colaAux)
        {
            grillaCoches.Rows.Clear();
            MostrarRecursiva(colaOrig.Desencolar(), colaOrig, colaAux);
            RearmarCola(colaAux.Desencolar(), colaOrig, colaAux);
        }

        private void MostrarRecursiva(Coche primerCoche, Cola colaOrig, Cola colaAux)
        {
            Coche n = primerCoche;
            if(primerCoche != null)
            {
                grillaCoches.Rows.Add(n.Modelo, n.TipoMotor);
                colaAux.Encolar(n.Modelo, n.TipoMotor);
                MostrarRecursiva(colaOrig.Desencolar(), colaOrig, colaAux);
            }
        }
        private void RearmarCola(Coche primerCoche, Cola colaOrig, Cola colaAux)
        {
            Coche n = primerCoche;
            if(primerCoche != null)
            {
                colaOrig.Encolar(n.Modelo, n.TipoMotor);
                RearmarCola(colaAux.Desencolar(), colaOrig, colaAux);
            }
        }

        private void btnEncolar_Click(object sender, EventArgs e)
        {
            try
            {
                string modelo = txtModelo.Text;
                if (modelo.Length == 0) throw new Exception("El modelo no debe estar vacio");
                Coche.Motor tipoMotor = (Coche.Motor)cbxTipoDeMotor.SelectedIndex;

                coches.Encolar(modelo, tipoMotor);
                Mostrar(coches, cochesAux);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDesencolar_Click(object sender, EventArgs e)
        {
            if(coches.Ver() != null)
            {
                coches.Desencolar();
                Mostrar(coches, cochesAux);
            }
            else
            {
                MessageBox.Show("No hay coches para atender!");
            }
        }
    }
}
