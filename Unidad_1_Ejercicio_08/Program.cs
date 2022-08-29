using System;
/*

escribir un programa que imprima por consola un triángulo como el siguiente:

*
***
*****
*******
*********

El usuario indicará cuál será la altura del triángulo ingresando un número entero positivo. Para el ejemplo anterior, la altura ingresada fue de 5.
*/

namespace Unidad_1_Ejercicio_08
{
    class Program
    {
        static void Main(string[] args)
        {
            char simbolo = '*';
            int altura;
            string valorIngresado;
            bool esNumero;
            int final = 1;

            Console.WriteLine("Ingrese la altura del triangulo mayor a cero: ");
            valorIngresado = Console.ReadLine();
            esNumero = int.TryParse(valorIngresado, out altura);

            while (esNumero == false || altura <1)
            {
                Console.WriteLine("Error: Ingrese la altura del triangulo mayor a cero: ");
                valorIngresado = Console.ReadLine();
                esNumero = int.TryParse(valorIngresado, out altura);
            }
            
            for (int i = 0; i < altura; i++)
            {
                for ( int j = 0; j < final; j++)
                {
                    Console.Write(simbolo);
                }
                final += 2;
                Console.Write("\n");
            }

        }
    }
}
