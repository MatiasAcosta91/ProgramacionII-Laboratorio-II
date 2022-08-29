using System;
/*
 * Realizar una clase llamada Validador que posea un método estático llamado Validar con la siguiente firma:

bool Validar(int valor, int min, int max)

valor: dato a validar.
min: mínimo valor incluido.
max: máximo valor incluido.
Pedir al usuario que ingrese 10 números enteros. Validar con el método desarrollado anteriormente que estén dentro del rango -100 y 100.

Terminado el ingreso mostrar el valor mínimo ingresado, valor máximo ingresado y el promedio.
*/

namespace Unidad_2_Ejercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            int minimo = 0;
            int maximo = 0;
            int acumulador = 0;
            bool esNumero;
            float promedio;
            for (int i = 0; i < 10; i++)
            {
                do
                {
                    Console.WriteLine("Ingrese un numero entre -100 y 100: ");
                    esNumero = int.TryParse(Console.ReadLine(), out numeroIngresado);

                } while (!esNumero || Validador.validar(numeroIngresado, -100, 100) == false);
                if (i == 0)
                {
                    minimo = numeroIngresado;
                    maximo = numeroIngresado;

                }
                else
                {
                    if (numeroIngresado > maximo)
                    {
                        maximo = numeroIngresado;
                    }
                    else
                    {
                        if (numeroIngresado < minimo)
                        {
                            minimo = numeroIngresado;
                        }
                    }

                }
                acumulador += numeroIngresado;
             
            }
            promedio = (float)acumulador / 10;
            Console.WriteLine("maximo {0} minimo {1} promedio {2}",maximo,minimo,promedio);
        }
    }
}
