using System;

/*
Crear un método estático que reciba una fecha y calcule el número de días que pasaron desde esa fecha hasta la fecha actual. 
Tener en cuenta los años bisiestos.
Pedir por consola la fecha de nacimiento de una persona (día, mes y año) y calcule el número de días vividos por esa persona hasta 
la fecha actual utilizando el método desarrollado anteriormente.
Ayudarse con las funcionalidades del tipo DateTime para resolver el ejercicio.
*/

namespace Unidad_2_Ejercicio_08
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int dia;
            int mes;
            int año;
            int totalDias;
            while (true)
            {
                Console.WriteLine("Ingrese dia: ");
                dia = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese mes: ");
                mes = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese año: ");
                año = int.Parse(Console.ReadLine());

                totalDias = Calculadora.CalculadoraDeVida(dia, mes, año);

                Console.WriteLine("El total de dias vividos es: "+totalDias);
            }
    
          
         


        }
    }
}
