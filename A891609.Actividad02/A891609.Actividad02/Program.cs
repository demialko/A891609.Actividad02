using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A891609.Actividad02
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidadMaximaDeEquipos = 5;
            int cantidadEquipos = Validador.pedirInt("Ingrese la cantidad de equipos que jugarán el torneo (la misma no puede ser mayor a " + cantidadMaximaDeEquipos + ")", cantidadMaximaDeEquipos);
            string nombreTorneo = Validador.pedirStrNoVacio("Ingrese el nombre del torneo");
            Torneo torneo = new Torneo(nombreTorneo, cantidadEquipos);

            for (int i = 0; i <= torneo.CantidadDeEquipos-1; i++)
            {
                string nombre = Validador.pedirStrNoVacio("Ingrese el nombre del equipo número " + (i + 1));
                Equipo eq = new Equipo(nombre);
                torneo.cargaDeEquipos(eq);
            }
 
            /*
            //Hasta aca
            List<String> listaDeEquipos = new List<string> { };
            
            

            for (int i = 0; i < cantidadEquipos; i++)
            {
                string nombre = "";
                do
                {
                    Console.WriteLine("Ingrese el nombre del equipo número " + (i + 1));
                    nombre = Console.ReadLine();
                } while (nombre == "");
                listaDeEquipos.Add(nombre);
            }

            Console.WriteLine(cantidadEquipos);
            foreach (var equipo in listaDeEquipos)
            {
                Console.WriteLine(equipo);
            }
            Console.ReadKey();*/
        }
    }
}
