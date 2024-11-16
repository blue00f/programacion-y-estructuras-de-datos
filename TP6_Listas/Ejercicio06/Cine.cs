namespace Ejercicio06
{
    public partial class Cine : Form
    {
        public Cine()
        {
            InitializeComponent();
        }

        ListaDE lista;
        double totalRecaudado = 0;

        private void Mostrar(ListaDE lista)
        {
            grillaClientes.Rows.Clear();
            Cliente aux = lista.RetornaPrimero();
            while (aux != null)
            {
                grillaClientes.Rows.Add(aux.Nombre, aux.Apellido, aux.Edad, aux.Monto);
                aux = aux.Siguiente;
            }
        }

        private void Cine_Load(object sender, EventArgs e)
        {
            lista = new ListaDE();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;

                if (nombre.Length == 0) throw new Exception("El campo nombre está vacío!");
                if (apellido.Length == 0) throw new Exception("El campo apellido está vacío!");

                int posicion;
                if (grillaClientes.RowCount == 0) posicion = 0;
                else
                {
                    if (grillaClientes.CurrentRow == null) throw new Exception("No hay un registro seleccionado!");
                    posicion = grillaClientes.CurrentRow.Index;
                }

                Cliente cliente = new Cliente(nombre, apellido);
                lista.AgregarPosicionN(cliente, posicion + 1);
                Mostrar(lista);
                LimpiarTextBoxs();
                CambiarLaFilaSeleccionada(posicion, grillaClientes);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                int posicion;
                if (grillaClientes.CurrentRow == null) throw new Exception("No hay un registro seleccionado!");

                posicion = grillaClientes.CurrentRow.Index;
                Cliente clienteEliminado = lista.BorrarPosicionN(posicion + 1);
                totalRecaudado += clienteEliminado.Monto;
                txtTotalRecaudado.Text = totalRecaudado.ToString();

                Mostrar(lista);
                LimpiarTextBoxs();
                CambiarLaFilaSeleccionada(posicion, grillaClientes);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;

                if (nombre.Length == 0) throw new Exception("El campo nombre está vacío!");
                if (apellido.Length == 0) throw new Exception("El campo apellido está vacío!");

                if (grillaClientes.CurrentRow == null) throw new Exception("No hay un registro seleccionado!");
                int posicion = grillaClientes.CurrentRow.Index;

                Cliente paciente = new Cliente(nombre, apellido);
                lista.ModificarPosicionN(paciente, posicion + 1);
                Mostrar(lista);
                LimpiarTextBoxs();
                CambiarLaFilaSeleccionada(posicion, grillaClientes);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void grillaClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaSeleccionada = grillaClientes.Rows[e.RowIndex];
                txtNombre.Text = filaSeleccionada.Cells[0].Value.ToString() ?? "";
                txtApellido.Text = filaSeleccionada.Cells[1].Value.ToString() ?? "";
            }
        }
        private void CambiarLaFilaSeleccionada(int posicionSeleccionada, DataGridView grilla)
        {
            int nuevaSeleccion = (posicionSeleccionada >= grilla.Rows.Count) ? grilla.Rows.Count - 1 : posicionSeleccionada;
            if (nuevaSeleccion >= 0)
            {
                grilla.Rows[nuevaSeleccion].Selected = true;
                grilla.CurrentCell = grilla.Rows[nuevaSeleccion].Cells[0];
            }
        }
        private void LimpiarTextBoxs()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
        }
    }
}
