namespace ArchivosABM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Herramienta> herramientas;

        private void Form1_Load(object sender, EventArgs e)
        {
            herramientas = new List<Herramienta>();
            grillaHerramientas.MultiSelect = false;
            grillaHerramientas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            foreach (var herramienta in Enum.GetValues(typeof(Herramienta.TipoHerramienta)))
            {
                cbxTipoDeHerramienta.Items.Add(herramienta);
            }
            cbxTipoDeHerramienta.SelectedIndex = 2;
            Mostrar();
        }

        private void Mostrar()
        {
            try
            {
                if (File.Exists(@"..\..\..\sucursal.txt"))
                {
                    using (var sr = new StreamReader(@"..\..\..\sucursal.txt"))
                    {
                        string linea;
                        herramientas.Clear();
                        while ((linea = sr.ReadLine()) != null)
                        {
                            var datos = linea.Split(",");
                            herramientas.Add(new Herramienta(datos[0], (Herramienta.TipoHerramienta)Enum.Parse(typeof(Herramienta.TipoHerramienta), datos[1]), int.Parse(datos[2]), int.Parse(datos[3])));
                        }
                    }
                    grillaHerramientas.DataSource = null;
                    grillaHerramientas.DataSource = herramientas;
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
                string herramienta = txtHerramienta.Text;
                Herramienta.TipoHerramienta tipoHerramienta = (Herramienta.TipoHerramienta)cbxTipoDeHerramienta.SelectedIndex;

                if (herramienta.Length == 0) throw new Exception("La herramienta no puede estar vacia");
                if (!int.TryParse(txtStock.Text, out int stock)) throw new Exception("El stock debe ser numérico");
                if (!int.TryParse(txtIdVendedor.Text, out int idVendedor)) throw new Exception("El ID del vendedor debe ser numérico");

                using (var sw = new StreamWriter(@"..\..\..\sucursal.txt", true))
                {
                    sw.WriteLine($"{herramienta},{tipoHerramienta},{stock},{idVendedor}");
                }
                Mostrar();
                LimpiarCampos();
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
                if (grillaHerramientas.Rows.Count == 0) throw new Exception("No hay herramientas para borrar");
                var idVendedor = int.Parse(grillaHerramientas.SelectedRows[0].Cells[3].Value.ToString());
                var herramienta = herramientas.Find(x => x.IdVendedor == idVendedor);

                if (herramienta != null) herramientas.Remove(herramienta);
                File.Delete(@"..\..\..\sucursal.txt");

                using (var sw = new StreamWriter(@"..\..\..\sucursal.txt", true))
                {
                    herramientas.ForEach(x => sw.WriteLine($"{x.Nombre},{x.Tipo},{x.Stock},{x.IdVendedor}"));
                }
                Mostrar();
                LimpiarCampos();
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
                if (grillaHerramientas.Rows.Count == 0) throw new Exception("No hay registros para modificar");
                var idVendedor = int.Parse(grillaHerramientas.SelectedRows[0].Cells[3].Value.ToString());
                var herramienta = herramientas.Find(x => x.IdVendedor == idVendedor);

                if(herramienta != null)
                {
                    string nombre = txtHerramienta.Text;
                    Herramienta.TipoHerramienta tipoHerramienta = (Herramienta.TipoHerramienta)cbxTipoDeHerramienta.SelectedIndex;

                    if (!int.TryParse(txtStock.Text, out int stock)) throw new Exception("El stock debe ser numérico");

                    herramienta.Nombre = nombre;
                    herramienta.Tipo = tipoHerramienta;
                    herramienta.Stock = stock;
                }

                File.Delete(@"..\..\..\sucursal.txt");

                using (var sw = new StreamWriter(@"..\..\..\sucursal.txt", true))
                {
                    herramientas.ForEach(x => sw.WriteLine($"{x.Nombre},{x.Tipo},{x.Stock},{x.IdVendedor}"));
                }
                Mostrar();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LimpiarCampos()
        {
            txtHerramienta.Clear();
            txtStock.Clear();
            txtIdVendedor.Clear();
        }

        private void grillaHerramientas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = grillaHerramientas.Rows[e.RowIndex];
                txtHerramienta.Text = fila.Cells[0].Value.ToString();
                cbxTipoDeHerramienta.Text = fila.Cells[1].Value.ToString();
                txtStock.Text = fila.Cells[2].Value.ToString();
                txtIdVendedor.Text = fila.Cells[3].Value.ToString();
            }
        }
    }
}
