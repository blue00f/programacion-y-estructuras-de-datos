using System.IO;

namespace Laboratorio01
{
    public partial class ArchivoSecuencial : Form
    {
        string rutaArchivo = @"..\..\..\archivo.txt";
        string rutaArchivoAux = @"..\..\..\archivoAux.txt";
        public ArchivoSecuencial()
        {
            InitializeComponent();
        }
        private void ArchivoSecuencial_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void Listar()
        {
            try
            {
                if (File.Exists(rutaArchivo))
                {
                    using(var sr = new StreamReader(rutaArchivo))
                    {
                        string s;
                        lstListado.Items.Clear();
                        while((s = sr.ReadLine()) != null)
                        {
                            var d = s.Split(';');
                            lstListado.Items.Add($"{d[0]};{d[1]};{d[2]}");
                        }
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            FileStream archivo = new FileStream(rutaArchivo, FileMode.Append);
            StreamWriter EscritorArchivo = new StreamWriter(archivo);
            string reg;
            reg = $"{txtLegajo.Text};{txtNombre.Text};{txtCategoria.Text}";
            EscritorArchivo.WriteLine(reg);
            EscritorArchivo.Close();
            archivo.Close();

            txtLegajo.Text = "";
            txtNombre.Text = "";
            txtCategoria.Text = "";
            txtLegajo.Focus();
            Listar();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            FileStream archivo = new FileStream(rutaArchivo, FileMode.Open);
            FileStream archivoAux = new FileStream(rutaArchivoAux, FileMode.Create);
            StreamReader LectorArchivo = new StreamReader(archivo);
            StreamWriter EscritorArchivoAux = new StreamWriter(archivoAux);
            String[] VectorRegAux = new String[0];
            string reg;
            string legajo;
            while (LectorArchivo.Peek() > -1)
            {
                reg = LectorArchivo.ReadLine();
                VectorRegAux = reg.Split(';');
                legajo = VectorRegAux[0];
                if (legajo != txtLegajo.Text)
                {
                    EscritorArchivoAux.WriteLine(reg);
                }
            }
            // CIERRO ARCHIVOS
            LectorArchivo.Close();
            archivo.Close();
            EscritorArchivoAux.Close();
            archivoAux.Close();

            // PISO EL ARCHIVO ORIGINAL CON EL AUX
            File.Delete(rutaArchivo);
            File.Move(rutaArchivoAux, rutaArchivo);
            txtLegajo.Text = "";
            txtNombre.Text = "";
            txtCategoria.Text = "";
            txtLegajo.Focus();
            Listar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FileStream archivo = new FileStream(rutaArchivo, FileMode.Open);
            FileStream archivoAux = new FileStream(rutaArchivoAux, FileMode.Create);
            StreamReader LectorArchivo = new StreamReader(archivo);
            StreamWriter EscritorArchivoAux = new StreamWriter(archivoAux);
            String[] VectorRegAux = new string[0];
            string reg = "";
            string legajo;
            while (LectorArchivo.Peek() > -1)
            {
                reg = LectorArchivo.ReadLine();
                VectorRegAux = reg.Split(';');
                legajo = VectorRegAux[0];
                if (legajo == txtLegajo.Text)
                {
                    reg = String.Format("{0};{1};{2}", txtLegajo.Text, txtNombre.Text, txtCategoria.Text);
                }
                EscritorArchivoAux.WriteLine(reg);
            }
            LectorArchivo.Close();
            archivo.Close();
            EscritorArchivoAux.Close();
            archivoAux.Close();

            // PISO EL ARCHIVO ORIGINAL CON EL AUX
            File.Delete(rutaArchivo);
            File.Move(rutaArchivoAux, rutaArchivo);
            txtLegajo.Text = "";
            txtNombre.Text = "";
            txtCategoria.Text = "";
            txtLegajo.Focus();
            Listar();
        }
        private void lstListado_Click(object sender, EventArgs e)
        {
            if (lstListado.SelectedItem != null)
            {
                string seleccionado = lstListado.SelectedItem.ToString();
                String[] vectorLista = new String[0];
                vectorLista = seleccionado.Split(';');
                txtLegajo.Text = vectorLista[0];
                txtNombre.Text = vectorLista[1];
                txtCategoria.Text = vectorLista[2];
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
