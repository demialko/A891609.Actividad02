using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A891609.Actividad02
{
    class Torneo
    {
        private string nombre;
        private int cantidadDeEquipos;
        private List<Equipo> listadoDeEquipos = new List<Equipo> { };
        public Torneo() { }
        public Torneo(string nombre, int cantidadDeEquipos)
        {
            this.nombre = nombre;
            this.cantidadDeEquipos = cantidadDeEquipos;
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }
        public int CantidadDeEquipos
        {
            get
            {
                return this.cantidadDeEquipos;
            }
        }
        public List<Equipo> ListadoDeEquipos
        {
            get
            {
                return this.listadoDeEquipos;
            }
        }

        public void cargaDeEquipos(Equipo eq)
        {
            ListadoDeEquipos.Add(eq);
        }

        public void generarFixture()
        {
            for (int i = 0; i < cantidadDeEquipos; i++)
            {
                Partido part = new Partido()
            }
        }

    }
}
