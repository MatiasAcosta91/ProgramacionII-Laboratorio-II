using System;
/*
 Realizar un programa que sume números enteros hasta que el usuario lo determine por medio de un mensaje "¿Desea continuar? (S/N)".

Crear la clase Validador y el método estático ValidarRespuesta, que validará el ingreso de respuestas.

El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE si se ingresó cualquier otro valor.
*/
namespace Unidad_2_Ejercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            bool esNumero;
            bool esChar;
            int numero;
            string valorIngresado;
            char continuar = 's';
            int acumulador = 0;

            do
            {
                Console.WriteLine("Ingrese un numero: ");
                valorIngresado = Console.ReadLine();
                esNumero = int.TryParse(valorIngresado, out numero);
                while (esNumero == false)
                {
                    Console.WriteLine("ERROR: Ingrese un numero: ");
                    valorIngresado = Console.ReadLine();
                    esNumero = int.TryParse(valorIngresado, out numero);
                }
                acumulador += numero;
                Console.WriteLine("Desea Continuar?");
                valorIngresado = Console.ReadLine();
                esChar = char.TryParse(valorIngresado, out continuar);
                
            } while (Validador.ValidarRespuesta(continuar));

            Console.WriteLine("la suma de los numeros ingresados es: "+acumulador);
         


 
        }
    }
}
