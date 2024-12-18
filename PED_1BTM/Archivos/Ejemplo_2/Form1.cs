using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Si no se expecifica ruta busca el archivo en el lugar donde se encuantrra el ejecutable
            // if (!File.Exists($@"..\..\Archivos\Datos.txt"))
            // if (!File.Exists($"..\\..\\Archivos\\Datos.txt"))
            if (!File.Exists($"Datos.txt"))
            {
                var x = File.Create("Datos.txt");
                x.Close();
                MessageBox.Show("El archivo Datos.txt ya se ha creado !!!");

            }
            else { MessageBox.Show("El archivo Datos.txt ya existe !!!"); }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (File.Exists("Datos.txt"))
            {
                File.Delete("Datos.txt");
                MessageBox.Show("Se borró el archivo Datos.txt !!!");
            }
            else { MessageBox.Show("El archivo Datos.txt no existe !!!"); }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
