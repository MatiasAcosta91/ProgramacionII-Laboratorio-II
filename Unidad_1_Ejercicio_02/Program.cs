using System;
/*
 Ingresar un número y mostrar el cuadrado y el cubo del mismo. 
Se debe validar que el número sea mayor que cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".
IMPORTANTE: Utilizar el método Pow de la clase Math para calcular las potencias.
 */
namespace Ejercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            double cuadrado;
            double cubo;
           
           Console.WriteLine("Ingrese un numero: ");
           numeroIngresado = int.Parse(Console.ReadLine());
           while (numeroIngresado <=0)
           {
                Console.WriteLine("ERROR: Ingrese numero mayor a cero");
                numeroIngresado = int.Parse(Console.ReadLine());
           }
            cuadrado = Math.Pow(numeroIngresado, 2);
            cubo = Math.Pow(numeroIngresado, 3);
          

            Console.WriteLine("Numero ingresado {0}, su cuadrado es {1}, el cubo es {2}",numeroIngresado,cuadrado,cubo);
        }
    }
}
