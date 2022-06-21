using Microsoft.Reporting.WinForms;
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
    public partial class Form4 : Form
    {
        private Form1 form1;
        public Form4(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void Form4_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            generarReporte();
        }

        private void generarReporte()
        {
            string alcance = "Un chamuyo de por ahí";
            DataTable tabla = new DataTable();
            tabla = ObtenerTabla();

            ReportDataSource ds = new ReportDataSource("DataSet1", tabla);
            ReportParameter[] parametros = new ReportParameter[2];

            parametros[0] = new ReportParameter("Alcance", alcance);
            parametros[1] = new ReportParameter("Fecha", DateTime.Now.ToShortDateString());

            reportViewer1.LocalReport.SetParameters(parametros);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
            reportViewer1.RefreshReport();
        }

        private DataTable ObtenerTabla()
        {
            string cadenaDeConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection con = new SqlConnection(cadenaDeConexion);
            try
            {

                SqlCommand cmd = new SqlCommand();

                string consulta = "select codigo_materia, nombre_materia, count(*) cantidad " +
                    "from materias_x_alumnos group by codigo_materia, nombre_materia";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                con.Open();
                cmd.Connection = con;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                return tabla;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con.Close();
            }
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.Show();
        }
    }
}
