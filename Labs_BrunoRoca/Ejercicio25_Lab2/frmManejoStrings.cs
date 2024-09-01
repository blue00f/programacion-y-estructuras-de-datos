namespace Ejercicio25_Lab2
{
    public partial class frmManejoStrings : Form
    {
        public frmManejoStrings()
        {
            InitializeComponent();
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length == 0)
            {
                MessageBox.Show("Ingrese un numero", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Asigno el valor a la variable del textBox1
                string variable = textBox1.Text;

                // Asigno al textBox2 el tamaño de la palabra asignada
                textBox2.Text = variable.Length.ToString();

                // Si en el txtDato es > 0, devuelvo el caracter en la posición indicada
                if ((txtDato.Text.Length > 0))
                {
                    int pos = Convert.ToInt32(txtDato.Text);
                    textBox3.Text = (variable[pos]).ToString();
                }

                // A la cadena le inserto 12345
                textBox4.Text = variable.Insert(3, "12345");

                // Quito los espacios en blanco al final de la cadena
                textBox5.Text = variable.TrimStart();

                if ((variable.Length < 10))
                {
                    // Le agrego 0 a la derecha si no posee 10 caracteres, hasta llegar a ellos
                    // FORMA DE HACERLO ELEGANTE
                    textBox7.Text = variable.PadRight(10, '0');
                }

                // Concateno la cadena con el textBox9
                textBox8.Text = string.Concat(txtDato.Text, variable);

                if (textBox6.Text == "ABC")
                {
                    textBox6.Text = "Si";
                }
                else
                {
                    textBox6.Text = "No";
                }
            }
           
        }
        private void btnSalir_Click( object sender, EventArgs e)
        {
            Close();
        }
    }
}
