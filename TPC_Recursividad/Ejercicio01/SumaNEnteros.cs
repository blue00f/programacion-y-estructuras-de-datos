using Microsoft.VisualBasic;
using System.CodeDom;

namespace Ejercicio01
{
    public partial class frmSumaNEnteros : Form
    {
        public frmSumaNEnteros()
        {
            InitializeComponent();
        }

        private int sumarHastaNVecesRecursiva(int numero)
        {
            int res = 0;
            if (numero == 1)
            {
                res = 1;
            }
            else
            {
                res = numero + sumarHastaNVecesRecursiva(numero - 1);
            }
            return res;
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = Convert.ToInt16(Interaction.InputBox("Ingresa un número", "Sumar hasta N veces"));
                if (numero < 0) throw new Exception("Solo se permite ingresar números enteros");
                txtResultado.Text = sumarHastaNVecesRecursiva(numero).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
