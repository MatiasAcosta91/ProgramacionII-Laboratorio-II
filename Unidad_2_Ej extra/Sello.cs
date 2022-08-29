using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_2_Ej_extra
{
    class Sello
    {
        public static string mensaje;
        public static ConsoleColor color;

        public static string Imprimir ()
        {
            return Sello.ArmarFormatoMensaje();
        }
        public static void Borrar()
        {
            mensaje = "borrado";
        }
        public static void ImprimirEnColor()
        {
            Console.ForegroundColor = color;
            Console.WriteLine(Imprimir());
            Console.ResetColor();
        }

        private static string ArmarFormatoMensaje ()
        {
            string nuevoString;
            int cantidadAsteriscos;
            string LineaAsteriscos = "*";
            cantidadAsteriscos = Sello.mensaje.Length;
           for (int j = 0; j<=cantidadAsteriscos;j++)
           {
                LineaAsteriscos += "*";
           }
            nuevoString = LineaAsteriscos + "\n" + "*" + Sello.mensaje +"*\n"+ LineaAsteriscos + "\n";
            return nuevoString;
            

        }
    }
}
