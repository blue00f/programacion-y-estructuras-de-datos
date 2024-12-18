using System.Text.RegularExpressions;

namespace ArchivosABM1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Vendedor> lista;

        private void Form1_Load(object sender, EventArgs e)
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
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string legajo = txtLegajo.Text;
                decimal venta;
                string patronLegajo = @"^[A-Z][0-9]{3}$";
                if (!Regex.IsMatch(legajo, patronLegajo)) throw new Exception("El legajo no cumple con el formato");
                if (!decimal.TryParse(txtVenta.Text, out venta)) throw new Exception("La venta no es numérica");
                if (lista.Find(x => x.Legajo == legajo) != null) throw new Exception("El legajo está repetido");

                using (var sw = new StreamWriter(@"..\..\..\ventas.txt", true))
                {
                    sw.WriteLine($"{legajo},{venta}");
                }
                Mostrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (grillaVendedores.Rows.Count == 0) throw new Exception("No hay registros para borrar");
                var legajo = grillaVendedores.SelectedRows[0].Cells[0].Value.ToString();
                var alumno = lista.Find(x => x.Legajo == legajo);

                if (alumno != null) lista.Remove(alumno);
                File.Delete(@"..\..\..\ventas.txt");

                using (var sw = new StreamWriter(@"..\..\..\ventas.txt", true))
                {
                    lista.ForEach(x => sw.WriteLine($"{x.Legajo},{x.Venta}"));
                }
                Mostrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (grillaVendedores.Rows.Count == 0) throw new Exception("no hay filas");
                var legajo = grillaVendedores.SelectedRows[0].Cells[0].Value.ToString();
                var vendedor = lista.Find(x => x.Legajo == legajo);
                if (vendedor != null)
                {
                    decimal venta;
                    if (!decimal.TryParse(txtVenta.Text, out venta)) throw new Exception("La venta no es numérica");
                    vendedor.Venta = venta;
                }
                File.Delete(@"..\..\..\ventas.txt");

                using (var sw = new StreamWriter(@"..\..\..\ventas.txt", true))
                {
                    lista.ForEach(x => sw.WriteLine($"{x.Legajo},{x.Venta}"));
                }
                Mostrar();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void grillaVendedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = grillaVendedores.Rows[e.RowIndex];
                txtLegajo.Text = fila.Cells[0].Value.ToString();
                txtVenta.Text = fila.Cells[1].Value.ToString();
            }
        }
    }
}
