/* Controles utilizados:
 * -checkBox
 * -radioButton
 * -groupBox
 * -numericUpDown
 * -pictureBox
 */

namespace Ejemplo03
{
    public partial class frmSeleccionDeHelado : Form
    {
        public frmSeleccionDeHelado()
        {
            InitializeComponent();
        }

        private void MostrarLeyenda(object sender, EventArgs e)
        {
            string leyendaSeleccion = "Selección: ";
            string leyendaExtras = "Extras: ";
            string leyendaCantidad = "Cantidad: ";
            //decimal cantidad = 0;

            if (radTipo1.Checked) leyendaSeleccion += $" {radTipo1.Text} ";
            else leyendaSeleccion += $" {radTipo2.Text} ";

            if (radTamanio1.Checked) leyendaSeleccion += $" {radTamanio1.Text} ";
            else leyendaSeleccion += $" {radTamanio2.Text} ";

            if (chkSabor1.Checked) leyendaExtras += $" {chkSabor1.Text} ";
            if (chkSabor2.Checked) leyendaExtras += $" {chkSabor2.Text} ";
            if (chkSabor3.Checked) leyendaExtras += $" {chkSabor3.Text} ";


            //cantidad = numCantidad.Value;
            leyendaCantidad += numCantidad.Value.ToString();

            lblPedidoFinal.Text = leyendaSeleccion;
            lblExtras.Text = leyendaExtras;
            lblCantidad.Text = leyendaCantidad;
        }

        private void frmSeleccionDeHelado_Load(object sender, EventArgs e)
        {
            lblPedidoFinal.Text = "Selección: Pendiente";
            lblExtras.Text = "Extras: Pendiente";
            lblCantidad.Text = "Cantidad: Pendiente";
        }
    }
}
