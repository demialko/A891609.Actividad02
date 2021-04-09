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
            int cantidadEquipos = 0;
            bool ingresoCorrecto = false;
            List<String> listaDeEquipos = new List<string> { };
            do
            {
                Console.WriteLine("Ingrese la cantidad de equipos que jugarán el torneo (la misma no puede ser mayor a 10)");
                ingresoCorrecto = int.TryParse(Console.ReadLine(), out cantidadEquipos);
            } while (!ingresoCorrecto);

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
            Console.ReadKey();
        }
    }
}
