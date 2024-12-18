namespace Ejemplo05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Leyenda(object sender, EventArgs e)
        {
            string s = "Selección: ";
            if (radioButton1.Checked) { s+=$"{radioButton1.Text} "; }
            else s+=$"{radioButton2.Text} ";
            if (radioButton3.Checked) { s+= $"{radioButton3.Text} "; }
            else s+=$"{radioButton4.Text} ";
            s+=$"  -->  ";
            if (checkBox1.Checked) s+=$"{checkBox1.Text} ";
            if (checkBox2.Checked) s+=$"{checkBox2.Text} ";
            if (checkBox3.Checked) s+=$"{checkBox3.Text}";
            
            label1.Text = s;
        }

       
    }
}
