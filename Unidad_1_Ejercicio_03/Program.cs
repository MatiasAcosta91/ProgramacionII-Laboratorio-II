using System;
/*
Consigna
Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola.
Validar que el dato ingresado por el usuario sea un número.
Volver a pedir el dato hasta que sea válido o el usuario ingrese "salir".
Si ingresa "salir", cerrar la consola.
Al finalizar, preguntar al usuario si desea volver a operar. Si la respuesta es afirmativa, iterar. De lo contrario, cerrar la consola.
 */

namespace Ejercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            string valorIngresado;
            bool esNumero;
            int numeroIngresado;
            bool iterar = true;
            int divisores;


            while (iterar == true)
            {
                Console.WriteLine("Ingrese un numero o \"salir\"");
                valorIngresado = Console.ReadLine();
                esNumero = int.TryParse(valorIngresado, out numeroIngresado);

                if (esNumero == true)
                {
                    for (int i = 2; i <= numeroIngresado; i++)
                    {
                        divisores = 0;
                        for (int j = 1; j <= i; j++)
                        {
                            if (i % j == 0)
                            {
                                divisores++;
                            }
                        }
                        if (divisores == 2)
                        {
                            Console.Write(i+",");
                        }
                    }

                }
                else if (valorIngresado == "salir")
                {
                    Console.WriteLine("salir");
                    iterar = false;
                }
            }



        }
    }
}
