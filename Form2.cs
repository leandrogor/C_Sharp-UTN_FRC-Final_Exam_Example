using simulacroPAV.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simulacroPAV
{
    public partial class Form2 : Form
    {
        private Form1 form1;
        private List<Alumnos> listadoAlumnos = new List<Alumnos>();
        public List<Materias_x_Alumnos> listadoMatXAl = new List<Materias_x_Alumnos>();

        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            dgvAlumnos.Rows.Add(txtLegajo.Text, txtApellido.Text, txtNombres.Text);

            Alumnos alumno = new Alumnos(int.Parse(txtLegajo.Text), txtApellido.Text, txtNombres.Text);

            listadoAlumnos.Add(alumno);

            limpiarCampos();
            txtLegajo.Focus();
        }

        private void limpiarCampos()
        {
            txtLegajo.Text = "";
            txtApellido.Text = "";
            txtNombres.Text = "";
        }

        private void Form2_Activated(object sender, EventArgs e)
        {
            btnMaterias.Enabled = false;
        }

        private void dgvAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnMaterias.Enabled = true;
        }

        private void btnMaterias_Click(object sender, EventArgs e)
        {
            int legajo = int.Parse(dgvAlumnos.CurrentRow.Cells[0].Value.ToString());
            Form3 ventana = new Form3(legajo, this);
            ventana.ShowDialog();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (altaAlumnosYMaterias())
            {
                MessageBox.Show("Proceso realizado correctamente");
            }
            else
            {
                MessageBox.Show("Pasó algo raro al hacer la transacción cheeee");
            }
        }

        private bool altaAlumnosYMaterias()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlTransaction objTransaccion = null;
            SqlConnection con = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                con.Open();
                objTransaccion = con.BeginTransaction("AltaAlumnosYMaterias");
                cmd.Transaction = objTransaccion;
                cmd.Connection = con;

                foreach (Alumnos alumno in listadoAlumnos)
                {
                    string consulta = "insert into alumnos values(@legajo, @apellido, @nombres)";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@legajo", alumno.Legajo);
                    cmd.Parameters.AddWithValue("@apellido", alumno.Apellido);
                    cmd.Parameters.AddWithValue("@nombres", alumno.Nombres);
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = consulta;
                    cmd.ExecuteNonQuery();
                }

                foreach (Materias_x_Alumnos matX in listadoMatXAl)
                {
                    string consulta2 = "insert into materias_x_alumnos values(@cod, @nom, @leg)";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@cod", matX.Codigo_materia);
                    cmd.Parameters.AddWithValue("@nom", matX.Nombre_meteria);
                    cmd.Parameters.AddWithValue("@leg", matX.Legajo_alumno);
                    cmd.CommandText = consulta2;
                    cmd.ExecuteNonQuery();
                }

                objTransaccion.Commit();
                return true;
            }
            catch (Exception)
            {
                objTransaccion.Rollback();
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            form1.Show();
            Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            form1.Close();
        }
    }
}