namespace Ejercicio05
{
    public partial class Hospital : Form
    {
        public Hospital()
        {
            InitializeComponent();
        }

        ListaDE lista;

        private void Hospital_Load(object sender, EventArgs e)
        {
            lista = new ListaDE();
        }

        private void Mostrar(ListaDE pLista)
        {
            grillaPacientes.Rows.Clear();
            Paciente aux = lista.RetornaPrimero();
            while (aux != null)
            {
                grillaPacientes.Rows.Add(aux.Id, aux.Nombre, aux.Apellido, aux.Direccion, aux.Telefono);
                aux = aux.Siguiente;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                int id;
                string nombre, apellido, direccion, telefono;
                IngresoDeDatosPaciente(out id, out nombre, out apellido, out direccion, out telefono);

                int posicion;
                if (grillaPacientes.RowCount == 0) posicion = 0;
                else
                {
                    if (grillaPacientes.CurrentRow == null) throw new Exception("No hay un registro seleccionado!");
                    posicion = grillaPacientes.CurrentRow.Index;
                }

                Paciente paciente = new Paciente(id, nombre, apellido, direccion, telefono);
                lista.AgregarPosicionN(paciente, posicion + 1);
                Mostrar(lista);
                LimpiarTextBoxs();
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
                if (grillaPacientes.CurrentRow == null) throw new Exception("No hay un registro seleccionado!");

                posicion = grillaPacientes.CurrentRow.Index;
                lista.BorrarPosicionN(posicion + 1);
                Mostrar(lista);
                LimpiarTextBoxs();
                CambiarLaFilaSeleccionada(posicion, grillaPacientes);
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
                int id;
                string nombre, apellido, direccion, telefono;
                IngresoDeDatosPaciente(out id, out nombre, out apellido, out direccion, out telefono);

                if (grillaPacientes.CurrentRow == null) throw new Exception("No hay un registro seleccionado!");
                int posicion = grillaPacientes.CurrentRow.Index;

                Paciente paciente = new Paciente(id, nombre, apellido, direccion, telefono);
                lista.ModificarPosicionN(paciente, posicion + 1);
                Mostrar(lista);
                LimpiarTextBoxs();
                CambiarLaFilaSeleccionada(posicion, grillaPacientes);
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
        private void IngresoDeDatosPaciente(out int id, out string nombre, out string apellido, out string direccion, out string telefono)
        {
            nombre = txtNombre.Text;
            apellido = txtApellido.Text;
            direccion = txtDireccion.Text;
            telefono = txtTelefono.Text;
            if (!int.TryParse(txtId.Text, out id)) throw new Exception("El campo código debe ser numérico!");
            if (nombre.Length == 0) throw new Exception("El campo nombre está vacío!");
            if (apellido.Length == 0) throw new Exception("El campo apellido está vacío!");
            if (direccion.Length == 0) throw new Exception("El campo dirección está vacío!");
            if (telefono.Length == 0) throw new Exception("El campo teléfono está vacío!");
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
            txtId.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
        }
        private void grillaPacientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = grillaPacientes.Rows[e.RowIndex];
                txtId.Text = fila.Cells[0].Value.ToString();
                txtNombre.Text = fila.Cells[1].Value.ToString();
                txtApellido.Text = fila.Cells[2].Value.ToString();
                txtDireccion.Text = fila.Cells[3].Value.ToString();
                txtTelefono.Text = fila.Cells[4].Value.ToString();
            }
        }
    }
}
