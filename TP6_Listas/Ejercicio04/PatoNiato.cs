namespace Ejercicio04
{
    public partial class PatoNiato : Form
    {
        public PatoNiato()
        {
            InitializeComponent();
        }
        ListaCS listaJugadores;

        private void PatoNiato_Load(object sender, EventArgs e)
        {
            listaJugadores = new ListaCS();
        }

        private void Mostrar(ListaCS lista)
        {
            grillaJugadores.Rows.Clear();
            Jugador aux = lista.RetornaPrimero();

            if(aux != null)
            {
                // guardamos la referencia del primer nodo y la usamos para saber cuando es que recorrimos toda la lista
                Jugador primerNodo = aux;

                do
                {
                    grillaJugadores.Rows.Add(aux.Nombre, aux.Apellido, aux.Edad, aux.Dni);
                    aux = aux.Siguiente;
                }
                while (aux != primerNodo);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre, apellido, dni;
                int edad;
                IngresoDeDatosJugador(out nombre, out apellido, out edad, out dni);

                Jugador jugador = new Jugador(nombre, apellido, edad, dni);
                listaJugadores.AgregarAlFinal(jugador);
                Mostrar(listaJugadores);
                LimpiarTextboxs();
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
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                int edad;
                string dni = txtDni.Text;

                if (nombre.Length == 0) throw new Exception("El campo nombre no puede estar vacío!");
                if (apellido.Length == 0) throw new Exception("El campo apellido no puede estar vacío!");
                if (txtEdad.Text.Length == 0) throw new Exception("El campo edad no puede estar vacío!");
                if (dni.Length == 0) throw new Exception("El campo DNI no puede estar vacío!");
                if (!int.TryParse(txtEdad.Text, out edad)) throw new Exception("El campo edad debe ser numérico!");

                if (grillaJugadores.CurrentRow == null) throw new Exception("No hay un registro seleccionado!");
                int posicionSeleccionada = grillaJugadores.CurrentRow.Index;

                Jugador jugador = new Jugador(nombre, apellido, edad, dni);
                listaJugadores.AgregarPosicionN(jugador, posicionSeleccionada + 2);
                Mostrar(listaJugadores);
                LimpiarTextboxs();
                CambiarLaFilaSeleccionada(posicionSeleccionada, grillaJugadores);
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
                if (grillaJugadores.CurrentRow == null) throw new Exception("No hay un registro seleccionado!");
                int posicionSeleccionada = grillaJugadores.CurrentRow.Index;
                listaJugadores.BorrarPosicionN(posicionSeleccionada + 1);
                Mostrar(listaJugadores);
                LimpiarTextboxs();
                CambiarLaFilaSeleccionada(posicionSeleccionada, grillaJugadores);
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
                int edad;
                string dni = txtDni.Text;

                if (nombre.Length == 0) throw new Exception("El campo nombre no puede estar vacío!");
                if (apellido.Length == 0) throw new Exception("El campo apellido no puede estar vacío!");
                if (txtEdad.Text.Length == 0) throw new Exception("El campo edad no puede estar vacío!");
                if (dni.Length == 0) throw new Exception("El campo DNI no puede estar vacío!");
                if (!int.TryParse(txtEdad.Text, out edad)) throw new Exception("El campo edad debe ser numérico!");

                if (grillaJugadores.CurrentRow == null) throw new Exception("No hay un registro seleccionado!");
                int posicionSeleccionada = grillaJugadores.CurrentRow.Index;

                Jugador jugador = new Jugador(nombre, apellido, edad, dni);
                listaJugadores.ModificarPosicionN(jugador, posicionSeleccionada + 1);
                Mostrar(listaJugadores);
                LimpiarTextboxs();
                CambiarLaFilaSeleccionada(posicionSeleccionada, grillaJugadores);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void grillaJugadores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0){
                DataGridViewRow filaSeleccionada = grillaJugadores.Rows[e.RowIndex];
                txtNombre.Text = filaSeleccionada.Cells[0].Value.ToString();
                txtApellido.Text = filaSeleccionada.Cells[1].Value.ToString();
                txtEdad.Text = filaSeleccionada.Cells[2].Value.ToString();
                txtDni.Text = filaSeleccionada.Cells[3].Value.ToString();
            }
        }
        private void IngresoDeDatosJugador(out string nombre, out string apellido, out int edad, out string dni)
        {
            nombre = txtNombre.Text;
            apellido = txtApellido.Text;
            dni = txtDni.Text;
            if (nombre.Length == 0) throw new Exception("El campo nombre no puede estar vacío!");
            if (apellido.Length == 0) throw new Exception("El campo apellido no puede estar vacío!");
            if (txtEdad.Text.Length == 0) throw new Exception("El campo edad no puede estar vacío!");
            if (dni.Length == 0) throw new Exception("El campo DNI no puede estar vacío!");
            if (!int.TryParse(txtEdad.Text, out edad)) throw new Exception("El campo edad debe ser numérico!");
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
        private void LimpiarTextboxs()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtEdad.Text = "";
            txtDni.Text = "";
        }
    }
}
