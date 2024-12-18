namespace CorteDeControl2
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
                            var d = s.Split(",");
                            lista.Add(new Vendedor(d[0], d[1], int.Parse(d[2])));
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
                string nombre = txtNombre.Text;
                string producto = txtProducto.Text;
                int factura;

                if (nombre.Length == 0) throw new Exception("El nombre no puede estar vacio");
                if (producto.Length == 0) throw new Exception("El producto no puede estar vacio");
                if (!int.TryParse(txtFactura.Text, out factura)) throw new Exception("La factura debe ser numérica");

                using (var sw = new StreamWriter(@"..\..\..\ventas.txt", true))
                {
                    sw.WriteLine($"{nombre},{producto},{factura}");
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
                if (grillaVendedores.Rows.Count == 0) throw new Exception("No hay vendedores para eliminar!");
                string nombreVendedor = grillaVendedores.SelectedRows[0].Cells[0].Value.ToString();
                var vendedor = lista.Find(x => x.Nombre == nombreVendedor);

                if (vendedor != null) lista.Remove(vendedor);

                File.Delete(@"..\..\..\ventas.txt");

                using (var sw = new StreamWriter(@"..\..\..\ventas.txt", true))
                {
                    lista.ForEach(x => sw.WriteLine($"{x.Nombre},{x.Producto},{x.Factura}"));
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
                if (grillaVendedores.Rows.Count == 0) throw new Exception("No hay vendedores para modificar!");
                string nombreVendedor = grillaVendedores.SelectedRows[0].Cells[0].Value.ToString();
                var vendedor = lista.Find(x => x.Nombre == nombreVendedor);

                if (vendedor != null)
                {
                    string nombreNuevo = txtNombre.Text;
                    string productoNuevo = txtProducto.Text;
                    int facturaNueva;

                    if (nombreNuevo.Length == 0) throw new Exception("El nombre no puede estar vacio");
                    if (productoNuevo.Length == 0) throw new Exception("El producto no puede estar vacio");
                    if (!int.TryParse(txtFactura.Text, out facturaNueva)) throw new Exception("La factura debe ser numérica");

                    vendedor.Nombre = nombreNuevo;
                    vendedor.Producto = productoNuevo;
                    vendedor.Factura = facturaNueva;
                }

                File.Delete(@"..\..\..\ventas.txt");

                using (var sw = new StreamWriter(@"..\..\..\ventas.txt", true))
                {
                    lista.ForEach(x => sw.WriteLine($"{x.Nombre},{x.Producto},{x.Factura}"));
                }
                Mostrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void grillaVendedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = grillaVendedores.Rows[e.RowIndex];
                txtNombre.Text = fila.Cells[0].Value.ToString();
                txtProducto.Text = fila.Cells[1].Value.ToString();
                txtFactura.Text = fila.Cells[2].Value.ToString();
            }
        }

        private void PasarDeListaAArchivo(List<Vendedor> listaActualizada)
        {
            using (var sw = new StreamWriter(@"..\..\..\ventas.txt"))
            {
                listaActualizada.ForEach(x => sw.WriteLine($"{x.Nombre},{x.Producto},{x.Factura}"));
            }
            Mostrar();
        }


        private void OrdenaPorNombreYProducto()
        {
            if (radAsc.Checked)
            {
                lista.Sort(new Vendedor.NombreProductoASC());
                PasarDeListaAArchivo(lista);
            }
            else
            {
                lista.Sort(new Vendedor.NombreProductoDESC());
                PasarDeListaAArchivo(lista);
            }
        }

        private void radAsc_CheckedChanged(object sender, EventArgs e)
        {
            OrdenaPorNombreYProducto();
        }

        private void radDesc_CheckedChanged(object sender, EventArgs e)
        {
            OrdenaPorNombreYProducto();
        }

        private void btnCorteDeControl_Click(object sender, EventArgs e)
        {
            grillaValores.Rows.Clear();
            bool agrega = false;
            int subtotalProducto = 0;
            int subtotalVendedor = 0;
            int total = 0;

            if (File.Exists(@"..\..\..\ventas.txt"))
            {
                using (var sr = new StreamReader(@"..\..\..\ventas.txt"))
                {
                    string s = sr.ReadLine();
                    var d = s.Split(",");
                    while(s != null)
                    {
                        string vendedor = d[0];
                        grillaValores.Rows.Add(d[0]);
                        while(vendedor == d[0] && s != null)
                        {
                            string producto = d[1];
                            grillaValores.Rows.Add("", d[1]);
                            while(producto == d[1] && vendedor == d[0] && s != null)
                            {
                                subtotalProducto += int.Parse(d[2]);
                                subtotalVendedor += int.Parse(d[2]);
                                total += int.Parse(d[2]);

                                if (agrega)
                                {
                                    grillaValores.Rows.Add("", "", d[2]);
                                }
                                else
                                {
                                    grillaValores.Rows[grillaValores.Rows.GetLastRow(DataGridViewElementStates.None)].Cells[2].Value = d[2];
                                    agrega = true;
                                }

                                s = sr.ReadLine();
                                if(s != null)
                                {
                                    d = s.Split(",");
                                }
                            }
                            grillaValores.Rows.Add("", "", "Subtot =>", subtotalProducto);
                            subtotalProducto = 0;
                            agrega = false;
                        }
                        grillaValores.Rows.Add("", "", "", "Subtot =>", subtotalVendedor);
                        subtotalVendedor = 0;
                        agrega = false;
                    }
                    grillaValores.Rows.Add("", "", "", "", "Total =>", total);
                    total = 0;
                }
            }
        }
    }
}
