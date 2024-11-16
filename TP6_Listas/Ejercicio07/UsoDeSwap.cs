namespace Ejercicio07
{
    public partial class UsoDeSwap : Form
    {
        public UsoDeSwap()
        {
            InitializeComponent();
        }

        ListaSE lista;

        private void Mostrar(ListaSE pLista)
        {
            grillaNumeros.Rows.Clear();
            Nodo aux = pLista.RetornaPrimero();
            while (aux != null)
            {
                grillaNumeros.Rows.Add(aux.Id, aux.Nombre);
                aux = aux.Siguiente;
            }
        }
        private void UsoDeSwap_Load(object sender, EventArgs e)
        {
            lista = new ListaSE();
            grillaNumeros.MultiSelect = true;  // Habilita la selección múltiple
            grillaNumeros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;  // Selecciona filas completas
            grillaNumeros.ClearSelection();

            // Asocia el evento para controlar la selección
            grillaNumeros.SelectionChanged += grillaNumeros_SelectionChanged;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre;
                IngresoDeDatos(out nombre);

                Nodo nodo = new Nodo(nombre);
                lista.AgregarAlPrincipio(nodo);
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
                if (grillaNumeros.CurrentRow == null) throw new Exception("No hay un registro seleccionado!");
                int posicionSeleccionada = grillaNumeros.CurrentRow.Index;
                lista.BorrarPosicionN(posicionSeleccionada + 1);
                Mostrar(lista);
                LimpiarTextBoxs();
                CambiarLaFilaSeleccionada(posicionSeleccionada, grillaNumeros);
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
                string nombre;
                IngresoDeDatos(out nombre);

                if (grillaNumeros.CurrentRow == null) throw new Exception("No hay un registro seleccionado!");
                int posicionSeleccionada = grillaNumeros.CurrentRow.Index;

                Nodo nodo = new Nodo(nombre);
                lista.ModificarPosicionN(nodo, posicionSeleccionada + 1);
                Mostrar(lista);
                LimpiarTextBoxs();
                CambiarLaFilaSeleccionada(posicionSeleccionada, grillaNumeros);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnIntercambiarDerecha_Click(object sender, EventArgs e)
        {
            if (grillaNumeros.CurrentRow == null) throw new Exception("No hay un registro seleccionado!");
            int posicionSeleccionada = grillaNumeros.CurrentRow.Index;
            lista.IntercambiarDerecha(posicionSeleccionada + 1);

            Mostrar(lista);
            LimpiarTextBoxs();
            CambiarLaFilaSeleccionada(posicionSeleccionada, grillaNumeros);
        }

        private void btnIntercambiarIzquierda_Click(object sender, EventArgs e)
        {
            if (grillaNumeros.CurrentRow == null) throw new Exception("No hay un registro seleccionado!");
            int posicionSeleccionada = grillaNumeros.CurrentRow.Index;
            lista.IntercambiarIzquierda(posicionSeleccionada + 1);

            Mostrar(lista);
            LimpiarTextBoxs();
            CambiarLaFilaSeleccionada(posicionSeleccionada, grillaNumeros);
        }
        private void btnIntercambiar_Click(object sender, EventArgs e)
        {
            try
            {
                if (grillaNumeros.SelectedRows.Count != 2) throw new Exception("Se tienen que seleccionar dos filas!");

                int fila1 = grillaNumeros.SelectedRows[0].Index; // Se guarda la posicion de la primera fila clickeada
                int fila2 = grillaNumeros.SelectedRows[1].Index; // Se guarda la posicion de la segunda fila clickeada

                // Los nodos a intercambiar estan en posiciones seguidas, por ej: se intercambia nodo3 con nodo4 (o viceversa)
                if (Math.Abs((fila1+1) - (fila2+1)) == 1)
                {
                    if (fila1 < fila2) lista.IntercambiarIzquierda(fila1 + 1);
                    else lista.IntercambiarDerecha(fila2 + 1);
                }
                else if (fila1 == 1)
                {
                    lista.Intercambiar(fila1 + 1, fila2 + 1);
                }
                else if (fila2 == 1)
                {
                    lista.Intercambiar(fila2 + 1, fila1 + 1);
                }
                else
                {
                    if (fila1 < fila2) lista.Intercambiar(fila1 + 1, fila2 + 1);
                    else if (fila2 < fila1) lista.Intercambiar(fila2 + 1, fila1 + 1);
                }

                Mostrar(lista);
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
                DataGridViewRow filaSeleccionada = grillaNumeros.Rows[e.RowIndex];
                txtNombre.Text = filaSeleccionada.Cells[1].Value.ToString();
            }
        }
        private void IngresoDeDatos(out string nombre)
        {
            nombre = txtNombre.Text;
            if (nombre.Length == 0) throw new Exception("El campo nombre está vacio");
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
        }

        private void grillaNumeros_SelectionChanged(object sender, EventArgs e)
        {
            if (grillaNumeros.SelectedRows.Count > 2)
            {
                grillaNumeros.SelectedRows[2].Selected = false;
            }
        }
    }
}
