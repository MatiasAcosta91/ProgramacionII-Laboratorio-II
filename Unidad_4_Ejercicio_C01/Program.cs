using System;
using Bibilioteca__Unidad4_Ej_C01;

namespace Unidad_4_Ejercicio_C01
{
    class Program
    {
        static void Main(string[] args)
        {
            NumeroBinario objBinario = "1001";
            NumeroDecimal objDecimal = 9;

            Console.WriteLine(objDecimal.GetNumeroDecimal());
            Console.WriteLine(objBinario.GetNumeroBinario());

            NumeroBinario objBinario2 = "1010";
            NumeroDecimal objDecimal2 = 10;

            Console.WriteLine(objBinario2 == objDecimal2); //comparo los dos objetos

            NumeroBinario objBinario3 = objBinario + objDecimal2; //sumo objeto 1 que es 1001 (9 en decimal) + 10
            Console.WriteLine("La suma de 1001 binario y 10 decimal es el : "+objBinario3.GetNumeroBinario()+" en binario (19 en decimal)");//tiene que dar 10011 que es 19 en decimal.





        }
    }
}
