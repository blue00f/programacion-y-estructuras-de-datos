namespace Ejercicio02
{
    public partial class Institucion : Form
    {
        public Institucion()
        {
            InitializeComponent();
        }
        ListaSE listaAlu;
        private void Institucion_Load(object sender, EventArgs e)
        {
            listaAlu = new ListaSE();
            dtpFechaNacimiento.MaxDate = DateTime.Now;
        }
        private void Mostrar(ListaSE pLista)
        {
            grillaAlumnos.Rows.Clear();
            Alumno aux = pLista.RetornaPrimero();
            while (aux != null)
            {
                grillaAlumnos.Rows.Add(aux.Nombre, aux.Apellido, aux.DNI, aux.FechaNacimiento.ToShortDateString(), aux.Direccion, aux.Telefono);
                aux = aux.Siguiente;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre, apellido, dni, direccion, telefono;
                DateTime fechaNacimiento;
                IngresoDeDatos(out nombre, out apellido, out dni, out fechaNacimiento, out direccion, out telefono);

                Alumno alumno = new Alumno(nombre, apellido, dni, fechaNacimiento, direccion, telefono);
                listaAlu.AgregarAlPrincipio(alumno);
                Mostrar(listaAlu);
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
                string nombre, apellido, dni, direccion, telefono;
                DateTime fechaNacimiento;
                IngresoDeDatos(out nombre, out apellido, out dni, out fechaNacimiento, out direccion, out telefono);

                if (grillaAlumnos.CurrentRow == null) throw new Exception("No hay un registro seleccionado!");
                int posicionSeleccionada = grillaAlumnos.CurrentRow.Index;

                Alumno alumno = new Alumno(nombre, apellido, dni, fechaNacimiento, direccion, telefono);

                // Se suma 2 para agregar el nodo abajo de la fila seleccionada en la grilla
                listaAlu.AgregarPosicionN(alumno, posicionSeleccionada + 2);
                Mostrar(listaAlu);
                LimpiarTextBoxs();
                CambiarLaFilaSeleccionada(posicionSeleccionada, grillaAlumnos);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAgregarArribaDelSeleccionado_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre, apellido, dni, direccion, telefono;
                DateTime fechaNacimiento;
                IngresoDeDatos(out nombre, out apellido, out dni, out fechaNacimiento, out direccion, out telefono);

                if (grillaAlumnos.CurrentRow == null) throw new Exception("No hay un registro seleccionado!");
                int posicionSeleccionada = grillaAlumnos.CurrentRow.Index;

                Alumno alumno = new Alumno(nombre, apellido, dni, fechaNacimiento, direccion, telefono);

                // Se suma 1 para agregar el nodo arriba de la fila seleccionada en la grilla
                listaAlu.AgregarPosicionN(alumno, posicionSeleccionada + 1);
                Mostrar(listaAlu);
                LimpiarTextBoxs();
                CambiarLaFilaSeleccionada(posicionSeleccionada, grillaAlumnos);
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
                if (grillaAlumnos.CurrentRow == null) throw new Exception("No hay un registro seleccionado!");
                int posicionSeleccionada = grillaAlumnos.CurrentRow.Index;
                listaAlu.BorrarPosicionN(posicionSeleccionada + 1);
                Mostrar(listaAlu);
                CambiarLaFilaSeleccionada(posicionSeleccionada, grillaAlumnos);
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
                string nombre, apellido, dni, direccion, telefono;
                DateTime fechaNacimiento;
                IngresoDeDatos(out nombre, out apellido, out dni, out fechaNacimiento, out direccion, out telefono);

                if (grillaAlumnos.CurrentRow == null) throw new Exception("No hay un registro seleccionado!");
                int posicionSeleccionada = grillaAlumnos.CurrentRow.Index;

                Alumno alumno = new Alumno(nombre, apellido, dni, fechaNacimiento, direccion, telefono);
                listaAlu.ModificarPosicionN(alumno, posicionSeleccionada + 1);
                Mostrar(listaAlu);
                LimpiarTextBoxs();
                CambiarLaFilaSeleccionada(posicionSeleccionada, grillaAlumnos);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void grillaAlumnos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaSeleccionada = grillaAlumnos.Rows[e.RowIndex];
                txtNombre.Text = filaSeleccionada.Cells[0].Value?.ToString() ?? "";
                txtApellido.Text = filaSeleccionada.Cells[1].Value?.ToString() ?? "";
                txtDni.Text = filaSeleccionada.Cells[2].Value?.ToString() ?? "";
                txtDireccion.Text = filaSeleccionada.Cells[4].Value?.ToString() ?? "";
                txtTelefono.Text = filaSeleccionada.Cells[5].Value?.ToString() ?? "";
            }
        }
        private void IngresoDeDatos(out string nombre, out string apellido, out string dni, out DateTime fechaNacimiento, out string direccion, out string telefono)
        {
            nombre = txtNombre.Text;
            apellido = txtApellido.Text;
            dni = txtDni.Text;
            fechaNacimiento = dtpFechaNacimiento.Value.Date;
            direccion = txtDireccion.Text;
            telefono = txtTelefono.Text;
            if (nombre.Length == 0) throw new Exception("El campo nombre está vacio");
            if (apellido.Length == 0) throw new Exception("El campo apellido está vacio");
            if (dni.Length == 0) throw new Exception("El campo DNI está vacio");
            if (fechaNacimiento > DateTime.Now) throw new Exception("La fecha de nacimiento es inválida");
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
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDni.Text = "";
            dtpFechaNacimiento.Value = DateTime.Now.Date;
            txtDireccion.Text = "";
            txtTelefono.Text = "";
        }
    }
}
