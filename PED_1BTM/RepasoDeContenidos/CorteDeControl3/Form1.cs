namespace CorteDeControl3
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
                            lista.Add(new Vendedor(d[0], d[1], int.Parse(d[2]), int.Parse(d[3])));
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
                string vendedor = txtVendedor.Text;
                string producto = txtProducto.Text;
                int cantidad, factura;
                if (vendedor.Length == 0) throw new Exception("Nombre vacio");
                if (producto.Length == 0) throw new Exception("producto vacio");
                if (!int.TryParse(txtCantidad.Text, out cantidad)) throw new Exception("Cantidad invalida");
                if (!int.TryParse(txtFactura.Text, out factura)) throw new Exception("Factura invalida");

                using (var sw = new StreamWriter(@"..\..\..\ventas.txt", true))
                {
                    sw.WriteLine($"{vendedor},{producto},{cantidad},{factura}");
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
                string nombreVendedor = grillaVendedores.SelectedRows[0].Cells[0].Value.ToString();
                var vendedor = lista.Find(x => x.Nombre == nombreVendedor);
                if (vendedor != null) lista.Remove(vendedor);

                File.Delete(@"..\..\..\ventas.txt");
                using (var sw = new StreamWriter(@"..\..\..\ventas.txt", true))
                {
                    lista.ForEach(x => sw.WriteLine($"{x.Nombre},{x.Producto},{x.Cantidad},{x.Factura}"));
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
                if (grillaVendedores.Rows.Count == 0) throw new Exception("No hay registros para modificar");
                string nombreVendedor = grillaVendedores.SelectedRows[0].Cells[0].Value.ToString();
                var vendedor = lista.Find(x => x.Nombre == nombreVendedor);

                if (vendedor != null)
                {
                    string vendedorNuevo = txtVendedor.Text;
                    string productoNuevo = txtProducto.Text;
                    int cantidadNueva, facturaNueva;
                    if (vendedorNuevo.Length == 0) throw new Exception("Nombre vacio");
                    if (productoNuevo.Length == 0) throw new Exception("producto vacio");
                    if (!int.TryParse(txtCantidad.Text, out cantidadNueva)) throw new Exception("Cantidad invalida");
                    if (!int.TryParse(txtFactura.Text, out facturaNueva)) throw new Exception("Factura invalida");

                    vendedor.Nombre = vendedorNuevo;
                    vendedor.Producto = productoNuevo;
                    vendedor.Cantidad = cantidadNueva;
                    vendedor.Factura = facturaNueva;
                }
                File.Delete(@"..\..\..\ventas.txt");

                using (var sw = new StreamWriter(@"..\..\..\ventas.txt", true))
                {
                    lista.ForEach(x => sw.WriteLine($"{x.Nombre},{x.Producto},{x.Cantidad},{x.Factura}"));
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
                txtVendedor.Text = fila.Cells[0].Value.ToString();
                txtProducto.Text = fila.Cells[1].Value.ToString();
                txtCantidad.Text = fila.Cells[2].Value.ToString();
                txtFactura.Text = fila.Cells[3].Value.ToString();
            }
        }

        private void PasarDeListaAArchivo(List<Vendedor> listaActualizada)
        {
            using (var sw = new StreamWriter(@"..\..\..\ventas.txt", false))
            {
                listaActualizada.ForEach(x => sw.WriteLine($"{x.Nombre},{x.Producto},{x.Cantidad},{x.Factura}"));
            }
            Mostrar();
        }

        private void OrdenarPorVendedorYProducto()
        {
            if (radAsc.Checked)
            {
                lista.Sort(new Vendedor.VendedorProductoASC());
                PasarDeListaAArchivo(lista);
            }
            else
            {
                lista.Sort(new Vendedor.VendedorProductoDESC());
                PasarDeListaAArchivo(lista);
            }
        }
        private void radAsc_CheckedChanged(object sender, EventArgs e)
        {
            OrdenarPorVendedorYProducto();
        }

        private void radDesc_CheckedChanged(object sender, EventArgs e)
        {
            OrdenarPorVendedorYProducto();
        }

        private void btnCorte_Click(object sender, EventArgs e)
        {
            grillaTotales.Rows.Clear();
            int subtotalProducto = 0;
            int subtotalVendedor = 0;
            int total = 0;
            bool agrega = false;

            if (File.Exists(@"..\..\..\ventas.txt"))
            {
                using (var sr = new StreamReader(@"..\..\..\ventas.txt"))
                {
                    string s = sr.ReadLine();
                    var d = s.Split(",");
                    while(s != null)
                    {
                        string vendedor = d[0];
                        grillaTotales.Rows.Add(d[0]);
                        while(vendedor == d[0] && s != null)
                        {
                            string producto = d[1];
                            grillaTotales.Rows.Add("", d[1]);
                            while(producto == d[1] && vendedor == d[0] && s != null)
                            {
                                subtotalProducto += int.Parse(d[3]) * int.Parse(d[2]);
                                subtotalVendedor += int.Parse(d[3]) * int.Parse(d[2]);
                                total += int.Parse(d[3]) * int.Parse(d[2]);

                                if (agrega)
                                {
                                    grillaTotales.Rows.Add("", "", d[2], d[3]);
                                }
                                else
                                {
                                    grillaTotales.Rows[grillaTotales.Rows.GetLastRow(DataGridViewElementStates.None)].Cells[2].Value = d[2];
                                    grillaTotales.Rows[grillaTotales.Rows.GetLastRow(DataGridViewElementStates.None)].Cells[3].Value = d[3];
                                    agrega = true;
                                }

                                s = sr.ReadLine();
                                if(s != null)
                                {
                                    d = s.Split(",");
                                }
                            }
                            grillaTotales.Rows.Add("", "", "", "Subtot =>", subtotalProducto);
                            subtotalProducto = 0;
                            agrega = false;
                        }
                        grillaTotales.Rows.Add("", "", "", "", "Subtot =>", subtotalVendedor);
                        subtotalVendedor = 0;
                        agrega = false;
                    }
                    grillaTotales.Rows.Add("", "", "", "", "", "Total =>", total);
                    total = 0;
                }
            }
        }
    }
}
