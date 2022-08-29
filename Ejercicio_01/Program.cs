using System;

namespace Ejercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int edad;
            Console.WriteLine("Ingrese edad: ");
            edad = int.Parse( Console.ReadLine() ); //Console.ReadLine solo toma datos tipo string, si quiero convertirlo a otro
            //tipo de dato lo debo parsear int.Parse(), float.Parse(), double.Parse(), etc.
            Console.WriteLine("La edad es: {0}",edad);
            */

            /*
            Consigna: 
            Ingresar 5 números por consola, guardándolos en una variable escalar.
            Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.
            */

            int contador = 0;
            int maximo = 0;
            int minimo = 0;
            int numeroIngresado;
            int acumulador = 0;
            float promedio;
            do
            {
                Console.WriteLine("Ingrese un numero: ");
                numeroIngresado = int.Parse(Console.ReadLine());
                acumulador += numeroIngresado;
                if (contador == 0)
                {
                    maximo = numeroIngresado;
                    minimo = numeroIngresado;
                }
                else
                {
                    if (numeroIngresado > maximo)
                    {
                        maximo = numeroIngresado;
                    }
                    if (numeroIngresado < minimo)
                    {
                        minimo = numeroIngresado;
                    }
                }
                contador++;
            } while (contador < 5);

            promedio = (float)acumulador / 5;
            Console.WriteLine("El numero minimo ingresado es: {0}",minimo);
            Console.WriteLine("El numero minimo ingresado es: {0}",maximo);
            Console.WriteLine("El promedio de los numeros ingresados es: {0}",promedio);
        }
    }
}
