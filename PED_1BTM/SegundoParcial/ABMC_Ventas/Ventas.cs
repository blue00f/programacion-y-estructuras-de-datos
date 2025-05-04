using System.Text.RegularExpressions;

namespace ABMC_Ventas
{
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
        }

        List<Vendedor> lista;

        private void Ventas_Load(object sender, EventArgs e)
        {
            lista = new List<Vendedor>();
            grillaVendedores.MultiSelect = false;
            grillaVendedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Mostrar();
        }

        private void Mostrar()
        {
            try
            {
                if (File.Exists(@"..\..\..\ventas.txt"))
                {
                    using (var sr = new StreamReader(@"..\..\..\ventas.txt"))
                    {
                        string s;
                        lista.Clear();
                        while ((s = sr.ReadLine()) != null)
                        {
                            var d = s.Split(',');
                            lista.Add(new Vendedor(d[0], Convert.ToDecimal(d[1])));
                        }
                    }
                    grillaVendedores.DataSource = null;
                    grillaVendedores.DataSource = lista;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string codigo = txtCodigo.Text;
                decimal venta;
                string formatoCodigo = @"^[A-Z][0-9]{3}$";

                if (!Regex.IsMatch(codigo, formatoCodigo)) throw new Exception("El formato del código no es válido!");
                if (!decimal.TryParse(txtVenta.Text, out venta)) throw new Exception("El valor de la venta no es numérica!");
                if (lista.Find(x => x.Codigo == codigo) != null) throw new Exception("El código está repetido!");

                using (var sw = new StreamWriter(@"..\..\..\ventas.txt", true))
                {
                    sw.WriteLine($"{codigo},{venta}");
                }
                Mostrar();
                LimpiarTextboxs();
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
                if (grillaVendedores.Rows.Count == 0) throw new Exception("No hay registros para borrar!");
                var codigo = grillaVendedores.SelectedRows[0].Cells[0].Value.ToString();
                var vendedor = lista.Find(x => x.Codigo == codigo);

                if (vendedor != null)
                {
                    lista.Remove(vendedor);
                }

                File.Delete(@"..\..\..\ventas.txt");
                using (var sw = new StreamWriter(@"..\..\..\ventas.txt", true))
                {
                    lista.ForEach(x => sw.WriteLine($"{x.Codigo},{x.Venta}"));
                }
                Mostrar();
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
                if (grillaVendedores.Rows.Count == 0) throw new Exception("No hay registros para modificar!");
                var codigo = grillaVendedores.SelectedRows[0].Cells[0].Value.ToString();
                var vendedor = lista.Find(x => x.Codigo == codigo);

                if (vendedor != null)
                {
                    decimal venta;
                    if (!decimal.TryParse(txtVenta.Text, out venta)) throw new Exception("El valor de la venta no es numérica!");
                    vendedor.Venta = venta;
                }
                File.Delete(@"..\..\..\ventas.txt");
                using (var sw = new StreamWriter(@"..\..\..\ventas.txt", true))
                {
                    lista.ForEach(x => sw.WriteLine($"{x.Codigo},{x.Venta}"));
                }
                Mostrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grillaVendedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = grillaVendedores.Rows[e.RowIndex];
                txtCodigo.Text = fila.Cells[0].Value.ToString();
                txtVenta.Text = fila.Cells[1].Value.ToString();
            }
        }

        private void LimpiarTextboxs()
        {
            txtCodigo.Text = "";
            txtVenta.Text = "";
            txtCodigo.Focus();
        }

        private void radOrdenarAsc_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radOrdenarDesc_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
