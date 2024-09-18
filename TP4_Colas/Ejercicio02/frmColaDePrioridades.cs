namespace Ejercicio02;
public partial class frmColaDePrioridades : Form
{
    public frmColaDePrioridades()
    {
        InitializeComponent();
    }
    private Cola cola = new Cola();

    private void ActualizarListBox()
    {
        lstCola.Items.Clear();
        Cliente? actual = cola.ObtenerPrimerNodo(); // Comienza desde el primer nodo de la cola (justo después del centinela)

        // Recorre todos los nodos de la cola
        while (actual != null)
        {
            lstCola.Items.Add($"{actual.Nombre} - Prioridad: {actual.Prioridad}");
            actual = actual.Siguiente;
        }
    }

    private void btnEncolar_Click(object sender, EventArgs e)
    {
        string nombre = txtNombre.Text;
        int prioridad;
        try
        {
            if (string.IsNullOrWhiteSpace(nombre)) throw new Exception("El nombre no puede estar vacío");
            if (!(int.TryParse(txtPrioridad.Text, out prioridad))) throw new Exception("La prioridad debe ser un valor numérico");
            if (prioridad < 1 || prioridad > 3) throw new Exception("Prioridad inválida, debe ser entre 1 y 3");

            cola.Encolar(nombre, prioridad);
            lstCola.Items.Clear(); 
            ActualizarListBox(); // Llama al método para actualizar y mostrar los elementos en la cola
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }

    }

    private void btnDesencolar_Click(object sender, EventArgs e)
    {
        Cliente? nodo = cola.Desencolar();
        if (nodo != null)
        {
            lstCola.Items.Clear(); 
            ActualizarListBox();
        }
        else
        {
            MessageBox.Show("La cola está vacía.");
        }
    }
}
