namespace Ejercicio03
{
    public partial class Cine : Form
    {
        public Cine()
        {
            InitializeComponent();
        }

        ListaSE listaClientes;
        double totalRecaudado = 0;

        private void Cine_Load(object sender, EventArgs e)
        {
            listaClientes = new ListaSE();
        }

        private void Mostrar(ListaSE lista)
        {
            grillaClientes.Rows.Clear();
            Cliente aux = lista.RetornaPrimero();
            while (aux != null)
            {
                grillaClientes.Rows.Add(aux.Nombre, aux.Apellido, aux.Edad, aux.Monto);
                aux = aux.Siguiente;
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                if (nombre.Length == 0) throw new Exception("El campo nombre no puede estar vacío!");
                if (apellido.Length == 0) throw new Exception("El campo apellido no puede estar vacío!");
                Cliente cliente = new Cliente(nombre, apellido);

                listaClientes.AgregarAlFinal(cliente);
                Mostrar(listaClientes);
                LimpiarTextBoxs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregarAbajo_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                if (nombre.Length == 0) throw new Exception("El campo nombre no puede estar vacío!");
                if (apellido.Length == 0) throw new Exception("El campo apellido no puede estar vacío!");

                Cliente cliente = new Cliente(nombre, apellido);
                if (grillaClientes.CurrentRow == null) throw new Exception("No hay un registro seleccionado!");
                int posicionSeleccionada = grillaClientes.CurrentRow.Index;

                listaClientes.AgregarPosicionN(cliente, posicionSeleccionada + 2);
                Mostrar(listaClientes);
                LimpiarTextBoxs();
                CambiarLaFilaSeleccionada(posicionSeleccionada, grillaClientes);
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
                if (grillaClientes.CurrentRow == null) throw new Exception("No hay un registro seleccionado!");
                int posicionSeleccionada = grillaClientes.CurrentRow.Index;
                Cliente clienteEliminado = listaClientes.BorrarPosicionN(posicionSeleccionada + 1);
                totalRecaudado += clienteEliminado.Monto;
                txtTotalRecaudado.Text = totalRecaudado.ToString();
                Mostrar(listaClientes);
                LimpiarTextBoxs();

                // Este método sirve para que al borrar una fila de la grilla, se siga apuntando a esa misma grilla
                // Si se eliminó el ultimo elemento, se apunta a la fila de arriba
                CambiarLaFilaSeleccionada(posicionSeleccionada, grillaClientes);
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

                if (nombre.Length == 0) throw new Exception("El campo nombre no puede estar vacío!");
                if (apellido.Length == 0) throw new Exception("El campo apellido no puede estar vacío!");
                if (grillaClientes.CurrentRow == null) throw new Exception("No hay un registro seleccionado!");
                int posicionSeleccionada = grillaClientes.CurrentRow.Index;

                Cliente cliente = new Cliente(nombre, apellido);
                listaClientes.ModificarPosicionN(cliente, posicionSeleccionada + 1);
                Mostrar(listaClientes);
                LimpiarTextBoxs();
                CambiarLaFilaSeleccionada(posicionSeleccionada, grillaClientes);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimpiarTextBoxs()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
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
        private void grillaClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow filaSeleccionada = grillaClientes.Rows[e.RowIndex];
                txtNombre.Text = filaSeleccionada.Cells[0].Value.ToString() ?? "";
                txtApellido.Text = filaSeleccionada.Cells[1].Value.ToString() ?? "";
            }
        }
    }
}
