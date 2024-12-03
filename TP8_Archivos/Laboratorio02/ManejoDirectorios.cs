namespace Laboratorio02
{
    public partial class ManejoDirectorios : Form
    {
        public ManejoDirectorios()
        {
            InitializeComponent();
        }

        private void ManejoDirectorios_Load(object sender, EventArgs e)
        {
            string[] Unidades = Directory.GetLogicalDrives();
            int i;
            for (i = 0; i < Unidades.Length; i++)
            {
                lstUnidades.Items.Add(Unidades[i]);
            }
        }

        private void btnContenido_Click(object sender, EventArgs e)
        {
            lstContenido.Items.Clear();
            DateTime creacion;
            int i;
            string ruta = txtRuta.Text;

            if (Directory.Exists(ruta))
            {
                var carpetas = Directory.GetDirectories(ruta);
                creacion = Directory.GetCreationTime(ruta);
                var archivos = Directory.GetFiles(ruta);

                for (i = 0; i < carpetas.Length; i++)
                {
                    lstContenido.Items.Add($"Carpeta: {Path.GetFileName(carpetas[i])}");
                }

                // Imprimo los archivos
                for (i = 0; i < archivos.Length; i++)
                {
                    lstContenido.Items.Add($"Archivo: {Path.GetFileName(archivos[i])}");
                }
            }
        }
        private void btnSeleccionarCarpeta_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtRuta.Text = folderBrowserDialog1.SelectedPath;
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
