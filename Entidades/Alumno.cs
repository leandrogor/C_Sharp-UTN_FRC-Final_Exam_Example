using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulacroPAV.Entidades
{
    public class Alumno
    {
        private int legajo;
        private string apellido;
        private string nombre;

        public Alumno()
        {
            
        }

        public Alumno(int legajo, string apellido, string nombre)
        {
            this.legajo = legajo;
            this.apellido = apellido;
            this.nombre = nombre;
        }

        public int Legajo
        {
            get => legajo;
            set => legajo = value;
        }

        public string Apellido
        {
            get => apellido;
            set => apellido = value;
        }

        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }
    }
}
