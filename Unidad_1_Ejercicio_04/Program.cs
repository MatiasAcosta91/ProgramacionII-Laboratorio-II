using System;

namespace Unidad_1_Ejercicio_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidadPerfectos = 0;
            int numeroInicial = 2;
            int acumulador = 0;

            do
            {
                for (int i = 1; i < numeroInicial; i++)
                {
                    if (numeroInicial % i == 0)
                    {
                        acumulador += i;
                    }
                }
                if (acumulador == numeroInicial)
                {
                    Console.WriteLine(numeroInicial);
                    cantidadPerfectos++;
                }
                numeroInicial++;
                acumulador = 0;
            } while (cantidadPerfectos < 4);




        }
    }
}
