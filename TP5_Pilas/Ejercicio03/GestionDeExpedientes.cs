namespace Ejercicio03
{
    public partial class frmGestionDeExpedientes : Form
    {
        public frmGestionDeExpedientes()
        {
            InitializeComponent();
        }
        Pila expedientes, expedientesAuxiliar;

        private void frmGestionDeExpedientes_Load(object sender, EventArgs e)
        {
            expedientes = new Pila();
            expedientesAuxiliar = new Pila();
        }

        private void Mostrar(DataGridView pGridExpedientes, Pila pPilaOriginal, Pila pPilaAuxiliar)
        {
            pGridExpedientes.Rows.Clear();
            MostrarEnListBox(pGridExpedientes, pPilaOriginal, pPilaAuxiliar);
            RestaurarPilaOriginal(pPilaOriginal, pPilaAuxiliar);
        }
        private void MostrarEnListBox(DataGridView pGridExpedientes, Pila pPilaOriginal, Pila pPilaAuxiliar)
        {
            Expediente aux = pPilaOriginal.Desapilar();
            if (aux != null)
            {
                //pGridExpedientes.Items.Add($"Fecha: {aux.Fecha.ToShortDateString()} - Expediente: {aux.Id} - Car�tula: {aux.Caratula}");
                pGridExpedientes.Rows.Add(aux.Fecha.ToShortDateString(), aux.Id, aux.Caratula);
                pPilaAuxiliar.Apilar(aux.Fecha, aux.Id, aux.Caratula);
                MostrarEnListBox(pGridExpedientes, pPilaOriginal, pPilaAuxiliar);
            }

        }
        private void RestaurarPilaOriginal(Pila pPilaOriginal, Pila pPilaAuxiliar)
        {
            Expediente aux = pPilaAuxiliar.Desapilar();
            if (aux != null)
            {
                pPilaOriginal.Apilar(aux.Fecha, aux.Id, aux.Caratula);
                RestaurarPilaOriginal(pPilaOriginal, pPilaAuxiliar);
            }
        }
        private void btnCargarExpediente_Click(object sender, EventArgs e)
        {
            try
            {
                int numExpediente;
                if (txtNumExpediente.Text.Length == 0) throw new Exception("El n�mero de expediente est� vac�o!");
                if (!int.TryParse(txtNumExpediente.Text, out numExpediente)) throw new Exception("El n�mero de expediente debe ser un n�mero!");
                ;

                if (txtCaratula.Text.Length == 0) throw new Exception("La car�tula est� vac�a!");
                string caratula = txtCaratula.Text;

                expedientes.ApilarOrdenado(dateTimePicker1.Value, numExpediente.ToString(), caratula);
                Mostrar(gridExpedientes, expedientes, expedientesAuxiliar);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
