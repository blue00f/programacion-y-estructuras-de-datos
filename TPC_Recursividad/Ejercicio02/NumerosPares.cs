using Microsoft.VisualBasic;
using System.CodeDom;

namespace Ejercicio02
{
    public partial class frmMostrarPares : Form
    {
        public frmMostrarPares()
        {
            InitializeComponent();
        }

        private List<int> devolverPares(int numero)
        {
            List<int> pares = new List<int>();
            if (numero == 0)
            {
                pares.Add(0);
            }
            else
            {
                pares = devolverPares(numero-1);
                if(numero % 2 == 0) pares.Add(numero);
            }
            return pares;
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = Convert.ToInt16(Interaction.InputBox("Ingrese un número", "Ingrese un número para mostrar todos los números pares"));
                if (numero < 0) throw new Exception("No se permiten números negativos");

                string cadenaPares;
                List<int> pares = devolverPares(numero);

                cadenaPares = string.Join(", ", pares);
                txtResultado.Text = cadenaPares;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
