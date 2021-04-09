using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A891609.Actividad02
{
    static class Validador
    {
        public static int pedirInt(string mensaje, int maximo)
        {
            int valor;
            do
            {
                Console.WriteLine(mensaje);
                if (!int.TryParse(Console.ReadLine(), out valor))
                {
                    valor = -1;
                }
                else if (valor > maximo)
                {
                    Console.WriteLine("El numero maximo que se puede ingresar es " + maximo);
                }
            } while (valor <= 0 || valor > maximo);
            return valor;
        }

        public static string pedirStrNoVacio(string mensaje)
        {
            string strNoVacio = "";
            do
            {
                Console.WriteLine(mensaje);
                strNoVacio = Console.ReadLine();
            } while (strNoVacio == "");
            return strNoVacio;
        }
    }
}
