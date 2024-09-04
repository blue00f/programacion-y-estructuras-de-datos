namespace Ejercicio11
{
    public partial class frmTateti : Form
    {
        public frmTateti()
        {
            InitializeComponent();
        }
        // True -> X
        // False -> O
        bool banderaTurno;
        int banderaEmpate;
        private void Escribir(Button btn)
        {
            // Se verifica si alguien ya jugó en un determinado botón
            if(btn.Text.Length == 0)
            {
                // Se verifica de quién es el turno
                if (banderaTurno)
                {
                    btn.Text = "X";
                    btn.BackColor = Color.CadetBlue;
                    ComprobarGanador();
                    banderaTurno = false;
                }
                else if (!banderaTurno)
                {
                    btn.Text = "O";
                    btn.BackColor = Color.Aquamarine;
                    ComprobarGanador();
                    banderaTurno = true;
                }
            }
        }

        private void ComprobarGanador()
        {
            if(btn1.Text == btn2.Text && btn1.Text == btn3.Text && btn1.Text != "")
            {
                MessageBox.Show($"Ganaste", "Mensaje del juego", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Reset();
            }
            if (btn4.Text == btn5.Text && btn4.Text == btn6.Text && btn4.Text != "")
            {
                MessageBox.Show($"Ganaste", "Mensaje del juego", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reset();
            }
            if (btn7.Text == btn8.Text && btn7.Text == btn9.Text && btn7.Text != "")
            {
                MessageBox.Show($"Ganaste", "Mensaje del juego", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reset();
            }


            if (btn1.Text == btn4.Text && btn1.Text == btn7.Text && btn1.Text != "")
            {
                MessageBox.Show($"Ganaste", "Mensaje del juego", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reset();
            }
            if (btn2.Text == btn5.Text && btn2.Text == btn8.Text && btn2.Text != "")
            {
                MessageBox.Show($"Ganaste", "Mensaje del juego", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reset();
            }
            if (btn3.Text == btn6.Text && btn3.Text == btn9.Text && btn3.Text != "")
            {
                MessageBox.Show($"Ganaste", "Mensaje del juego", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reset();
            }


            if (btn1.Text == btn5.Text && btn1.Text == btn9.Text && btn1.Text != "")
            {
                MessageBox.Show($"Ganaste", "Mensaje del juego", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reset();
            }
            if (btn3.Text == btn5.Text && btn3.Text == btn7.Text && btn3.Text != "")
            {
                MessageBox.Show($"Ganaste", "Mensaje del juego", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reset();
            }

            banderaEmpate++;
            if(banderaEmpate == 9)
            {
                MessageBox.Show("Empataste", "Mensaje del juego", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reset();
            }
        }

        private void Reset()
        {
            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";
            btn1.BackColor = Color.Orange;
            btn2.BackColor = Color.Orange;
            btn3.BackColor = Color.Orange;
            btn4.BackColor = Color.Orange;
            btn5.BackColor = Color.Orange;
            btn6.BackColor = Color.Orange;
            btn7.BackColor = Color.Orange;
            btn8.BackColor = Color.Orange;
            btn9.BackColor = Color.Orange;

            banderaEmpate = 0;
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            Escribir(btn1);
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            Escribir(btn2);
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            Escribir(btn3);
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            Escribir(btn4);
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            Escribir(btn5);
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            Escribir(btn6);
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            Escribir(btn7);
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            Escribir(btn8);
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            Escribir(btn9);
        }
    }
}
