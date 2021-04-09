using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A891609.Actividad02
{
    class Equipo
    {
        private string nombre;
        private int puntos;
        private string abreviatura;
        

        public Equipo() { }
        public Equipo(string nombre)
        {
            this.nombre = nombre;
            this.puntos = 0;
            this.abreviatura = nombre.Substring(0, 3).ToUpper();
        }
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }
        public string Abreviatura
        {
            get
            {
                return this.abreviatura;
            }
        }
        public int Puntos
        {
            get
            {
                return this.puntos;
            }
            set
            {
                this.puntos = value;
            }
        }
    }
}
