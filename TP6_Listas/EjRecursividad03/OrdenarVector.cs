namespace EjRecursividad03
{
    public partial class frmOrdenarVector : Form
    {
        public frmOrdenarVector()
        {
            InitializeComponent();
        }

        private int[] OrdenarVector(int[] pNumeros)
        {
            OrdenarVectorRecursiva(pNumeros, 0);
            return pNumeros;
        }
        private int[] OrdenarVectorRecursiva(int[] pNumeros, int pIndice)
        {
            int[] numerosOrd = pNumeros;
            if (pIndice >= pNumeros.Length - 1)
            {
                numerosOrd = pNumeros;
            }
            else
            {
                int minIndice = pIndice;
                int temp;
                for (int i = pIndice + 1; i < pNumeros.Length; i++)
                {
                    if (pNumeros[i] < pNumeros[minIndice]) minIndice = i;
                }
                // Se produce el cambio de posiciones
                temp = pNumeros[pIndice];
                pNumeros[pIndice] = pNumeros[minIndice];
                pNumeros[minIndice] = temp;
                OrdenarVectorRecursiva(pNumeros, pIndice + 1);
            }
            return numerosOrd;
        }

        public void btnOrdenar_Click(object sender, EventArgs e)
        {
            int[] numeros = new int[lstVector.Items.Count];
            for(int i = 0; i< lstVector.Items.Count; i++)
            {
                numeros[i] = Convert.ToInt32(lstVector.Items[i]);
            }

            numeros = OrdenarVector(numeros);
            for(int i = 0;i< numeros.Length;i++)
            {
                lstVectorOrdenado.Items.Add(numeros[i]);
            }
        }
    }
}
