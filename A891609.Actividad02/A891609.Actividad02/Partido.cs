using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A891609.Actividad02
{
    class Partido
    {
        public Equipo eq1;
        public Equipo eq2;
        public int golesEq1;
        public int golesEq2;

        public Partido() { }
        public Partido(Equipo equipo1, Equipo equipo2)
        {
            this.eq1 = equipo1;
            this.eq2 = equipo2;
        }
        public Partido(Equipo equipo1, Equipo equipo2, int golEq1, int golEq2)
        {
            this.eq1 = equipo1;
            this.eq2 = equipo2;
            this.golesEq1 = golEq1;
            this.golesEq2 = golEq2;
        }
        public int GolesEq1
        {
            get
            {
                return this.golesEq1;
            }
            set
            {
                this.golesEq1 = value;
            }
        }
        public int GolesEq2
        {
            get
            {
                return this.golesEq2;
            }
            set
            {
                this.golesEq2 = value;
            }
        }
    }
}
