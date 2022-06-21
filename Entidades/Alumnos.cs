using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulacroPAV.Entidades
{
    public class Alumnos
    {
        private int legajo;
        private string apellido;
        private string nombres;

        public Alumnos()
        {
            
        }

        public Alumnos(int legajo, string apellido, string nombre)
        {
            this.legajo = legajo;
            this.apellido = apellido;
            this.nombres = nombre;
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

        public string Nombres
        {
            get => nombres;
            set => nombres = value;
        }
    }
}
