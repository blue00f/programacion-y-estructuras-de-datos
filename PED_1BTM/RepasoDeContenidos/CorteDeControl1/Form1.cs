using System.CodeDom;
using System.Runtime.CompilerServices;

namespace CorteDeControl1
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

        #region ABM_Vendedores
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
                            lista.Add(new Vendedor(d[0], int.Parse(d[1])));
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
                if (nombre.Length == 0) throw new Exception("El nombre no puede estar vacio");
                if (!int.TryParse(txtFactura.Text, out int factura)) throw new Exception("La factura debe ser numérica");

                using (var sw = new StreamWriter(@"..\..\..\ventas.txt", true))
                {
                    sw.WriteLine($"{nombre},{factura}");
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
                if (grillaVendedores.Rows.Count == 0) throw new Exception("No hay vendedores para eliminar");
                var nombreVendedor = grillaVendedores.SelectedRows[0].Cells[0].Value.ToString();
                var vendedor = lista.Find(x => x.Nombre == nombreVendedor);

                if (vendedor != null) lista.Remove(vendedor);

                File.Delete(@"..\..\..\ventas.txt");

                using (var sw = new StreamWriter(@"..\..\..\ventas.txt", true))
                {
                    lista.ForEach(x => sw.WriteLine($"{x.Nombre},{x.Factura}"));
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
                if (grillaVendedores.Rows.Count == 0) throw new Exception("No hay vendedores para modificar");
                var nombreVendedor = grillaVendedores.SelectedRows[0].Cells[0].Value.ToString();
                var vendedor = lista.Find(x => x.Nombre == nombreVendedor);

                if (vendedor != null)
                {
                    string nombreNuevo = txtNombre.Text;
                    int facturaNueva;

                    if (nombreNuevo.Length == 0) throw new Exception("El nombre esta vacío");
                    if (!int.TryParse(txtFactura.Text, out facturaNueva)) throw new Exception("La factura debe ser numérica");
                    vendedor.Nombre = nombreNuevo;
                    vendedor.Factura = facturaNueva;
                }

                File.Delete(@"..\..\..\ventas.txt");

                using (var sw = new StreamWriter(@"..\..\..\ventas.txt"))
                {
                    lista.ForEach(x => sw.WriteLine($"{x.Nombre},{x.Factura}"));
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
                txtFactura.Text = fila.Cells[1].Value.ToString();
            }
        }
        #endregion

        private void btnCorteControl_Click(object sender, EventArgs e)
        {
            grillaCalculos.Rows.Clear();
            bool agrega1 = false;
            decimal totalGeneral = 0;
            decimal subtotalVendedor = 0;

            if (File.Exists(@"..\..\..\ventas.txt"))
            {
                using (var sr = new StreamReader(@"..\..\..\ventas.txt"))
                {
                    string s = sr.ReadLine();
                    var d = s.Split(",");

                    while (s != null)
                    {
                        string vendedor = d[0];
                        grillaCalculos.Rows.Add(d[0]);

                        while (vendedor == d[0] && s != null)
                        {
                            subtotalVendedor += decimal.Parse(d[1]);
                            totalGeneral += decimal.Parse(d[1]);

                            if (agrega1)
                            {
                                grillaCalculos.Rows.Add("", d[1]);
                            }
                            else
                            {
                                grillaCalculos.Rows[grillaCalculos.Rows.GetLastRow(DataGridViewElementStates.None)].Cells[1].Value = d[1];
                                agrega1 = true;
                            }

                            s = sr.ReadLine();
                            if (s != null)
                            {
                                d = s.Split(",");
                            }
                        }
                        grillaCalculos.Rows.Add("", "Subtotal =>", subtotalVendedor.ToString());
                        grillaCalculos.Rows.Add(1);

                        subtotalVendedor = 0;
                        agrega1 = false;
                    }
                    grillaCalculos.Rows.Add("", "", "Total general =>", totalGeneral.ToString());
                    totalGeneral = 0;
                }
            }
        }

        private void PasarListaAArchivo(List<Vendedor> listaActualizada)
        {
            using (var sw = new StreamWriter(@"..\..\..\ventas.txt"))
            {
                listaActualizada.ForEach(x => sw.WriteLine($"{x.Nombre},{x.Factura}"));
            }
            Mostrar();
        }

        private void OrdenaPorNombre()
        {
            if (radAsc.Checked)
            {
                lista.Sort(new Vendedor.NombreASC());
                PasarListaAArchivo(lista);
            }
            else
            {
                lista.Sort(new Vendedor.NombreDESC());
                PasarListaAArchivo(lista);
            }
        }

        private void radAsc_CheckedChanged(object sender, EventArgs e)
        {
            OrdenaPorNombre();
        }

        private void radDesc_CheckedChanged(object sender, EventArgs e)
        {
            OrdenaPorNombre();
        }
    }
}
