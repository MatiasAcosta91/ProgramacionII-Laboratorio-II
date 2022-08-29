using System;
/*
Escribir un programa que determine si un año es bisiesto.

Un año es bisiesto si es múltiplo de 4. Los años múltiplos de 100 no son bisiestos, salvo si ellos también son múltiplos de 400. Por ejemplo: el año 2000 es bisiesto pero 1900 no.

Pedirle al usuario un año de inicio y otro de fin y mostrar todos los años bisiestos en ese rango.
*/
namespace Unidad__1_Ejercicio_06
{
    class Program
    {
        static void Main(string[] args)
        {
            bool esNumero;
            int inicio;
            int final;
            string valorIngresado;


            Console.WriteLine("Ingrese el año de inicio: ");
            valorIngresado = Console.ReadLine();
            esNumero = int.TryParse(valorIngresado, out inicio);

            while (esNumero == false || inicio < 1)
            {
                Console.WriteLine("Error: debe ingresarse un numero positivo siendo el inicio menor al fin.");
                valorIngresado = Console.ReadLine();
                esNumero = int.TryParse(valorIngresado, out inicio);
            }
            Console.WriteLine("Ingrese el año final: ");
            valorIngresado = Console.ReadLine();
            esNumero = int.TryParse(valorIngresado, out final);
            while (esNumero == false || final < 1 || final <= inicio)
            {
                Console.WriteLine("Error: debe ingresarse un numero positivo siendo el inicio menor al fin.");
                valorIngresado = Console.ReadLine();
                esNumero = int.TryParse(valorIngresado, out final);
            }
            for (int i = inicio; i < final; i++)
            {
                if ( (i % 4 == 0 && i % 100 != 0) || (i % 4 == 0 && i % 100 == 0 && i % 400 == 0))
                {
                        Console.WriteLine("Es año bisiesto: " + i);
                }

            }

        }
    }
}
