using System;

/*
 * Consigna
Desarollar una clase llamada Conversor que posea dos métodos de clase (estáticos):

El método ConvertirDecimalABinario que convierte un número entero del sistema decimal al sistema binario.

public string ConvertirDecimalABinario(int numeroEntero) {}

El método ConvertirBinarioADecimal que convierte un número entero del sistema binario al sistema decimal.

public int ConvertirBinarioADecimal(int numeroEntero) {}

IMPORTANTE
NO utilizar los atajos del lenguaje, hacerlo mediante estructuras de iteración y selección.
 */

namespace Unidad_2_Ejercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int ingreso;
            string resultadoDecimal;
            int resultadoBinario;
 
       
            Console.WriteLine("Ingrese un numero decimal: ");
            ingreso = int.Parse(Console.ReadLine());
            resultadoDecimal = Conversor.ConvertirDecimalABinario(ingreso);
            Console.WriteLine("El numero decimal: " + ingreso + " equivale al numero binario: " + resultadoDecimal);
           
            Console.WriteLine("Ingrese un numero binario: ");
            ingreso = int.Parse(Console.ReadLine());
            resultadoBinario = Conversor.ConvertirBinarioADecimal(ingreso);
            Console.WriteLine("El numero binario: " + ingreso + " equivale al numero decimal: " + resultadoBinario);






        }
    }
}
