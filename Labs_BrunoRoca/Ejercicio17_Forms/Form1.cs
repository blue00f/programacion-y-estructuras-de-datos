namespace Ejercicio17_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            if((this.chk1.Checked == true) && (this.chk2.Checked == false))
            {
                lbl1.BackColor = Color.Aquamarine;
                lbl2.BackColor = Color.Beige;
                lbl3.BackColor = Color.Black;
            }

            if((this.chk1.Checked == false) && (this.chk2.Checked == true))
            {
                lbl1.BackColor = Color.Green;
                lbl2.BackColor = Color.LightPink;
                lbl3.BackColor = Color.Linen;
            }
            
            if((this.chk1.Checked == true) && (this.chk2.Checked == true))
            {
                lbl1.BackColor = Color.Blue;
                lbl2.BackColor = Color.White;
                lbl3.BackColor = Color.Blue;
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
