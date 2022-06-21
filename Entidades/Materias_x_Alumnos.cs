using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulacroPAV.Entidades
{
    public class Materias_x_Alumnos
    {
        private int codigo_materia;
        private string nombre_meteria;
        private int legajo_alumno;

        public Materias_x_Alumnos()
        {
            
        }

        public Materias_x_Alumnos(int codigo_materia, string nombre_meteria, int legajo_alumno)
        {
            this.codigo_materia = codigo_materia;
            this.nombre_meteria = nombre_meteria;
            this.legajo_alumno = legajo_alumno;
        }

        public int Codigo_materia
        {
            get => codigo_materia;
            set => codigo_materia = value;
        }

        public string Nombre_meteria
        {
            get => nombre_meteria;
            set => nombre_meteria = value;
        }

        public int Legajo_alumno
        {
            get => legajo_alumno;
            set => legajo_alumno = value;
        }
    }
}
