using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A891609.Actividad02
{
    class Program
    {
        public const string opcCargaEquipos = "1";
        public const string opcListaPartidos = "2";
        public const string opcTablaPosiciones = "3";
        public const string opcSalir = "S";
        public const string menu = "MENU\n" + opcCargaEquipos + " - Realizar carga de equipos\n" + opcListaPartidos +
                " - Listar partidos e ingresar resultados\n" + opcTablaPosiciones + " - Tabla de posiciones\n" + opcSalir + " - Salir";
        public const int puntosIniciales = 0;
        static void Main(string[] args)
        {
            string opcElegida = "";
            int cantidadEquipos = 0;
            int cantidadMaximaEquipos = 6;
            bool cargaEquipos = false;
            bool cargaResultados = false;
            Dictionary<string, int> equipos = new Dictionary<string, int>() { };

            do
            {
                opcElegida = Validador.pedirStrNoVacio(menu);
                if (opcElegida == opcCargaEquipos)
                {
                    if (cargaEquipos)
                    {
                        Console.WriteLine("Ya se han cargado los equipos");
                    }
                    else
                    {
                        cantidadEquipos = Validador.pedirIntConMaximo("Ingrese la cantidad de equipos que jugarán el torneo", cantidadMaximaEquipos);
                        for (int i = 0; i < cantidadEquipos; i++)
                        {
                            string equipo = Validador.pedirStrNoVacio("Ingrese el nombre del equipo número " + (i + 1));
                            equipos.Add(equipo, puntosIniciales);
                        }
                        cargaEquipos = true;
                    }                    
                }
                else if (opcElegida == opcListaPartidos)
                {
                    
                    if (cargaResultados)
                    {
                        Console.WriteLine("Ya se han cargado los resultados");
                    }
                    else if(!cargaEquipos)
                    {
                        Console.WriteLine("Para poder mostrar resultados se deben haber cargado los equipos");
                    }
                    else
                    {
                        Console.WriteLine("\nListado de partidos");
                        for (int i = 0; i < equipos.Count; i++)
                        {
                            for (int y = (1 + i); y < equipos.Count; y++)
                            {
                                Console.WriteLine(equipos.ElementAt(i).Key + " - " + equipos.ElementAt(y).Key);
                                int golesA = Validador.pedirInt("Ingrese los goles de " + equipos.ElementAt(i).Key);
                                int golesB = Validador.pedirInt("Ingrese los goles de " + equipos.ElementAt(y).Key);
                                equipos[equipos.ElementAt(i).Key] = equipos[equipos.ElementAt(i).Key] + PuntosPorPartido(golesA, golesB);
                                equipos[equipos.ElementAt(y).Key] = equipos[equipos.ElementAt(y).Key] + PuntosPorPartido(golesB, golesA);
                            }
                        }
                        cargaResultados = true;
                    }
                    
                }
                else if (opcElegida == opcTablaPosiciones)
                {
                    //https://www.dotnetperls.com/sort-dictionary
                    //:(
                    var eqs = from pair in equipos
                    orderby pair.Value descending
                    select pair;
                    //:(
                    foreach (KeyValuePair<string, int> pair in eqs)
                    {
                        Console.WriteLine(pair.Key + " - " + pair.Value);
                    }
                }
                else if (opcElegida != opcSalir)
                {
                    Console.WriteLine("La opción de menú ingresada es incorrecta");
                }
            } while (opcElegida != opcSalir);
            Console.WriteLine("Ejecución del programa finalizada");
            Console.ReadKey();
        }
        private static int PuntosPorPartido(int a, int b)
        {
            if (a > b)
            {
                return 3;
            }
            else if (a < b)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
}
