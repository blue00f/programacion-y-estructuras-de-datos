using System.CodeDom;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ejercicio01
{
    public partial class SistemaDeNotas : Form
    {
        public SistemaDeNotas()
        {
            InitializeComponent();
        }

        List<Alumno> listaAlumnos;
        List<Nota> listaNotas;

        private void SistemaDeNotas_Load(object sender, EventArgs e)
        {
            listaAlumnos = new List<Alumno>();
            listaNotas = new List<Nota>();
            grillaAlumnos.MultiSelect = false;
            grillaAlumnos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            grillaNotas.MultiSelect = false;
            grillaNotas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dtpFecha.MaxDate = DateTime.Now;

            MostrarAlumnos(listaAlumnos);
            MostrarNotas(listaNotas);
            ActualizarComboBoxDni();
        }

        #region ABMC_Alumnos
        private void MostrarAlumnos(List<Alumno> pListaAlumnos)
        {
            try
            {
                if (File.Exists(@"..\..\..\alumnos.txt"))
                {
                    using (var sr = new StreamReader(@"..\..\..\alumnos.txt"))
                    {
                        string s;
                        pListaAlumnos.Clear();
                        while ((s = sr.ReadLine()) != null)
                        {
                            var d = s.Split(';');
                            pListaAlumnos.Add(new Alumno(d[0], d[1], d[2]));
                        }
                    }
                    grillaAlumnos.DataSource = null;
                    grillaAlumnos.DataSource = pListaAlumnos;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PasarDeListaAArchivoDeAlumnos(List<Alumno> pListaAlumnos)
        {
            try
            {
                using (var sw = new StreamWriter(@"..\..\..\alumnos.txt"))
                {
                    pListaAlumnos.ForEach(x => sw.WriteLine($"{x.Dni};{x.Nombre};{x.Apellido}"));
                }
                MostrarAlumnos(pListaAlumnos);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnGuardarAlumno_Click(object sender, EventArgs e)
        {
            try
            {
                string dni = txtDni.Text;
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;

                if (dni.Length == 0) throw new Exception("El DNI no puede estar vacio!");
                if (!int.TryParse(dni, out _)) throw new Exception("El DNI debe contener solo números!");
                if (nombre.Length == 0) throw new Exception("El nombre no puede estar vacio!");
                if (apellido.Length == 0) throw new Exception("El apellido no puede estar vacio!");
                if (listaAlumnos.Find(x => x.Dni == dni) != null) throw new Exception("El DNI no puede estar repetido!");

                using (var sw = new StreamWriter(@"..\..\..\alumnos.txt", true))
                {
                    sw.WriteLine($"{dni};{nombre};{apellido}");
                }
                MostrarAlumnos(listaAlumnos);
                LimpiarCamposDelAlumno();
                ActualizarComboBoxDni();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnBorrarAlumno_Click(object sender, EventArgs e)
        {
            try
            {
                if (grillaAlumnos.Rows.Count == 0) throw new Exception("No hay alumnos para borrar!");
                var dni = grillaAlumnos.SelectedRows[0].Cells[0].Value.ToString();
                var alumno = listaAlumnos.Find(x => x.Dni == dni);

                if (alumno != null) listaAlumnos.Remove(alumno);
                File.Delete(@"..\..\..\alumnos.txt");

                using (var sw = new StreamWriter(@"..\..\..\alumnos.txt", true))
                {
                    listaAlumnos.ForEach(x => sw.WriteLine($"{x.Dni};{x.Nombre};{x.Apellido}"));
                }
                MostrarAlumnos(listaAlumnos);
                ActualizarComboBoxDni();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnModificarAlumno_Click(object sender, EventArgs e)
        {
            try
            {
                if (grillaAlumnos.Rows.Count == 0) throw new Exception("No hay alumnos para modificar!");
                var dni = grillaAlumnos.SelectedRows[0].Cells[0].Value.ToString();
                var alumno = listaAlumnos.Find(x => x.Dni == dni);

                if (alumno != null)
                {
                    string dniNuevo = txtDni.Text;
                    string nombreNuevo = txtNombre.Text;
                    string apellidoNuevo = txtApellido.Text;

                    if (dniNuevo.Length == 0) throw new Exception("El DNI no puede estar vacio!");
                    if (nombreNuevo.Length == 0) throw new Exception("El nombre no puede estar vacio!");
                    if (apellidoNuevo.Length == 0) throw new Exception("El apellido no puede estar vacio!");

                    alumno.Dni = dniNuevo;
                    alumno.Nombre = nombreNuevo;
                    alumno.Apellido = apellidoNuevo;
                }
                File.Delete(@"..\..\..\alumnos.txt");

                using (var sw = new StreamWriter(@"..\..\..\alumnos.txt", true))
                {
                    listaAlumnos.ForEach(x => sw.WriteLine($"{x.Dni};{x.Nombre};{x.Apellido}"));
                }
                MostrarAlumnos(listaAlumnos);
                LimpiarCamposDelAlumno();
                ActualizarComboBoxDni();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region ABMC_Notas
        private void MostrarNotas(List<Nota> pListaNotas)
        {
            try
            {
                if (File.Exists(@"..\..\..\notas.txt"))
                {
                    using (var sr = new StreamReader(@"..\..\..\notas.txt"))
                    {
                        string s;
                        pListaNotas.Clear();
                        while ((s = sr.ReadLine()) != null)
                        {
                            var d = s.Split(';');
                            pListaNotas.Add(new Nota(d[0], float.Parse(d[1]), DateTime.Parse(d[2])));
                        }
                    }
                    grillaNotas.DataSource = null;
                    grillaNotas.DataSource = pListaNotas;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PasarDeListaAArchivoDeNotas(List<Nota> pListaNotas)
        {
            try
            {
                using (var sw = new StreamWriter(@"..\..\..\notas.txt"))
                {
                    pListaNotas.ForEach(x => sw.WriteLine($"{x.Dni};{x.Calificacion};{x.Fecha}"));
                }
                MostrarNotas(pListaNotas);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnGuardarNota_Click(object sender, EventArgs e)
        {
            try
            {
                float nota;
                DateTime fecha = dtpFecha.Value.Date;

                if (cbxDni.Items.Count == 0) throw new Exception("El DNI no puede estar vacio!");
                if (!float.TryParse(txtNota.Text, out nota)) throw new Exception("La nota debe ser numérica!");
                if (nota < 0f || nota > 10f) throw new Exception("La nota no esta en el rango de 1 a 10!");
                string dni = cbxDni.Text;

                using (var sw = new StreamWriter(@"..\..\..\notas.txt", true))
                {
                    sw.WriteLine($"{dni};{nota};{fecha}");
                }
                MostrarNotas(listaNotas);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnBorrarNota_Click(object sender, EventArgs e)
        {
            try
            {
                if (grillaNotas.Rows.Count == 0) throw new Exception("No hay notas para borrar!");
                var dni = grillaNotas.SelectedRows[0].Cells[0].Value.ToString();
                var nota = listaNotas.Find(x => x.Dni == dni);

                if (nota != null) listaNotas.Remove(nota);
                File.Delete(@"..\..\..\notas.txt");

                using (var sw = new StreamWriter(@"..\..\..\notas.txt", true))
                {
                    listaNotas.ForEach(x => sw.WriteLine($"{x.Dni};{x.Calificacion};{x.Fecha}"));
                }
                MostrarNotas(listaNotas);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnModificarNota_Click(object sender, EventArgs e)
        {
            try
            {
                if (grillaNotas.Rows.Count == 0) throw new Exception("No hay notas para modificar!");
                var dni = grillaNotas.SelectedRows[0].Cells[0].Value.ToString();
                var nota = listaNotas.Find(x => x.Dni == dni);

                if (nota != null)
                {
                    float notaNueva = float.Parse(txtNota.Text);
                    DateTime fechaNueva = dtpFecha.Value.Date;
                    if (notaNueva < 0f || notaNueva > 10f) throw new Exception("La nota no esta en el rango de 1 a 10!");

                    nota.Calificacion = notaNueva;
                    nota.Fecha = fechaNueva;
                }
                File.Delete(@"..\..\..\notas.txt");

                using (var sw = new StreamWriter(@"..\..\..\notas.txt", true))
                {
                    listaNotas.ForEach(x => sw.WriteLine($"{x.Dni};{x.Calificacion};{x.Fecha}"));
                }
                MostrarNotas(listaNotas);
                LimpiarCamposDeLaNota();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Servicios
        private void grillaAlumnos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = grillaAlumnos.Rows[e.RowIndex];
                txtDni.Text = fila.Cells[0].Value.ToString();
                txtNombre.Text = fila.Cells[1].Value.ToString();
                txtApellido.Text = fila.Cells[2].Value.ToString();
            }
        }
        private void LimpiarCamposDelAlumno()
        {
            txtDni.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
        }
        private void LimpiarCamposDeLaNota()
        {
            txtNota.Text = "";
        }
        private void ActualizarComboBoxDni()
        {
            cbxDni.DataSource = null;
            cbxDni.DataSource = listaAlumnos;
            cbxDni.DisplayMember = "Dni";
        }
        private void grillaNotas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = grillaNotas.Rows[e.RowIndex];
                cbxDni.Text = fila.Cells[0].Value.ToString();
                txtNota.Text = fila.Cells[1].Value.ToString();
                dtpFecha.Value = DateTime.Parse(fila.Cells[2].Value.ToString());
            }
        }
        #endregion

        #region Ordenamiento_Archivos
        private void OrdenaLegajo()
        {
            if (radAsc.Checked)
            {
                listaAlumnos.Sort(new Alumno.DniASC());
                PasarDeListaAArchivoDeAlumnos(listaAlumnos);
                listaNotas.Sort(new Nota.DniASC());
                PasarDeListaAArchivoDeNotas(listaNotas);
            }
            else
            {
                listaAlumnos.Sort(new Alumno.DniDESC());
                PasarDeListaAArchivoDeAlumnos(listaAlumnos);
                listaNotas.Sort(new Nota.DniDESC());
                PasarDeListaAArchivoDeNotas(listaNotas);
            }
        }
        private void radAsc_CheckedChanged(object sender, EventArgs e)
        {
            OrdenaLegajo();
        }
        private void radDesc_CheckedChanged(object sender, EventArgs e)
        {
            OrdenaLegajo();
        }
        #endregion

        #region Corte_de_Control

        /*
        * 
        * La solución actual contempla que algunos alumnos NO tengan al menos una nota.
        * Esto se logra mostrando únicamente los alumnos que tienen registros en notas.txt.
        * 
        * En contraste, la implementación anterior asumía que todos los alumnos debían tener al menos una nota.
        * Esto provocaba inconsistencias en el campo nombre cuando no se encontraba una coincidencia,
        * mostrando "No existe".
        * 
       */
        private string BuscarAlumnoPorDni(string pDni)
        {
            string nombre = null;
            using (var sr = new StreamReader(@"..\..\..\alumnos.txt"))
            {
                string s;
                while((s = sr.ReadLine()) != null)
                {
                    var d = s.Split(';');
                    if (d[0] == pDni)
                    {
                        nombre = d[1];
                    }
                }
            }
            return nombre;
        }
        private void btnCorteDeControl_Click(object sender, EventArgs e)
        {
            grillaPromedios.Rows.Clear();
            bool _Agrega1 = false;
            int _CantidadNotas = 0;
            float _SumaNotas = 0;
            float _Promedio = 0;

            if (File.Exists(@"..\..\..\notas.txt") && File.Exists(@"..\..\..\alumnos.txt"))
            {
                using (var srn = new StreamReader(@"..\..\..\notas.txt"))
                {
                    string _SNota = srn.ReadLine();
                    string[] _DNota = _SNota?.Split(';');

                    while (_SNota != null)
                    {
                        // Obtenemos el DNI de notas.txt
                        string _Alumno = _DNota[0];
                        string _NombreAlumno = BuscarAlumnoPorDni(_Alumno);

                        if (_NombreAlumno == null)
                        {
                            // Si no se encuentra el alumno, pasamos a la siguiente nota
                            _SNota = srn.ReadLine();
                            if (_SNota != null) _DNota = _SNota.Split(';');
                            continue;
                        }

                        grillaPromedios.Rows.Add(new string[] { _NombreAlumno });

                        while (_Alumno == _DNota[0] && _SNota != null)
                        {
                            _CantidadNotas += 1;
                            _SumaNotas += float.Parse(_DNota[1]);

                            if (_Agrega1)
                            {
                                grillaPromedios.Rows.Add(new string[] { "", _DNota[1] });
                            }
                            else
                            {
                                grillaPromedios.Rows[grillaPromedios.Rows.GetLastRow(DataGridViewElementStates.None)].Cells[1].Value = _DNota[1];
                                _Agrega1 = true;
                            }

                            _SNota = srn.ReadLine();

                            if (_SNota != null)
                            {
                                _DNota = _SNota.Split(';');
                            }
                        }
                        _Promedio = _SumaNotas / _CantidadNotas;
                        grillaPromedios.Rows.Add(new string[] { "", "Promedio =>", _Promedio.ToString() });
                        grillaPromedios.Rows[grillaPromedios.Rows.GetLastRow(DataGridViewElementStates.None)].DefaultCellStyle.BackColor = Color.Aqua;
                        grillaPromedios.Rows.Add(1);
                        _Agrega1 = false;
                        _SumaNotas = 0;
                        _CantidadNotas = 0;
                    }
                }
            }
        }
        #endregion
    }
}
