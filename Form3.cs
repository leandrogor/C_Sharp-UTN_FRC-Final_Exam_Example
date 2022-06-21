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
    public partial class Form3 : Form
    {
        private int legajo;
        private Form2 form;

        public Form3(int leg, Form2 form2)
        {
            InitializeComponent();
            legajo = leg;
            txtLegajo.Text = legajo.ToString();
            form = form2;
            foreach (Materias_x_Alumnos item in form.listadoMatXAl)
            {
                if (item.Legajo_alumno == legajo)
                {
                    grdMaterias_x_Alumno.Rows.Add(item.Codigo_materia, item.Nombre_meteria);
                }              
            }
        }

        private void Form3_Load(object sender, EventArgs e)
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (estaEnLaGrilla())
            {
                MessageBox.Show("Cargue alguna materia que ya no esté agregada.");
            }
            else
            {
                grdMaterias_x_Alumno.Rows.Add(cmbMaterias.SelectedValue, cmbMaterias.Text);
                Materias_x_Alumnos materias_X_Alumno = new Materias_x_Alumnos(
                    int.Parse(cmbMaterias.SelectedValue.ToString()), 
                    cmbMaterias.Text, 
                    int.Parse(txtLegajo.Text));

                form.listadoMatXAl.Add(materias_X_Alumno);
            }
        }

        private bool estaEnLaGrilla()
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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            form.Show();
            Close();
        }
    }
}