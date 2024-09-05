/* Controles utilizados:
 * -button
 * -comboBox
 * -dataGridView
 * -dateTimePicker
 */

namespace AltaAlumnos
{
    public partial class frmAltaAlumnos : Form
    {
        int idAutoincremental = 0; // Este campo ya puede validar para que no haya IDs repetidos
        int cantidadAlumnos = 50;
        string[] nombres;
        string[] apellidos;
        DateTime[] fechasNacimiento;
        string[] especialidades;
        int[] anios;
        int[] divisiones;
        bool[] estados;
        public frmAltaAlumnos()
        {
            InitializeComponent();
            nombres = new string[cantidadAlumnos];
            apellidos = new string[cantidadAlumnos];
            fechasNacimiento = new DateTime[cantidadAlumnos];
            especialidades = new string[cantidadAlumnos];
            anios = new int[cantidadAlumnos];
            divisiones = new int[cantidadAlumnos];
            estados = new bool[cantidadAlumnos];
        }

        private void AgregarAlumno(string pNombre, string pApellido, DateTime pFechaNacimiento, string pEspecialidad, int pAnio, int pDivision)
        {
            grillaAlumnos.Rows.Add(idAutoincremental, pNombre, pApellido, pFechaNacimiento, pEspecialidad, pAnio, pDivision, true);
            idAutoincremental++; 
        }

        private void LimpiarInput()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            cbxEspecialidad.SelectedIndex = -1; // El index -1 permite que no haya una seleccion en el comboBox
            cbxAnio.SelectedIndex = -1;
            cbxDivision.SelectedIndex = -1;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que el nombre no esté vacio
                if (txtNombre.Text.Length == 0) throw new Exception("El nombre está vacio");
                string nombre = txtNombre.Text;
                nombres[idAutoincremental] = nombre;

                // Validar que el apellido no esté vacio
                if (txtApellido.Text.Length == 0) throw new Exception("El apellido está vacio");
                string apellido = txtApellido.Text;
                apellidos[idAutoincremental] = apellido;

                // Guardar fecha de nacimiento del alumno
                DateTime fechaNacimiento = dateFechaNacimiento.Value.Date;
                fechasNacimiento[idAutoincremental] = fechaNacimiento;

                // Validar especialidad
                if (cbxEspecialidad.Text.Length == 0) throw new Exception("El campo especialidad está vacio");
                string especialidad = cbxEspecialidad.Text;
                especialidades[idAutoincremental] = especialidad;

                // Validar anio
                if (cbxAnio.Text.Length == 0) throw new Exception("El campo año está vacio");
                int anio = int.Parse(cbxAnio.Text);
                anios[idAutoincremental] = anio;

                // Validar division
                if (cbxDivision.Text.Length == 0) throw new Exception("El campo división está vacio");
                int division = int.Parse(cbxDivision.Text);
                divisiones[idAutoincremental] = division;

                // Guardar estado por default en true
                estados[idAutoincremental] = true;
                AgregarAlumno(nombre, apellido, fechaNacimiento, especialidad, anio, division);
                LimpiarInput();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "ERROR AL INGRESAR ALUMNO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
