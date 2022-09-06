using System;
using BibliotecaEj04;

namespace Unidad_3_Ejercicio_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Boligrafo boligrafoAzul = new Boligrafo(ConsoleColor.Blue,5);
            Boligrafo boligrafoRojo = new Boligrafo(ConsoleColor.Red, 50);

            string textoAzul = "";
            string textoRojo = "";

            boligrafoAzul.Pintar(10,out textoAzul);
            Console.WriteLine(textoAzul);
            boligrafoAzul.Recargar();
            boligrafoAzul.Pintar(10, out textoAzul);
            Console.WriteLine(textoAzul);

    

            boligrafoRojo.Pintar(10, out textoRojo);

            Console.WriteLine(textoRojo);

            Console.ResetColor();


        }
    }
}
