using System;

/*
 Escribir un programa que imprima por consola un triángulo como el siguiente:

        *
       ***
      *****
     *******
    *********

El usuario indicará cuál será la altura del triángulo ingresando un número entero positivo. Para el ejemplo anterior, la altura ingresada fue de 5.
*/

namespace Unidad_1_Ejercicio_09
{
    class Program
    {
        static void Main(string[] args)
        {
            char simbolo = '*';
            int altura;
            string valorIngresado;
            bool esNumero;
            int espacios;
            int cantidadSimbolos = 1;
            
           

            Console.WriteLine("Ingrese la altura del triangulo mayor a cero: ");
            valorIngresado = Console.ReadLine();
            esNumero = int.TryParse(valorIngresado, out altura);

            while (esNumero == false || altura < 1)
            {
                Console.WriteLine("Error: Ingrese la altura del triangulo mayor a cero: ");
                valorIngresado = Console.ReadLine();
                esNumero = int.TryParse(valorIngresado, out altura);
            }
            espacios = altura - 1;
            for (int i = 0; i < altura; i++)
            {
                //imprimo espacios
                for (int k = 0; k < espacios; k++)
                {
                    Console.Write(" ");
                }
                //imprimo *
                for (int j = 0; j < cantidadSimbolos; j++)
                {
                    Console.Write(simbolo);
                }
                Console.Write("\n");
                cantidadSimbolos += 2;
                espacios--;
            }
        }
    }
}
