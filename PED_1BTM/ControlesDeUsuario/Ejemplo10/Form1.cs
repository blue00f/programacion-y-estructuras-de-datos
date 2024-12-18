using Microsoft.VisualBasic;

namespace Ejemplo10
{
    public partial class Form1 : Form
    {
        Alumno[] alumnos = { };
        public Form1()
        {
            InitializeComponent();
        }

        #region"Funciones de Servicio"
              #region"Validaciones"
        private bool ExisteLegajo(int pLegajo)
        {
            return Array.Exists<Alumno>(alumnos, x => x.Legajo==pLegajo);
        }
        private void ValidaExistenciaDeFilasEnGrilla1(string pLeyenda)
        {
            if (dataGridView1.Rows.Count==0) throw new Exception($"No hay nada para {pLeyenda} !!!");
        }
        #endregion
              #region"Ingreso"
        private static void IngresaNombreApellido(out string nombre, out string apellido, string pT1, string pT2, string pR1, string pR2)
        {
            nombre =Interaction.InputBox("Nombre: ", pT1, pR1);
            apellido =Interaction.InputBox("Apellido: ", pT2, pR2);
        }

        private static bool IngresaActivo()
        {
            return MessageBox.Show("El alumno que ingresa está activo", "¿Activo?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)==DialogResult.Yes ? true : false;
        }

        private static string IngresaFecha(string pTitulo, string pRta)
        {
            var fIng = Interaction.InputBox("Fecha de Ingreso: ", pTitulo, pRta);
            if (!Information.IsDate(fIng)) throw new Exception("La fecha no es válida !!!");
            return fIng;
        }
        #endregion
        private int TomarLegajoDeLaFilaSeleccionadaEnGrilla1()
        {
            return (int)dataGridView1.SelectedRows[0].Cells[0].Value;
        }

        private void Mostrar()
        {
            dataGridView1.Rows.Clear();
            foreach (var x in alumnos)
            {
                dataGridView1.Rows.Add(new object[] { x.Legajo, x.Nombre, x.Apellido, x.Fecha_de_Ingreso.ToShortDateString(), x.Activo });
            }
        }

        #endregion
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.MultiSelect=false;
            dataGridView1.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string legajo = Interaction.InputBox("Legajo: ");
                // Verificamos si el legajo es numérico
                if (!Information.IsNumeric(legajo)) throw new Exception("El legajo debe ser numérico !!!");
                // Verificamos si el legajo es mayor a cero
                if (Convert.ToInt32(legajo)<1) throw new Exception("El legajo debe ser mayor a cero !!!");
                // Verificamos que el legajo no esté repetido
                if (ExisteLegajo(Convert.ToInt32(legajo))) throw new Exception("El legajo ya existe !!!");
                string nombre, apellido;
                IngresaNombreApellido(out nombre, out apellido,"Agregando nombre...","Agregando apellido...","","");
                string fIng = IngresaFecha("Ingresando Fecha...", "");
                bool activo = IngresaActivo();
                Alumno a = new Alumno() { Legajo= Convert.ToInt32(legajo), Nombre=nombre, Apellido=apellido, Fecha_de_Ingreso=Convert.ToDateTime(fIng), Activo=activo };
                Array.Resize(ref alumnos, alumnos.Length+1);
                alumnos[alumnos.Length-1]=a;
                Mostrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {


            try
            {
                ValidaExistenciaDeFilasEnGrilla1("Borrar");
                int legajo = TomarLegajoDeLaFilaSeleccionadaEnGrilla1();
                Alumno[] aux = { };
                Array.ForEach<Alumno>(alumnos,
                     x =>
                     {
                         if (x.Legajo!=legajo)
                         {
                             Array.Resize(ref aux, aux.Length+1);
                             aux[aux.Length-1]=x;
                         }
                     });
                Array.Clear(alumnos);
                Array.Resize(ref alumnos, aux.Length);
                Array.Copy(aux, alumnos, aux.Length);
                Mostrar();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                ValidaExistenciaDeFilasEnGrilla1("Modificar");
                int legajo = TomarLegajoDeLaFilaSeleccionadaEnGrilla1();
                Alumno a = Array.Find<Alumno>(alumnos, x => x.Legajo==legajo);
                string nombre, apellido;
                IngresaNombreApellido(out nombre, out apellido, "Modificandoando nombre...", "Modificando apellido...", a.Nombre, a.Apellido);
                string fIng = IngresaFecha("Modificando Fecha...", a.Fecha_de_Ingreso.ToShortDateString());
                bool activo = IngresaActivo();
                a.Nombre=nombre;
                a.Apellido=apellido;
                a.Fecha_de_Ingreso=Convert.ToDateTime(fIng);
                a.Activo=activo;

                Mostrar();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
