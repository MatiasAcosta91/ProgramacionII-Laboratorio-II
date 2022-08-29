using System;
/*
Realizar un programa que permita realizar operaciones matemáticas simples (suma, resta, multiplicación y división).
Crear una clase llamada Calculadora que posea dos métodos estáticos (de clase):
Calcular (público): Recibirá tres parámetros, el primer operando, el segundo operando y la operación matemática.
El método devolverá el resultado de la operación.
Validar (privado): Recibirá como parámetro el segundo operando. Este método se debe utilizar sólo cuando la operación elegida sea la DIVISIÓN.
Este método devolverá true si el operando es distinto de cero.
Se le debe pedir al usuario que ingrese dos números y la operación que desea realizar (ingresando el caracter +, -, * o /).

El usuario decidirá cuándo finalizar el programa.
*/
namespace Unidad_2_Ejercicio_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int operandoUno;
            int operandoDos;
            char operador;
            double resultado;
            while (true)
            {
                Console.WriteLine("Ingrese el primer operador: ");
                operandoUno = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el segundo operador: ");
                operandoDos = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el operandor: ");
                operador = char.Parse(Console.ReadLine());
                resultado = Calculadora.Calcular(operandoUno, operandoDos, operador);

                if (Calculadora.OperacionOk == true)
                {
                    Console.WriteLine("El resultado de la operacion es: " + resultado);
                }
                else
                {
                    Console.WriteLine("No se pueden realizar divisiones por 0");
                }
          
            }
        

           

        }
    }
}
