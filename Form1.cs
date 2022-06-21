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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarComboMaterias();
        }

        private void CargarComboMaterias()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection con = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string sql = "select * from materias";
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;

                con.Open();
                cmd.Connection = con;

                DataTable tabla = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(tabla);

                cmbMaterias.DataSource = tabla;
                cmbMaterias.DisplayMember = "nombre";
                cmbMaterias.ValueMember = "codigo";
                cmbMaterias.SelectedIndex = -1;
            }
            catch (Exception) { throw; }
            finally { con.Close(); }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Alumnos al = buscarEstudiante(txtLegajo.Text);
            if (al.Nombres != null)
            {
                txtApellido.Text = al.Apellido;
                txtNombres.Text = al.Nombres;
                cargarGrilla(al.Legajo);
            }
            else
            {
                MessageBox.Show("No encontré alumno con ese legajo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                blanquearCampos();
                txtLegajo.Focus();   
            }
        }

        private Alumnos buscarEstudiante(string legajo)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection con = new SqlConnection(cadenaConexion);

            Alumnos al = new Alumnos();
            SqlCommand cmd = new SqlCommand();
            try
            {
                string consulta = "select * from alumnos where legajo=@legajo";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@legajo", legajo);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;
                con.Open();
                cmd.Connection = con;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    al.Legajo = int.Parse(dr["legajo"].ToString());
                    al.Apellido = dr["apellido"].ToString();
                    al.Nombres = dr["nombres"].ToString();
                }
            }
            catch (Exception) { return al; }
            finally { con.Close(); }

            return al;
        }

        private void cargarGrilla(int legajo)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection con = new SqlConnection(cadenaConexion);
            try
            {

                SqlCommand cmd = new SqlCommand();

                string consulta = "select codigo_materia 'Código Materia', nombre_materia 'Nombre Materia' " +
                    "from materias_x_alumnos where legajo_alumno=@legajo";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@legajo", legajo);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                con.Open();
                cmd.Connection = con;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                grdMaterias_x_Alumno.DataSource = tabla;
            }
            catch (Exception) { throw; }
            finally { con.Close(); }
        }

        private void blanquearCampos()
        {
            txtApellido.Text = "";
            txtNombres.Text = "";
            grdMaterias_x_Alumno.DataSource = null;
            cmbMaterias.SelectedIndex = -1;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (cmbMaterias.SelectedIndex != -1)
            {
                if (noEstaGrabada(int.Parse(txtLegajo.Text), cmbMaterias.Text))
                {
                    if (grabarCarrera(int.Parse(txtLegajo.Text), int.Parse(cmbMaterias.SelectedValue.ToString()), cmbMaterias.Text))
                    {
                        cargarGrilla(int.Parse(txtLegajo.Text));
                        MessageBox.Show("Se grabó con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("La materia para este alumno ya está grabada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Seleccione carrera primero", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool noEstaGrabada(int legajo, string carrera)
        {
            bool resultado = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection con = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string sql = "select codigo_materia from materias_x_alumnos where nombre_materia=@nom and legajo_alumno=@leg";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nom", carrera);
                cmd.Parameters.AddWithValue("@leg", legajo);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;

                con.Open();
                cmd.Connection = con;

                DataTable tabla = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(tabla);

                if (tabla.Rows.Count==0)
                {
                    resultado = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo realizar la solicitud", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
            return resultado;
        }


        private bool grabarCarrera(int legajo, int cod_car, string nombre_car)
        {
            bool resultado = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection con = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string sql = "insert into materias_x_alumnos values(@cod, @nom, @leg)";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@cod", cod_car);
                cmd.Parameters.AddWithValue("@nom", nombre_car);
                cmd.Parameters.AddWithValue("@leg", legajo);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;

                con.Open();
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                resultado = true;

            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo realizar la solicitud", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }

            return resultado;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            blanquearCampos();
            txtLegajo.Text = "";
            txtLegajo.Focus();
        }


        private bool VerificarAlumnoMateria()
        {
            foreach (DataGridViewRow fila in grdMaterias_x_Alumno.Rows)
            {
                if (fila.Cells["codigo_materia"].Value.ToString().Equals(cmbMaterias.SelectedValue.ToString()))
                {
                    return true;
                }
            }
            return false;
        }

        private void btnTransaccion_Click(object sender, EventArgs e)
        {
            Form2 ventana = new Form2(this);
            Hide();
            ventana.Show();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            Form4 ventana = new Form4(this);
            Hide();
            ventana.Show();
        }
    }
}