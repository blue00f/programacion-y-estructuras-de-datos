using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CC_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            bool _Agrega1 = false;
            decimal _TotalGeneral = 0;
            decimal _SubTotalVendedor = 0;
            decimal _SubTotalProducto = 0;

            if (File.Exists("Ventas.txt"))
            {
                Ordena();
                // Se genera un StreamReader para leer el archivo.
                using (StreamReader sr = new StreamReader("Ventas.txt"))
                {
                    string _S = sr.ReadLine();
                    string[] _D = _S.Split(',');
                    while (_S != null)
                    {
                        string _Vendedor = _D[0];
                        dataGridView1.Rows.Add(new string[] { _D[0] });
                        while (_Vendedor == _D[0] && _S != null)
                        {
                            string _Producto = _D[1];
                            dataGridView1.Rows.Add(new string[] { "", _D[1] });
                            while (_Producto == _D[1] && _Vendedor == _D[0] && _S != null)
                            {
                                _SubTotalVendedor += decimal.Parse(_D[2]);
                                _SubTotalProducto+= decimal.Parse(_D[2]);
                                _TotalGeneral += decimal.Parse(_D[2]);


                                if (_Agrega1)
                                    dataGridView1.Rows.Add(new string[] { "", "", _D[2] });
                                else
                                {
                                    dataGridView1.Rows[dataGridView1.Rows.GetLastRow(DataGridViewElementStates.None)].Cells[2].Value = _D[2];
                                    _Agrega1 = true;
                                }

                                _S = sr.ReadLine();
                                if (_S != null) { _D = _S.Split(new char[] { ',' }); }
                            }
                            //Mostrar sub total del producto
                            dataGridView1.Rows.Add(new string[] { "", "", "Sub Tot =>", _SubTotalProducto.ToString() });
                            dataGridView1.Rows[dataGridView1.Rows.GetLastRow(DataGridViewElementStates.None)].DefaultCellStyle.BackColor = Color.Aqua;
                            dataGridView1.Rows.Add(1);

                            _SubTotalProducto = 0;
                            _Agrega1 = false;
                        }
                        //Mostrar sub total del vendedor
                        dataGridView1.Rows.Add(new string[] { "", "", "", "Sub Tot =>", _SubTotalVendedor.ToString() });
                        dataGridView1.Rows[dataGridView1.Rows.GetLastRow(DataGridViewElementStates.None)].DefaultCellStyle.BackColor = Color.Aquamarine;
                        dataGridView1.Rows.Add(1);

                        _SubTotalVendedor = 0;
                        _Agrega1 = false;
                    }
                    //Mostrar el total general
                    dataGridView1.Rows.Add(1);
                    dataGridView1.Rows.Add(new string[] { "", "", "", "", "Total Gral =>", _TotalGeneral.ToString() });
                    dataGridView1.Rows[dataGridView1.Rows.GetLastRow(DataGridViewElementStates.None)].DefaultCellStyle.BackColor = Color.Coral;

                    _TotalGeneral = 0;
                }
            }
        }
        private void Ordena()
        {
            // Se genera un StreamReader para leer el archivo.
            string contenido;
            using (StreamReader sr = new StreamReader("Ventas.txt"))
            {
                // Leo todo el archivo
                contenido = sr.ReadToEnd();
            }
            // Genero un array de los registros leidos
            var registros = contenido.Split(new string[] { "\r\n" }, StringSplitOptions.None);
            // Creo una lista de venta
            List<Venta> ventas = new List<Venta>();
            Array.Resize(ref registros, registros.Length-1);
            // Cargo la lista
            foreach (string s in registros)
            {
                ventas.Add(new Venta(s));
            }
            // obtengo la lista ordenada
            ventas.Sort(new Venta.VendedorASC());
            // Grabo el archivo ordenado
            using (StreamWriter sw = new StreamWriter("Ventas.txt"))
            {
                ventas.ForEach(x => sw.WriteLine($"{x.Vendedor},{x.Producto},{x.Importe}"));
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            foreach (var c in dataGridView1.Columns)
            {
                if ((c as DataGridViewColumn).Index > 0)
                {
                    (c as DataGridViewColumn).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
            }
            dataGridView1.Columns[0].ToolTipText = "Columna de Vendedores !!!";
        }
    }
    public class Venta
    {
        public Venta(string pDatos)
        {
            var datos = pDatos.Split(',');
            Vendedor=datos[0];
            Producto=datos[1];
            Importe=Convert.ToDecimal(datos[2]);
        }
        public string Vendedor { get; set; }
        public string Producto { get; set; }
        public decimal Importe { get; set; }
        public class VendedorASC : IComparer<Venta>
        {
            public int Compare(Venta x, Venta y)
            {
                var rdo = 0;
                rdo = x.Vendedor.CompareTo(y.Vendedor);
                if (rdo==0) { rdo=x.Producto.CompareTo(y.Producto); }
                return rdo;
            }

        }
    }
}
