namespace EjemploCola1
{
    public partial class Form1 : Form
    {
        Cola colaClientes, colaClientesAux;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            colaClientes = new Cola();
            colaClientesAux = new Cola();
        }

        private void Mostrar(Cola colaO, Cola colaA)
        {
            gridClientes.Rows.Clear();
            if (colaO.Ver() != null)
            {
                MostrarEnGrid(colaO.Desencolar());
                RearmarColaOriginal(colaA.Desencolar());
            }
        }

        private void MostrarEnGrid(Nodo pNodo)
        {
            if (pNodo != null)
            {
                gridClientes.Rows.Add(pNodo.Nombre, pNodo.Apellido, pNodo.Edad);
                colaClientesAux.Encolar(pNodo.Nombre, pNodo.Apellido, pNodo.Edad);
                MostrarEnGrid(colaClientes.Desencolar());
            }
        }

        private void RearmarColaOriginal(Nodo pNodo)
        {
            if (pNodo != null)
            {
                colaClientes.Encolar(pNodo.Nombre, pNodo.Apellido, pNodo.Edad);
                RearmarColaOriginal(colaClientesAux.Desencolar());
            }
        }

        private void btnApilar_Click(object sender, EventArgs e)
        {

            string nombre = txtNombre.Text;
            string apellido = txtApe.Text;
            int edad;
            try
            {
                if (nombre.Length == 0) throw new Exception("El nombre no puede estar vacío");
                if (apellido.Length == 0) throw new Exception("El apellido no puede estar vacío");
                if (txtEdad.Text.Length == 0) throw new Exception("La edad no puede estar vacía");
                if (!int.TryParse(txtEdad.Text, out edad)) throw new Exception("La edad debe ser numérico");
                colaClientes.Encolar(nombre, apellido, edad);
                Mostrar(colaClientes, colaClientesAux);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDesapilar_Click(object sender, EventArgs e)
        {
            try
            {
                if (colaClientes.Ver() == null) throw new Exception("No hay nodos para desencolar");
                colaClientes.Desencolar();
                Mostrar(colaClientes, colaClientesAux);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            Nodo infoNodo = colaClientes.Ver();
            if (infoNodo == null)
            {
                MessageBox.Show("No hay nodos para mostrar");
            }
            else
            {
                MessageBox.Show($"El nodo a eliminar es de {infoNodo.Nombre} {infoNodo.Apellido} de {infoNodo.Edad} años");
            }
        }
    }
}
