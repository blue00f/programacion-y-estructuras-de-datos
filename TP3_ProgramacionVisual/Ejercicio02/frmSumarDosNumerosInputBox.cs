using Microsoft.VisualBasic;

namespace Ejercicio02
{
    public partial class frmSumarDosNumerosInputBox : Form
    {
        public frmSumarDosNumerosInputBox()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            string txtNum1 = Interaction.InputBox("Ingrese el numero 1: ");
            string txtNum2 = Interaction.InputBox("Ingrese el numero 2: ");
            int num1, num2;

            if(txtNum1.Length == 0 || txtNum2.Length == 0)
            {
                MessageBox.Show("Se ingresó un campo vacio", "ERROR");
            }
            else if (!int.TryParse(txtNum1, out num1) || !int.TryParse(txtNum2, out num2))
            {
                MessageBox.Show("Se ingresó una letra", "ERROR");
            }
            else
            {
                MessageBox.Show($"La suma es: {num1+num2}", "Resultado");
            }
        }
    }
}
