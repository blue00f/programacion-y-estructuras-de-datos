namespace EjemploPila1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Pila pilaClientes, pilaClientesAux;
        private void Form1_Load(object sender, EventArgs e)
        {
            pilaClientes = new Pila();
            pilaClientesAux = new Pila();
        }

        private void Mostrar()
        {
            gridClientes.Rows.Clear();
            MostrarEnGrilla();
            RearmarPilaOriginal();
        }
        private void MostrarEnGrilla()
        {
            Nodo nodoEliminado = pilaClientes.Desapilar();
            if (nodoEliminado != null)
            {
                gridClientes.Rows.Add(nodoEliminado.Nombre, nodoEliminado.FechaNacimiento.ToShortDateString());
                pilaClientesAux.Apilar(nodoEliminado.FechaNacimiento, nodoEliminado.Nombre);
                MostrarEnGrilla();
            }
        }
        private void RearmarPilaOriginal()
        {
            Nodo nodoEliminado = pilaClientesAux.Desapilar();
            if (nodoEliminado != null)
            {
                pilaClientes.Apilar(nodoEliminado.FechaNacimiento, nodoEliminado.Nombre);
                RearmarPilaOriginal();
            }
        }

        private void btnApilar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombre.Text;
                DateTime fechaNacimiento = dateFechaNaci.Value;
                if (nombre.Length == 0) throw new Exception("El nombre no puede estar vacío");
                pilaClientes.Apilar(fechaNacimiento, nombre);
                Mostrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDesapilar_Click(object sender, EventArgs e)
        {
            try
            {
                if (pilaClientes.Ver() == null) throw new Exception("La pila está vacía");
                pilaClientes.Desapilar();
                Mostrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
