using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Ejemplo_3
{
    public partial class Form1 : Form
    {
        List<Alumno> l;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            var x = Convert.ToDateTime("10/10/2024") < Convert.ToDateTime("1/11/2024");


            l= new List<Alumno>();
            dataGridView1.SelectionMode= DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect=false;
            listBox1.SelectedIndex=0;
            Mostrar();
        }
        private void Mostrar()
        {

            try
            {
                if (File.Exists(@"..\..\Datos.txt"))
                {
                    using (var sr = new StreamReader(@"..\..\Datos.txt"))
                    {
                        string s;
                        l.Clear();
                        while ((s=sr.ReadLine()) !=null)
                        {
                            var d = s.Split(',');
                            l.Add(new Alumno(d[0], d[1], d[2]));
                        }
                        dataGridView1.DataSource=null; dataGridView1.DataSource=l;
                    }

                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }
        private void Mostrar(List<Alumno> pL)
        {
            dataGridView1.DataSource=null; dataGridView1.DataSource=pL;


        }
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                var legajo = Interaction.InputBox("Legajo: ");
                var nombre = Interaction.InputBox("Nombre: ");
                var apellido = Interaction.InputBox("Apellido: ");
                using (var sw = new StreamWriter(@"..\..\Datos.txt", true))
                {
                    sw.WriteLine($"{legajo},{nombre},{apellido}");
                }
                listBox1_SelectedIndexChanged(null,null);
                Mostrar();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                if (dataGridView1.Rows.Count==0) throw new Exception("No hay nada para borrar !!!");
                // var legajo = (dataGridView1.SelectedRows[0].DataBoundItem as Alumno).Legajo;
                var legajo = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                var alumno = l.Find(x => x.Legajo==legajo);
                if (alumno!=null) { l.Remove(alumno); }
                File.Delete(@"..\..\Datos.txt");
                using (var sw = new StreamWriter(@"..\..\Datos.txt", true))
                {
                    l.ForEach(x => sw.WriteLine($"{x.Legajo},{x.Nombre},{x.Apellido}"));
                }
                Mostrar();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count==0) throw new Exception("No hay nada para modificar !!!");
                // var legajo = (dataGridView1.SelectedRows[0].DataBoundItem as Alumno).Legajo;
                var legajo = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                var alumno = l.Find(x => x.Legajo==legajo);
                if (alumno!=null)
                {
                    alumno.Nombre=Interaction.InputBox("Nombre: ", "Modificando Nombre ...", alumno.Nombre);
                    alumno.Apellido=Interaction.InputBox("Apellido: ", "Modificando Apllido ...", alumno.Apellido);
                }
                File.Delete(@"..\..\Datos.txt");
                using (var sw = new StreamWriter(@"..\..\Datos.txt", true))
                {
                    l.ForEach(x => sw.WriteLine($"{x.Legajo},{x.Nombre},{x.Apellido}"));
                }
                Mostrar();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void Ordena1()
        {

            try
            {
                if (radioButton1.Checked)
                {
                    if (File.Exists(@"..\..\Datos.txt"))
                    {
                        //Para que se repita mientras hay registros que ordenar
                        while (true)
                        {
                            //Aborta el while cuando no hay más registros
                            using (var srx = new StreamReader(@"..\..\Datos.txt"))
                            { if (srx.ReadToEnd()=="") break; }

                            int legajoAux = 100000;
                            string registroAux = "";

                            using (var sr = new StreamReader(@"..\..\Datos.txt"))
                            {

                                string s;
                                //Ubicamos el legajo más chico
                                while ((s=sr.ReadLine()) !=null)
                                {
                                    var d = s.Split(',');
                                    if (Convert.ToInt16(d[0])<legajoAux)
                                    {
                                        legajoAux=Convert.ToInt16(d[0]);
                                        registroAux=s;
                                    }
                                }

                                // Grabamos el legajo mas chico en el auxiliar
                                using (var sw = new StreamWriter(@"..\..\DatosAux.txt", true))
                                {
                                    sw.WriteLine(registroAux);
                                }
                            }
                            // Borramos del maestro el registro que ya ordenamos
                            using (var sr = new StreamReader(@"..\..\Datos.txt"))
                            {
                                string s;

                                var fs = File.Create(@"..\..\DatosAuxBorrar.txt"); fs.Close();
                                while ((s=sr.ReadLine()) !=null)
                                {
                                    var d = s.Split(',');
                                    if (Convert.ToInt16(d[0])!=legajoAux)
                                    {
                                        using (var sw = new StreamWriter(@"..\..\DatosAuxBorrar.txt", true))
                                        {
                                            sw.WriteLine(s);
                                        }
                                    }
                                }
                            }
                            File.Delete(@"..\..\Datos.txt");
                            File.Copy(@"..\..\DatosAuxBorrar.txt", @"..\..\Datos.txt");
                            File.Delete(@"..\..\DatosAuxBorrar.txt");


                        }
                        File.Delete(@"..\..\Datos.txt");
                        File.Copy(@"..\..\DatosAux.txt", @"..\..\Datos.txt");
                        File.Delete(@"..\..\DatosAux.txt");
                        Mostrar();
                    }
                }
                else
                {
                    if (File.Exists(@"..\..\Datos.txt"))
                    {
                        //Para que se repita mientras hay registros que ordenar
                        while (true)
                        {
                            //Aborta el while cuando no hay más registros
                            using (var srx = new StreamReader(@"..\..\Datos.txt"))
                            { if (srx.ReadToEnd()=="") break; }

                            int legajoAux = 0;
                            string registroAux = "";

                            using (var sr = new StreamReader(@"..\..\Datos.txt"))
                            {

                                string s;
                                //Ubicamos el legajo más chico
                                while ((s=sr.ReadLine()) !=null)
                                {
                                    var d = s.Split(',');
                                    if (Convert.ToInt16(d[0])>legajoAux)
                                    {
                                        legajoAux=Convert.ToInt16(d[0]);
                                        registroAux=s;
                                    }
                                }

                                // Grabamos el legajo mas chico en el auxiliar
                                using (var sw = new StreamWriter(@"..\..\DatosAux.txt", true))
                                {
                                    sw.WriteLine(registroAux);
                                }
                            }
                            // Borramos del maestro el registro que ya ordenamos
                            using (var sr = new StreamReader(@"..\..\Datos.txt"))
                            {
                                string s;

                                var fs = File.Create(@"..\..\DatosAuxBorrar.txt"); fs.Close();
                                while ((s=sr.ReadLine()) !=null)
                                {
                                    var d = s.Split(',');
                                    if (Convert.ToInt16(d[0])!=legajoAux)
                                    {
                                        using (var sw = new StreamWriter(@"..\..\DatosAuxBorrar.txt", true))
                                        {
                                            sw.WriteLine(s);
                                        }
                                    }
                                }
                            }
                            File.Delete(@"..\..\Datos.txt");
                            File.Copy(@"..\..\DatosAuxBorrar.txt", @"..\..\Datos.txt");
                            File.Delete(@"..\..\DatosAuxBorrar.txt");


                        }
                        File.Delete(@"..\..\Datos.txt");
                        File.Copy(@"..\..\DatosAux.txt", @"..\..\Datos.txt");
                        File.Delete(@"..\..\DatosAux.txt");
                        Mostrar();
                    }

                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void Ordena2()
        {
            if (radioButton4.Checked)
            {
                l.Sort(new Alumno.LegajoASC());
                Mostrar(l);
            }
            else
            {
                l.Sort(new Alumno.LegajoDESC());
                Mostrar(l);
            }

        }
        private void Ordena3()
        {
            try
            {
                if (radioButton6.Checked)
                {
                    if (File.Exists(@"..\..\Datos.txt"))
                    {
                        //Para que se repita mientras hay registros que ordenar
                        while (true)
                        {
                            //Aborta el while cuando no hay más registros
                            using (var srx = new StreamReader(@"..\..\Datos.txt"))
                            { if (srx.ReadToEnd()=="") break; }

                            string nombreAux = "zzzzzzzz";
                            int legajoAux = 0;
                            string apellidoAux = "zzzzzzzz";
                            string registroAux = "";

                            using (var sr = new StreamReader(@"..\..\Datos.txt"))
                            {

                                string s;
                                //Ubicamos el legajo más chico
                                while ((s=sr.ReadLine()) !=null)
                                {
                                    var d = s.Split(',');
                                    if (d[1].CompareTo(nombreAux)<0)
                                    {
                                        legajoAux=Convert.ToInt16(d[0]);
                                        apellidoAux= d[2];
                                        nombreAux =d[1];
                                        registroAux=s;
                                    }
                                    else if (d[1].CompareTo(nombreAux)==0)
                                    {
                                        if (d[2].CompareTo(apellidoAux)<0)
                                        {
                                            legajoAux=Convert.ToInt16(d[0]);
                                            apellidoAux= d[2];
                                            nombreAux =d[1];
                                            registroAux=s;

                                        }

                                    }
                                }

                                // Grabamos el legajo mas chico en el auxiliar
                                using (var sw = new StreamWriter(@"..\..\DatosAux.txt", true))
                                {
                                    sw.WriteLine(registroAux);
                                }
                            }
                            // Borramos del maestro el registro que ya ordenamos
                            using (var sr = new StreamReader(@"..\..\Datos.txt"))
                            {
                                string s;

                                var fs = File.Create(@"..\..\DatosAuxBorrar.txt"); fs.Close();
                                while ((s=sr.ReadLine()) !=null)
                                {
                                    var d = s.Split(',');
                                    if (d[1]!=nombreAux || Convert.ToInt16(d[0])!=legajoAux)
                                    {
                                        using (var sw = new StreamWriter(@"..\..\DatosAuxBorrar.txt", true))
                                        {
                                            sw.WriteLine(s);
                                        }
                                    }
                                }
                            }
                            File.Delete(@"..\..\Datos.txt");
                            File.Copy(@"..\..\DatosAuxBorrar.txt", @"..\..\Datos.txt");
                            File.Delete(@"..\..\DatosAuxBorrar.txt");


                        }
                        File.Delete(@"..\..\Datos.txt");
                        File.Copy(@"..\..\DatosAux.txt", @"..\..\Datos.txt");
                        File.Delete(@"..\..\DatosAux.txt");
                        Mostrar();
                    }
                }
                else
                {
                    if (File.Exists(@"..\..\Datos.txt"))
                    {
                        //Para que se repita mientras hay registros que ordenar
                        while (true)
                        {
                            //Aborta el while cuando no hay más registros
                            using (var srx = new StreamReader(@"..\..\Datos.txt"))
                            { if (srx.ReadToEnd()=="") break; }

                            string nombreAux = "";
                            int legajoAux = 0;
                            string apellidoAux = "";
                            string registroAux = "";

                            using (var sr = new StreamReader(@"..\..\Datos.txt"))
                            {

                                string s;
                                //Ubicamos el legajo más chico
                                while ((s=sr.ReadLine()) !=null)
                                {
                                    var d = s.Split(',');
                                    if (d[1].CompareTo(nombreAux)>0)
                                    {
                                        legajoAux=Convert.ToInt16(d[0]);
                                        apellidoAux= d[2];
                                        nombreAux=d[1];
                                        registroAux=s;
                                    }
                                    else if (d[1].CompareTo(nombreAux)==0)
                                    {
                                        if (d[2].CompareTo(apellidoAux)>0)
                                        {
                                            legajoAux=Convert.ToInt16(d[0]);
                                            apellidoAux= d[2];
                                            nombreAux =d[1];
                                            registroAux=s;

                                        }

                                    }
                                }

                                // Grabamos el legajo mas chico en el auxiliar
                                using (var sw = new StreamWriter(@"..\..\DatosAux.txt", true))
                                {
                                    sw.WriteLine(registroAux);
                                }
                            }
                            // Borramos del maestro el registro que ya ordenamos
                            using (var sr = new StreamReader(@"..\..\Datos.txt"))
                            {
                                string s;

                                var fs = File.Create(@"..\..\DatosAuxBorrar.txt"); fs.Close();
                                while ((s=sr.ReadLine()) !=null)
                                {
                                    var d = s.Split(',');
                                    if (d[1]!=nombreAux || Convert.ToInt16(d[0])!=legajoAux)
                                    {
                                        using (var sw = new StreamWriter(@"..\..\DatosAuxBorrar.txt", true))
                                        {
                                            sw.WriteLine(s);
                                        }
                                    }
                                }
                            }
                            File.Delete(@"..\..\Datos.txt");
                            File.Copy(@"..\..\DatosAuxBorrar.txt", @"..\..\Datos.txt");
                            File.Delete(@"..\..\DatosAuxBorrar.txt");
                        }
                        File.Delete(@"..\..\Datos.txt");
                        File.Copy(@"..\..\DatosAux.txt", @"..\..\Datos.txt");
                        File.Delete(@"..\..\DatosAux.txt");
                        Mostrar();
                    }

                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }
        private void Ordena4()
        {
            if (radioButton8.Checked)
            {
                l.Sort(new Alumno.ApellidoASC());
                Mostrar(l);
            }
            else
            {
                l.Sort(new Alumno.ApellidoDESC());
                Mostrar(l);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Ordena1();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Ordena1();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Ordena2();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Ordena2();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex==0)
            {
                label1.Location=new Point(30, 306);
                groupBox2.Location=new Point(30, 369);
                label1.Visible=true; groupBox2.Visible=true;
                label2.Visible=false; groupBox1.Visible=false;
                label3.Visible=false; groupBox3.Visible=false;
                label4.Visible=false; groupBox4.Visible=false;
                Ordena1();

            }
            else if (listBox1.SelectedIndex==1)
            {
                label2.Location=new Point(30, 306);
                groupBox1.Location=new Point(30, 369);
                label2.Visible=true; groupBox1.Visible=true;
                label1.Visible=false; groupBox2.Visible=false;
                label3.Visible=false; groupBox3.Visible=false;
                label4.Visible=false; groupBox4.Visible=false;
                Ordena2();
            }
            else if (listBox1.SelectedIndex==2)
            {
                label3.Location=new Point(30, 306);
                groupBox3.Location=new Point(30, 369);
                label2.Visible=false; groupBox1.Visible=false;
                label1.Visible=false; groupBox2.Visible=false;
                label3.Visible=true; groupBox3.Visible=true;
                label4.Visible=false; groupBox4.Visible=false;
                Ordena3();
            }
            else
            {
                label4.Location=new Point(30, 306);
                groupBox4.Location=new Point(30, 369);
                label2.Visible=false; groupBox1.Visible=false;
                label1.Visible=false; groupBox2.Visible=false;
                label3.Visible=false; groupBox3.Visible=false;
                label4.Visible=true; groupBox4.Visible=true;
                Ordena4();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            Ordena3();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            Ordena3();
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            Ordena4();
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            Ordena4();
        }
    }
    public class Alumno
    {
        public Alumno(string pLegajo, string pNombre, string pApellido)
        {
            Legajo=pLegajo;
            Nombre=pNombre;
            Apellido=pApellido;
        }

        public string Legajo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public class LegajoASC : IComparer<Alumno>
        {
            public int Compare(Alumno x, Alumno y)
            {
                int rta = 0;
                if (Convert.ToInt16(x.Legajo) < Convert.ToInt16(y.Legajo)) rta=-1;
                if (Convert.ToInt16(x.Legajo) > Convert.ToInt16(y.Legajo)) rta=1;
                return rta;
            }

        }
        public class LegajoDESC : IComparer<Alumno>
        {
            public int Compare(Alumno x, Alumno y)
            {

                return new Alumno.LegajoASC().Compare(x, y) * -1;
            }


        }
        public class ApellidoASC : IComparer<Alumno>
        {
            public int Compare(Alumno x, Alumno y)
            {
                int rdo = x.Apellido.CompareTo(y.Apellido);
                if (rdo==0)
                { 
                    rdo = x.Nombre.CompareTo(y.Nombre);

                }
                return rdo;
            }

        }
        public class ApellidoDESC : IComparer<Alumno>
        {
            public int Compare(Alumno x, Alumno y)
            {

                return new Alumno.ApellidoASC().Compare(x, y) * -1;

            }


        }
    }
}
