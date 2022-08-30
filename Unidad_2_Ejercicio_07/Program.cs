using System;

namespace Unidad_2_Ejercicio_07
{
    class Program
    {
        static void Main(string[] args)
        {
            double basee = 3;
            double altura = 9;
            double hipotenusa;

            hipotenusa = Math.Sqrt ( Math.Pow(basee, 2) + Math.Pow(altura, 2) );

            Console.WriteLine(hipotenusa);



        }
    }
}
