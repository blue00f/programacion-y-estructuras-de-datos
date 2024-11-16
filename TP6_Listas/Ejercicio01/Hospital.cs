namespace Ejercicio01
{
    public partial class Hospital : Form
    {
        public Hospital()
        {
            InitializeComponent();
            
        }
        ListaSE listaPac;
        private void Hospital_Load(object sender, EventArgs e)
        {
            listaPac = new ListaSE();
        }
        private void Mostrar(ListaSE pLista)
        {
            grillaPacientes.Rows.Clear();
            Paciente aux = pLista.RetornaPrimero();
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
                string nombre, apellido, direccion, telefono;
                int id;
                IngresoDeDatos(out nombre, out apellido, out direccion, out telefono, out id);

                Paciente paciente = new Paciente(id, nombre, apellido, direccion, telefono);
                listaPac.AgregarAlPrincipio(paciente);
                Mostrar(listaPac);
                LimpiarTextBoxs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregarAbajoDelSeleccionado_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre, apellido, direccion, telefono;
                int id;
                IngresoDeDatos(out nombre, out apellido, out direccion, out telefono, out id);

                if (grillaPacientes.CurrentRow == null) throw new Exception("No hay un registro seleccionado!");
                int posicionSeleccionada = grillaPacientes.CurrentRow.Index;

                Paciente paciente = new Paciente(id, nombre, apellido, direccion, telefono);

                // Se suma 2 para agregar el nodo despues del seleccionado
                listaPac.AgregarPosicionN(paciente, posicionSeleccionada + 2);
                Mostrar(listaPac);
                LimpiarTextBoxs();
                CambiarLaFilaSeleccionada(posicionSeleccionada, grillaPacientes);
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
                if (grillaPacientes.CurrentRow == null) throw new Exception("No hay un registro seleccionado!");
                int posicionSeleccionada = grillaPacientes.CurrentRow.Index;
                listaPac.BorrarPosicionN(posicionSeleccionada + 1);
                Mostrar(listaPac);
                LimpiarTextBoxs();
                CambiarLaFilaSeleccionada(posicionSeleccionada, grillaPacientes);
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
                string nombre, apellido, direccion, telefono;
                int id;
                IngresoDeDatos(out nombre, out apellido, out direccion, out telefono, out id);

                if (grillaPacientes.CurrentRow == null) throw new Exception("No hay un registro seleccionado!");
                int posicionSeleccionada = grillaPacientes.CurrentRow.Index;

                Paciente paciente = new Paciente(id, nombre, apellido, direccion, telefono);
                listaPac.ModificarPosicionN(paciente, posicionSeleccionada + 1);
                Mostrar(listaPac);
                LimpiarTextBoxs();
                CambiarLaFilaSeleccionada(posicionSeleccionada, grillaPacientes);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void grillaPacientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaSeleccionada = grillaPacientes.Rows[e.RowIndex];
                txtId.Text = filaSeleccionada.Cells[0].Value?.ToString() ?? "";
                txtNombre.Text = filaSeleccionada.Cells[1].Value?.ToString() ?? "";
                txtApellido.Text = filaSeleccionada.Cells[2].Value?.ToString() ?? "";
                txtDireccion.Text = filaSeleccionada.Cells[3].Value?.ToString() ?? "";
                txtTelefono.Text = filaSeleccionada.Cells[4].Value?.ToString() ?? "";
            }
        }
        private void IngresoDeDatos(out string nombre, out string apellido, out string direccion, out string telefono, out int id)
        {
            nombre = txtNombre.Text;
            apellido = txtApellido.Text;
            direccion = txtDireccion.Text;
            telefono = txtTelefono.Text;
            if (txtId.Text.Length == 0) throw new Exception("El campo código está vacio");
            if (!int.TryParse(txtId.Text, out id)) throw new Exception("El campo código debe ser numérico");
            if (nombre.Length == 0) throw new Exception("El campo nombre está vacio");
            if (apellido.Length == 0) throw new Exception("El campo apellido está vacio");
            if (direccion.Length == 0) throw new Exception("El campo dirección está vacio");
            if (telefono.Length == 0) throw new Exception("El campo teléfono está vacio");
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
    }
}
