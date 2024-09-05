/* Controles utilizados:
 * -colorDialog
 * -fontDialog
 * -richTextBox
 * -menuStrip
 */

namespace Ejemplo01
{
    public partial class frmBlocDeNotas : Form
    {
        public frmBlocDeNotas()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void adelanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void atrásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void cortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void seleccionarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void borrarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void estiloDeFuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK) richTextBox1.Font = fontDialog1.Font;
        }

        private void colorDeFuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK) richTextBox1.ForeColor = colorDialog1.Color;
        }

        private void colorDeFondoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog()== DialogResult.OK) richTextBox1.BackColor = colorDialog1.Color;
        }

    }
}
