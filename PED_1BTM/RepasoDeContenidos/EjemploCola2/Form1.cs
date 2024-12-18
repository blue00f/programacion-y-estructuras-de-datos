namespace EjemploCola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Cola clientes;
        Cola clientesAux;
        private void Form1_Load(object sender, EventArgs e)
        {
            clientes = new Cola();
            clientesAux = new Cola();
        }

        private void btnEncolar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombre.Text;
                if (nombre.Length == 0) throw new Exception("El nombre no debe ser vacio");
                if (!int.TryParse(txtMonto.Text, out int monto)) throw new Exception("El monto debe ser numérico");

                clientes.Encolar(nombre, monto);
                Mostrar(clientes, clientesAux);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDesencolar_Click(object sender, EventArgs e)
        {
            Nodo clienteEliminado = clientes.Desencolar();
            if (clienteEliminado != null)
            {
                Mostrar(clientes, clientesAux);
            }
            else
            {
                MessageBox.Show("No hay clientes para atender");
            }
        }

        private void Mostrar(Cola colaOriginal, Cola colaAuxiliar)
        {
            grillaClientes.Rows.Clear();
            if(colaOriginal.Ver() != null)
            {
                MostrarRecursiva(colaOriginal.Desencolar(), colaOriginal, colaAuxiliar);
                RearmarColaOriginal(colaAuxiliar.Desencolar(), colaOriginal, colaAuxiliar);
            }
        }

        private void MostrarRecursiva(Nodo primerNodo, Cola colaOriginal, Cola colaAuxiliar)
        {
            if(primerNodo != null)
            {
                grillaClientes.Rows.Add(primerNodo.Nombre, primerNodo.Monto);
                colaAuxiliar.Encolar(primerNodo.Nombre, primerNodo.Monto);
                MostrarRecursiva(colaOriginal.Desencolar(), colaOriginal, colaAuxiliar);
            }
        }

        private void RearmarColaOriginal(Nodo primerNodo, Cola colaOriginal, Cola colaAuxiliar)
        {
            if(primerNodo != null)
            {
                colaOriginal.Encolar(primerNodo.Nombre, primerNodo.Monto);
                RearmarColaOriginal(colaAuxiliar.Desencolar(), colaOriginal, colaAuxiliar);
            }
        }
    }
}
